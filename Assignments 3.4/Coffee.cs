using System;
using System.Collections.Generic;
using System.Text;

namespace Assignments_3._4
{
    internal class Coffee : Beverage
    {
        public string RoastLevel { get; set; } = "";
        public bool HasMilk { get; set; }
        public bool HasSugar { get; set; }
        public bool IsDecaf { get; set; }
        public CoffeeType Type { get; set; }
    }
}
