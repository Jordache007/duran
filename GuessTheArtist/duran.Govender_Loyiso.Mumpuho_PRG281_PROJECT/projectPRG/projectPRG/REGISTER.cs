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
    public partial class REGISTER : Form
    {
        public REGISTER()
        {
            InitializeComponent();
        }

        private void REGISTER_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Users ll = new Users();
            List<Users> alluser = ll.GetUsers();
            if (txtpass.Text != null && txtuser.Text != null)
            {
                alluser.Add(new Users(txtuser.Text, txtpass.Text));
                MessageBox.Show("You have succesfully registered", "WELCOME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Console.Beep();
                MainMenu mm = new MainMenu();
                this.Hide();
                mm.Show();
            }
            else
            {
                Console.Beep();
                MessageBox.Show("Please fill in your credentials", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtuser.Focus();
                txtpass.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.Beep();
            Form1 ff = new Form1();
            this.Hide();
            ff.Show();
        }
    }
}
