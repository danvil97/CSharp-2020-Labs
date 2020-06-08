using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ5
{
    /// <summary>
    /// Component
    /// </summary>
    public abstract class Hamburger
    {
        public Hamburger(string newName)
        {
            this.Name = newName;
        }
        public string Name { get; set; }
        public abstract int GetPrice();
    }
}
