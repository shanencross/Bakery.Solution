namespace Bakery.Models 
{
  public class Pastry 
  {
    public static int PricePerItem { get; } = 2;
    public int Count { get; }
    public int TotalPrice { get; }
    public static string MenuMessage { get; }

    public Pastry(int count)
    {
      Count = count;
      TotalPrice = CalculatePrice();
    }

    static Pastry()
    {
      MenuMessage = GetMenuMessage();
    }

    private int CalculatePrice()
    {
      int totalPrice = PricePerItem * Count - Count / 3;
      return totalPrice;
    }

    private static string GetMenuMessage()
    {
      string message = "Pastries: $" + PricePerItem + " each, or get 3 for $5.";
      return message;
    }

  }
}