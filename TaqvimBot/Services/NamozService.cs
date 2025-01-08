using System.Net.Http.Json;
using TaqvimBot.Models;

namespace TaqvimBot.Services;

public class NamozService(HttpClient httpClient)
{
    private readonly HttpClient _httpClient = httpClient;

    public async Task<NamozVaqtlariModel?> GetNamozVaqtlariAsync(string city, string country)
    {
        var response = await _httpClient.GetFromJsonAsync<ApiResponse>(
            $"https://api.aladhan.com/v1/timingsByCity?city={city}&country={country}&method=2");

        if (response == null || response.Data == null)
            return null;

        var timings = response.Data.Timings;
        return new NamozVaqtlariModel
        {
            Sana = DateTime.UtcNow.ToString("yyyy-MM-dd"),
            Bomdod = timings.Fajr,
            Quyosh = timings.Sunrise,
            Peshin = timings.Dhuhr,
            Asr = timings.Asr,
            Shom = timings.Maghrib,
            Xufton = timings.Isha
        };
    }
}
