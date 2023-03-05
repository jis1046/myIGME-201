using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SongAppLib;

namespace SongApp
{
    internal class Program
    {

        struct 
        static void Main(string[] args)
        {
            Song song;
            ISong iSong;
            Object myObject;

            TapeSong tapeSong = new TapeSong();

            tapeSong.artist = "Pharrel Williams";
            tapeSong.Name = "Happy";
            tapeSong.side - 1;
            tapeSong.Play();

            // We can use any parent of TapeSong as a handle for it
            // so we can use a song variable to point to it
            song = tapeSong;

            string.artist = song.artist;
            //song.tapeName = "";
            song.Play();

            song.nCopes = 50;

            tapeSong pTapeSong;

            pTapeSong = tapeSong;

            iSong = pTapeSong;

            iSong.Name = "Sad";

            SongStruct mySong;
            mySong.name = "Happy";

            SongStruct anotherSongStruct;
            anotherSongStruct = mySong;

            anotherSongStruct.name = "Sad";

            List<SongApp> songList = new List<SongApp>();

            VinylSong vinylSong = new VinylSong();
            vinylSong.Name = "Suite Judy Blue Eyes";

            songList.Add(tapeSong);
            songList.Add(vinylSong);

            songList.Sort();

            songList.OrderBy(delegate (Song s) {  return s.artist; }).ToList();
            songList.OrderBy((Song s) => { return s.artist; }).ToList();
            songList.OrderBy((s) =>  s.artist).ToList();
            songList.OrderBy( s => s.artist).ToList();

            List<Song> newList = songList.GetRange(0, songList.Count);

            List<Song> pSongList;
            pSongList = songList;




        }
    }
}
