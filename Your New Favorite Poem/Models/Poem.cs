using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Your_New_Favorite_Poem.Models
{
    [Table("poems")]
    public class Poem : IDatabaseModel
    {
        public Poem()
        {

        }
        
        [Key, DatabaseGenerat‌ed(DatabaseGeneratedOp‌​tion.Identity)]
        public Guid Id { get; set; }

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
