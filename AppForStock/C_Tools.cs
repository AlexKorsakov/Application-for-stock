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
    public partial class C_Tools : Form
    {
        string currentRegNumber = "";
        int currentid = 0;

        public C_Tools()
        {
            InitializeComponent();
        }

        private void tOOLBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (currentRegNumber != "" && currentid != 0)
            {
                C_Moving form = new C_Moving(currentRegNumber, currentid);           //Объект формы
                form.MdiParent = this.ParentForm;       //Указываем родителя
                form.Show();
            }
        }

        private void C_Tools_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.CONTRACTOR". При необходимости она может быть перемещена или удалена.
                this.cONTRACTORTableAdapter.Fill(this.dataSet1.CONTRACTOR);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.TOOL". При необходимости она может быть перемещена или удалена.
                this.tOOLTableAdapter.Fill(this.dataSet1.TOOL);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void сохранитьToolStripButton_Click(object sender, EventArgs e)
        {
            if (this.dataSet1.HasChanges())
                try
                {
                    this.Validate();
                    this.tOOLBindingSource.EndEdit();
                    //this.tableAdapterManager.UpdateAll(this.dataSet1);

                    this.tOOLBindingSource.EndEdit();
                    //this.tOOLTableAdapter.Update(this.dataSet1.TOOL);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Saving error: \r\n" + ex.Message);
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            C_Tools_Add form = new C_Tools_Add();           //Объект формы
            form.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow current_row = this.dataGridView1.Rows[e.RowIndex];
                currentRegNumber = current_row.Cells[2].Value.ToString();
                var num = current_row.Cells[0].Value;
                currentid = Convert.ToInt32(num);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
