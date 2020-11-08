using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Your_New_Favorite_Poem.Database;
using Your_New_Favorite_Poem.Models;

namespace Your_New_Favorite_Poem.Database
{
    public class PoemDatabase : BaseDatabase<Poem>
    {
        public override Task<Poem> PatchData(Poem data)
        {
            return PerformDatabaseFunction(patchPoemFunction);

            async Task<Poem> patchPoemFunction(DatabaseContext dataContext)
            {
                var poemFromDatabase = await dataContext.Data.SingleAsync(y => y.Id.Equals(data.Id)).ConfigureAwait(false);

                poemFromDatabase.Author = data.Author;
                poemFromDatabase.Title = data.Title;
                poemFromDatabase.URL = data.URL;
                poemFromDatabase.IsVerified = data.IsVerified;
                poemFromDatabase.IsDeleted = data.IsDeleted;
                poemFromDatabase.UpdatedAt = DateTimeOffset.UtcNow;

                dataContext.Update(poemFromDatabase);

                return poemFromDatabase;
            }
        }
    }
}

