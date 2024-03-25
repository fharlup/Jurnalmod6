using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class program
{
    public static void Main(string[] args)
    {
        SayaTubeVIdoe video1 = new SayaTubeVIdoe("a");
        SayaTubeVIdoe video2 = new SayaTubeVIdoe("b");
        SayaTubeVIdoe video3 = new SayaTubeVIdoe("c");
        SayaTubeVIdoe video4= new SayaTubeVIdoe("d");
        SayaTubeVIdoe video5 = new SayaTubeVIdoe("e");
        SayaTubeVIdoe video6 = new SayaTubeVIdoe("f");
        SayaTubeVIdoe video8 = new SayaTubeVIdoe("g");
        SayaTubeVIdoe video9 = new SayaTubeVIdoe("x");

        SayaTubeVIdoe video7 = new SayaTubeVIdoe("y");
        SayaTubeVIdoe video10= new SayaTubeVIdoe("z");
        Random rand = new Random();
        video9.IncreasePlayCount(rand.Next(10000, 99999));
        video1.IncreasePlayCount(rand.Next(10000, 99999));
        video2.IncreasePlayCount(rand.Next(10000, 99999));
        video3.IncreasePlayCount(rand.Next(10000, 99999));
        video4.IncreasePlayCount(rand.Next(10000, 99999));
        video5.IncreasePlayCount(rand.Next(10000, 99999));
        video6.IncreasePlayCount(rand.Next(10000, 99999));
        video7.IncreasePlayCount(rand.Next(10000, 99999));
        video8.IncreasePlayCount(rand.Next(10000, 99999));
        video10.IncreasePlayCount(rand.Next(10000, 99999));
        SayaTubeUser user = new("fajar mufid");
        user.AddVideo(video10);
        user.AddVideo(video1);
        user.AddVideo(video2);
        user.AddVideo(video3);
        user.AddVideo(video4);
        user.AddVideo(video5);
        user.AddVideo(video6);
        user.AddVideo(video7);
        user.AddVideo(video8);
        user.AddVideo(video9);
        Console.WriteLine("Review Film " + video1.Gettitle() + "oleh fajar");
        video1.PrintVideoDetails();
        Console.WriteLine("Review Film " + video1.Gettitle() + "oleh fajar");
        video2.PrintVideoDetails();
        Console.WriteLine("Review Film " + video1.Gettitle() + "oleh fajar");
        video3.PrintVideoDetails();
        Console.WriteLine("Review Film " + video1.Gettitle() + "oleh fajar");
        video3.PrintVideoDetails();
        Console.WriteLine("Review Film " + video1.Gettitle() + "oleh fajar");
        video4.PrintVideoDetails();
        Console.WriteLine("Review Film " + video1.Gettitle() + "oleh fajar");
        video5.PrintVideoDetails();
        Console.WriteLine("Review Film " + video1.Gettitle() + "oleh fajar");
        video6.PrintVideoDetails();
        Console.WriteLine("Review Film " + video1.Gettitle() + "oleh fajar");
        video7.PrintVideoDetails();
        Console.WriteLine("Review Film " + video1.Gettitle() + "oleh fajar");
        video8.PrintVideoDetails();
        Console.WriteLine("Review Film " + video1.Gettitle() + "oleh fajar");
        video9.PrintVideoDetails();


        user.PrintAllVIdoecount();


    }
}

