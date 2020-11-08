using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Your_New_Favorite_Poem.Database;
using Your_New_Favorite_Poem.Models;

namespace Your_New_Favorite_Poem.Pages
{
    public class AddPoetModel : PageModel
    {
        public string SubmissionResult { get; private set; } = "Submit your poem above!";
        public async Task OnPostSubmit(string author, string poem, string poemName)
        {
            var isValidUri = Uri.TryCreate(poem, UriKind.Absolute, out var poemUri);
            if (!isValidUri || poemUri is null)
            {
                SubmissionResult = "Invalid URL";
            }
            else
            {
                try
                {
                    await _poemDatabase.InsertData(new Poem(author, poemName, poemUri));
                    SubmissionResult = "We did it! Submission Accepted. Check back soon!";
                }
                catch
                {
                    SubmissionResult = "WHAT'D YOU DO?!? Error submitting to Database.";
                }
            }
        }

        public AddPoetModel(ILogger<AddPoetModel> logger, PoemDatabase poemDatabase)
        {
            _logger = logger;
            _poemDatabase = poemDatabase;

        }
        private readonly PoemDatabase _poemDatabase;
        private readonly ILogger<AddPoetModel> _logger;
        public void OnGet()
        {

        }
    }
}
