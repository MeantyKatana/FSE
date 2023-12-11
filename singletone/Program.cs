using System;


public sealed class Cinema
{
    private static Cinema instance;

    private Cinema() { }

    public static Cinema Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new Cinema();
            }
            return instance;
        }
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Welcome to our cinema!");
    }
}

class Program
{
    static void Main()
    {
        Cinema cinema = Cinema.Instance;

        cinema.DisplayInfo();
    }
}