using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace PrisonersDilemmaServer.Strategy {
  public class TitForTat : Strategy {

    public override StrategyChoice Start() {
      return StrategyChoice.Cooperate;
    }

    public override StrategyChoice Step(StrategyChoice inputChoice) {
      return inputChoice; 
    }
  }
}
