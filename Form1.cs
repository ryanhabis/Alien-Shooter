using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_PrggrammingGame
{
    public partial class Form1 : Form
    {
        
        int shotsCounter = 0;
        int missShotCounter = 0;
        int timeLeft = 15;

        public Form1()
        {
            InitializeComponent();
        }

        private void Score_Click(object sender, EventArgs e)
        {

        }

        private void totalShots_Click(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            // This restarts the application
            Application.Restart();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // closes the game
            this.Close();
        }
        
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // once the picture is shot it will record it and show the result
            shotsCounter++;
            int missedAndHitshots = shotsCounter + missShotCounter;
            totalShots.Text = ("Total: " + missedAndHitshots.ToString());
            Score.Text = ("Score: " + shotsCounter.ToString());
            if (shotsCounter == 10)
            {
                winner.Visible = true;
                timer2.Stop();
                timer1.Stop();
                win.URL = @"D:\College work\GUI-PrggrammingGame\GUI-PrggrammingGame\bin\Debug\winner2.wav";
            }
            lazerShoot.URL = @"D:\College work\GUI-PrggrammingGame\GUI-PrggrammingGame\bin\Debug\lazerShoot.wav";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // before the player takes any shots the text bellow will appear
            totalShots.Text = shotsCounter.ToString();
            Score.Text = shotsCounter.ToString();
            totalShots.Text = "Total: 0";
            Score.Text = "Score: 0";
            backgroundMusic.URL= @"D:\College work\GUI-PrggrammingGame\GUI-PrggrammingGame\bin\Debug\backgroundMusic.wav";
        }

        private void missedShots_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            //Records and shows the total shots and missed shots
            missShotCounter++;
            int missedAndHitshots = shotsCounter + missShotCounter;
            totalShots.Text = ("Total: " + missedAndHitshots.ToString());
            missedShots.Text = missShotCounter.ToString();
            missedShots.Text = ("Missed: " + missShotCounter.ToString());
            // if the player misses 10 times the game will end
            if (missShotCounter == 10)
            {
                over.Visible = true;
                gameOver.URL = @"D:\College work\GUI-PrggrammingGame\GUI-PrggrammingGame\bin\Debug\gameOver.wav";
                timer2.Stop();
                timer1.Stop();
            }
            lazerShoot.URL = @"D:\College work\GUI-PrggrammingGame\GUI-PrggrammingGame\bin\Debug\lazerShoot.wav";

        }
        public Random r = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            // the image will randomly move around the alocated space below because of a random number generator 
            int x = r.Next(0, 500);
            int y = r.Next(200, 330);
            pictureBox2.Location = new Point(x, y);
        }
       
        private void timerCount_Click(object sender, EventArgs e)
        {

        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            // this is how I made the application start a count down
            if(timeLeft > 0)
            {
                timeLeft--;
                timerCount.Text = "Time left: " + timeLeft + " seconds";
            }
            else
            {
                timer2.Stop();
                timer1.Stop();
                over.Visible = true;
                gameOver.URL = @"D:\College work\GUI-PrggrammingGame\GUI-PrggrammingGame\bin\Debug\gameOver.wav";
            }
        }
       
        private void over_Click(object sender, EventArgs e)
        {

        }

        private void winner_Click(object sender, EventArgs e)
        {

        }
        private void backgroundMusic_Enter(object sender, EventArgs e)
        {
           
        }

        private void win_Enter(object sender, EventArgs e)
        {

        }
    }
}
