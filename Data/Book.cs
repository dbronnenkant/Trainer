using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Trainer.Data
{
    public partial class Book
    {
        public Book() { }

        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
    }
}
