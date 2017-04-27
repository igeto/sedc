using Music.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.Domain
{
    public class Artist
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ArtistType ArtistType { get; set; }
        public List<Album> Albums { get; set; }

        public Artist(int id, string name, ArtistType artistType)
        {
            ID = id;
            Name = name;
            ArtistType = artistType;
        }
    }
}
