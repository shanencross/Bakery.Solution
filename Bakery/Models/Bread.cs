namespace Bakery.Models {
  public class Bread {
    public static int PricePerItem { get; } = 5;
    public int Count { get; }
    public int TotalPrice { get; }

    public static string MenuMessage { get; }

    public Bread(int count)
    {
      Count = count;
      TotalPrice = CalculatePrice();
    }

    private int CalculatePrice()
    {
      int totalPrice = PricePerItem * (Count - (Count / 3));
      return totalPrice;
    }
  }
}