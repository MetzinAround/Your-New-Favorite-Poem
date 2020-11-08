using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Your_New_Favorite_Poem.Constants;
using Your_New_Favorite_Poem.Models;

namespace Your_New_Favorite_Poem.Database
{
    public abstract class BaseDatabase<T> where T : class, IDatabaseModel
    {
        readonly static string _connectionString = GetConnectionString();
        public abstract Task<T> PatchData(T data);
        public List<T> GetAllData(Func<T, bool> wherePredicate)
        {
            using var connection = new DatabaseContext();

            return connection.Data?.Where(wherePredicate).ToList() ?? new List<T>();
        }

        public List<T> GetAllData() => GetAllData(x => true);

        public Task<T> GetData(string id)
        {
            return PerformDatabaseFunction(getDataFunction);

            Task<T> getDataFunction(DatabaseContext dataContext) => dataContext.Data.SingleAsync(x => x.Id.Equals(id));
        }

        public Task<T> InsertData(T data)
        {
            return PerformDatabaseFunction(insertDataFunction);

            async Task<T> insertDataFunction(DatabaseContext dataContext)
            {
                data.Id = Guid.NewGuid();

                data.CreatedAt = DateTimeOffset.UtcNow;
                data.UpdatedAt = DateTimeOffset.UtcNow;

                await dataContext.AddAsync(data).ConfigureAwait(false);

                return data;
            }
        }



        public Task<T> DeleteData(string id)
        {
            return PerformDatabaseFunction(deleteDataFunction);

            async Task<T> deleteDataFunction(DatabaseContext dataContext)
            {
                var dataFromDatabase = await dataContext.Data.SingleAsync(y => y.Id.Equals(id)).ConfigureAwait(false);

                dataFromDatabase.IsDeleted = true;

                return await PatchData(dataFromDatabase).ConfigureAwait(false);
            }
        }

        public Task<T> RemoveData(string id)
        {
            return PerformDatabaseFunction(removeDataDatabaseFunction);

            async Task<T> removeDataDatabaseFunction(DatabaseContext dataContext)
            {
                var dataFromDatabase = await dataContext.Data.SingleAsync(x => x.Id.Equals(id)).ConfigureAwait(false);

                dataContext.Remove(dataFromDatabase);

                return dataFromDatabase;
            }
        }

        protected static async Task<TResult> PerformDatabaseFunction<TResult>(Func<DatabaseContext, Task<TResult>> databaseFunction) where TResult : class
        {
            using var connection = new DatabaseContext();

            try
            {
                var result = await databaseFunction.Invoke(connection).ConfigureAwait(false);
                await connection.SaveChangesAsync().ConfigureAwait(false);

                return result;
            }
            catch (Exception e)
            {
                Debug.WriteLine("");
                Debug.WriteLine(e.Message);
                Debug.WriteLine(e.ToString());
                Debug.WriteLine("");

                throw;
            }
        }

        //https://stackoverflow.com/a/43740589/13741035
        static string GetConnectionString()
        {
            var connectionStringFromEnvironmentVariable = Environment.GetEnvironmentVariable("MYSQLCONNSTR_localdb") ?? string.Empty;
            var connArray = Regex.Split(connectionStringFromEnvironmentVariable, ";");

            var connectionstring = string.Empty;
            for (int i = 0; i < connArray.Length; i++)
            {

                if (i is 1)
                {
                    string[] datasource = Regex.Split(connArray[i], ":");
                    connectionstring += datasource[0] + string.Format(";port={0};", datasource[1]);
                }
                else
                {
                    connectionstring += connArray[i] + ";";
                }
            }

            return connectionstring;
        }

        protected class DatabaseContext : DbContext
        {
            public DatabaseContext()
            {
                Database.EnsureCreated();

            }
            public DbSet<T>? Data { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseMySQL(_connectionString);
            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<T>().Property(b => b.CreatedAt).HasDefaultValue(DateTimeOffset.UtcNow);
                modelBuilder.Entity<T>().Property(b => b.UpdatedAt).HasDefaultValue(DateTimeOffset.UtcNow);

            }
        }
    }
}