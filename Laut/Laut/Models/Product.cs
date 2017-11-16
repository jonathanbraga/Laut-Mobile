using System;
using System.Collections.Generic;
using System.Text;

namespace Laut.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string FullDescription { get; set; }
        public string Subtitle { get; set; }
        public string Image { get; set; }
    }
}
