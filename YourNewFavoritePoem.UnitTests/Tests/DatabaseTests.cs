using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging.Abstractions;
using NUnit.Framework;
using Your_New_Favorite_Poem;
using Your_New_Favorite_Poem.Constants;
using Your_New_Favorite_Poem.Database;
using Your_New_Favorite_Poem.Models;
using Your_New_Favorite_Poem.Pages;
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