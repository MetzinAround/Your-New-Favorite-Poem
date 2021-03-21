using System;
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
        const string _inMemoryConnectionString = "DataSource=:memory:?cache=shared";
        readonly SqliteConnection _connection = new SqliteConnection(_inMemoryConnectionString);
        AuthorsDbContext? _authorsDbContext;

        protected AuthorsDbContext AuthorsDbContext => _authorsDbContext ?? throw new NullReferenceException();

        [SetUp]
        public Task Setup()
        {
            var optionsBuilder = new DbContextOptionsBuilder<AuthorsDbContext>().UseSqlite(_connection);

            _authorsDbContext = new AuthorsDbContext(optionsBuilder.Options);
            return DbInitializer.Initialize(_authorsDbContext);
        }

        [TearDown]
        public Task Teardown() => AuthorsDbContext.Database.EnsureDeletedAsync();
    }
}
