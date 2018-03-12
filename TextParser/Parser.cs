using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextParser
{
    public class Parser
    {
        private List<CityAtributes> _cities;
        private string _input;
        private const char CitiesSeparator = ',';
        private const char NameAndPopulationSeparator = '=';

        /// <summary>
        /// Default Constructor(Empty, use set input string method)
        /// </summary>
        public Parser()
        {
        }

        /// <summary>
        /// Input String 
        /// </summary>
        /// <param name="input"></param>
        public Parser(string input)
        {
            this._input = input;
        }

        /// <summary>
        /// Method Set Input string (if you yse default constructor)
        /// </summary>
        /// <param name="input"></param>
        public void SetInputString(string input)
        {
            if (input == String.Empty)
            {
                throw new ArgumentNullException();
            }
            this._input = input;
        }

        public List<CityAtributes> Parse()
        {
            this._cities = new List<CityAtributes>();
            var SplittedCities = _input.Split(CitiesSeparator);
            //string.Join(NameAndPopulationSeparator, SplittedCities);
            var Cities = GetCitiesNames(SplittedCities);

            return _cities;
        }

        private string[] GetCitiesNames(string[] inputcities)
        {
            string []cities = new string[inputcities.Length];//= string.Empty;
            for (int i = 0; i < inputcities.Length; ++i)
            {
                cities[i] = inputcities[i]
                    .Split(NameAndPopulationSeparator)
                    .First();
            }
            return cities;
        }

        private CityAtributes createCity(string name, int population, int nameLength)
            => new CityAtributes(name, population, nameLength);


        private int GetNameLength(string name)
            => name.Length;
    }
}
