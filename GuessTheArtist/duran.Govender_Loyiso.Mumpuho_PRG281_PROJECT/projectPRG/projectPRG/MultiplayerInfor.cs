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
    public partial class MultiplayerInfor : Form
    {
        public MultiplayerInfor()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            play1 dd = new play1();
            this.Hide();
            dd.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu ee = new MainMenu();
            this.Hide();
            ee.Show();
        }
    }
}
