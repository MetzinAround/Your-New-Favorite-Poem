using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Your_New_Favorite_Poem.Constants;
using Your_New_Favorite_Poem.Models;

namespace Your_New_Favorite_Poem.Pages
{
    public class IndexModel : PageModel
    {
        
        public IActionResult OnPostRandomPoem()
        {
            var rnd = new Random();
            var index = rnd.Next(0, PoetsConstants.PoemList.Count);

            var randomPoem = PoetsConstants.PoemList[index];

            return Redirect(randomPoem.URL.ToString());
        }
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
    }
} 
