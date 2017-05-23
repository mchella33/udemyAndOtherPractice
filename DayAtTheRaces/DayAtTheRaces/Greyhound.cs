using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DayAtTheRaces
{
    public class Greyhound
    {
        public int StartingPosition; //where my PictureBox starts
        public int RacetrackLenth; //How long the reacetrack is
        public PictureBox MyPictureBox = null; //My PictureBox object
        public int Location = 0; // My location on the racetrack
        public Random Randomizer; // An instance of Random
        public bool Run()
        {
            //Move forward either 1, 2, 3 or 4 spaces at random
            //Update the position of my PictureBox on the form like this:
            // My PictureBox.Left = StartingPosition + Location;
            // Return true if I won the race
        }
        public void TakeStartingPosition()
        {
            //Reset my location to 0 and my PictureBox to starting position
        }

        GreyhoundArray[0] = new Greyhound()
        {
            MyPictureBox = pictureBox1,
            StartingPosition = pictureBox1,
            RacetrackLength = racetrackPictureBox.Width - pictureBox1.Width,
            Randomizer = MyRandomizer
        };


    }
}
