using System;
using System.Collections.Generic;
using System.Text;

namespace MyRentalShop
{
    public class Book
    {
        public int IdBook { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public int Edition { get; set; }
        public int TypeId { get; set; }
    }
}
