using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrisonersDilemmaServer;
using PrisonersDilemmaServer.Strategy;

namespace PrisonersDilemmaTest {
  [TestClass]
  public class PDTest {

    private PrisonersDilemma pd;
    private int scoreAmount;

    [TestInitialize]
    public void Initialize() {
      var contestant1 = new Contestant("Nice",new Nice());
      var contestant2 = new Contestant("Mean",new Mean());
      scoreAmount = 1;

      pd = new PrisonersDilemma(contestant1, contestant2,scoreAmount);
    }
    
    
    [TestMethod]
    public void ConstructorTest() {
      Assert.IsNotNull(pd);
    }


    [TestMethod]
    public void ServerSetUpTest() {
      var result = pd.ShowContestants();
      Assert.AreEqual("Contestand 1: Nice  Contestand 2: Mean", result);
    }
    

    [TestMethod]
    public void ServerStartTest() {
      var result = pd.Step();
      Assert.AreEqual("C,D 0,2 0,2", result);
    }
    

    [TestMethod]
    public void ServerStepTest() {
      var result = pd.Step();
      Assert.AreEqual("C,D 0,2 0,2", result);

      result = pd.Step();
      Assert.AreEqual("C,D 0,2 0,4", result);

      result = pd.Step();
      Assert.AreEqual("C,D 0,2 0,6", result);

      result = pd.Step();
      Assert.AreEqual("C,D 0,2 0,8", result);
    }
        
    [TestMethod]
    public void ContestantTest() {
      var name = "NameONE";
      
      IContestant contestant = new Contestant(name,new Nice());
      Assert.IsNotNull(contestant);
          
      Assert.AreEqual(name, contestant.Name);
    }

    [TestMethod]
    public void NiceTest() {
      IPDStrategy nice = new Nice();
      Assert.IsNotNull(nice);

      nice.Name = "Nice";
      Assert.AreEqual("Nice", nice.Name);
      
      var expectedResult = StrategyChoice.Cooperate;
      var result = nice.Start();
      Assert.AreEqual(expectedResult, result);

      for (int i = 0; i < 10; i++) {
        result = nice.Step(result);
        Assert.AreEqual(expectedResult, result);
      }
    }


    [TestMethod]
    public void NiceVSNiceTest() {
      var contestant1 = new Contestant("Nice", new Nice());
      var contestant2 = new Contestant("Nice2", new Nice());
      scoreAmount = 10;

      pd = new PrisonersDilemma(contestant1, contestant2, scoreAmount);

      var result = pd.Step();
      Assert.AreEqual("C,C 10,10 10,10", result);

      result = pd.Step();
      Assert.AreEqual("C,C 10,10 20,20", result);

      result = pd.Step();
      Assert.AreEqual("C,C 10,10 30,30", result);

      result = pd.Step();
      Assert.AreEqual("C,C 10,10 40,40", result);
    }

  }



}
