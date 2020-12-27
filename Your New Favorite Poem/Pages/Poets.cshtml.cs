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
        public IReadOnlyList<Author> AuthorsFromDatabase { get; private set; } = Array.Empty<Author>();
        readonly AuthorsDbContext _authorsDbContext;
        public PoetsModel(ILogger<PoetsModel> logger, AuthorsDbContext authorsDbContext)
        {
            Logger = logger;
            _authorsDbContext = authorsDbContext;
        }

        internal ILogger<PoetsModel> Logger { get; }

        public void OnGet()
        {
            AuthorsFromDatabase = _authorsDbContext.Authors.ToList();
        }
    }
}