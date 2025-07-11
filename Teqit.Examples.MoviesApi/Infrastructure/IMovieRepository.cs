using Teqit.Examples.MoviesApi.Domain;

namespace Teqit.Examples.MoviesApi.Infrastructure;

public interface IMovieRepository
{
    IEnumerable<Movie> GetAllMovies();
    Movie? GetMovieById(int id);
    void AddMovie(Movie movie);
    void UpdateMovie(Movie movie);
    void DeleteMovie(int id);
}