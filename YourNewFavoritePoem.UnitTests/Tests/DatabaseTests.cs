using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using Your_New_Favorite_Poem;
using Your_New_Favorite_Poem.Database;
using Your_New_Favorite_Poem.Models;
using YourNewFavoritePoem.UnitTests.Tests;

namespace YourNewFavoritePoem.UnitTests.Tests
{
    class DatabaseTests : BaseTest
    {
        [Test]
        public void InitializationTest()
        {
            //Arrange
            List<Author> authorList;
            List<Poem> poemList;

            //Act
            authorList = AuthorsDbContext.Authors.ToList();
            poemList = AuthorsDbContext.Poems.ToList();

            //Assert

            Assert.IsNotEmpty(authorList);
            Assert.IsNotEmpty(poemList);
        }
    }
}