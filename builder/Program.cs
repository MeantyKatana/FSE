using System;

class Movie
{
    public string Title { get; set; }
    public string Genre { get; set; }
    public string Director { get; set; }
    public int Duration { get; set; }

    public void Play()
    {
        Console.WriteLine($"Playing {Genre} Movie - {Title} (Director: {Director}, Duration: {Duration} minutes)");
    }
}

interface IMovieBuilder
{
    void SetTitle(string title);
    void SetGenre(string genre);
    void SetDirector(string director);
    void SetDuration(int duration);
    Movie Build();
}

class MovieBuilder : IMovieBuilder
{
    private Movie _movie = new Movie();

    public void SetTitle(string title)
    {
        _movie.Title = title;
    }

    public void SetGenre(string genre)
    {
        _movie.Genre = genre;
    }

    public void SetDirector(string director)
    {
        _movie.Director = director;
    }

    public void SetDuration(int duration)
    {
        _movie.Duration = duration;
    }

    public Movie Build()
    {
        return _movie;
    }
}

class Director
{
    private IMovieBuilder _builder;

    public Director(IMovieBuilder builder)
    {
        _builder = builder;
    }

    public Movie Construct(string title, string genre, string director, int duration)
    {
        _builder.SetTitle(title);
        _builder.SetGenre(genre);
        _builder.SetDirector(director);
        _builder.SetDuration(duration);

        return _builder.Build();
    }
}

class Program
{
    static void Main()
    {
        IMovieBuilder builder = new MovieBuilder();
        Director director = new Director(builder);

        Movie comedyMovie = director.Construct("The Funny Movie", "Comedy", "John Director", 120);
        comedyMovie.Play();
    }
}