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
        private Form1 _parent;
        public AdminForms(Form1 parent)
        {
            InitializeComponent();
            _parent = parent;
            listBoxUsers.Items.AddRange(UserDataBase.GetUsers().ToArray());
        }
    }
}
