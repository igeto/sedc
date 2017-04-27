using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.Domain
{
    public class Song
    {
        public int ID { get; set; }
        public int AlbumId { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }

        public Song(int id, int albumId, string name, int duration)
        {
            ID = id;
            AlbumId = albumId;
            Name = name;
            Duration = duration;
        }
    }
}
