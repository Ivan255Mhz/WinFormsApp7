using WinFormsApp7.Base;
using WinFormsApp7.Forms;

namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            UserDataBase.Load();

            if(UserDataBase.GetUsers() is null)
            {
                UserDataBase.Users = new List<User>();
            }


            UpdateDataBase();
            this.FormClosing += MainFormEx;

        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();

            var UserFormReg = new UserFormsRegister(this);

            UserFormReg.ShowDialog();
            UpdateDataBase();


            this.Show();
        }

        private void MainFormEx(object sender, EventArgs e)

        {
            Application.Exit();
        }


        private void UpdateDataBase()
        {
            if (UserDataBase.GetUsers() is null) 
            {
                return;
            }

            listBoxUsers.Items.Clear();
            listBoxUsers.Items.AddRange(UserDataBase.GetUsers().ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            var AutoForm = new AutoForm(this);
            AutoForm.ShowDialog();

            this.Show();
        }
    }
}
