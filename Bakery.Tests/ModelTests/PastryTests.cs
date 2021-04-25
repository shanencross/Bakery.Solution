using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests 
{
  [TestClass]
  public class PastryTests 
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry() 
    {
      Pastry pastry = new Pastry();
      Assert.AreEqual(typeof(Pastry), pastry.GetType());
    }

    [TestMethod]
     public void PricePerItem_GetsCorrectValue_2()
    {
      int expectedResult = 2;
      int result = Pastry.PricePerItem;
      Assert.AreEqual(expectedResult, result);
    }
  }
}
