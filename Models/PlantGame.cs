using System;
using System.Collections.Generic;

namespace PlantGame.Models
{

  public class Plant
  {
    public int Height { get; set; }
    public int SunshineLevel { get; set; }
    public int FoodLevel { get; set; }
    public int WaterLevel { get; set; }

    public Plant(int height, int sunshineLevel, int foodLevel, int waterLevel)
    {
      Height = height;
      SunshineLevel = sunshineLevel;
      FoodLevel = foodLevel;
      WaterLevel = waterLevel;
    }
    public string Feed()
    {
      FoodLevel += 5;

      if (FoodLevel >= 10)
      {
        Height += 1;
        FoodLevel = 0;
        return "your plant grew a little bit, keep it up!";
      }
      else
      {
      return "you fed your plant";
      }
    }
    public string GiveSun()
      {
        SunshineLevel += 1;
        return "you gave your plant sunshine";
      }
    public string Water()
    {
      WaterLevel += 1;
      return "you gave your plant water";
    }
    // public string Grow()
    // {
    //   Feed();
    //   GiveSun();
    //   Water();
    //   return "You fed your plant";
    //   return "you fed your plant";
    //   return "you gave your plant sunshine";
    //   return "you gave your plant water";
    // }
  }
}