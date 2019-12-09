using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lecture19.Models {
    public class Album {

        public int AlbumId { get; set; }
        public decimal Price { get; set; }
        public string Title { get; set; }


        public int ArtistId { get; set; } //foreign key
        public int GenreId { get; set; }

        public Genre Genre { get; set; } //for navigation syntax
        public Artist Artist { get; set; }

    }
}