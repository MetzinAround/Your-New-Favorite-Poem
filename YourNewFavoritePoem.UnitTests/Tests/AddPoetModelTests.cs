using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging.Abstractions;
using NUnit.Framework;
using Your_New_Favorite_Poem;
using Your_New_Favorite_Poem.Constants;
using Your_New_Favorite_Poem.Pages;

namespace YourNewFavoritePoem.UnitTests.Tests
{
    class AddPoetModelTests : BaseTest
    {
        [Test]
        public async Task OnPostSubmit_AddPoetModel_AddsNewPoetToDatabase()
        {
            //Arrange
            var emptyLogger = new NullLogger<AddPoetModel>();
            var addPoetPage = new AddPoetModel(emptyLogger, AuthorsDbContext);
            string authorName = "😀😀";
            string poemUrl = PoemsConstants.AuthorList.First().Poems.First().URL.ToString();
            string poemName = PoemsConstants.AuthorList.First().Poems.First().Title;
            string bio = PoemsConstants.AuthorList.First().Bio;
            string pictureUrl = PoemsConstants.AuthorList.First().PictureURL?.ToString() ?? throw new NullReferenceException();
            string pictureAltText = PoemsConstants.AuthorList.First().PictureAltText;
            int authorsCount_initial = AuthorsDbContext.Authors.Count();
            int authorsCount_final;

            //Act
            await addPoetPage.OnPostSubmit(authorName, poemUrl, poemName, bio, pictureUrl, pictureAltText);
            authorsCount_final = AuthorsDbContext.Authors.Count();

            //Assert
            Assert.AreEqual(authorsCount_initial + 1, authorsCount_final);

            var newestAuthor = AuthorsDbContext.Authors.Last();
            Assert.AreEqual(authorName, newestAuthor.Name);
            Assert.AreEqual(poemUrl, newestAuthor.Poems.First().URL.ToString());
            Assert.AreEqual(poemName, newestAuthor.Poems.First().Title);
            Assert.AreEqual(bio, newestAuthor.Bio);
            Assert.AreEqual(pictureUrl, newestAuthor.PictureURL?.ToString());
            Assert.AreEqual(pictureAltText, newestAuthor.PictureAltText);



        }
    }
}
