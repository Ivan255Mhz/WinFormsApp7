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
using WinFormsApp7.Class;

namespace WinFormsApp7.Forms
{
    public partial class WorkerForm : Form
    {

        private AutoForm _parent;
        public WorkerForm(AutoForm parent)
        {
            InitializeComponent();
            _parent = parent;
            BookDataBase.Load();
            UiSetup();


        }


        private void DB_Click(object sender, EventArgs e)
        {
            this.Hide();
            var refbook = new RefBook(this);
            refbook.ShowDialog();
            UiSetup();
            this.Show();
            
        }

        public int SelectedIndex()
        {
            return listBoxBook.SelectedIndex;
        }
        public Book SelectedBook()
        {

           



            return listBoxBook.SelectedItem as Book;
        }


       

        private void UiSetup()
        {
            listBoxBook.Items.Clear();
            listBoxBook.Items.AddRange(BookDataBase.GetBooks().ToArray());
            listBoxClients.Items.Clear();
            listBoxClients.Items.AddRange(UserDataBase.GetCliens().ToArray());
        }



        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxName.Text) && string.IsNullOrEmpty(textBoxText.Text))
            {
                MessageBox.Show("Заполните поля");
                return;
            }

            var book = new Book(textBoxName.Text, textBoxText.Text);
            BookDataBase.Add(book);
            BookDataBase.Save();
            UiSetup();
        }
    }
}
