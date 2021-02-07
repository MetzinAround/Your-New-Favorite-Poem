using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public void Setup()
        {
            var optionsBuilder = new DbContextOptionsBuilder<AuthorsDbContext>()
    .UseInMemoryDatabase("InMemoryDb");

            authorsDbContext = new AuthorsDbContext(optionsBuilder.Options);
            DbInitializer.Initialize(authorsDbContext);
        }
    }
}
