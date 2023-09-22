using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System;

namespace PierresBakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryOrderConstructor_CreateInstanceOfBreadOrder_BreadOrder()
    {
      //arrange and act
      PastryOrder newPastryOrder = new PastryOrder(1);
      //assert
      Assert.AreEqual(typeof(PastryOrder), newPastryOrder.GetType());
    }
    [TestMethod]
    public void GetPastryCost_ReturnPriceOfSinglePastry_Int()
    {
      //arrange 
      int expectedCost = 2;
      PastryOrder newPastryOrder = new PastryOrder(1);
      //act
      int actuallCost = newPastryOrder.GetPastryCost();
      //assert
      Assert.AreEqual(expectedCost, actuallCost);
    }
    [TestMethod]
    public void GetPastryCost_ReturnPriceOfTwoPastries_Int()
    {
      //arrange 
      int expectedCost = 4;
      PastryOrder newPastryOrder = new PastryOrder(2);
      //act
      int actuallCost = newPastryOrder.GetPastryCost();
      //assert
      Assert.AreEqual(expectedCost, actuallCost);
    }
   [TestMethod]
   public void GetPastryCost_ReturnPriceOfThreePastries_Int()
    {
      //arrange 
      int expectedCost = 6;
      PastryOrder newPastryOrder = new PastryOrder(3);
      //act
      int actuallCost = newPastryOrder.GetPastryCost();
      //assert
      Assert.AreEqual(expectedCost, actuallCost);
    }
  }
}
