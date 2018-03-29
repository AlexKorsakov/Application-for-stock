namespace AppForStock
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tOOL_STATUSTableAdapter = new AppForStock.DataSet1TableAdapters.TOOL_STATUSTableAdapter();
            this.tOOLTableAdapter = new AppForStock.DataSet1TableAdapters.TOOLTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инструментToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.движенияToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.инструментыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.движенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tOOL_STATUSTableAdapter
            // 
            this.tOOL_STATUSTableAdapter.ClearBeforeFill = true;
            // 
            // tOOLTableAdapter
            // 
            this.tOOLTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.инструментыToolStripMenuItem,
            this.движенияToolStripMenuItem,
            this.сотрудникиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(748, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отчетыToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.инструментToolStripMenuItem,
            this.движенияToolStripMenuItem1});
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // инструментToolStripMenuItem
            // 
            this.инструментToolStripMenuItem.Name = "инструментToolStripMenuItem";
            this.инструментToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.инструментToolStripMenuItem.Text = "Инструмент";
            this.инструментToolStripMenuItem.Click += new System.EventHandler(this.инструментToolStripMenuItem_Click);
            // 
            // движенияToolStripMenuItem1
            // 
            this.движенияToolStripMenuItem1.Name = "движенияToolStripMenuItem1";
            this.движенияToolStripMenuItem1.Size = new System.Drawing.Size(141, 22);
            this.движенияToolStripMenuItem1.Text = "Движения";
            this.движенияToolStripMenuItem1.Click += new System.EventHandler(this.движенияToolStripMenuItem1_Click);
            // 
            // инструментыToolStripMenuItem
            // 
            this.инструментыToolStripMenuItem.Name = "инструментыToolStripMenuItem";
            this.инструментыToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.инструментыToolStripMenuItem.Text = "Инструмент";
            this.инструментыToolStripMenuItem.Click += new System.EventHandler(this.инструментыToolStripMenuItem_Click);
            // 
            // движенияToolStripMenuItem
            // 
            this.движенияToolStripMenuItem.Name = "движенияToolStripMenuItem";
            this.движенияToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.движенияToolStripMenuItem.Text = "Движения";
            this.движенияToolStripMenuItem.Click += new System.EventHandler(this.движенияToolStripMenuItem_Click);
            // 
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem});
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.сотрудникиToolStripMenuItem.Text = "Сотрудники";
            this.сотрудникиToolStripMenuItem.Click += new System.EventHandler(this.сотрудникиToolStripMenuItem_Click);
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.ClientSize = new System.Drawing.Size(748, 457);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataSet1TableAdapters.TOOL_STATUSTableAdapter tOOL_STATUSTableAdapter;
        private DataSet1TableAdapters.TOOLTableAdapter tOOLTableAdapter;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инструментыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem движенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инструментToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem движенияToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
    }
}

