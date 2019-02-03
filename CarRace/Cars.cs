using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRace
{
    class Cars
    {
        /*
         * Object of random class that is used to generate a random no and then move the picture location 
         */
        Random rm = null;
        int move = 0;
        //this is user define method that is used to return a integer no to move the picture from one location to another using x-axis
        public int position() {
            rm = new Random();
            //calling the next function and generate a random no and pass it to the global variable and then return it to the main class for moving the image 
            move = rm.Next(1, 20);
            return move;
        }
        // this method is also user define method that is used to reset the whole images of the car from track 
        public int reset() {
            return -1;
        }

    }
}
