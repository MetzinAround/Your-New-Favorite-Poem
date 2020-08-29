using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Your_New_Favorite_Poem.Database;
using Your_New_Favorite_Poem.Models;
using System.Collections.Generic;

namespace Your_New_Favorite_Poem.Pages
{
    
    public class PoetsModel : PageModel
    {
        public IReadOnlyList<Poem> PoemsFromDatabase { get; }
        readonly PoemDatabase _poemDatabase;
        public PoetsModel(ILogger<PoetsModel> logger, PoemDatabase poemDatabase)
        {
            Logger = logger;
            _poemDatabase = poemDatabase;
            PoemsFromDatabase = poemDatabase.GetAllPoems();
        }


        internal ILogger<PoetsModel> Logger { get; }

        public void OnGet()
        {
            
        }
    }
}