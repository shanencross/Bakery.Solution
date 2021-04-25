namespace Bakery.Models
{
  public abstract class MenuItem
  {
    public int Count { get; protected set; }
    public int TotalPrice { get; protected set; }

    public MenuItem(int count)
    {
      Count = count;
      TotalPrice = CalculatePrice();
    }

    protected abstract int CalculatePrice();
  }
}