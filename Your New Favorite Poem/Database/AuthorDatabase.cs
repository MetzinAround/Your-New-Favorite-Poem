using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Your_New_Favorite_Poem.Models;

namespace Your_New_Favorite_Poem.Database
{
    public class AuthorDatabase : BaseDatabase<Author> 
    {
        public override Task<Author> PatchData(Author data)
        {
            return PerformDatabaseFunction(patchPoemFunction);

            async Task<Author> patchPoemFunction(DatabaseContext dataContext)
            {
                var authorFromDatabase = await dataContext.Data.SingleAsync(y => y.Id.Equals(data.Id)).ConfigureAwait(false);

                authorFromDatabase.Name = data.Name;
                authorFromDatabase.Bio = data.Bio;
                authorFromDatabase.PictureURL = data.PictureURL;
                authorFromDatabase.IsVerified = data.IsVerified;
                authorFromDatabase.IsDeleted = data.IsDeleted;
                authorFromDatabase.UpdatedAt = DateTimeOffset.UtcNow;

                dataContext.Update(authorFromDatabase);

                return authorFromDatabase;
            }
        }
    }
}
