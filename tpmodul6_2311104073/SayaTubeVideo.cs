using System;

class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        // Prekondisi: Judul tidak boleh null dan maksimal 100 karakter
        if (string.IsNullOrEmpty(title))
            throw new ArgumentException("Judul tidak boleh kosong.");
        if (title.Length > 100)
            throw new ArgumentException("Judul maksimal 100 karakter.");

        this.id = new Random().Next(10000, 99999); // Generate ID random 5 digit
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        try
        {
            // Prekondisi: Jumlah penambahan play count tidak boleh lebih dari 10.000.000
            if (count > 10000000)
                throw new ArgumentException("Penambahan play count maksimal 10.000.000.");

            // Cek Overflow
            checked
            {
                playCount += count;
            }
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error: Play count melebihi batas integer!");
        }
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine($"ID: {id}");
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Play Count: {playCount}");
    }
}
