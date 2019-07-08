using System;
using System.Collections.Generic;

namespace planet_and_spaceships
{
  class Program
  {
    static void Main(string[] args)
    {
      // Known planets: Mercury; Venus; Earth; Mars; Jupiter; Saturn; Uranus; Neptune; Pluto

      //initial setup
      List<string> planetList = new List<string>() { "Mercury", "Mars" };
      Console.WriteLine($"Initial Planet List: ");
      planetList.ForEach(planet => Console.WriteLine(planet));

      //add() Jupiter and Saturn to the end of the list
      Console.WriteLine($"Two Additional Planet List: ");
      planetList.Add("Jupiter");
      planetList.Add("Saturn");
      planetList.ForEach(planet => Console.WriteLine(planet));

      //create another List that contains that last two planet of our solar system and combine the two lists by using AddRange().
      List<string> evenMorePlanets = new List<string>() {
                "Uranus", "Neptune"
            };
      Console.WriteLine($"Even More Planets Planet List: ");
      planetList.AddRange(evenMorePlanets);
      planetList.ForEach(planet => Console.WriteLine(planet));

      //use Insert() to add Earth, and Venus in the correct order.
      Console.WriteLine($"Still More Planets Planet List: ");
      planetList.Insert(1, "Venus");
      planetList.Insert(2, "Earth");
      planetList.ForEach(planet => Console.WriteLine(planet));

      //use Add() again to add Pluto to the end of the list.
      Console.WriteLine($"All the Planets Planet List: ");
      planetList.Add("Pluto");
      planetList.ForEach(planet => Console.WriteLine(planet));

      //now that all the planets are in the list, slice the list using GetRange() in order to extract the rocky planets into a new list called rockyPlanets. The rocky planets will remain in the original planets list. Rockey Planets: Mercury, Venus, Earth, and Mars.
      Console.WriteLine($"Rockey Planet List: ");
      var rockyPlanets = planetList.GetRange(index: 0, count: 4);
      rockyPlanets.ForEach(planet => Console.WriteLine(planet));

      //being good amateur astronomers, we know that Pluto is now a dwarf planet, so use the Remove() method to eliminate it from the end of planetList.
      Console.WriteLine($"Goodbye Pluto Planet List: ");
      planetList.Remove("Pluto");
      planetList.ForEach(planet => Console.WriteLine(planet));
    }
  }
}
