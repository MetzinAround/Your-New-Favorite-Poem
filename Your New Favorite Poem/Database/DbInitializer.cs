using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Your_New_Favorite_Poem.Constants;

namespace Your_New_Favorite_Poem.Database
{
    public static class DbInitializer
    {
        public static async Task Initialize(AuthorsDbContext authorsDbContext)
        {
            await authorsDbContext.Database.MigrateAsync().ConfigureAwait(false);

            if (authorsDbContext.Authors != null && !authorsDbContext.Authors.Any())
            {
                authorsDbContext.Authors.AddRange(PoemsConstants.AuthorList);
                await authorsDbContext.SaveChangesAsync().ConfigureAwait(false);
            }
        }
    }
}
