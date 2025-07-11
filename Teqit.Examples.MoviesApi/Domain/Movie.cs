namespace Teqit.Examples.MoviesApi.Domain;

public class Movie
{
    public required int Id { get; set; }
    public required string Title { get; set; }
    public required string Genre { get; set; }
    public required int Year { get; set; }
}