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
    public partial class Report_tool : Form
    {
        public Report_tool()
        {
            InitializeComponent();
        }

        private void Report_tool_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "DataSet1.TOOL". При необходимости она может быть перемещена или удалена.
            this.TOOLTableAdapter.Fill(this.DataSet1.TOOL);

            this.reportViewer1.RefreshReport();
        }
    }
}
