namespace TaqvimBot.Models;

public class Timings
{
    public string Fajr { get; set; } = string.Empty;
    public string Sunrise { get; set; } = string.Empty;
    public string Dhuhr { get; set; } = string.Empty;
    public string Asr { get; set; } = string.Empty;
    public string Maghrib { get; set; } = string.Empty;
    public string Isha { get; set; } = string.Empty;
}

public class Data
{
    public Timings Timings { get; set; } = new Timings();
}

public class ApiResponse
{
    public Data Data { get; set; } = new Data();
}

public class NamozVaqtlariModel
{
    public string Sana { get; set; } = string.Empty;
    public string Bomdod { get; set; } = string.Empty;
    public string Quyosh { get; set; } = string.Empty;
    public string Peshin { get; set; } = string.Empty;
    public string Asr { get; set; } = string.Empty;
    public string Shom { get; set; } = string.Empty;
    public string Xufton { get; set; } = string.Empty;
}
