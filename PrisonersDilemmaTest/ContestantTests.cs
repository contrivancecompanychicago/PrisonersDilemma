using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrisonersDilemmaServer;
using PrisonersDilemmaServer.Strategy;

namespace PrisonersDilemmaTest {
  /// <summary>
  /// Summary description for ContestantTests
  /// </summary>
  [TestClass]
  public class ContestantTests {
 
 
    [TestMethod]
    public void ContestantConstructTest() {
      var contestant1 = new Contestant("Nice", new Nice());
      Assert.IsNotNull(contestant1);
    }

    [TestMethod]
    [ExpectedException(typeof(System.ArgumentNullException),"Empty Names should not be allowed")]
    public void ContestantEmptyNameTest() {
      var contestant1 = new Contestant(string.Empty, new Nice());
      Assert.IsNotNull(contestant1);
    }

    [TestMethod]
    [ExpectedException(typeof(System.NullReferenceException), "Null Strategy should not be allowed")]
    public void ContestantNullStrategyTest() {
      var contestant1 = new Contestant("Nice", null);
      Assert.IsNotNull(contestant1);
    }

    [TestMethod]
    public void StepNoLastChoiceTest() {
      var contestant1 = new Contestant("TitForTat", new TitForTat());
      var result = contestant1.Step(null);
      Assert.AreEqual(result,StrategyChoice.Cooperate);
    }

    [TestMethod]
    public void StepWithLastChoiceTest() {
      var contestant1 = new Contestant("TitForTat", new TitForTat());
      var result = contestant1.Step(StrategyChoice.Defect);
      Assert.AreEqual(result, StrategyChoice.Defect);
    }


  }
}
