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

        private void Parse()
        {
            this._cities = new List<CityAtributes>();
            var SplittedCities = _input.Split(CitiesSeparator);
            //string.Join(NameAndPopulationSeparator, SplittedCities);
            var Cities = GetCitiesNames(SplittedCities);
            var Population = GetPopulations(SplittedCities);
            for (int i = 0; i < Cities.Length; i++)
            {
                _cities.Add(createCity(Cities[i], Population[i]));
            }
        }

        public CityAtributes GetBiggestCity()
        {
            Parse();
            CityAtributes cityAtributes = new CityAtributes();
            cityAtributes = _cities.Aggregate((i1, i2) => i1.Population > i2.Population ? i1 : i2);
            return cityAtributes;
        }

        private string[] GetCitiesNames(string[] inputcities)
        {
            string []cities = new string[inputcities.Length];//= string.Empty;
            string[] population = new string[inputcities.Length];
            for (int i = 0; i < inputcities.Length; ++i)
            {
                cities[i] = inputcities[i]
                    .Split(NameAndPopulationSeparator)
                    .First();
            }
            return cities;
        }
        private int[] GetPopulations(string[] inputcities)
        {
            //string[] cities = new string[inputcities.Length];//= string.Empty;
            int[] population = new int[inputcities.Length];
            for (int i = 0; i < inputcities.Length; ++i)
            {
                population[i] = Convert.ToInt32(inputcities[i]
                    .Split(NameAndPopulationSeparator)
                    .Last());
            }
            return population;
        }

        private CityAtributes createCity(string name, int population)
            => new CityAtributes(name, population);


        private int GetNameLength(string name)
            => name.Length;
    }
}
