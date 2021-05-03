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
    public partial class SIGIN : Form
    {
        public SIGIN()
        {
            InitializeComponent();
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        

       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtusernamesignin_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Users user = new Users();
            List<Users> allusers = user.GetUsers();

            bool userfound = false;
            foreach (Users item in allusers)
            {
                if (txtUser.Text == item.Username && txtpass.Text == item.Password)
                {
                    userfound = true;
                }
            }
            if (userfound == true)
            {
                MainMenu mm = new MainMenu();
                this.Hide();
                mm.Show();
            }
            else
            {
                Console.Beep();
                MessageBox.Show("Your credentials are incorrect", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Console.Beep();
            Form1 fe = new Form1();
            fe.Show();
            this.Hide();
        }
    }
}
