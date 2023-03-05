using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongLib
{
    public interface ISong
    {
        string Name
        {
            get;
            set;
        }

        void Play();
        void Sing();
        void Dance();
        void Copy();
    }

    public interface Iplay
    {
        string Name
        { 
            get; set; 
        }
        void Play();
    }

    public abstract class Song : ISong, Iplay, IComparable<Song>
    {
        public int year;
        public string lyrics;
        public string composer;
        public string srtist;
        public int nRating;
        public int nCopies;
        
        public string Name
        {
            get;
            set;
        }

        public abstract void Play();
        public void Sing()
        {
            // la la la
        }

        public void Dance()
        {
            //bust out my moves
        }

        public virtual void Copy()
        {
            //default code to copy a song
        }

        public int CompareTo(Song s)
        {
            return this.Name.CompareTo(s.Name);
        }
    }

    public class TapeSong : Song
    {
        public string tapeName;
        public int side;
        public int counter;

        public override void Play()
        {
            //load the tape on the correct side
            //fast forward to the counter 
            //press the play button
        }
    }

    public class VinylSong : Song
    {
        public string recordName;
        public int side;
        public int track;

        public override void Play()
        {
            //turn on the turntable
            //put the record on the correct side
            // drop the needle on the correct track
        }
    }

    public class CDSong : Song
    {
        public string cdName;
        public int track;

        public override void Play()
        {
            //Insert the cd 
            // forward to the truck
            // press the play button
        }
    }

    public class MP3SOng : Song
    {
        public string fileName;

        public override void Play()
        {
            // double-click the filename
        }

        public virtual void Copy()
        {
            // do step 1

            base.Copy();

            // copy and paste the mp3 file

        }
    }

    public class Game : Iplay
    {
        public int players;
        public string Name
        {
            get; set;
        }

        public void
    }

    public sealed class MyClass
    {
        // class members
    }
    
    public class myDerivedClass : MyClass
    {
        // class members
    }

}
