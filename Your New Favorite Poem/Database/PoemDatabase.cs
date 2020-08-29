using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Your_New_Favorite_Poem.Constants;
using Your_New_Favorite_Poem.Models;

namespace Your_New_Favorite_Poem.Database
{
    public class PoemDatabase
    {
        readonly static string _connectionString = Environment.GetEnvironmentVariable("MYSQLCONNSTR_localdb") ?? string.Empty;

        public List<Poem> GetAllPoems(Func<Poem, bool> wherePredicate)
        {
            using var connection = new PoemDatabaseContext();

            return connection.Poems?.Where(wherePredicate).ToList() ?? new List<Poem>();
        }

        public List<Poem> GetAllPoems() => GetAllPoems(x => true);

        public Task<Poem> GetPoem(string id)
        {
            return PerformDatabaseFunction(getPoemFunction);

            Task<Poem> getPoemFunction(PoemDatabaseContext dataContext) => dataContext.Poems.SingleAsync(x => x.Id.Equals(id));
        }

        public Task<Poem> InsertPoems(Poem poem)
        {
            return PerformDatabaseFunction(insertPoemFunction);

            async Task<Poem> insertPoemFunction(PoemDatabaseContext dataContext)
            {
                if (string.IsNullOrWhiteSpace(poem.Id))
                    poem.Id = Guid.NewGuid().ToString();

                poem.CreatedAt = DateTimeOffset.UtcNow;
                poem.UpdatedAt = DateTimeOffset.UtcNow;

                await dataContext.AddAsync(poem).ConfigureAwait(false);

                return poem;
            }
        }

        public Task<Poem> PatchPoem(Poem poem)
        {
            return PerformDatabaseFunction(patchPoemFunction);

            async Task<Poem> patchPoemFunction(PoemDatabaseContext dataContext)
            {
                var poemFromDatabase = await dataContext.Poems.SingleAsync(y => y.Id.Equals(poem.Id)).ConfigureAwait(false);

                poemFromDatabase.Author = poem.Author;
                poemFromDatabase.Title = poem.Title;
                poemFromDatabase.URL = poem.URL;
                poemFromDatabase.IsDeleted = poem.IsDeleted;
                poemFromDatabase.UpdatedAt = DateTimeOffset.UtcNow;

                dataContext.Update(poemFromDatabase);

                return poemFromDatabase;
            }
        }

        public Task<Poem> DeletePoem(string id)
        {
            return PerformDatabaseFunction(deletePoemFunction);

            async Task<Poem> deletePoemFunction(PoemDatabaseContext dataContext)
            {
                var poemFromDatabase = await dataContext.Poems.SingleAsync(y => y.Id.Equals(id)).ConfigureAwait(false);

                poemFromDatabase.IsDeleted = true;

                return await PatchPoem(poemFromDatabase).ConfigureAwait(false);
            }
        }

        public Task<Poem> RemovePoem(string id)
        {
            return PerformDatabaseFunction(removePoemDatabaseFunction);

            async Task<Poem> removePoemDatabaseFunction(PoemDatabaseContext dataContext)
            {
                var poemFromDatabase = await dataContext.Poems.SingleAsync(x => x.Id.Equals(id)).ConfigureAwait(false);

                dataContext.Remove(poemFromDatabase);

                return poemFromDatabase;
            }
        }

        static async Task<TResult> PerformDatabaseFunction<TResult>(Func<PoemDatabaseContext, Task<TResult>> databaseFunction) where TResult : class
        {
            using var connection = new PoemDatabaseContext();

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

        class PoemDatabaseContext : DbContext
        {
            public PoemDatabaseContext()
            {
                Database.EnsureCreated();
                if( !Poems.Any())
                {
                    Poems?.AddRange(PoemsConstants.PoemList);
                }
            }

            public DbSet<Poem>? Poems { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseMySQL(_connectionString);
        }
    }
}