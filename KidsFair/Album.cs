using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace KidsFair
{
    internal class Album
    {
        private string albumName; // Album name
        private string artistName; // Artist name
        private int numOfTracks; // Number of tracks as an integer

        public void Start()
        {
            Console.WriteLine();
            Console.WriteLine("Starting the album program!");
            Console.WriteLine();

            ReadAndSaveAlbumData();
            ShowAlbumInfo();
        }

        private void ReadAndSaveAlbumData()
        {
            ReadAlbumName();
            ReadArtistName();
            ReadNumOfTracks();
        }
        private void ShowAlbumInfo()
        {
            // Writes text out to the console containing the album name, artist/band name and number of tracks
            string textOut = "Album Name: " + albumName + "\n" + "Artist/Band: " + artistName + "\n" + "Number of Tracks: " + numOfTracks + "\n" + "Enjoy listening!";

            Console.WriteLine("++++++++++++++++++++++++");
            Console.WriteLine(textOut); // Writes the above string to the console
            Console.WriteLine("++++++++++++++++++++++++");
            Console.WriteLine(); // Blank line
        }
        private void ReadAlbumName()
        {
            // Reads the name of the album put in by user
            Console.WriteLine("What's the name of your favorite music album?" + "\n");

            albumName = Console.ReadLine();
            Console.WriteLine();
        }
        private void ReadArtistName()
        {
            // Reads the name of the artis/band put in by user
            Console.WriteLine("What's the name of the Artist or Band for " + albumName + "?" + "\n");

            artistName = Console.ReadLine();
            Console.WriteLine();
        }

        private void ReadNumOfTracks()
        {
            // Reads the number of tracks put in by user
            Console.WriteLine("How many tracks does " + albumName + " have?" + "\n");

            numOfTracks = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }
    }
}
