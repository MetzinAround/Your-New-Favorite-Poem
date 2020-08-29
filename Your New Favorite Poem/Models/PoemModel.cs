using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Org.BouncyCastle.Bcpg.OpenPgp;

namespace Your_New_Favorite_Poem.Models
{
    public class Poem
    {
        public Poem( string author, string title, Uri url)
        {
            Author = author;
            Title = title;
            URL =  url;
        }
        [Key]
        public string Id { get; set; } = string.Empty;
        public string Author { get; set; }
        public string Title { get; set; }
        public Uri URL { get; set; }
        public bool IsDeleted { get; internal set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }

    }


}
