using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Your_New_Favorite_Poem.Pages.Shared
{
    public class PoetsModel : PageModel
    {
        private readonly ILogger<PoetsModel> _logger;

        private PoetsModel(ILogger<PoetsModel> logger) //don't know why changing this to public doesn't work even though that's how it looks in Privacy.cshtml.cs
        {
            _logger = logger;
        }

        internal ILogger<PoetsModel> Logger => _logger;

        public void OnGet()
        {
        }
    }
}// absolutely no idea what I've done here. I copied the code from the privacy.cshtml.cs and then clicked lightbulbs until there were no problems. 
 // pt 2. Can't amke the new page come up, and not sure how, but I know I need to add a button to the top. 