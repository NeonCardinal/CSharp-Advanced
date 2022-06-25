using System;
using System.Collections.Generic;
using System.Linq;

public class CitiesByContinentAndCountry
{
    static void Main()
    {
        var cities = new Dictionary<string, Dictionary<string, List<string>>>();
        int n = int.Parse(Console.ReadLine());

        for(int i = 0; i < n; i++)
        {
            string[] tokens = Console.ReadLine().Split();
            string continent = tokens[0];
            string country = tokens[1];
            string city = tokens[2];

            AddCity(cities, continent, country, city);
        }

        PrintCities(cities);
    }



    static void AddCity(Dictionary<string, Dictionary<string, List<string>>> cities, string continent, string country, string city)
    {
        if(!cities.ContainsKey(continent))
        {
            cities.Add(continent, new Dictionary<string, List<string>>());
        }

        var countries = cities[continent];

        if(!countries.ContainsKey(country))
        {
            countries.Add(country, new List<string>());
        }

        countries[country].Add(city);
    }

    static void PrintCities(Dictionary<string, Dictionary<string, List<string>>> cities)
    {
        foreach(string continent in cities.Keys)
        {
            Console.WriteLine(continent + ":");

            foreach(string country in cities[continent].Keys)
            {
                Console.Write("  " + country + " -> ");

                List<string> allCities = cities[continent][country];

                Console.WriteLine(string.Join(", ", allCities));
            }
        }
    }
}