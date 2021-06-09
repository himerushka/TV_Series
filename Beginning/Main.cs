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
    public partial class Main : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=MIAIR13\SQLEXPRESS;Initial Catalog=YouWatchSeries;Integrated Security=True");
        int item = 0;

        
        /*public string connection_str()
        {
            ConnectionStringSettings ConnectionString;
            connectionString = ConfigurationManager.ConnectionStrings["Project1.Properties.Settings.NorthwindConnectionString"];
            return connectionString.ConnectionString;
        }*/

        public Main(string name)
        {
            InitializeComponent();
            lblHello.Text = "Добро пожаловать, " + name;
            if (name == "admin")
            {
                pnlAdmin.Visible = true;
            }
            SqlCommand com = new SqlCommand("SELECT dbo.User_Item('" + name + "') FROM Viewers V WHERE V.login='" + name + "';", connect);
            connect.Open();
            item = (int)com.ExecuteScalar();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand sql = new SqlCommand("SELECT * FROM MySeries("+item+");", connect);
            SqlDataAdapter sda = new SqlDataAdapter(sql);
            DataTable dtb1 = new DataTable();
            sda.Fill(dtb1);
            dataGV.DataSource = dtb1;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            cBDo.Visible = true;
            btnDo.Visible = true;
            tBtitle.Visible = true;
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            switch (cBDo.SelectedIndex) {
                case 0: //добавить
                    try
                    {
                        Data.without_error = true;
                        using (var connect = new SqlConnection(@"Data Source=MIAIR13\SQLEXPRESS;Initial Catalog=YouWatchSeries;Integrated Security=True"))
                        {
                            var sqlCmd = new SqlCommand("dbo.AddMy", connect);
                            sqlCmd.CommandType = CommandType.StoredProcedure;
                            sqlCmd.Parameters.AddWithValue("@title", tBtitle.Text);
                            sqlCmd.Parameters.AddWithValue("@item", item);
                            connect.Open();
                            sqlCmd.ExecuteNonQuery();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Такой сериал отсутствует.");
                        Data.without_error = false;
                    }
                    finally
                    {
                        if (Data.without_error) MessageBox.Show("Сериал добавлен в Ваш список!");
                        cBDo.Visible = false;
                        btnDo.Visible = false;
                        tBtitle.Visible = false;
                        tBtitle.Text = "";
                    }
                    break;
                case 1: //редактировать
                    try
                    {
                        Data.without_error = true;
                        ChangeMy objWhat = new ChangeMy(item);
                        objWhat.ShowDialog();

                        using (var connect = new SqlConnection(@"Data Source=MIAIR13\SQLEXPRESS;Initial Catalog=YouWatchSeries;Integrated Security=True"))
                        {
                            var sqlCmd = new SqlCommand("dbo.ChangeMy", connect);
                            sqlCmd.CommandType = CommandType.StoredProcedure;
                            sqlCmd.Parameters.AddWithValue("@title", tBtitle.Text);
                            sqlCmd.Parameters.AddWithValue("@item", item);
                            sqlCmd.Parameters.AddWithValue("@status", Data.stat);
                            sqlCmd.Parameters.AddWithValue("@watched", Data.series);
                            sqlCmd.Parameters.AddWithValue("@rate", Data.rate);
                            connect.Open();
                            sqlCmd.ExecuteNonQuery();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Не удалось изменить данные.");
                        Data.without_error = false;
                    }
                    finally
                    {
                        if (Data.without_error) MessageBox.Show("Данные о сериале изменены!");
                        cBDo.Visible = false;
                        btnDo.Visible = false;
                        tBtitle.Visible = false;
                        tBtitle.Text = "";
                    }
                    break;
                case 2: //удалить
                    try
                    {
                        Data.without_error = true;
                        using (var connect = new SqlConnection(@"Data Source=MIAIR13\SQLEXPRESS;Initial Catalog=YouWatchSeries;Integrated Security=True"))
                        {
                            var sqlCmd = new SqlCommand("dbo.DeleteMy", connect);
                            sqlCmd.CommandType = CommandType.StoredProcedure;
                            sqlCmd.Parameters.AddWithValue("@title", tBtitle.Text);
                            sqlCmd.Parameters.AddWithValue("@item", item);
                            connect.Open();
                            sqlCmd.ExecuteNonQuery();
                        }
                    }
                    catch { MessageBox.Show("Не удалось удалить сериал."); Data.without_error =false; }
                    finally
                    {
                        if (Data.without_error) MessageBox.Show("Сериал удален из вашего списка.");
                        cBDo.Visible = false;
                        btnDo.Visible = false;
                        tBtitle.Visible = false;
                        tBtitle.Text = "";
                    }
                    break;
                default:
                    MessageBox.Show("Выберите тип изменения.");
                    break;
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //проверка на удаление админа через триггер
            Data.without_error = true;
            try
            {
                Data.str1 = "Пользователь:";
                Data.str2 = "";
                Data.str2_v = false;
                Data.UsersBtn = "Удалить";
                Users objUser = new Users();
                objUser.ShowDialog();
                using (var connect = new SqlConnection(@"Data Source=MIAIR13\SQLEXPRESS;Initial Catalog=YouWatchSeries;Integrated Security=True"))
                {
                    var sqlCmd = new SqlCommand("dbo.DeleteUser", connect);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@login", Data.user);
                    connect.Open();
                    sqlCmd.ExecuteNonQuery();
                }
            }
            catch {
                MessageBox.Show("Не удалось удалить пользователя. Проверьте данные и повторите попытку. Напоминаем, что администратора ресурса удалить нельзя!");
                Data.without_error = false;
            }
            finally { if (Data.without_error) { MessageBox.Show("Пользователь удален!"); } }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //добавление сериала
            lblSeries.Text = "Добавить сериал:";
            btnSeries.Text = "Добавить";
            lblSeries.Visible = true;
            tBSeriesT.Visible = true;
            tBSeriesY.Visible = true;
            tBSeriesE.Visible = true;
            btnSeries.Visible = true;
            Data.s_add = true;
            Data.s_ch = false;
            Data.s_del = false;
        }

        private void dataGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            if (pnlAdmin.Visible)
            {
                SqlCommand sql = new SqlCommand("SELECT *FROM dbo.AllSeries();", connect);
                SqlDataAdapter sda = new SqlDataAdapter(sql);
                DataTable dtb1 = new DataTable();
                sda.Fill(dtb1);
                dataGV.DataSource = dtb1;
            }
            else
            {
                SqlCommand sql = new SqlCommand("SELECT *FROM dbo.AllSeries_extended();", connect);
                SqlDataAdapter sda = new SqlDataAdapter(sql);
                DataTable dtb1 = new DataTable();
                sda.Fill(dtb1);
                dataGV.DataSource = dtb1;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            connect.Close();
            Application.Exit();
        }
        

        private void cBDo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //новый пользователь
            Data.without_error = true;
            try
            {
                Data.str1 = "Новый логин:";
                Data.str2 = "Новый пароль:";
                Data.UsersBtn = "Создать пользователя";
                Data.str2_v = true;
                Users objUser = new Users();
                objUser.ShowDialog();
                using (var connect = new SqlConnection(@"Data Source=MIAIR13\SQLEXPRESS;Initial Catalog=YouWatchSeries;Integrated Security=True"))
                {
                    var sqlCmd = new SqlCommand("dbo.AddUser", connect);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@login", Data.user);
                    sqlCmd.Parameters.AddWithValue("@password", Data.pass);
                    connect.Open();
                    sqlCmd.ExecuteNonQuery();
                }
            }
            catch
            {
                MessageBox.Show("Не удалось создать пользователя, проверьте данные и повторите попытку.");
                Data.without_error = false;
            }
            finally
            {
                if (Data.without_error) MessageBox.Show("Пользователь создан!");
            }
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            Data.without_error = true;
            try
            {
                Data.str1 = "Пользователь:";
                Data.str2 = "Новый пароль:";
                Data.UsersBtn = "Изменить пароль";
                Data.str2_v = true;
                Users objUser = new Users();
                objUser.ShowDialog();
                using (var connect = new SqlConnection(@"Data Source=MIAIR13\SQLEXPRESS;Initial Catalog=YouWatchSeries;Integrated Security=True"))
                {
                    var sqlCmd = new SqlCommand("dbo.ChangePass", connect);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@login", Data.user);
                    sqlCmd.Parameters.AddWithValue("@password", Data.pass);
                    connect.Open();
                    sqlCmd.ExecuteNonQuery();
                }
            }
            catch {
                MessageBox.Show("Не удалось изменить пароль. Проверьте введенные данные и повторите попытку.");
                Data.without_error = false;
            }
            finally { if (Data.without_error) MessageBox.Show("Пароль успешно изменен!"); }
        }

        private void btnAllUsers_Click(object sender, EventArgs e)
        {
            SqlCommand sql = new SqlCommand("SELECT *FROM dbo.ViewUsers;", connect);
            SqlDataAdapter sda = new SqlDataAdapter(sql);
            DataTable dtb1 = new DataTable();
            sda.Fill(dtb1);
            dataGV.DataSource = dtb1;
        }

        private void btnChangeSeries_Click(object sender, EventArgs e)
        {
            //изменение данных о сериале
            lblSeries.Text = "Изменить данные о сериале:";
            btnSeries.Text = "Изменить";
            lblSeries.Visible = true;
            tBSeriesT.Visible = true;
            tBSeriesY.Visible = true;
            tBSeriesE.Visible = true;
            btnSeries.Visible = true;
            Data.s_add = false;
            Data.s_ch = true;
            Data.s_del = false;
        }

        private void btnDeleteSeries_Click(object sender, EventArgs e)
        {
            //удаление сериала
            lblSeries.Text = "Удалить сериал:";
            lblSeries.Visible = true;
            tBSeriesT.Visible = true;
            btnSeries.Text = "Удалить";
            btnSeries.Visible = true;
            Data.s_add = false;
            Data.s_ch = false;
            Data.s_del = true;

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void tBtitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSeries_Click(object sender, EventArgs e)
        {
            if (Data.s_add)
            {
                using (var connect = new SqlConnection(@"Data Source=MIAIR13\SQLEXPRESS;Initial Catalog=YouWatchSeries;Integrated Security=True"))
                {
                    var sqlCmd = new SqlCommand("dbo.AddS", connect);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@title", tBSeriesT.Text);
                    sqlCmd.Parameters.AddWithValue("@year", Convert.ToInt32(tBSeriesY.Text));
                    sqlCmd.Parameters.AddWithValue("@episodes", Convert.ToInt32(tBSeriesE.Text));
                    connect.Open();
                    sqlCmd.ExecuteNonQuery();
                }
                MessageBox.Show("Сериал добавлен!");
                lblSeries.Visible = false;
                tBSeriesT.Visible = false;
                tBSeriesY.Visible = false;
                tBSeriesE.Visible = false;
                btnSeries.Visible = false;
                Data.s_add = false;
            }

            if (Data.s_ch)
            {
                using (var connect = new SqlConnection(@"Data Source=MIAIR13\SQLEXPRESS;Initial Catalog=YouWatchSeries;Integrated Security=True"))
                {
                    var sqlCmd = new SqlCommand("dbo.ChangeS", connect);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@title", tBSeriesT.Text);
                    sqlCmd.Parameters.AddWithValue("@year", Convert.ToInt32(tBSeriesY.Text));
                    sqlCmd.Parameters.AddWithValue("@episodes", Convert.ToInt32(tBSeriesE.Text));
                    connect.Open();
                    sqlCmd.ExecuteNonQuery();
                }
                MessageBox.Show("Сериал изменен!");
                lblSeries.Visible = false;
                tBSeriesT.Visible = false;
                tBSeriesY.Visible = false;
                tBSeriesE.Visible = false;
                btnSeries.Visible = false;
                Data.s_ch = false;
            }

            if (Data.s_del)
            {
                using (var connect = new SqlConnection(@"Data Source=MIAIR13\SQLEXPRESS;Initial Catalog=YouWatchSeries;Integrated Security=True"))
                {
                    var sqlCmd = new SqlCommand("dbo.DeleteS", connect);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@title", tBSeriesT.Text);
                    connect.Open();
                    sqlCmd.ExecuteNonQuery();
                }
                MessageBox.Show("Сериал удален!");
                lblSeries.Visible = false;
                tBSeriesT.Visible = false;
                btnSeries.Visible = false;
                Data.s_del = false;
            }
        }
    }
}
