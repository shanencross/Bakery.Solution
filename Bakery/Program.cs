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
      Console.WriteLine(Bread.MenuMessage);
      Console.WriteLine(Pastry.MenuMessage);
      Console.WriteLine("------------------------------------------------");
      
      Console.WriteLine("May I take your order?");

      Console.WriteLine("How may loaves of bread would you like?");
      int breadCount = int.Parse(Console.ReadLine());

      Console.WriteLine("How many pastries would you like?");
      int pastryCount = int.Parse(Console.ReadLine());

      Bread breadOrder =  new Bread(breadCount);
      Pastry pastryOrder = new Pastry(pastryCount);
      int total = breadOrder.TotalPrice + pastryOrder.TotalPrice;

      Console.WriteLine("The total cost of " + breadOrder.Count + " loaves of bread is $" + breadOrder.TotalPrice + ".");
      Console.WriteLine("The total cost of " + pastryOrder.Count + " pastries is $" + pastryOrder.TotalPrice + ".");
      Console.WriteLine("So, you're total comes to $" + total + "!");
    }
  } 
}