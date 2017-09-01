using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Trainer.Data
{
    public partial class Product
    {
        public Product()
        {
            Order = new HashSet<Order>();
        }

        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        [JsonIgnore]
        public ICollection<Order> Order { get; set; }
    }
}
