using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Your_New_Favorite_Poem.Constants;

namespace Your_New_Favorite_Poem.Database
{
    public static class DbInitializer
    {
        public static void Initialize(AuthorsDbContext authorsDbContext)
        {
            authorsDbContext.Database.Migrate();


            if (authorsDbContext.Authors != null && !authorsDbContext.Authors.Any())
            {
                authorsDbContext.Authors.AddRange(PoemsConstants.AuthorList);
                authorsDbContext.SaveChanges();
            }
        }
    }
}
