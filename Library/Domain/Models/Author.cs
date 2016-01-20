using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.Domain.Models {
    public class Author {

        public int Id { get; set; }
        public string Name { get; set; }
        //Use interface list instead of a type list
        public IList<Book> Books { get; set; }
    }
}