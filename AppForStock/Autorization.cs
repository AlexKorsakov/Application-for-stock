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
    /**
    * Класс авторизации
    * \param Username Поле, содержащее имя пользователя
    * \param Password Поле, содержащее пароль
    */
    public partial class Autorization : Form
    {
        public string Username = "";        //Имя пользователя
        public string Password = "";        //Пароль

        //@function Autorization()
        public Autorization()
        {
            InitializeComponent();
        }

        private void Autorization_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Username = textBox1.Text;
            Password = textBox2.Text;
            this.Close();
        }
    }
}
