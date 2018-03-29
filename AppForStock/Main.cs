using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client; // ODP.NET Oracle managed provider
using Oracle.DataAccess.Types;

namespace AppForStock
{
    public partial class Main : Form
    {
        Form newMdiChild;                           //Экземпляр для дочерних форм
        static string UserName { get; set; }        //Имя пользователя
        public static string ConnectionString = "Data Source=(DESCRIPTION="
                                                            + "(ADDRESS_LIST="
                                                                    + "(ADDRESS="
                                                                    + "(PROTOCOL=TCP)"
                                                                    + "(HOST=DESKTOP-VT9VHU4)"
                                                                    + "(PORT=1521)"
                                                                    + ")"
                                                            + ")"
                                                            + "(CONNECT_DATA="
                                                                    + "(SERVER=DEDICATED)"
                                                                    + "(SERVICE_NAME=XE)"
                                                            + ")"
                                                        + ");"
                        + "User Id=ivan;Password=ivan;";

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

            Autorization form = new Autorization();
            form.ShowDialog();
            UserName = form.Username;

            OracleConnection conn = new OracleConnection(ConnectionString);  
            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select count(*) from EMPLOYEE WHERE login = '" 
                    + form.Username + "' and password = '"+ form.Password + "'";
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();
                //dr.Read();
                int count = 0;
                try
                {
                    while (dr.Read())
                        count = Convert.ToInt32(dr.GetValue(0));
                }
                finally
                {
                    dr.Close();
                }
                if (count == 0)
                {
                    MessageBox.Show("Логин и/или пароль введен неверно");
                    this.Main_Load(sender, e);
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Dispose();
            }

            /*
            ConnectionString = @"Data Source=SHAYTAN-MACHINE\SQLEXPRESS;
                            Initial Catalog=Cafe;
                            Integrated Security=false;
                            ";
            //ConnectionString += "User ID=ivan; Password=ivan";              //FOR TEST
            ConnectionString += "User ID=" + form.Username + "; Password=" + form.Password;     //Передаем логин и пароль из формы авторизации
            UserName = form.Username;

            SqlConnection connect = new SqlConnection(ConnectionString);
            try
            {
                connect.Open();
                SqlDataReader reader;
                using (SqlCommand com = connect.CreateCommand())
                {
                    com.CommandText = string.Format("DECLARE @user sysname SET @user = USER EXEC sp_helpuser @user");
                    reader = com.ExecuteReader();
                    if (reader.HasRows)
                        while (reader.Read())
                            UserRole = reader.GetString(1);     //Получили роль из запроса
                    reader.Close();
                }
                connect.Close();
            }
            catch (SqlException ex)
            {
                /*
                if (ex.Number == 4060)  // Если база не обнаружена
                    MessageBox.Show("База не обнаружена!" + ex.Message);
                else
                    MessageBox.Show(ex.Message);
                this.Close();
                */
            /*}
            finally
            {
                connect.Dispose();
            }
            */
        }

        public static string GetUserName()      //Возвращает имя пользователя
        {
            return UserName;
        }

        void ShowChildForm(Form form)           //Позволяет открыть дочернюю форму внутри mdi-контейнера
        {
            newMdiChild = form;
            form.MdiParent = this;
            form.Show();
        }

        private void инструментыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            C_Tools form = new C_Tools();           //Объект формы
            ShowChildForm(form);
        }

        private void движенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            C_MoveList form = new C_MoveList();           //Объект формы
            ShowChildForm(form);
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            C_Employee form = new C_Employee();           //Объект формы
            ShowChildForm(form);
        }

        private void инструментToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report_tool report = new Report_tool();
            report.Show();
        }

        private void движенияToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Report_motion report = new Report_motion();
            report.Show();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            C_Employee_Add form = new C_Employee_Add();
            form.Show();
        }
    }
}
