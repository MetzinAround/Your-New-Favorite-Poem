using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using Your_New_Favorite_Poem;
using Your_New_Favorite_Poem.Database;

namespace YourNewFavoritePoem.UnitTests.Tests
{
    class BaseTest
    {
        AuthorsDbContext? authorsDbContext;

        protected AuthorsDbContext AuthorsDbContext => authorsDbContext ?? throw new NullReferenceException();

        [SetUp]
        public async Task Setup()
        {

            const string inMemoryConnectionString = "DataSource=:memory:?cache=shared";
            SqliteConnection connection = new SqliteConnection(inMemoryConnectionString);

            var optionsBuilder = new DbContextOptionsBuilder<AuthorsDbContext>().UseSqlite(connection);

            authorsDbContext = new AuthorsDbContext(optionsBuilder.Options);
            await connection.OpenAsync();
            DbInitializer.Initialize(authorsDbContext);
        }
    }
}
