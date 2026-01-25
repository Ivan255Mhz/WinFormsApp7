using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp7.Base;

namespace WinFormsApp7.Forms
{
    public partial class AutoForm : Form
    {

        public Form1 _parent;
        public AutoForm(Form1 parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxEmail.Text = string.Empty;
            textBoxPassword.Text = string.Empty;
        }

        private void buttonIN_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text;
            string password = textBoxPassword.Text;

            if (string.IsNullOrEmpty(email)||string.IsNullOrEmpty(password)) 
            {
                MessageBox.Show("Введите  email или пароль", "Ошибка", 
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var User = UserDataBase.GetUsers().
                                    Where(x=> x.email== email && x.password == password).
                                    FirstOrDefault();

            if(User is null)
            {
                MessageBox.Show("Пользавотель не найден", "Ошибка",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Авторизация пройдена");
            return;


        }
    }
}
