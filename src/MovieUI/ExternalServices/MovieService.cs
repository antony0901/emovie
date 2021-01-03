using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace MovieUI.ExternalServices
{
    public class MovieService : IMovieService
    {
        private readonly HttpClient _httpClient;
        public MovieService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IList<WeatherForecast>> GetMovies()
        {
            var response =  await _httpClient.GetStringAsync("weatherforecast");
            return JsonSerializer.Deserialize<IList<WeatherForecast>>(response);
        }
    }
}
