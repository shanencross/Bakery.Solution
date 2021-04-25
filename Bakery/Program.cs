using System;
using Bakery.Models;

namespace Bakery 
{
  public class Program 
  {
    public static void Main() 
    {
      Console.WriteLine("Hello, and welcome to Pierre's Bakery!");
      Console.WriteLine("Here's our menu:");
      
      Console.WriteLine("------------------------------------------------");
      // Console.WriteLine("Loaves of bread: $" + Bread.PricePerItem + " each. Buy 2, get 1 free!");
      Console.WriteLine(Bread.MenuMessage);
      // Console.WriteLine("Pastries: $" + Pastry.PricePerItem + " each, or get 3 for $5.");
      Console.WriteLine(Pastry.MenuMessage);
      Console.WriteLine("------------------------------------------------");
      
      Console.WriteLine("May I take your order?");

      Console.WriteLine("How may loaves of bread would you like?");
      int breadCount = int.Parse(Console.ReadLine());

      Console.WriteLine("How many pastries would you like?");
      int pastryCount = int.Parse(Console.ReadLine());

      Bread bread =  new Bread(breadCount);
      Pastry pastry = new Pastry(pastryCount);

      int total = bread.TotalPrice + pastry.TotalPrice;
    }
  } 
}