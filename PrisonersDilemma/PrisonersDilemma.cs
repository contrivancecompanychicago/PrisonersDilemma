
namespace PrisonersDilemmaServer {

  /// <summary>
  /// Runs Prisoners Dilemma Game
  /// </summary>
  public class PrisonersDilemma {
    private IContestant contestant1;
    private IContestant contestant2;

    public PrisonersDilemma(IContestant contestant1, IContestant contestant2,int scoreAmount) {
      this.contestant1 = contestant1;
      this.contestant2 = contestant2;
      Score.scoreUnit = scoreAmount;
    }
    
    public string ShowContestants() {
      return string.Format("Contestand 1: {0}  Contestand 2: {1}",contestant1.Name,contestant2.Name);
    }

    public string Step() {
      
      if (contestant1.LastChoice.HasValue && contestant2.LastChoice.HasValue) {
        var contestant1Choice = contestant1.LastChoice.Value;
        contestant1.Step(contestant2.LastChoice.Value);
        contestant2.Step(contestant1Choice);
      }
      else {
        contestant1.Start();
        contestant2.Start();
      }

      Score.SetScore(contestant1, contestant2);
      return string.Format("{0},{1} {2},{3} {4}", contestant1.LastChoice.Value.Display(), contestant2.LastChoice.Value.Display(),  contestant1.RoundScore, contestant2.RoundScore, DisplayTotalScore());
    }

    private string DisplayTotalScore() {
      return string.Format("{0},{1}", contestant1.TotalScore, contestant2.TotalScore);
    }
  }
}
