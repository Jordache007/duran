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

namespace projectPRG
{
    public partial class play2 : Form
    {
        public play2()
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
            label8.Show();
            label8.Text = "CORRECT ANSWER ";
            btnhipop.BackColor = Color.Green;






            if (label8.Visible)
            {
                count += 5;

            }

            lblscore1.Text = count.ToString();

            lblscore1.Show();

        }

        private void btntrapdrake_Click(object sender, EventArgs e)
        {
            label8.Show();
            label8.Text = "CORRECT ANSWER";
            btntrapdrake.BackColor = Color.Green;

            lblscore1.Show();



            if (label8.Visible)
            {
                count += 5;

            }

            lblscore1.Text = count.ToString();
        }

        private void btnelectrodrake_Click(object sender, EventArgs e)
        {
            btnelectrodrake.BackColor = Color.Red;
            Console.Beep();
            label6.Show();
            label6.Text = "INCORRECT";



            lblscore1.Show();
            if (label8.Visible)
            {
                count += 5;

            }
            else
            {
                count = 0;
            }

            lblscore1.Text = count.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Green;

            label7.Text = "CORRECT ANSWER!";

            lblscore2.Show();


            if (label7.Visible)
            {
                count += 5;


            }
            lblscore2.Text = score.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Console.Beep();
            button2.BackColor = Color.Red;
            label5.Text = "INCCORRECT";




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
            label5.Text = "INCCORRECT";




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

        private void button4_Click(object sender, EventArgs e)
        {
            Console.Beep();
            button4.BackColor = Color.Red;



            label3.Text = "INNCORRECT";

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

        private void button5_Click(object sender, EventArgs e)
        {
            button5.BackColor = Color.Green;

            lblcorrect.Text = "CORRECT ANSWER!";

            lblscore3.Show();


            if (lblcorrect.Visible)
            {
                 count += 5;


            }
            lblscore3.Text = score.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Console.Beep();
            button6.BackColor = Color.Red;



            label3.Text = "INNCORRECT";

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

        private void play2_Load(object sender, EventArgs e)
        {
            lblcorrect.Hide();
            label3.Hide();
            label6.Hide();
            label7.Hide();
            label5.Hide();
            label8.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
