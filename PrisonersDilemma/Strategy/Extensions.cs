using PrisonersDilemmaServer.Strategy;

namespace PrisonersDilemmaServer {
  public static class Extensions {

    public static string Display(this StrategyChoice choice) {
      return choice == StrategyChoice.Cooperate ? "C" : "D";
    }

  }
}
