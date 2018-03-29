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
    public partial class C_Employee_Add : Form
    {
        OracleConnection conn = new OracleConnection(Main.ConnectionString);
        public C_Employee_Add()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "insert into EMPLOYEE (ID, NAME, DATE_PLACEMENT, ID_EMPLOYEE_STATUS, LOGIN, PASSWORD) "
                                + "values (:id, :name, :date_pl, :id_emp_status, :login, :pass)";
                cmd.Parameters.Add("id", System.DBNull.Value);
                cmd.Parameters.Add("name", textBox1.Text);
                cmd.Parameters.Add("date_pl", dateTimePicker1.Value);
                if (checkBox1.Checked)
                {
                    cmd.Parameters.Add("id_emp_status", 1);
                    cmd.Parameters.Add("login", textBox2.Text);
                    cmd.Parameters.Add("pass", textBox3.Text);
                }
                else
                {
                    cmd.Parameters.Add("id_emp_status", 2);
                    cmd.Parameters.Add("login", System.DBNull.Value);
                    cmd.Parameters.Add("pass", System.DBNull.Value);
                }
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Dispose();
                this.Close();
            }
        }
    }
}
