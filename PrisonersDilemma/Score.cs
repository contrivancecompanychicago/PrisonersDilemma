using PrisonersDilemmaServer.Strategy;

namespace PrisonersDilemmaServer {
  public static class Score {     
    public static int scoreUnit = 1;
    
    public static void SetScore(IContestant contestant1, IContestant contestant2) {

      if (contestant1.LastChoice == StrategyChoice.Cooperate && contestant2.LastChoice == StrategyChoice.Cooperate) {
        contestant1.AddScore(scoreUnit);
        contestant2.AddScore(scoreUnit);
      }
      else if (contestant1.LastChoice == StrategyChoice.Cooperate && contestant2.LastChoice == StrategyChoice.Defect) {
        contestant1.AddScore(0);
        contestant2.AddScore(scoreUnit * 2);
      }
      else if (contestant1.LastChoice == StrategyChoice.Defect && contestant2.LastChoice == StrategyChoice.Cooperate) {
        contestant1.AddScore(scoreUnit * 2);
        contestant2.AddScore(0);
      }
      else {
        contestant1.AddScore(0);
        contestant2.AddScore(0);        
      }      
    }
  }
}
