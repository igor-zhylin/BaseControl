using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextParser
{
    public class CityAtributes
    {
        public string Name { get; private set; }
        public int Population { get; private set; }
        public int NameSize { get; private set; }

        public CityAtributes(string name, int population, int namesize)
        {
            this.Name = name;
            this.Population = population;
            this.NameSize = namesize;
        }
    }
}
