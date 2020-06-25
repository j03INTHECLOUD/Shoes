using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shoes.Models
{
    public class PairOfShoes
    {
        public PairOfShoes(string id, string brand, double value, string note, string color, string title)
        {
            Id = id;
            Brand = brand;
            Value = value;
            Note = note;
            Color = color;
            Title = title;
        }

        public string Id { get; set; }
        public string Brand { get; set; }
        public double Value { get; set; }
        public string Note { get; set; }
        public string Color { get; set; }
        public string Title { get; set; }


    }
}
