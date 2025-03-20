class Program
{
    static void Main()
    {
        try
        {
            // Uji Prekondisi: Judul terlalu panjang
            SayaTubeVideo video1 = new SayaTubeVideo(new string('A', 101));
        }
        catch (Exception e)
        {
            Console.WriteLine($"Exception: {e.Message}");
        }

        try
        {
            // Uji Normal
            SayaTubeVideo video2 = new SayaTubeVideo("Tutorial Design By Contract – Farhan");
            video2.PrintVideoDetails();

            // Uji Prekondisi: Penambahan play count lebih dari 10.000.000
            video2.IncreasePlayCount(15000000);
        }
        catch (Exception e)
        {
            Console.WriteLine($"Exception: {e.Message}");
        }

        // Uji Overflow
        SayaTubeVideo video3 = new SayaTubeVideo("Test Overflow");
        for (int i = 0; i < 5; i++) // 5x250 juta (overflow cepat)
        {
            video3.IncreasePlayCount(250000000);
        }
        video3.PrintVideoDetails();
    }
}
