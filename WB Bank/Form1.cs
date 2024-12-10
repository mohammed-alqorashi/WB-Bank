using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WB_Bank
{
    public partial class log_sign : Form
    {
        SignUp s = new SignUp();
        public log_sign()
        {
            InitializeComponent();
        }

        private void log_Click(object sender, EventArgs e)
        {

        }

        private void id_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void id_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { 
                pass.Focus();
            }
        }

        private void sign_Click(object sender, EventArgs e)
        {
            s.Show();
            this.Hide();
        }
    }
}
