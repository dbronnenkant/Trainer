using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Trainer.Data
{
    public partial class Cat
    {
        public Cat() { }

        public int CatId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Owner { get; set; }
        public string Breed { get; set; }
    }
}
