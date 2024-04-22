using SportsResultsNotifier.BBualdo.Models;
using SportsResultsNotifier.BBualdo.Services;

MatchScraperService matchScraperService = new MatchScraperService();

List<Match> matches = matchScraperService.GetMatches("https://www.basketball-reference.com/boxscores/");

if (matches.Count == 0)
{
  Console.WriteLine("There is no matches today. Come back later.");
}

foreach (Match match in matches)
{
  match.ShowResults();
}