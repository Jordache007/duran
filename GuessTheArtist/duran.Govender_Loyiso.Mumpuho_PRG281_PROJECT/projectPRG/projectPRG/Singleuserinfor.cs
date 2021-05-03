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
    public partial class Singleuserinfor : Form
    {
        public Singleuserinfor()
        {
            InitializeComponent();
        }

        private void BTNPLAY_Click(object sender, EventArgs e)
        {
          
        }

        private void BTNBACK_Click(object sender, EventArgs e)
        {
            Form1 ff = new Form1();
            this.Hide();
            ff.Show();
        }

        private void Singleuserinfor_Load(object sender, EventArgs e)
        {

        }
    }
}
