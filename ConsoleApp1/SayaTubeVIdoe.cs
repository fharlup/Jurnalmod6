using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class SayaTubeVIdoe
    {
        

    private int id;
    private string title;
    private int playCount;


        public int GetPlayCount()
        {
            return playCount;
        }
        public SayaTubeVIdoe(String title)
    {
        Contract.Requires(title != null);
        Contract.Requires(title.Length <= 200);
           

        Random rand = new Random();
        id = rand.Next(10000, 99999);
        this.title = title;
        playCount = 0;
          

        }
    public void IncreasePlayCount(int count)
    {
        Contract.Requires(count <= 25000000);
        try
        {
            checked
            {
                this.playCount += count;
            }
        }
        catch (OverflowException ex)
        {
            Console.WriteLine("Error : {0} ", ex.Message);
        }

    }
    public void PrintVideoDetails()
    {
        Console.WriteLine("Video ID : {0} ", id);
        Console.WriteLine("Title : {0} ", title);
        Console.WriteLine("Play Count : {0} ", playCount);
    }
    public string Gettitle()
    {
        return title;
    }
}
    
    }

