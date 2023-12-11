using System;

interface IPrototype
{
    IPrototype Clone();
    void Play();
}

class Movie : IPrototype
{
    public string Title { get; set; }
    public string Genre { get; set; }
    public string Director { get; set; }
    public int Duration { get; set; }

    public IPrototype Clone()
    {
        return new Movie
        {
            Title = this.Title,
            Genre = this.Genre,
            Director = this.Director,
            Duration = this.Duration
        };
    }

    public void Play()
    {
        Console.WriteLine($"Playing {Genre} Movie - {Title} (Director: {Director}, Duration: {Duration} minutes)");
    }
}

class Program
{
    static void Main()
    {
        Movie prototypeMovie = new Movie
        {
            Title = "The Prototype Movie",
            Genre = "Sci-Fi",
            Director = "Jane Director",
            Duration = 150
        };

        Movie newMovie = (Movie)prototypeMovie.Clone();
        newMovie.Title = "The New Movie";

        prototypeMovie.Play();
        newMovie.Play();
    }
}