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
    public partial class AdminForms : Form
    {
        private AutoForm _parent;
        public AdminForms(AutoForm parent)
        {
            InitializeComponent();
            _parent = parent;
            SetingUi();
        }


        private void SetingUi()
        {
            listBoxUsers.Items.Clear();
            listBoxUsers.Items.AddRange(UserDataBase.GetUsers().ToArray());
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            var User = listBoxUsers.SelectedItem as User;

            UserDataBase.Remove(User);

            UserDataBase.Save();

            SetingUi();
        }

        private void buttonRem_Click(object sender, EventArgs e)
        {
            this.Hide();

            var form = new RefAdminForm(this);

            form.ShowDialog();

            this.Show();
        }


        public User  SelectedUser()
        {
            return listBoxUsers.SelectedItem as User;
        }
    }
}
