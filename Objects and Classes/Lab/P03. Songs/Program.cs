namespace P03._Songs
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            List<Song> listSong = new List<Song>();
            for (int i = 0; i < n; i++)
            {
                string[] songData = Console.ReadLine().Split('_');
                string typeList = songData[0];
                string name = songData[1];
                string time = songData[2];
                Song newSong = new Song(typeList, name, time);
                listSong.Add(newSong);


            }
            string type = Console.ReadLine();
            if (type == "all")
            {
                foreach (Song song in listSong)
                {
                    Console.WriteLine(song.Name);
                }

            }
            else
            {
                foreach (Song song in listSong.Where(x => x.TypeList == type))
                {
                    Console.WriteLine(song.Name);
                }
            }
               

        }
    }
    class Song
    {
        public Song(string typeList, string name, string time)
        {
            TypeList = typeList;
            Name = name;
            Time = time;
        }

        public string TypeList { get; set; }
        public string Name { get; set; }    
        public string Time { get; set; }


    }


}
