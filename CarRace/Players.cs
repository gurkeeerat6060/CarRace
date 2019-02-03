using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRace
{
    class Players
    {
        /*
        winner method is post define method that is used for passing the value of the winner after winning the game . it has different   argument list to do perform task
        */
        public int  winner(String Name,int Amount, int bet) {
            Amount = Amount - bet;
            return Amount;
        }

    }
}
