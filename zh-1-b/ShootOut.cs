using CsvHelper.Configuration.Attributes;

namespace ZH;

public class ShootOut
{
    [Index(0)]
    public DateOnly Date { get; set; }
    [Index(1)]
    public string HomeTeam { get; set; }
    [Index(2)]
    public string AwayTeam { get; set; }
    [Index(3)]
    public string Winner { get; set; }
}
