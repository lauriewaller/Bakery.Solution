using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceofBread_Bread()
    {
      Bread newBread = new Bread();
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void GetPrice_ReturnsPrice_Int()
    {
      int price = 5;
      Bread newBread = new Bread();
      int result = newBread.Price;
      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void DetermineBreadPrice_CalculatesRegularPrice_Int()
    {
      int price = 10;
      Bread newBread = new Bread();
      int result = newBread.DetermineBreadPrice(2);
      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void DetermineBreadPrice_CalculatesSalePrice_Int()
    {
      int price = 10;
      Bread newBread = new Bread();
      int result = newBread.DetermineBreadPrice(3);
      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void DetermineSalePrice_CalculatesSalePrice_Int()
    {
      int price = 10;
      Bread newBread = new Bread();
      int result = newBread.DetermineSalePrice(3);
      Assert.AreEqual(price, result);
    }
  }
}
