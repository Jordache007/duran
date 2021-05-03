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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            single ss = new single();
            this.Hide();
            ss.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MultiplayerInfor cc = new MultiplayerInfor();
            this.Hide();
            cc.Show();
        }
    }
}
