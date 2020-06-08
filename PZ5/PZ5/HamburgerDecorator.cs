using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ5
{
    /// <summary>
    /// Decorator
    /// </summary>
    abstract class HamburgerDecorator:Hamburger
    {
        protected Hamburger hamburger;
        public HamburgerDecorator(string newName,Hamburger hamburger) : base(newName)
        {
            this.hamburger = hamburger;
        }
    }
}
