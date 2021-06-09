using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Beginning
{
    public partial class Autorization : Form
    {
        public Autorization()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Autorization_Load(object sender, EventArgs e)
        {

        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            tBLogin.Text = "";
            tBPassword.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=MIAIR13\SQLEXPRESS;Initial Catalog=YouWatchSeries;Integrated Security=True");
            string user = "Select Viewers.login, Viewers_Pass.password FROM Viewers JOIN Viewers_Pass ON Viewers.id_v=Viewers_Pass.id_v WHERE (Viewers.login = '"+tBLogin.Text.Trim() +"' and Viewers_Pass.password = '"+ tBPassword.Text.Trim() +"')";

            SqlDataAdapter sda = new SqlDataAdapter(user, connection);
            DataTable dtb1 = new DataTable();
            sda.Fill(dtb1);
            if (dtb1.Rows.Count == 1)
            {
                string name = tBLogin.Text; //передача логина в следующую форму
                Main objMain = new Main(name);
                this.Hide();
                objMain.Show();
            }
            else
            {
                MessageBox.Show("Введены неверные данные! Повторите попытку.");
            }
        }
    }
}
