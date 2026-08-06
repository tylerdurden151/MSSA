using System;
using System.Collections.Generic;
using System.Text;

namespace Assignments_3._4
{
    internal abstract class Beverage 
    {
        private string _name = ""; 
        public string Name { get { return _name; } set { _name = value; } }
        public decimal Price { get; set; }
    }
}
