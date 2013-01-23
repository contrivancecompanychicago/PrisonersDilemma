using System;
namespace PrisonersDilemmaServer.Strategy {
  public interface IPDStrategy {
    string Name { get; set; }
    StrategyChoice Start();
    StrategyChoice Step(StrategyChoice inputChoice);
  }
}
