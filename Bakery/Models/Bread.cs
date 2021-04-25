namespace Bakery.Models {
  public class Bread {
    public static int PricePerItem { get; } = 5;
    public int Count { get; }
    public int TotalPrice { get; }

    public Bread(int count)
    {
      Count = count;
      TotalPrice = CalculatePrice();
    }

    private int CalculatePrice()
    {
      return -1;
    }
  }
}