using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectPRG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

      

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Console.Beep();
            SIGIN ss = new SIGIN();
            ss.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Console.Beep();
            REGISTER ss = new REGISTER();
            ss.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Console.Beep();
            Environment.Exit(0);

        }
    }
}
