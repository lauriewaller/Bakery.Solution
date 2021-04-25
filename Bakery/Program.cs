using System;
using Bakery.Models;

namespace UserBakery
{
  public class BakeryProgram
  {
    public static void Main()
    {

      Bread breadToday = new Bread();
      Pastry pastryToday = new Pastry();

      Console.WriteLine("Welcome to Pierre's Bakery! Today we're offering sourdough bread($" + breadToday.Price + ")" + " and puff pastries($" + pastryToday.Price + ").");
      Console.WriteLine("Specials Today: Buy 2 loaves of bread, get 1 free! Get 3 pastries for just $5!");
      Console.WriteLine("Enter how many loaves of sourdough bread you would like:");
      string breadEntry = Console.ReadLine();
      int breadNumber = int.Parse(breadEntry);
      Console.WriteLine("Enter how many puff pastries you would like:");
      string pastryEntry = Console.ReadLine();
      int pastryNumber = int.Parse(pastryEntry);

      int totalCost = breadToday.DetermineBreadPrice(breadNumber) + pastryToday.DeterminePastryPrice(pastryNumber);

      Console.WriteLine("Your total today is $" + totalCost + ". Come back soon!");

    }
  }
}