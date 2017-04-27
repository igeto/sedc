using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM.Repo
{
    class Program
    {
        public static List<Artist> Artists { get; set; }
        static void Main(string[] args)
        {
            Init();
            var ss = Artists.Where(x => x.Id == 2).Select(x => x.FullName).FirstOrDefault();
            var ss2 = Artists.Where(x => x.albums.Count() >= 2).Select(x => x.FullName);

            string artists = Artists.Where(x => x.FullName.Contains("a"))
                                    .Select(x => x.FullName)
                                    .Aggregate((a, b) => a + ", " + b);

            //var ss4 = Artists
            //            .Where(x => x.albums
            //                         .Exists(p => p.Name.Contains("Metalika")))
            //                         .FirstOrDefault().ArtistType.ToString();

            var listOfSoloArtists = Artists.Where(x => x.ArtistType.ToString().Contains("Band")).Select(x => x.FullName).Max();

            Console.WriteLine(listOfSoloArtists);
            Console.ReadLine();
        }

        private static void Init()
        {
            Artists = new List<Artist>();
            Artists.Add(new Artist(1, "Metallica", ArtistType.Band));
            Artists.Add(new Artist(2, "Iron Maiden", ArtistType.Band));

            var AlbumsMetallica = new List<Album>();
            AlbumsMetallica.Add(new Album(1, 1, "Metallica Album 1", Genre.PopRock, 1991));
            AlbumsMetallica.Add(new Album(2, 1, "Metallica Album 2", Genre.PopRock, 1991));
            Artists[0].albums = AlbumsMetallica;

            var AlbumsIron = new List<Album>();
            AlbumsIron.Add(new Album(1, 1, "Iron Maiden 1", Genre.PopRock, 1991));
            AlbumsIron.Add(new Album(2, 1, "Iron Maiden 2", Genre.PopRock, 1991));
            Artists[1].albums = AlbumsIron;

            var Songs = new List<Song>();
            Songs.Add(new Song(1, 1, "1", 5 * 60 + 31));
            Songs.Add(new Song(2, 1, "2", 5 * 60 + 24));
            Artists[0].albums[0].songs = Songs;

            Songs = new List<Song>();
            Songs.Add(new Song(1, 1, "3", 5 * 60 + 31));
            Songs.Add(new Song(2, 1, "4", 5 * 60 + 24));
            Artists[0].albums[1].songs = Songs;

            Songs = new List<Song>();
            Songs.Add(new Song(1, 1, "5", 5 * 60 + 31));
            Songs.Add(new Song(2, 1, "6", 5 * 60 + 24));
            Artists[1].albums[0].songs = Songs;

        }

    }
}