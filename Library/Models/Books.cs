using System;
using System.Collections.Generic;

namespace Library
{
    public partial class Books
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int? GenreId { get; set; }
    }
}
