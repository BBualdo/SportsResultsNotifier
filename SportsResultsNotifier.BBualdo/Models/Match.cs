namespace SportsResultsNotifier.BBualdo.Models;

internal class Match
{
  public Team Winner { get; set; }
  public Team Loser { get; set; }

  public Match(Team winner, Team loser)
  {
    Winner = winner;
    Loser = loser;
  }
}
