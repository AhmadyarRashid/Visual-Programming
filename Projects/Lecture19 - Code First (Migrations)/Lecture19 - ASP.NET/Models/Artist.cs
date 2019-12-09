using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lecture19___ASP.NET.Models {
    public class Artist {

        public int ArtistId { get; set; } //since this prop is using the class name along with 'Id', it is considered as the Primary key.
        public string Name { get; set; }



    }
}