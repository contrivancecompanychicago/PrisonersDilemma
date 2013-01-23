using System;
using PrisonersDilemmaServer.Strategy;

namespace PrisonersDilemmaServer {
  class Program {
    static void Main(string[] args) {
      RunPrisonersDilemma();
      Console.WriteLine("Press ENTER to exit.");
      Console.ReadLine();
    }

    private static void RunPrisonersDilemma() {

      var contestant1 =
      //new Contestant("Nice", new Nice());
      //new Contestant("mean", new Mean());
      new Contestant("titfortat", new TitForTat());   
      //new Contestant("RNG", new RandomChoice());

      var contestant2 = 
      //new Contestant("Mean", new Mean());
      //new Contestant("nice", new Nice());
      //new Contestant("titfortat", new TitForTat());
      new Contestant("RNG", new RandomChoice());

      var pd = new PrisonersDilemma(contestant1, contestant2, 1);

      Console.WriteLine(pd.ShowContestants());

      for (int i = 1; i < 40; i++) {
        Console.WriteLine(pd.Step());
      }
    }
  }
}
