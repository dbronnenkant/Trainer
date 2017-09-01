using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Trainer.Data
{
    public partial class Computer
    {
        public Computer() { }

        public int ComputerId { get; set; }
        public string Brand { get; set; }
        public string CPU { get; set; }
        public string Memory { get; set; }
        public decimal Price { get; set; }
    }
}
