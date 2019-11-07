using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextParser
{
    public class CityAtributes
    {
        public string Name { get;  set; }
        public int Population { get;  set; }
        // public int NameSize { get; private set; }

        public CityAtributes() { }
        public CityAtributes(string name, int population)
        {
            this.Name = name;
            this.Population = population;
        }
        public override string ToString()
        {
            return Name + " " + Population;
        }
    }
}
