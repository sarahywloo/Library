using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.Services {
    public class BookDTO {

        public int Id { get; set; }
        public string Title { get; set; }
        public string Isbn { get; set; }
        public AuthorDTO Author { get; set; }
    }
}