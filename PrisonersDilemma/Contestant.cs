using System;
using PrisonersDilemmaServer.Strategy;

namespace PrisonersDilemmaServer {
  public class Contestant : IContestant {
    private int totalScore = 0;
    private int roundScore = 0;

    public string Name { get; set; }
    public StrategyChoice? LastChoice { get; set; }
    public IPDStrategy Strategy { get; private set; }
    public int RoundScore { get { return roundScore; } }
    public int TotalScore { get { return totalScore; } }

    public Contestant(string name, IPDStrategy strategy) {
      if (string.IsNullOrEmpty(name)) throw new ArgumentNullException("name", "name can not be null or empty");
      if (strategy == null) throw new NullReferenceException("Strategy not set");
      Name = name;
      Strategy = strategy;
      LastChoice = null;
    }

    public StrategyChoice Step(StrategyChoice? opponentChoice) {
      if (Strategy == null) throw new NullReferenceException("Strategy not set");
      
      LastChoice = !opponentChoice.HasValue ? Strategy.Start() : Strategy.Step(opponentChoice.Value);
      return LastChoice.Value;
    }
    
    public void AddScore(int inputScore) {
      roundScore = inputScore;
      totalScore += inputScore;
    }

  }
}
