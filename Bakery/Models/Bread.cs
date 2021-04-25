namespace Bakery.Models 
{
  public class Bread : MenuItem
  {
    public static int PricePerItem { get; } = 5;

    public static string MenuMessage { get; }

    public Bread(int count) : base(count)
    {
    }

    static Bread()
    {
      MenuMessage = GetMenuMessage();
    }

    protected override int CalculatePrice()
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