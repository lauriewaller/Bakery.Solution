using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceofPastry_Pastry()
    {
      Pastry newPastry = new Pastry();
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void GetPrice_ReturnsPrice_Int()
    {
      int price = 2;
      Pastry newPastry = new Pastry();
      int result = newPastry.Price;
      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void DeterminePastryPrice_CalculatesRegularPrice_Int()
    {
      int price = 4;
      Pastry newPastry = new Pastry();
      int result = newPastry.DeterminePastryPrice(2);
      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void DeterminePastryPrice_CalculatesSalePrice_Int()
    {
      int price = 5;
      Pastry newPastry = new Pastry();
      int result = newPastry.DeterminePastryPrice(3);
      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void DetermineSalePrice_CalculatesSalePrice_Int()
    {
      int price = 5;
      Pastry newPastry = new Pastry();
      int result = newPastry.DetermineSalePrice(3);
      Assert.AreEqual(price, result);
    }
  }
}