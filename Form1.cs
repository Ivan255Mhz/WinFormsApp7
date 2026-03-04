using WinFormsApp7.Base;
using WinFormsApp7.Forms;

namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();

            try
            {
                UserDataBase.Load();
                BookDataBase.Load();
                LoanDataBase.Load();
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных { ex.Message}","Ошибка",MessageBoxButtons.OK);

                if (UserDataBase.GetUsers() is null)
                    UserDataBase.Clear();
                if(BookDataBase.GetBooks() is null)
                    BookDataBase.Clear();
                LoanDataBase.Clear();
            }

            if (UserDataBase.GetUsers() is null)
                UserDataBase.Clear();

            UpdateDataBase();


            

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
            listBoxUsers.Items.Clear();
            var users = UserDataBase.GetUsers();
            if(users != null)
                listBoxUsers.Items.AddRange(users.ToArray());
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
