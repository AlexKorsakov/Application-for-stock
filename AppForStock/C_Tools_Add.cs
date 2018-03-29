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
    public partial class C_Tools_Add : Form
    {
        OracleConnection conn = new OracleConnection(Main.ConnectionString);


        public C_Tools_Add()
        {
            InitializeComponent();
        }

        private void C_Tools_Add_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.CONTRACTOR". При необходимости она может быть перемещена или удалена.
                this.cONTRACTORTableAdapter.Fill(this.dataSet1.CONTRACTOR);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox2.Text;
            if (str.Length != str.Where(c => char.IsDigit(c)).Count())
            {
                MessageBox.Show("В поле \"Рег номер\" введено неверное значение!");
            }
            else
            {
                try
                {
                    conn.Open();
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "insert into TOOL (ID, NAME, REG_NUMBER, DATE_PLACEMENT, ID_CONTRACTOR) "
                                    + "values (:id, :name, :reg_no, :date_pl, :id_contr)";
                    cmd.Parameters.Add("id",        System.DBNull.Value);
                    if (textBox2.Text == "" ) throw new System.ArgumentException("Поле номера не должно быть пустым", "Рег номер");
                    cmd.Parameters.Add("name",      textBox1.Text);
                    cmd.Parameters.Add("reg_no",    str);
                    cmd.Parameters.Add("date_pl",   DateTime.Now);
                    cmd.Parameters.Add("id_contr",  comboBox1.SelectedValue);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                }
                catch (OracleException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (ArgumentException ex)
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
}
