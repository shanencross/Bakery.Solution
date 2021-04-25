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
      Pastry pastry = new Pastry(1);
      Assert.AreEqual(typeof(Pastry), pastry.GetType());
    }

    [TestMethod]
     public void PricePerItem_GetsCorrectValue_2()
    {
      int expectedResult = 2;
      int result = Pastry.PricePerItem;
      Assert.AreEqual(expectedResult, result);
    }
    
    [TestMethod]
    public void Count_CountIsInitializedCorrectly_12()
    {
      int expectedResult = 12;
      Pastry pastry = new Pastry(expectedResult);
      int result = pastry.Count;
      Assert.AreEqual(expectedResult, result);
    }    
    
    [TestMethod]
    public void TotalPrice_OnePastry_2()
    {
      int expectedResult = 2;
      int count = 1;
      Pastry pastry = new Pastry(count);
      int result = pastry.TotalPrice;
      Assert.AreEqual(expectedResult, result);
    }

    [TestMethod]
    public void TotalPrice_TwoPastries_4()
    {
      int expectedResult = 4;
      int count = 2;
      Pastry pastry = new Pastry(count);
      int result = pastry.TotalPrice;
      Assert.AreEqual(expectedResult, result);
    }

    [TestMethod]
    public void TotalPrice_GetThreeForFiveDeal_5()
    {
      int expectedResult = 5;
      int count = 3;
      Pastry pastry = new Pastry(count);
      int result = pastry.TotalPrice;
      Assert.AreEqual(expectedResult, result);
    }

    [TestMethod]
    public void TotalPrice_FourPastriesWithDeal_7()
    {
      int expectedResult = 7;
      int count = 4;
      Pastry pastry = new Pastry(count);
      int result = pastry.TotalPrice;
      Assert.AreEqual(expectedResult, result);
    }

    [TestMethod]
    public void TotalPrice_FivePastriesWithDeal_9()
    {
      int expectedResult = 9;
      int count = 5;
      Pastry pastry = new Pastry(count);
      int result = pastry.TotalPrice;
      Assert.AreEqual(expectedResult, result);
    }

    [TestMethod]
    public void TotalPrice_GetTwoDealsByBuyingSixPastries_10()
    {
      int expectedResult = 10;
      int count = 6;
      Pastry pastry = new Pastry(count);
      int result = pastry.TotalPrice;
      Assert.AreEqual(expectedResult, result);
    }
    
    [TestMethod]
    public void TotalPrice_SevenPastriesWithDeals_12()
    {
      int expectedResult = 12;
      int count = 7;
      Pastry pastry = new Pastry(count);
      int result = pastry.TotalPrice;
      Assert.AreEqual(expectedResult, result);
    }
    
    [TestMethod]
    public void TotalPrice_GetThreeDeals_15()
    {
      int expectedResult = 15;
      int count = 9;
      Pastry pastry = new Pastry(count);
      int result = pastry.TotalPrice;
      Assert.AreEqual(expectedResult, result);
    }

    [TestMethod]
    public void TotalPrice_GetFortySevenPastriesWithDeals_79()
    {
      int expectedResult = 79;
      int count = 47;
      Pastry pastry = new Pastry(count);
      int result = pastry.TotalPrice;
      Assert.AreEqual(expectedResult, result);
    }
  }
}
