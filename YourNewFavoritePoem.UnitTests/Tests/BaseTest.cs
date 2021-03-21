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
        readonly SqliteConnection _connection = new(_inMemoryConnectionString);
        AuthorsDbContext? _authorsDbContext;

        protected AuthorsDbContext AuthorsDbContext => _authorsDbContext ?? throw new NullReferenceException();

        [SetUp]
        public async Task Setup()
        {
            var optionsBuilder = new DbContextOptionsBuilder<AuthorsDbContext>().UseSqlite(_connection);

            _authorsDbContext = new AuthorsDbContext(optionsBuilder.Options);
            await _authorsDbContext.Database.EnsureDeletedAsync().ConfigureAwait(false);
            await DbInitializer.Initialize(_authorsDbContext).ConfigureAwait(false);
        }

        [TearDown]
        public Task Teardown() => AuthorsDbContext.Database.EnsureDeletedAsync();
    }
}
