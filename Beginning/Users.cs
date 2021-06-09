using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beginning
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
            lblLog.Text = Data.str1;
            btnOK.Text = Data.UsersBtn;
            if (Data.str2_v == false)
            {
                //lblPass.Visible = false;
                tBPass.Visible = false;
            }
            lblPass.Text = Data.str2;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Data.user = tBLog.Text;
            Data.pass = tBPass.Text;
            this.Close();
        }

        private void Users_Load(object sender, EventArgs e)
        {

        }
    }
}
