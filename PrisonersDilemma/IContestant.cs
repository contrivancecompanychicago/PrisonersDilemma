using PrisonersDilemmaServer.Strategy;

namespace PrisonersDilemmaServer {
  public interface IContestant {
    StrategyChoice? LastChoice { get; set; }
    string Name { get; set; }
    int RoundScore { get; }
    IPDStrategy Strategy { get; }
    int TotalScore { get; }
    
    StrategyChoice Step(StrategyChoice? opponentChoice);
    void AddScore(int value);
  }
}
