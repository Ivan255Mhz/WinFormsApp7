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
    public partial class UserFormsRegister : Form
    {


        private Form1 parentForm;
        public UserFormsRegister(Form1 parentForm)
        {
            this.parentForm = parentForm;
            InitializeComponent();
            comboBoxRole.Items.AddRange(new string[] {"Админ","Работник","Пользователь"});
            
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxName.Text = string.Empty;
            textBoxEmail.Text = string.Empty;
            textBoxPassword.Text = string.Empty;
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxName.Text))
            {
                MessageBox.Show("Заполните поле ИМЯ","Ошибка",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(textBoxEmail.Text))
            {
                MessageBox.Show("Заполните поле EMAIL", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(textBoxPassword.Text))
            {
                MessageBox.Show("Заполните поле ПАРОЛЬ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            int id = UserDataBase.GetId();
            string Name = textBoxName.Text;
            string Email = textBoxEmail.Text;
            string Password = textBoxPassword.Text;


            var User = new User(id, Name, Email, Password);

            UserDataBase.Add(User);


        }
    }
}
