using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lecture19___ASP.NET.Models {
    public class Album {

        public int ArtistId { get; set; }

        public int AlbumId { get; set; }

        public string Title { get; set; }

        public decimal Price { get; set; }

        public Artist Artist { get; set; } //foreign key to Artist

        public Genre Genre { get; set; } //foreign key to Genre

    }
}