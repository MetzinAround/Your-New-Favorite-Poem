using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Your_New_Favorite_Poem.Models
{
    //Interface to force classes to include properties needed in database
    public interface IDatabaseModel
    {
        public int Id { get; set; }

        public bool IsDeleted { get; set; }

        public DateTimeOffset CreatedAt { get; set; }

        public DateTimeOffset UpdatedAt { get; set; }

        public bool IsVerified { get; set; }
    }
}
