using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Your_New_Favorite_Poem.Models;

namespace Your_New_Favorite_Poem.Pages
{
    public class PoetsModel : PageModel
    {



        public PoetsModel(ILogger<PoetsModel> logger) //don't know why changing this to public doesn't work even though that's how it looks in Privacy.cshtml.cs
        {
            Logger = logger;
        }


        internal ILogger<PoetsModel> Logger { get; }

        public void OnGet()
        {

        }
    }
}// absolutely no idea what I've done here. I copied the code from the privacy.cshtml.cs and then clicked lightbulbs until there were no problems. 
 // pt 2. Can't amke the new page come up, and not sure how, but I know I need to add a button to the top. 