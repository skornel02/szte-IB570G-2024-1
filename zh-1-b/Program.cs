// See https://aka.ms/new-console-template for more information
using ConsolApp;
using CsvHelper;
using System.Globalization;
using ZH;


if (args.Length != 2)
{
    Console.WriteLine("Usage: Console <matches.csv> <shootouts.csv>");
    return;
}

#region Loading CSVs
var matchesPath = args[0];

List<Match> allMatches = [];
{
    using var sr = new StreamReader(File.OpenRead(matchesPath));
    using var csvReader = new CsvReader(sr, CultureInfo.InvariantCulture);
    allMatches = csvReader.GetRecords<Match>().ToList();
}

var shootoutsPath = args[1];

List<ShootOut> allShootOuts = new List<ShootOut>();
{
    using var sr = new StreamReader(File.OpenRead(shootoutsPath));
    using var csvReader = new CsvReader(sr, CultureInfo.InvariantCulture);
    allShootOuts = csvReader.GetRecords<ShootOut>().ToList();
}
#endregion

#region Functions
int CountCity(string city)
{
    return allMatches.Count(m => m.City.Equals(city, StringComparison.InvariantCultureIgnoreCase));
}

List<Match> FindMatches(string country, int startYear, int endYear)
{
    return allMatches.Where(m => m.Country.Equals(country, StringComparison.InvariantCultureIgnoreCase) 
        && m.Year >= startYear 
        && m.Year <= endYear)
        .ToList();
}

double AverageGoals(string team, bool home)
{
    var matches = allMatches.Where(m => (home && m.HomeTeam.Equals(team, StringComparison.InvariantCultureIgnoreCase))
        || (!home && m.AwayTeam.Equals(team, StringComparison.InvariantCultureIgnoreCase)))
        .ToList();

    if (matches.Count == 0)
    {
        return 0;
    }

    return matches.Average(m => home ? m.HomeScore : m.AwayScore);
}

// ZH feladat 3
void CreateShootOutSummaries()
{
    // Gyakvezt megkérdezve csak a hometeam és away team alapján kell kapcsolni. Dátum alapján nem. 
    // Ha mégis később releváns lenne, akkor a lentebbi kommenteket kell kiszedni.
    var summary = allShootOuts.Join(allMatches,
        _ => (/*_.Date.Year, */_.HomeTeam, _.AwayTeam),
        _ => (/*_.Year, */_.HomeTeam, _.AwayTeam), (a, b) => new
        {
            date = a.Date.ToString("yyyy-MM-dd"),
            home_team = a.HomeTeam,
            away_team = a.AwayTeam,
            home_score = b.HomeScore,
            away_score = b.AwayScore,
            winner = a.Winner
        })
        .GroupBy(_ => (_.date, _.home_team, _.away_team, _.winner))
        .Select(_ => new
        {
            _.Key.date,
            _.Key.home_team,
            _.Key.away_team,
            osszes_golok = _.Select(_ => _.home_score + _.away_score).Sum(),
            _.Key.winner,
        })
        .ToList();


    using var writer = new CsvWriter(new StreamWriter($"feladat3-osszefesult.csv"), CultureInfo.InvariantCulture);

    writer.WriteRecords(summary);
}

// ZH feladat 4
List<(Match match, int difference)> TopThreeBiggestDifferenceUntilYear(int year)
{
    return allMatches.Where(_ => _.Year <= year)
        .Select(_ => (_, Math.Abs(_.HomeScore - _.AwayScore)))
        .OrderByDescending(_ => _.Item2)
        .Take(3)
        .ToList();
} 

// ZH feladat 5
List<(int Year, int Goals)> TopThreeGoalsPerYear(string homeTeam)
{
    return allMatches.Where(_ => _.HomeTeam == homeTeam)
        .GroupBy(_ => _.Year)
        .Select(_ => (_.Key, _.Select(_ => _.HomeScore).Sum()))
        .OrderByDescending(_ => _.Item2)
        .Take(3)
        .ToList();
}
#endregion

