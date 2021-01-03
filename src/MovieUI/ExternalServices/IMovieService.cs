using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MovieUI.ExternalServices
{
    public interface IMovieService
    {
        Task<IList<WeatherForecast>> GetMovies();
    }
}
