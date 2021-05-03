using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace projectPRG
{
    public partial class single : Form
    {
        public single()
        {
            InitializeComponent();
        }
        public string scores
        {
            get { return score.ToString(); }
        }
        int count = 0;
        int score;
        private void btnhipop_Click(object sender, EventArgs e)
        {
            lblcorrectdrake.Show();
            lblcorrectdrake.Text = "CORRECT ANSWER ";
            btnhipop.BackColor = Color.Green;
           
            

          


            if (lblcorrectdrake.Visible)
            {
                count += 5;

            }

            lblscore1.Text = count.ToString();

            lblscore1.Show();










         
        }

        private void btntrapdrake_Click(object sender, EventArgs e)
        {
            lblcorrectdrake.Show();
            lblcorrectdrake.Text = "CORRECT ANSWER";
            btntrapdrake.BackColor = Color.Green;
           
            lblscore1.Show();

          
            
            if (lblcorrectdrake.Visible)
            {
                count += 5;

            }

            lblscore1.Text = count.ToString();
        }

        private void btnelectrodrake_Click(object sender, EventArgs e)
        {
            btnelectrodrake.BackColor = Color.Red;
            Console.Beep();
            lblincorrectdrake.Show();
            
           
           
            lblscore1.Show();
            if (lblcorrectdrake.Visible)
            {
                count += 5;

            }
            else
            {
                count = 0;
            }

            lblscore1.Text = count.ToString();


            
          
            
        }

        private void single_Load(object sender, EventArgs e)
        {
            lblcorrectdrake.Hide();
            lblincorrectdrake.Hide();
            label3.Hide();
            lblcorrect.Hide();
            label5.Hide();
            label6.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            Console.Beep();
            button2.BackColor = Color.Red;
           
          
           
            label3.Show();
           
            lblscore2.Show();
            if (lblcorrect.Visible)
            {
                count += 5;

            }
            else
            {
                count += 0;
            }

            lblscore2.Text = count.ToString();


        }

        private void button3_Click(object sender, EventArgs e)
        {

            Console.Beep();
            button3.BackColor = Color.Red;



            label3.Show();

            lblscore2.Show();
            if (lblcorrect.Visible)
            {
                count += 5;

            }
            else
            {
                count += 0;
            }

            lblscore2.Text = count.ToString();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            button1.BackColor = Color.Green;

            lblcorrect.Text = "CORRECT ANSWER!";
           
            lblscore2.Show();

            
            if (lblcorrect.Visible)
            {
                score = count += 5;


            }
            lblscore2.Text = score.ToString();


        }

        private void button5_Click(object sender, EventArgs e)
        {

            button5.BackColor = Color.Green;

            label5.Text = "CORRECT ANSWER!";

            lblscore3.Show();


            if (label5.Visible)
            {
                score = count += 5;


            }
            lblscore3.Text = score.ToString();


        }

        private void button4_Click(object sender, EventArgs e)
        {

            Console.Beep();
            button4.BackColor = Color.Red;



            label6.Text = "INNCORRECT";

            lblscore3.Show();
            if (label6.Visible)
            {
                count += 5;

            }
            else
            {
                count += 0;
            }

            lblscore3.Text = count.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Thread countDown = new Thread(new ThreadStart(Timer));
            countDown.Start();
            
            Console.Beep();
        }
        public void Timer()
        {

            for (int i = 300; i >= 0; i--)
            {
                Lableupdate();
                countNumber--;
                Thread.Sleep(1000);


            }
            if (countNumber == 0)
            {
                MessageBox.Show("Time up", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                END hh = new END();
                hh.Hide();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

      
        int countNumber = 300;

        public delegate void Countdown();
        public void Lableupdate()
        {
            if (lblTime.InvokeRequired)
            {
                Countdown cc = new Countdown(Lableupdate);
                this.Invoke(cc);
            }
            else
            {
                lblTime.Text = countNumber.ToString() + "   " + "seconds remaining ";
            }
        }

        private void lblscore1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Console.Beep();
            button6.BackColor = Color.Red;



            label6.Text = "INNCORRECT";

            lblscore3.Show();
            if (label5.Visible)
            {
                count += 5;

            }
            else
            {
                count += 0;
            }

            lblscore3.Text = count.ToString();
        }
    }
}
    

