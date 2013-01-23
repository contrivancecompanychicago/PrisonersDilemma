using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrisonersDilemmaServer.Strategy {
  /// <summary>
  /// Always Cooperate
  /// </summary>
  public class Nice : Strategy {

    public override StrategyChoice Start() {
      return StrategyChoice.Cooperate;
    }

    public override StrategyChoice Step(StrategyChoice inputChoice) {
      return StrategyChoice.Cooperate;
    }
  }
}
