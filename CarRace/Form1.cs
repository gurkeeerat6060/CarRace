using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRace
{
    public partial class Form1 : Form
    {
        /* global variable that are used for getting the name of the player and
         * no of car and bet amount and total amount which the player has in his account
        */
        String Player="";
        String Car="";
        int Amount=0;
        int winner=0;

        /*
            object of the user define classes that are used to call the method os those classes for calling the methods
         */
        Cars objCar = new Cars();
        Random rnd = new Random();
        Players objplayers = new Players();

        public Form1()
        {
            InitializeComponent();
            btnRace.Enabled = false;
            

        }

        private void btnBet_Click(object sender, EventArgs e)
        {
            //calling the Update Label Function to reset all the Label and display all the palyer's name with their individual amount
            updateLabel();
            /*this conditional statement is used for checking the bet if it is more then 
            the minimum amount or not if its more than then it will work otherwise it will give an error message 
            
             */
            if (nmBet.Value>=7) {

                //geting the name of the player who is going for the bet from the combo box
                Player = cbPlayer.SelectedItem.ToString();
                // getting the name of car on which the player has set the bet
                Car = cbCar.SelectedItem.ToString();
                /*passing the actuall amount of the player to the global variable which one the
                    player has this is done with the help of conditional statement 
                    and pass the value to the global variable so thus after winning or loosing the game the amount must be reseted from the player Account
                    */

                if (Player.Equals("David")) {
                    Amount = 50;
                    /*  this is used to pass the reset the label and pass the accurate message to them and print the accurate statement on label after
                     *  fixing the bet if the player name is david then the relevent label of david will be updated
                    */
                    label3.Text = "David has Bet on Car No " + Car +" Amount $"+nmBet.Value;
                }
                if (Player.Equals("Kain"))
                {
                    /*  this is used to pass the reset the label and pass the accurate message to them and print the accurate statement on label after fixing the bet
                     *  if the player is kain then the label of kain will be updated
                    */
                    label2.Text = "Kain has Bet on Car No " + Car + " Amount $" + nmBet.Value;
                    Amount = 70;
                }
                if (Player.Equals("Sam"))
                {

                    /*  this is used to pass the reset the label and pass the accurate message to them and print the accurate statement on label after fixing the bet
                     *  if the player is sam then the label of kain will be updated and Pass his Amount to the Global variable
                    */
                    Amount = 90;
                    label4.Text = "Sam has Bet on Car No " + Car + " Amount $" + nmBet.Value;

              

                }
                /* this conditional statement is used check the Amount of the bet if the player has less amount then the bet then 
                 * he can't be able to fix the bet  then this will generate an error messsage that the player has not enough money in his account
                 * 
                 */
                if (nmBet.Value>Amount){
                    //printing the error message dialoge box
                    MessageBox.Show("You are filling the bet Amount more than the Amount You have");
                }
                

            }
            else{
                // this is error message that will display when the player fix the amount less then minimum amount of the bet
                MessageBox.Show("You have to fill the Bet More than the Minimum Bet");

            }
            btnRace.Enabled = true;

        }
        //updateLabel is a POst deifne method that is used to reset all the label and all the values in the Label . we develop this empty type Method
        public void updateLabel() {
            label2.Text = "Kain has 70 Dollar in his Account";
            label3.Text = "David has 50 Dollar in his Account";
            label4.Text = "Sam has 90 Dollar in his Account";
        }
        private void nmBet_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            /* while clicking on the race button all timer will be start to do the task
             * while passing the interval also to change  the speed of the cars
            */
            TmCar1.Start();
            TmCar1.Interval=rnd.Next(1,15);

            tmCar2.Start();
            tmCar2.Interval = rnd.Next(1, 7);

            tmCar3.Start();
            tmCar3.Interval = rnd.Next(1, 10);

            btnRace.Enabled = false;
        }

        private void TmCar1_Tick(object sender, EventArgs e)
        {
            // this task perform the movement of the picture just when the pictureis less than the ending point 
            if (Car1.Left <= 570)
            {
                Car1.Left += objCar.position();
            }
            else{
                TmCar1.Stop();
            }

            // when car reached at the ending point then the winning dialogue box will be appear 
            if (Car1.Left>=570) {
                winner = 1;
                tmCar2.Stop();
                tmCar3.Stop();
                TmCar1.Stop();
                MessageBox.Show("Car 1 is winner");
                winningPlayer();
                

                
            }
            

        }

        private void tmCar2_Tick(object sender, EventArgs e)
        {
            // this task perform the movement of the picture just when the pictureis less than the ending point 
            if (Car2.Left <= 570)
            {
                Car2.Left += objCar.position();
            }
            else
            {
                tmCar2.Stop();
            }
            // when car reached at the ending point then the winning dialogue box will be appear 

            if (Car2.Left >= 570)
            {
                winner = 2;
                tmCar2.Stop();
                tmCar3.Stop();
                TmCar1.Stop();

                MessageBox.Show("Car 2 is winner");
                winningPlayer();
            }
        }

        private void tmCar3_Tick(object sender, EventArgs e)
        {
            // this task perform the movement of the picture just when the pictureis less than the ending point 
            if (Car3.Left <= 570)
            {
                Car3.Left += objCar.position();
            }
            else
            {
                tmCar3.Stop();

            }
            // when car reached at the ending point then the winning dialogue box will be appear 
            if (Car3.Left >= 570)
            {
                winner = 3;
                tmCar2.Stop();
                tmCar3.Stop();
                TmCar1.Stop();

                MessageBox.Show("Car 3 is winner");
                winningPlayer();
            }

        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            
        }
        /* this is post define Method that is used to increment or decrement the amount of the player and check the car is winning or not  
         * */
        public void winningPlayer() {
            int Amt = 0;
            if (winner == Convert.ToInt32(Car))
            {
                if (Player.Equals("David"))
                {
                    /*  increment the amount of the player
                    */
                    Amt = objplayers.winner(Player,Amount,Convert.ToInt32(nmBet.Value));
                    Amount = Amount + Convert.ToInt32(nmBet.Value);
                    label3.Text = "David has " + Amount + " Dollar in his Account";
                }
                if (Player.Equals("Kain"))
                {
                    /*  increment the amount of the player
                     */
                    Amt = objplayers.winner(Player, Amount, Convert.ToInt32(nmBet.Value));
                    Amount = Amount + Convert.ToInt32(nmBet.Value);
                    label2.Text = "Kain has " + Amount + " Dollar in his Account";

                }
                if (Player.Equals("Sam"))
                {

                    /*  increment the amount of the player
                     */
                    Amt = objplayers.winner(Player, Amount, Convert.ToInt32(nmBet.Value));
                    Amount = Amount + Convert.ToInt32(nmBet.Value);
                    label4.Text = "Sam has " + Amount + " Dollar in his Account";



                }


            }
            else {
                if (Player.Equals("David"))
                {
                    /*  decrement the amount of the player
                     */

                    Amount = Amount - Convert.ToInt32(nmBet.Value);
                    label3.Text = "David has " + Amount + " Dollar in his Account";
                }
                if (Player.Equals("Kain"))
                {
                    /*  decrement the amount of the player
                     */
                    Amount = Amount - Convert.ToInt32(nmBet.Value);
                    label2.Text = "Kain has" + Amount + " Dollar in his Account";

                }
                if (Player.Equals("Sam"))
                {

                    /*  decrement the amount of the player
                                         */
                    Amount = Amount - Convert.ToInt32(nmBet.Value);

                    label4.Text = "Sam has " + Amount + " Dollar in his Account";



                }

            }
            //calling the reset image method to move the image at the starting point
            resetImage();

        }
        //this method is post define method that is used reset all the image while calling the method of the car class so thus we can reset all the images
        public void resetImage() {
            Car1.Left = objCar.reset();
            Car2.Left = objCar.reset();
            Car3.Left = objCar.reset();
        }
    }
}
