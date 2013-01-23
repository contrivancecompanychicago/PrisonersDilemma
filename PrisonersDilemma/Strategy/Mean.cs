using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrisonersDilemmaServer.Strategy {


  /// <summary>
  /// Always Defect
  /// </summary>
  public class Mean : Strategy {

    public override StrategyChoice Start() {
      return StrategyChoice.Defect;
    }

    public override StrategyChoice Step(StrategyChoice inputChoice) {
      return StrategyChoice.Defect;
    }
  }
}
