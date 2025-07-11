using Teqit.Examples.MoviesApi.Domain;

namespace Teqit.Examples.MoviesApi.Application;

public class MovieService : IMovieService
{
    private static readonly List<Movie> _movies = [
            new () { Id = 1, Title = "The Shawshank Redemption", Genre = "Drama", Year = 1994 },
            new () { Id = 2, Title = "The Godfather", Genre = "Crime", Year = 1972 },
            new () { Id = 3, Title = "The Dark Knight", Genre = "Action", Year = 2008 },
            new () { Id = 4, Title = "The Godfather Part II", Genre = "Crime", Year = 1974 },
            new () { Id = 5, Title = "12 Angry Men", Genre = "Drama", Year = 1957 },
            new () { Id = 6, Title = "Schindler's List", Genre = "Biography", Year = 1993 },
            new () { Id = 7, Title = "The Lord of the Rings: The Return of the King", Genre = "Adventure", Year = 2003 },
            new () { Id = 8, Title = "Pulp Fiction", Genre = "Crime", Year = 1994 },
            new () { Id = 9, Title = "The Lord of the Rings: The Fellowship of the Ring", Genre = "Adventure", Year = 2001 },
            new () { Id = 10, Title = "The Good, the Bad and the Ugly", Genre = "Western", Year = 1966 },
            new () { Id = 11, Title = "Forrest Gump", Genre = "Drama", Year = 1994 },
            new () { Id = 12, Title = "Fight Club", Genre = "Drama", Year = 1999 },
            new () { Id = 13, Title = "The Lord of the Rings: The Two Towers", Genre = "Adventure", Year = 2002 },
            new () { Id = 14, Title = "Inception", Genre = "Action", Year = 2010 },
            new () { Id = 15, Title = "Star Wars: Episode V - The Empire Strikes Back", Genre = "Action", Year = 1980 },
            new () { Id = 16, Title = "The Matrix", Genre = "Sci-Fi", Year = 1999 },
            new () { Id = 17, Title = "Goodfellas", Genre = "Biography", Year = 1990 },
            new () { Id = 18, Title = "One Flew Over the Cuckoo's Nest", Genre = "Drama", Year = 1975 },
            new () { Id = 19, Title = "Se7en", Genre = "Crime", Year = 1995 },
            new () { Id = 20, Title = "Seven Samurai", Genre = "Adventure", Year = 1954 },
            new () { Id = 21, Title = "It's a Wonderful Life", Genre = "Drama", Year = 1946 },
            new () { Id = 22, Title = "The Silence of the Lambs", Genre = "Crime", Year = 1991 },
            new () { Id = 23, Title = "Saving Private Ryan", Genre = "Drama", Year = 1998 },
            new () { Id = 24, Title = "City of God", Genre = "Crime", Year = 2002 },
            new () { Id = 25, Title = "Interstellar", Genre = "Adventure", Year = 2014 },
            new () { Id = 26, Title = "Life Is Beautiful", Genre = "Comedy", Year = 1997 },
            new () { Id = 27, Title = "The Green Mile", Genre = "Crime", Year = 1999 },
            new () { Id = 28, Title = "Star Wars: Episode IV - A New Hope", Genre = "Action", Year = 1977 },
            new () { Id = 29, Title = "Terminator 2: Judgment Day", Genre = "Action", Year = 1991 },
            new () { Id = 30, Title = "Back to the Future", Genre = "Adventure", Year = 1985 }
        ];

    public IEnumerable<Movie> GetAllMovies()
    {
        return _movies;
    }

    public Movie? GetMovieById(int id)
    {
        return _movies.FirstOrDefault(m => m.Id == id);
    }

    public void AddMovie(Movie movie)
    {
        if (movie == null) return;
        movie.Id = _movies.Max(m => m.Id) + 1;
        _movies.Add(movie);
    }

    public void UpdateMovie(Movie movie)
    {
        if (movie == null) return;
        var existing = _movies.FirstOrDefault(m => m.Id == movie.Id);
        if (existing != null)
        {
            existing.Title = movie.Title;
            existing.Genre = movie.Genre;
            existing.Year = movie.Year;
        }
    }

    public void DeleteMovie(int id)
    {
        var movie = _movies.FirstOrDefault(m => m.Id == id);
        if (movie != null)
        {
            _movies.Remove(movie);
        }
    }
}