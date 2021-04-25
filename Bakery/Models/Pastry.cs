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
      int noDealPrice = PricePerItem * Count;
      int dealCount = Count / 3;
      int dealDiscount = (3 * PricePerItem - 5) * dealCount;
      int totalPrice = noDealPrice - dealDiscount;
      return totalPrice;
    }

  }
}