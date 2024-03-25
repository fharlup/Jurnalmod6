using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp1.SayaTubeVIdoe;


namespace ConsoleApp1
{
    internal class SayaTubeUser
    {


        private int id;
        private List<SayaTubeVIdoe> uploadedVideos;
        private string username;

        public SayaTubeUser(string nama)
        {
            Contract.Requires(nama != null);
            Contract.Requires(nama.Length <= 200);
            username = nama;
            uploadedVideos = new List<SayaTubeVIdoe>();


        }
        public int GetTotalVideoPlayCount()
        {
            int count = 0;

            foreach (SayaTubeVIdoe video in uploadedVideos)
            {
                count += video.GetPlayCount();
            }
            return count;

        }
        public void AddVideo(SayaTubeVIdoe vidoe)
        {

            Contract.Requires(vidoe != null);
            uploadedVideos.Add(vidoe);
        }
        public void PrintAllVIdoecount()
        {  
            

            for (int i = 0; i < uploadedVideos.Count; i++)
            {
                if (i > 7)
                {
                    break;
                }
                Console.WriteLine("vidoe" + i + 1 + "judul" + uploadedVideos[i].Gettitle() + "count" + uploadedVideos[i].GetPlayCount());
            }

        }
    }

}
