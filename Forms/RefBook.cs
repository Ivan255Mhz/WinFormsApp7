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
    public partial class RefBook : Form
    {

        private WorkerForm _parent;

        private Book _book;

        private int _index;



        public RefBook(WorkerForm parent)
        {
            InitializeComponent();
            _parent = parent;



            if(parent.SelectedBook() is null) 
            {
                MessageBox.Show("Выберите книгу ", "Ошибка ", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else 
            {
                _book = parent.SelectedBook();
            }



            if (parent.SelectedIndex() == -1)
            {
                MessageBox.Show("Выберите книгу ", "Ошибка ", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else
            {
                _index = parent.SelectedIndex();
            }


            


            textBoxName.Text = _book.Name;
            textBoxText.Text = _book.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Name = textBoxName.Text;
            string Text = textBoxText.Text;
            if (string.IsNullOrEmpty(Name) && string.IsNullOrEmpty(Text)) 
            {
                MessageBox.Show("Заполните поля");
                return;
            }

            BookDataBase.RefBook(new Book(Name, Text),_index);

            this.Close();
        }
    }
}
