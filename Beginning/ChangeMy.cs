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
    public partial class ChangeMy : Form
    {
        int ich = 0;

        public ChangeMy(int item)
        {
            InitializeComponent();
            ich = item;
        }

        private void ChangeMy_Load(object sender, EventArgs e)
        {

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            try
            {
                Data.stat = cBStatus.SelectedIndex + 1;
                Data.series = Convert.ToInt32(tBSeries.Text);
                Data.rate = Convert.ToInt32(cBRate.Text);
            }
            catch { MessageBox.Show("Ошибка при вводе данных."); }
            finally { this.Close(); };
            
        }
    }
}
