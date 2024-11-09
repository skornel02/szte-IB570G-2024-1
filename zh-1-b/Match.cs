using CsvHelper.Configuration.Attributes;

namespace ConsolApp;

public class Match
{

    [Index(0)]
    public int Year { get; set; }
    [Index(1)]
    public string HomeTeam { get; set; }
    [Index(2)]
    public string AwayTeam { get; set; }
    [Index(3)]
    public int HomeScore { get; set; }
    [Index(4)]
    public int AwayScore { get; set; }
    [Index(5)]
    public string Tournament { get; set; }
    [Index(6)]
    public string City { get; set; }
    [Index(7)]
    public string Country { get; set; }
    [Index(8)]
    public bool Neutral { get; set; }
}
