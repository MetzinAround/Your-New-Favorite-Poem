using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Your_New_Favorite_Poem.Database;
using Your_New_Favorite_Poem.Models;
using System.Collections.Generic;
using System;
using System.Linq;

namespace Your_New_Favorite_Poem.Pages
{

    public class PoetsModel : PageModel
    {
        public IReadOnlyList<Poem> PoemsFromDatabase { get; }
        readonly AuthorsDbContext _authorsDbContext;
        public PoetsModel(ILogger<PoetsModel> logger, AuthorsDbContext authorsDbContext)
        {
            Logger = logger;
            _authorsDbContext = authorsDbContext;
            var temp = authorsDbContext.Authors.ToList();
            PoemsFromDatabase = authorsDbContext.Poems.ToList();
        }

        internal ILogger<PoetsModel> Logger { get; }

        public void OnGet()
        {   //requires asnyc to work
            //Poem savedPoem = await _poemDatabase.InsertPoems(new Poem("name", "title", new Uri("url")));
            //Console.WriteLine($"Save Successful! Poem Id {savedPoem.Id}");
        }
    }
}