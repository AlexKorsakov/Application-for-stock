using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppForStock
{
    public partial class C_Employee : Form
    {
        public C_Employee()
        {
            InitializeComponent();
        }

        private void C_Employee_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.EMPLOYEE". При необходимости она может быть перемещена или удалена.
                this.eMPLOYEETableAdapter.FillBy_workers(this.dataSet1.EMPLOYEE);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet11.EMPLOYEE_STATUS". При необходимости она может быть перемещена или удалена.
                this.eMPLOYEE_STATUSTableAdapter.Fill(this.dataSet11.EMPLOYEE_STATUS);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            C_Employee_Add form = new C_Employee_Add();
            form.Show();
        }
    }
}
