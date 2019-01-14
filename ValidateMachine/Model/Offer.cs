using System;
using System.Collections.Generic;
using System.Text;

namespace ValidateMachine.Model
{
    public class Offer
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int rate { get; set; }
        public string Author { get; set; }
        public int Version { get; set; }
        public DateTime StartDate { get; set; }
    }
}
