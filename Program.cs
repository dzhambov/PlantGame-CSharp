using System;
using System.Collections.Generic;
using PlantGame.Models;

namespace PlantGame
{

  public class Program
  {
    public static void Main()
    {
      Plant plant = new Plant(0, 0, 0, 0);
      Console.WriteLine("press y to feed the plant");
      string response = Console.ReadLine();
      if (response == "y")
      {
        Console.WriteLine(plant.Feed());
        Console.WriteLine("plant height is currently " + plant.Height);
        Console.WriteLine("plant food level is currently " + plant.FoodLevel);
        // Console.WriteLine(plant.SunshineLevel);
        // Console.WriteLine(plant.WaterLevel);
        // Console.WriteLine(plant.Feed());
      }
      Console.WriteLine("press y to feed the plant");
      string response2 = Console.ReadLine();
      if (response2 == "y")
      {
        Console.WriteLine(plant.Feed());
        Console.WriteLine("plant height is currently " + plant.Height);
        // Console.WriteLine(plant.SunshineLevel);
        // Console.WriteLine(plant.WaterLevel);
        Console.WriteLine("plant food level is currently " + plant.FoodLevel);
      }
      Console.WriteLine("press y to feed the plant");
      string response3 = Console.ReadLine();
      if (response3 == "y")
      {
        Console.WriteLine(plant.Feed());
        Console.WriteLine("plant height is currently " + plant.Height);
        // Console.WriteLine(plant.SunshineLevel);
        // Console.WriteLine(plant.WaterLevel);
        Console.WriteLine("plant food level is currently " + plant.FoodLevel);
      }
    }
  }
}