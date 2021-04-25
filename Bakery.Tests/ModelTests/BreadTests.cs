using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests 
{
  [TestClass]
  public class BreadTests 
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread bread = new Bread();
      Assert.AreEqual(typeof(Bread), bread.GetType());
    }

    [TestMethod]
    public void PricePerItem_GetsCorrectValue_5()
    {
      int expectedResult = 5;
      int result = Bread.PricePerItem;
      Assert.AreEqual(expectedResult, result);
    }
  }
}
