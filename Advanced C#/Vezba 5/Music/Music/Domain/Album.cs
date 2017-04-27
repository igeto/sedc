using Music.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music
{
    public class Album
    {
        public int ID { get; set; }
        public int ArtistId { get; set; }
        public string AlbumName { get; set; }
        public Genre Genre { get; set; }
        public int Year { get; set; }
        public List<Song> Songs { get; set; }

        public Album(int id, int artistId, string albumName, Genre genre, int year)
        {
            ID = id;
            ArtistId = artistId;
            AlbumName = albumName;
            Genre = genre;
            Year = year;
        }
    }
}
