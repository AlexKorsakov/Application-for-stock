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
    public partial class Report_motion : Form
    {
        public Report_motion()
        {
            InitializeComponent();
        }

        private void Report_motion_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "DataSet1.TOOL_MOTION". При необходимости она может быть перемещена или удалена.
            this.TOOL_MOTIONTableAdapter.Fill(this.DataSet1.TOOL_MOTION);
            this.reportViewer1.RefreshReport();
        }
    }
}
