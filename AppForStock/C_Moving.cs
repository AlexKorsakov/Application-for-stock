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
    public partial class C_Moving : Form
    {
        bool status = false;
        int toolId = 0;
        OracleConnection conn = new OracleConnection(Main.ConnectionString);

        public C_Moving()
        {
            InitializeComponent();
        }

        public C_Moving(int id)
        {
            InitializeComponent();
            status = true;
            try
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.EMPLOYEE". При необходимости она может быть перемещена или удалена.
                this.eMPLOYEETableAdapter.Fill(this.dataSet1.EMPLOYEE);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.TOOL_STATUS". При необходимости она может быть перемещена или удалена.
                this.tOOL_STATUSTableAdapter.Fill(this.dataSet1.TOOL_STATUS);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet11.EMPLOYEE". При необходимости она может быть перемещена или удалена.
                this.eMPLOYEETableAdapter.Fill(this.dataSet11.EMPLOYEE);
                textBox1.ReadOnly = true;
                comboBox2.Enabled = false;
                richTextBox1.ReadOnly = true;
                comboBox1.Enabled = false;
                comboBox3.Enabled = false;
                button1.Enabled = false;

                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText =
                " SELECT"
                + " tl.reg_number,"
                //+    "ts.name AS status,"
                + " tlm.id_tool_status,"
                + " tlm.stockman,"
                + " tlm.worker,"
                + " tlm.time,"
                + "tlm.info"
                + " FROM"
                + " tool_motion tlm"
                + " INNER JOIN tool tl ON tlm.id_tool = tl.id"
                + " WHERE"
                + " tlm.id = :id";

                cmd.Parameters.Add("id", id.ToString());
                cmd.CommandType = CommandType.Text;
                if (conn.State == ConnectionState.Open)
                {
                    try
                    {
                        OracleDataReader dataReader = cmd.ExecuteReader();
                        string textLine = "";
                        int fieldCount = dataReader.FieldCount;

                        while (dataReader.Read())
                        {
                            textBox1.Text = dataReader[0].ToString();
                            comboBox1.SelectedValue = Int32.Parse(dataReader[1].ToString());
                            comboBox2.SelectedValue = dataReader[2].ToString();
                            if (dataReader[3].ToString() != "")
                                comboBox3.SelectedValue = dataReader[3].ToString();
                            else
                                checkBox1.Enabled = false;
                            string s = dataReader[4].ToString();
                            DateTime dateTime = Convert.ToDateTime(s);
                            dateTimePicker1.Value = dateTime;
                            richTextBox1.Text = dataReader[5].ToString();                                
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Exception Caught");
                    }
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
        }

        public C_Moving(string reg_number, int id)
        {
            InitializeComponent();
            textBox1.Text = reg_number;
            textBox1.ReadOnly = true;
            toolId = id;
        }

        private void C_Moving_Load(object sender, EventArgs e)
        {
            if (!status)
            {
                comboBox2.Enabled = false;
                try
                {
                    // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.EMPLOYEE". При необходимости она может быть перемещена или удалена.
                    this.eMPLOYEETableAdapter.Fill(this.dataSet1.EMPLOYEE);
                    // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.TOOL_STATUS". При необходимости она может быть перемещена или удалена.
                    this.tOOL_STATUSTableAdapter.Fill(this.dataSet1.TOOL_STATUS);
                    // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet11.EMPLOYEE". При необходимости она может быть перемещена или удалена.
                    this.eMPLOYEETableAdapter.Fill(this.dataSet11.EMPLOYEE);
                }
                catch (OracleException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "insert into TOOL_MOTION (ID_TOOL_STATUS, TIME, STOCKMAN, WORKER, ID_TOOL, INFO) "
                                + "values (:id_status, :time, :stockman, :worker, :id_tool, :info)";
                cmd.Parameters.Add("id_status", comboBox1.SelectedValue.ToString());
                cmd.Parameters.Add("time", dateTimePicker1.Value);
                cmd.Parameters.Add("stockman", comboBox3.SelectedValue);
                cmd.Parameters.Add("worker", checkBox1.Checked ? comboBox2.SelectedValue : System.DBNull.Value);
                cmd.Parameters.Add("id_tool", toolId);
                cmd.Parameters.Add("info", richTextBox1.Text);
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
                MessageBox.Show("Успешно!");
                this.Close();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                comboBox2.Enabled = true;
            else
                comboBox2.Enabled = false;
        }
    }
}
