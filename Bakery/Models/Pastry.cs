namespace Bakery.Models 
{
  public class Pastry 
  {
    public static int PricePerItem { get; } = 2;
    public int Count { get; }
    public int TotalPrice { get; }

    public Pastry(int count)
    {
      Count = count;
      TotalPrice = CalculatePrice();
    }

    private int CalculatePrice()
    {
      int totalPrice = PricePerItem * Count - Count / 3;
      return totalPrice;
    }

  }
}