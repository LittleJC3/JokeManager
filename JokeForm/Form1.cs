using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JokeManagerNamespace;


namespace JokeForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // This code runs when the form loads

            // Declare and instantiate
            

        }

        private void submitBTN_Click(object sender, EventArgs e)
        {

            String UCID = sixtwoTB.Text;
            String Joke = jokeTB.Text;
            
            if(JokeManager.SaveJoke(UCID, Joke) == -1 )
            {
                int JokeStuff = JokeManager.SaveJoke(UCID, Joke);
                // Need to put this in the if statement, otherwise it will never display the congrats, even if it goes through
                storedLBL.Text = "Congrats! Your hilarious joke is now saved into our database.";
            } else
            {
                storedLBL.Text = "Oops! Something went wrong! Joke or 6+2 may already be taken.";
            }

        }
    }
}
