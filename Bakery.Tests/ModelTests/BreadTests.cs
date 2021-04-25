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
      Bread bread = new Bread(1);
      Assert.AreEqual(typeof(Bread), bread.GetType());
    }

    [TestMethod]
    public void PricePerItem_GetsCorrectValue_5()
    {
      int expectedResult = 5;
      int result = Bread.PricePerItem;
      Assert.AreEqual(expectedResult, result);
    }

    [TestMethod]
    public void Count_CountIsInitializedCorrectly_23()
    {
      int expectedResult = 23;
      Bread bread = new Bread(expectedResult);
      int result = bread.Count;
      Assert.AreEqual(expectedResult, result);
    }

    [TestMethod]
    public void TotalPrice_GetRightPriceForOneBread_5()
    {
      int expectedResult = 5;
      int count = 1;
      Bread bread = new Bread(count);
      int result = bread.TotalPrice;
      Assert.AreEqual(expectedResult, result);
    }

    [TestMethod]
    public void TotalPrice_GetRightPriceForTwoBreads_10()
    {
      int expectedResult = 10;
      int count = 2;
      Bread bread = new Bread(count);
      int result = bread.TotalPrice;
      Assert.AreEqual(expectedResult, result);
    }

    
    [TestMethod]
    public void TotalPrice_BuyTwoGetOneFree_10()
    {
      int expectedResult = 10;
      int count = 3;
      Bread bread = new Bread(count);
      int result = bread.TotalPrice;
      Assert.AreEqual(expectedResult, result);
    }
    
    [TestMethod]
    public void TotalPrice_BuyFourBreadsWithDeal_15()
    {
      int expectedResult = 15;
      int count = 4;
      Bread bread = new Bread(count);
      int result = bread.TotalPrice;
      Assert.AreEqual(expectedResult, result);
    }
    
    [TestMethod]
    public void TotalPrice_BuyFiveBreadsWithDeal_20()
    {
      int expectedResult = 20;
      int count = 5;
      Bread bread = new Bread(count);
      int result = bread.TotalPrice;
      Assert.AreEqual(expectedResult, result);
    }
    
    [TestMethod]
    public void TotalPrice_GetTwoDealsByBuyingSixBreads_20()
    {
      int expectedResult = 20;
      int count = 6;
      Bread bread = new Bread(count);
      int result = bread.TotalPrice;
      Assert.AreEqual(expectedResult, result);
    }
    
    [TestMethod]
    public void TotalPrice_BuySevenBreadsWithDeal_25()
    {
      int expectedResult = 25;
      int count = 7;
      Bread bread = new Bread(count);
      int result = bread.TotalPrice;
      Assert.AreEqual(expectedResult, result);
    }
    
    [TestMethod]
    public void TotalPrice_GetThreeDeals_30()
    {
      int expectedResult = 30;
      int count = 9;
      Bread bread = new Bread(count);
      int result = bread.TotalPrice;
      Assert.AreEqual(expectedResult, result);
    }

    [TestMethod]
    public void TotalPrice_GetTwentyNineBreadsWithDeals_100()
    {
      int expectedResult = 100;
      int count = 29;
      Bread bread = new Bread(count);
      int result = bread.TotalPrice;
      Assert.AreEqual(expectedResult, result);
    }
  }
}