#region Program loop
Console.WriteLine("Usage:");
Console.WriteLine("city <city> - Prints out the total number of matches in the city");
Console.WriteLine("year <country> <startYear> <endYear> - Prints out the matches in the country between the years");
Console.WriteLine("goal <team> <home boolean> - Prints out the average number of goals scored by the team as home or away");
Console.WriteLine("diff <date> - Returns the top three matches");
Console.WriteLine("perform <home team> - Returns the top three years for a home team");
Console.WriteLine("stop - Exits the application");
Console.WriteLine();

CreateShootOutSummaries();

for (;;)
{
    var input = Console.ReadLine()?.Trim() ?? "";

    if (input.StartsWith("city ", StringComparison.CurrentCultureIgnoreCase))
    {
        var parametersText = input.Substring(5);
        var city = parametersText;

        var count = CountCity(city);
        Console.WriteLine($"\tThere are {count} matches in {city}");

        using var writer = new CsvWriter(new StreamWriter($"{input.Replace(" ", "-")}.csv"), CultureInfo.InvariantCulture);
        
        writer.WriteRecords([new { City = city, Count = count }]);
    }

    if (input.StartsWith("year ", StringComparison.CurrentCultureIgnoreCase))
    {
        var parametersText = input.Substring(5);

        var parameters = parametersText.Split(" ");

        if (parameters.Length != 3)
        {
            Console.WriteLine("\tInvalid number of parameters. Correct usage: year <city> <startYear> <endYear>");
            continue;
        }

        var country = parameters[0];
        var startYear = int.Parse(parameters[1]);
        var endYear = int.Parse(parameters[2]);

        var matches = FindMatches(country, startYear, endYear);
        foreach (var match in matches)
        {
            Console.WriteLine($"\t{match.Year} {match.HomeTeam} {match.HomeScore} - {match.AwayScore} {match.AwayTeam}");
        }

        if (matches.Count == 0)
        {
            Console.WriteLine($"\tNo matches found in {country} between {startYear} and {endYear}");
        }

        using var writer = new CsvWriter(new StreamWriter($"{input.Replace(" ", "-")}.csv"), CultureInfo.InvariantCulture);
        writer.WriteRecords(matches);
    }

    if (input.StartsWith("goal ", StringComparison.CurrentCultureIgnoreCase))
    {
        var parametersText = input.Substring(5);

        var parameters = parametersText.Split(" ");

        if (parameters.Length != 2)
        {
            Console.WriteLine("\tInvalid number of parameters. Correct usage: goal <team> <home boolean>");
            continue;
        }

        var team = parameters[0];
        var isHome = bool.Parse(parameters[1]);

        var averageGoals = AverageGoals(team, isHome);

        Console.WriteLine($"\tThe average number of goals scored by {team} as {(isHome ? "home" : "away")} is {averageGoals}");

        using var writer = new CsvWriter(new StreamWriter($"{input.Replace(" ", "-")}.csv"), CultureInfo.InvariantCulture);
        writer.WriteRecords([new { Team = team, Home = isHome, AverageGoals = averageGoals }]);
    }

    if (input.StartsWith("diff ", StringComparison.CurrentCultureIgnoreCase))
    {
        var parametersText = input.Substring(5);

        var parameters = parametersText.Split(" ");

        if (parameters.Length != 1)
        {
            Console.WriteLine("\tInvalid number of parameters. Correct usage: diff <year>");
            continue;
        }

        var year = int.Parse(parameters[0]);

        var matches = TopThreeBiggestDifferenceUntilYear(year);

        foreach (var matchPair in matches)
        {
            var (match, difference) = matchPair;
            Console.WriteLine($"\t{match.Year} {match.HomeTeam} {match.HomeScore} - {match.AwayScore} {match.AwayTeam} (difference: {difference})");
        }
    }

    if (input.StartsWith("perform ", StringComparison.CurrentCultureIgnoreCase))
    {
        var homeTeam = input.Substring(8);

        var topYears = TopThreeGoalsPerYear(homeTeam);

        foreach(var (year, goals) in topYears)
        {
            Console.WriteLine($"\t{year} - {goals} goal");
        }

        if (topYears.Count == 0)
        {
            Console.WriteLine($"\tTeam '{homeTeam}' is an invalid value.");
        }
    }

    if (input.Equals("stop", StringComparison.CurrentCultureIgnoreCase))
    {
        return;
    }
}
#endregion