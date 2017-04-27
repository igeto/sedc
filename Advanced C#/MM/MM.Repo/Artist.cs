using System.Collections.Generic;

namespace MM.Repo
{
    public class Artist
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public ArtistType ArtistType { get; set; }
        public List<Album> albums { get; set; }

        public Artist() { }
        public Artist(int id, string fullName, ArtistType artistType)
        {
            Id = id;FullName = fullName;ArtistType = artistType;
        }
    }
}