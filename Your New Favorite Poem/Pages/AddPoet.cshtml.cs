using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Your_New_Favorite_Poem.Models;

namespace Your_New_Favorite_Poem.Pages
{
    public class AddPoetModel : PageModel
    {
        private readonly AuthorsDbContext _authorsDbContext;
        private readonly ILogger<AddPoetModel> _logger;

        public AddPoetModel(ILogger<AddPoetModel> logger, AuthorsDbContext authorsDbContext)
        {
            _logger = logger;
            _authorsDbContext = authorsDbContext;
        }

        public string SubmissionResult { get; private set; } = "Submit Poem";
        public async Task OnPostSubmit(string authorName, string poemUrl, string poemName, string bio, string pictureUrl, string pictureAltText)
        {
            var isPoemUrlValid = Uri.TryCreate(poemUrl, UriKind.Absolute, out var poemUri);
            var isPictureUrlValid = Uri.TryCreate(pictureUrl, UriKind.Absolute, out var pictureUri);
            if (!isPoemUrlValid || poemUri is null)
            {
                SubmissionResult = "Invalid Poem URL";
            }
            else if (!isPictureUrlValid || pictureUri is null)
            {
                SubmissionResult = "Invalid Picture URL";
            }
            else
            {
                try
                {
                    var givenAuthor = new Author
                    {
                        IsVerified = false,
                        PictureAltText = pictureAltText,
                        Bio = bio,
                        Name = authorName,
                        PictureURL = pictureUri,
                        Poems = new List<Poem>
                        {
                            new Poem()
                            {
                                URL = poemUri,
                                Title = poemName,
                                IsVerified = false
                            }
                        }

                    };

                    await _authorsDbContext.AddAsync<Author>(givenAuthor);
                    await _authorsDbContext.SaveChangesAsync();

                    SubmissionResult = "Submission Accepted";
                }
                catch
                {
                    SubmissionResult = "Database Error";
                }
            }
        }

        public void OnGet()
        {

        }
    }
}