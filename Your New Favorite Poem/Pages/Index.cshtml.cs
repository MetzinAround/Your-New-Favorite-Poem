using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Your_New_Favorite_Poem.Database;
using Your_New_Favorite_Poem.Models;

namespace Your_New_Favorite_Poem.Pages
{
    public class IndexModel : PageModel
    {
        public IReadOnlyList<Author> AuthorsFromDatabase { get; }
        public string Home { get; set; } = "Home";
        public IActionResult OnPostRandomPoem()
        {

            var rnd = new Random();
            var index = rnd.Next(0, AuthorsFromDatabase.Count);

            var randomAuthor = AuthorsFromDatabase[index];
            var poemIndex = rnd.Next(0, randomAuthor.Poems.Count);
            return Redirect(randomAuthor.Poems[poemIndex].URL.ToString());
        }
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger, AuthorDatabase authorDatabase)
        {
            _logger = logger;
            _authorDatabase = authorDatabase;
            AuthorsFromDatabase = authorDatabase.GetAllData();
        }
        private readonly AuthorDatabase _authorDatabase;
    }
}
