using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Your_New_Favorite_Poem.Models
{
    [Table("poems")]
    public class Poem : IDatabaseModel
    {
        public Poem()
        {

        }
        
        [Key, DatabaseGenerat‌ed(DatabaseGeneratedOp‌​tion.Identity)]
        public int Id { get; set; }

        public Author Author { get; set; }

        public string Title { get; set; }

        public Uri URL { get; set; }

        public bool IsDeleted { get; set; }

        [DatabaseGenerat‌ed(DatabaseGeneratedOp‌​tion.Identity)]
        public DateTimeOffset CreatedAt { get; set; }

        [DatabaseGenerat‌ed(DatabaseGeneratedOp‌​tion.Computed)]
        public DateTimeOffset UpdatedAt { get; set; }

        public bool IsVerified { get; set; } = false;

    }


}
