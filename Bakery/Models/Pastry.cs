namespace Bakery.Models 
{
  public class Pastry : MenuItem
  {
    public static int PricePerItem { get; } = 2;
    public static string MenuMessage { get; }

    public Pastry(int count) : base(count)
    {
    }

    static Pastry()
    {
      MenuMessage = GetMenuMessage();
    }

    protected override int CalculatePrice()
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