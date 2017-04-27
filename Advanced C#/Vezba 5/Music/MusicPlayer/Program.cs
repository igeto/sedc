using Music;
using Music.Domain;
using Music.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Artist> Artists = new List<Artist>{
                new Artist(1, "LP", ArtistType.SoloArtist),
                new Artist(2, "Deep Purple", ArtistType.Band),
                new Artist(3, "Pink Floyd", ArtistType.Band)
            };

            List<Album> AlbumsLp = new List<Album>
            {
                new Album(1, 1, "Lost On You", Genre.PopRock, 2016),
                new Album(2, 1, "Heart-shaped Scar", Genre.PopRock, 2001),
                new Album(3, 1, "Forever For Now", Genre.PopRock, 2014)
            };
            Artists[0].Albums = AlbumsLp;
            List<Album> AlbumsDeepPurple = new List<Album>
            {
                new Album(1, 2, "Stormbringer", Genre.Rock, 1974),
                new Album(2, 2, "Burn", Genre.Rock, 1974),
                new Album(3, 2, "Perfect Strangers", Genre.Rock, 1984)
            };
            Artists[1].Albums = AlbumsDeepPurple;
            List<Album> AlbumsPinkFloyd = new List<Album>
            {
                new Album(1, 3, "The Division Bell", Genre.Rock, 1994),
                new Album(2, 3, "The Wall", Genre.Rock, 1979),
                new Album(3, 3, "The Dark Side Of The Moon", Genre.Rock, 1973)
            };
            Artists[2].Albums = AlbumsPinkFloyd;

            List<Song> SongsLp = new List<Song>
            {
                new Song(1, 1, "Lost On You", 268),
                new Song(2, 1, "Muddy Waters ", 227)
            };
            Artists[0].Albums[0].Songs = SongsLp;
            List<Song> SongsLp1 = new List<Song>
            {
                new Song(1, 2, "Perfect", 314),
                new Song(2, 2, "Love Somebody", 302),
            };
            Artists[0].Albums[1].Songs = SongsLp1;
            List<Song> SongsLp2 = new List<Song>
            {
                new Song(1, 3, "Heavenly Light", 231),
                new Song(2, 3, "night Like This", 240)
            };
            Artists[0].Albums[2].Songs = SongsLp2;


        }
    }
}
