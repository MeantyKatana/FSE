namespace DefaultNamespace;

public class Program
{
using System;

abstract class MediaFactory
{
    public abstract Movie CreateMovie();
    public abstract Trailer CreateTrailer();
}

class ComedyMediaFactory : MediaFactory
{
    public override Movie CreateMovie()
    {
        return new ComedyMovie();
    }

    public override Trailer CreateTrailer()
    {
        return new ComedyTrailer();
    }
}

class DramaMediaFactory : MediaFactory
{
    public override Movie CreateMovie()
    {
        return new DramaMovie();
    }

    public override Trailer CreateTrailer()
    {
        return new DramaTrailer();
    }
}

abstract class Movie
{
    public abstract void Play();
}
abstract class Trailer
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


class ComedyTrailer : Trailer
{
    public override void Play()
    {
        Console.WriteLine("Playing Comedy Trailer");
    }
}

class DramaTrailer : Trailer
{
    public override void Play()
    {
        Console.WriteLine("Playing Drama Trailer");
    }
}

class Client
{
    private Movie _movie;
    private Trailer _trailer;

    public Client(MediaFactory factory)
    {
        _movie = factory.CreateMovie();
        _trailer = factory.CreateTrailer();
    }

    public void WatchMovie()
    {
        _movie.Play();
    }

    public void WatchTrailer()
    {
        _trailer.Play();
    }
}

class Program
{
    static void Main()
    {
        MediaFactory comedyFactory = new ComedyMediaFactory();
        Client comedyClient = new Client(comedyFactory);

        comedyClient.WatchMovie();
        comedyClient.WatchTrailer();

        MediaFactory dramaFactory = new DramaMediaFactory();
        Client dramaClient = new Client(dramaFactory);

        dramaClient.WatchMovie();
        dramaClient.WatchTrailer();
    }
}

}