using System;
using System.Collections.Generic;

class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        Random random = new Random();
        this.id = random.Next(10000, 99999);
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        playCount += count;
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine($"ID: {id}");
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Play Count: {playCount}");
    }

    public int GetPlayCount()
    {
        return playCount;
    }

    public string GetTitle()
    {
        return title;
    }
}

class SayaTubeUser
{
    private int id;
    private string username;
    private List<SayaTubeVideo> uploadedVideos;

    public SayaTubeUser(string username)
    {
        Random random = new Random();
        this.id = random.Next(10000, 99999);
        this.username = username;
        this.uploadedVideos = new List<SayaTubeVideo>();
    }

    public void AddVideo(SayaTubeVideo video)
    {
        uploadedVideos.Add(video);
    }

    public int GetTotalVideoPlayCount()
    {
        int totalPlayCount = 0;
        foreach (var video in uploadedVideos)
        {
            totalPlayCount += video.GetPlayCount();
        }
        return totalPlayCount;
    }

    public void PrintAllVideoPlaycount()
    {
        Console.WriteLine($"User: {username}");
        int index = 1;
        foreach (var video in uploadedVideos)
        {
            Console.WriteLine($"Video {index} judul: {video.GetTitle()}");
            index++;
        }
    }
}

class Program
{
    static void Main()
    {
        SayaTubeUser user = new SayaTubeUser("Atika");

        string[] judulFilm = {
            "Review Film Inception oleh Atika",
            "Review Film Interstellar oleh Atika",
            "Review Film The Dark Knight oleh Atika",
            "Review Film Parasite oleh Atika",
            "Review Film Avengers: Endgame oleh Atika",
            "Review Film The Matrix oleh Atika",
            "Review Film Forrest Gump oleh Atika",
            "Review Film Spirited Away oleh Atika",
            "Review Film The Shawshank Redemption oleh Atika",
            "Review Film Fight Club oleh Atika"
        };

        foreach (string judul in judulFilm)
        {
            user.AddVideo(new SayaTubeVideo(judul));
        }

        user.PrintAllVideoPlaycount();
    }
}
