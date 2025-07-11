using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Web.Resource;
using Teqit.Examples.MoviesApi.Application;
using Teqit.Examples.MoviesApi.Domain;

namespace Teqit.Examples.MoviesApi.Controllers;

[Authorize]
[ApiController]
[Route("[controller]")]
[RequiredScope(RequiredScopesConfigurationKey = "AzureAd:Scopes")]
public class MoviesController(ILogger<MoviesController> _logger, IMovieService _movieService) : ControllerBase
{
    [HttpGet(Name = "GetMovies")]
    public IEnumerable<Movie> GetMovies()
    {
        _logger.LogDebug("Fetching all movies");
        return _movieService.GetAllMovies();
    }

    [HttpGet("{id}", Name = "GetMovieById")]
    public Movie? GetMovieById(int id)
    {
        return _movieService.GetMovieById(id);
    }

    [HttpPost(Name = "AddMovie")]
    public IActionResult AddMovie([FromBody] Movie movie)
    {
        _movieService.AddMovie(movie);
        return Ok();
    }

    [HttpPut(Name = "UpdateMovie")]
    public IActionResult UpdateMovie([FromBody] Movie movie)
    {
        _movieService.UpdateMovie(movie);
        return Ok();
    }

    [HttpDelete("{id}", Name = "DeleteMovie")]
    public IActionResult DeleteMovie(int id)
    {
        _movieService.DeleteMovie(id);
        return Ok();
    }
}