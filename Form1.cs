using WinFormsApp7.Forms;

namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var UserFormReg = new UserFormsRegister();

            UserFormReg.ShowDialog();
            this.Close();
        }
    }
}
