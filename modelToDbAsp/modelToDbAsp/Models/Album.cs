using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace modelToDbAsp.Models
{
    public class Album
    {
        public int AlbumID { get; set; }
        public String Title { get; set; }
        public String price { get; set; }

        public int ArtistID { get; set; }
        public int GenreID { get; set; }

        public Artist Artist { get; set; }
        public Genre Genre { get; set; }
    }
}