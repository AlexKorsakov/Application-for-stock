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
    public partial class C_MoveList : Form
    {
        public int ColNum;          //Текущий столбец
        public int RowNum;          //Текущая строка
        int currentRowId = 0;


        public C_MoveList()
        {
            InitializeComponent();
        }

        private void C_MoveList_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.EMPLOYEE". При необходимости она может быть перемещена или удалена.
                this.eMPLOYEETableAdapter.Fill(this.dataSet1.EMPLOYEE);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.TOOL_STATUS". При необходимости она может быть перемещена или удалена.
                this.tOOL_STATUSTableAdapter.Fill(this.dataSet1.TOOL_STATUS);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.TOOL". При необходимости она может быть перемещена или удалена.
                this.tOOLTableAdapter.Fill(this.dataSet1.TOOL);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.TOOL_MOTION". При необходимости она может быть перемещена или удалена.
                this.tOOL_MOTIONTableAdapter.Fill(this.dataSet1.TOOL_MOTION);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (currentRowId > 0)
            {
                C_Moving form = new C_Moving(currentRowId);           //Объект формы
                form.MdiParent = this.ParentForm;       //Указываем родителя
                form.Show();
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RowNum = e.RowIndex;
            ColNum = e.ColumnIndex;
            try
            {
                var v = dataGridView1.Rows[RowNum].Cells[0].Value.ToString();
                currentRowId = Convert.ToInt32(v);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
