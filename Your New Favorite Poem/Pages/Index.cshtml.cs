using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Your_New_Favorite_Poem.Constants;
using Your_New_Favorite_Poem.Database;
using Your_New_Favorite_Poem.Models;

namespace Your_New_Favorite_Poem.Pages
{
    public class IndexModel : PageModel
    {
        public IReadOnlyList<Poem> PoemsFromDatabase { get; }
        public string Home { get; set; } = "Home";
        public IActionResult OnPostRandomPoem()
        {
            
            var rnd = new Random();
            var index = rnd.Next(0, PoemsFromDatabase.Count);

            var randomPoem = PoemsFromDatabase[index];

            return Redirect(randomPoem.URL.ToString());
        }
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger, PoemDatabase poemDatabase)
        {
            _logger = logger;
            _poemDatabase = poemDatabase;
            PoemsFromDatabase = poemDatabase.GetAllPoems();
        }
        private readonly PoemDatabase _poemDatabase;
    }  
} 
