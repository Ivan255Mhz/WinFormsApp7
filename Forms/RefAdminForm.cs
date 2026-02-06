using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp7.Forms
{
    public partial class RefAdminForm : Form
    {

        private AdminForms _parent;
        public RefAdminForm(AdminForms parent)
        {
            InitializeComponent();
            _parent = parent;
            comboBoxRole.Items.AddRange(new string[] { "Админ", "Работник", "Пользователь" });
            SetUserForm();
        }


        private void  SetUserForm()
        {
            var user = _parent.SelectedUser();
            if (user is null)
            {
                MessageBox.Show("Выберете пользователя ");
            }

            textBoxNane.Text = user.name;
            textBoxEmail.Text = user.email;
            textBoxPass.Text = user.password;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
