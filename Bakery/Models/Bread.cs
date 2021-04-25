namespace Bakery.Models 
{
  public class Bread 
  {
    public static int PricePerItem { get; } = 5;
    public int Count { get; }
    public int TotalPrice { get; }

    public static string MenuMessage { get; }

    public Bread(int count)
    {
      Count = count;
      TotalPrice = CalculatePrice();
    }

    static Bread()
    {
      MenuMessage = GetMenuMessage();
    }

    private int CalculatePrice()
    {
      int totalPrice = PricePerItem * (Count - (Count / 3));
      return totalPrice;
    }

    private static string GetMenuMessage()
    {
      string message = "Loaves of bread: $" + PricePerItem + " each. Buy 2, get 1 free!";
      return message;
    }
  }
}