using Teqit.Examples.MoviesApi.Domain;

namespace Teqit.Examples.MoviesApi.Infrastructure;

public class MovieRepository : IMovieRepository
{
    public IEnumerable<Movie> GetAllMovies()
    {
        // Stub implementation
        return [];
    }

    public Movie? GetMovieById(int id)
    {
        // Stub implementation
        return null;
    }

    public void AddMovie(Movie movie)
    {
        // Stub implementation
    }

    public void UpdateMovie(Movie movie)
    {
        // Stub implementation
    }

    public void DeleteMovie(int id)
    {
        // Stub implementation
    }
}