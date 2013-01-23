using System;

namespace PrisonersDilemmaServer.Strategy {
  class RandomChoice : Strategy {
    private static Random rng = new Random();

    public override StrategyChoice Start() {
      return (StrategyChoice) rng.Next(0,2);
    }

    public override StrategyChoice Step(StrategyChoice inputChoice) {
      return (StrategyChoice)rng.Next(0, 2);
    }
  }
}
