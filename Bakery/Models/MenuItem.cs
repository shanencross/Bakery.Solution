namespace Bakery.Models
{
  public abstract class MenuItem
  {
    public int Count { get; }
    public int TotalPrice { get; }

    public MenuItem(int count)
    {
      Count = count;
      TotalPrice = CalculatePrice();
    }

    protected abstract int CalculatePrice();
  }
}