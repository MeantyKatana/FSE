{
public abstract void Play();
}

class ComedyMovie : Movie
{
    public override void Play()
    {
        Console.WriteLine("Playing Comedy Movie");
    }
}

class DramaMovie : Movie
{
    public override void Play()
    {
        Console.WriteLine("Playing Drama Movie");
    }
}

abstract class MovieFactory
{
    public abstract Movie CreateMovie();
}

class ComedyMovieFactory : MovieFactory
{
    public override Movie CreateMovie()
    {
        return new ComedyMovie();
    }
}

class DramaMovieFactory : MovieFactory
{
    public override Movie CreateMovie()
    {
        return new DramaMovie();
    }
}

class Client
{
    private MovieFactory _movieFactory;

    public Client(MovieFactory movieFactory)
    {
        _movieFactory = movieFactory;
    }

    public void WatchMovie()
    {
        Movie movie = _movieFactory.CreateMovie();
        movie.Play();
    }
}

class Program
{
    static void Main()
    {

        MovieFactory comedyFactory = new ComedyMovieFactory();
        Client comedyClient = new Client(comedyFactory);

        comedyClient.WatchMovie();

        MovieFactory dramaFactory = new DramaMovieFactory();
        Client dramaClient = new Client(dramaFactory);

        dramaClient.WatchMovie();
    }
}