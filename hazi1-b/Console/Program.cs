// See https://aka.ms/new-console-template for more information
using ConsolApp;
using CsvHelper;
using System.Globalization;

if (args.Length != 1)
{
    Console.WriteLine("Usage: Console <matches.csv>");
    return;
}

var matchesPath = args[0];

List<Match> allMatches = [];
{
    using var matchesStreamReader = new StreamReader(File.OpenRead(matchesPath));
    using var matchesCsvReader = new CsvReader(matchesStreamReader, CultureInfo.InvariantCulture);
    allMatches = matchesCsvReader.GetRecords<Match>().ToList();
}

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

Console.WriteLine("Usage:");
Console.WriteLine("city <city> - Prints out the total number of matches in the city");
Console.WriteLine("year <country> <startYear> <endYear> - Prints out the matches in the country between the years");
Console.WriteLine("goal <team> <home boolean> - Prints out the average number of goals scored by the team as home or away");
Console.WriteLine("stop - Exits the application");
Console.WriteLine();

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

    if (input.Equals("stop", StringComparison.CurrentCultureIgnoreCase))
    {
        return;
    }
}