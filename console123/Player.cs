using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console123
{
    internal class Player : Animal
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { Console.WriteLine("Value Changed"); name = value; }
        }
    }
}
