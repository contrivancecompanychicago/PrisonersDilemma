using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrisonersDilemmaServer.Strategy {

  public enum StrategyChoice {
    Cooperate,
    Defect
  }
  
  public abstract class Strategy : IPDStrategy {
    public string Name { get; set; }

    public abstract StrategyChoice Start();
    public abstract StrategyChoice Step(StrategyChoice inputChoice);
  }
}
