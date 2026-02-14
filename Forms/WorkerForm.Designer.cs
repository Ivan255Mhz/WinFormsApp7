namespace WinFormsApp7.Forms
{
    partial class WorkerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            listBoxBook = new ListBox();
            groupBox2 = new GroupBox();
            listBoxClients = new ListBox();
            buttonPlay = new Button();
            button2 = new Button();
            groupBoxAddBook = new GroupBox();
            buttonAddBook = new Button();
            textBoxText = new TextBox();
            textBoxName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBoxAddBook.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listBoxBook);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(473, 608);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Книги";
            // 
            // listBoxBook
            // 
            listBoxBook.FormattingEnabled = true;
            listBoxBook.ItemHeight = 37;
            listBoxBook.Location = new Point(12, 43);
            listBoxBook.Name = "listBoxBook";
            listBoxBook.Size = new Size(455, 559);
            listBoxBook.TabIndex = 0;
            listBoxBook.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            listBoxBook.DoubleClick += DB_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listBoxClients);
            groupBox2.Location = new Point(514, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(509, 608);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Клиенты";
            // 
            // listBoxClients
            // 
            listBoxClients.FormattingEnabled = true;
            listBoxClients.ItemHeight = 37;
            listBoxClients.Location = new Point(6, 42);
            listBoxClients.Name = "listBoxClients";
            listBoxClients.Size = new Size(497, 559);
            listBoxClients.TabIndex = 0;
            // 
            // buttonPlay
            // 
            buttonPlay.Location = new Point(1043, 467);
            buttonPlay.Name = "buttonPlay";
            buttonPlay.Size = new Size(169, 52);
            buttonPlay.TabIndex = 2;
            buttonPlay.Text = "Выдать";
            buttonPlay.UseVisualStyleBackColor = true;
            buttonPlay.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1043, 562);
            button2.Name = "button2";
            button2.Size = new Size(169, 52);
            button2.TabIndex = 3;
            button2.Text = "Отчет";
            button2.UseVisualStyleBackColor = true;
            // 
            // groupBoxAddBook
            // 
            groupBoxAddBook.Controls.Add(buttonAddBook);
            groupBoxAddBook.Controls.Add(textBoxText);
            groupBoxAddBook.Controls.Add(textBoxName);
            groupBoxAddBook.Controls.Add(label2);
            groupBoxAddBook.Controls.Add(label1);
            groupBoxAddBook.Location = new Point(24, 643);
            groupBoxAddBook.Name = "groupBoxAddBook";
            groupBoxAddBook.Size = new Size(999, 345);
            groupBoxAddBook.TabIndex = 4;
            groupBoxAddBook.TabStop = false;
            groupBoxAddBook.Text = "Добавление книги";
            // 
            // buttonAddBook
            // 
            buttonAddBook.Location = new Point(801, 44);
            buttonAddBook.Name = "buttonAddBook";
            buttonAddBook.Size = new Size(169, 52);
            buttonAddBook.TabIndex = 4;
            buttonAddBook.Text = "Добавить";
            buttonAddBook.UseVisualStyleBackColor = true;
            buttonAddBook.Click += buttonAddBook_Click;
            // 
            // textBoxText
            // 
            textBoxText.Location = new Point(168, 134);
            textBoxText.Multiline = true;
            textBoxText.Name = "textBoxText";
            textBoxText.Size = new Size(811, 196);
            textBoxText.TabIndex = 3;
            textBoxText.TextChanged += textBox2_TextChanged;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(168, 49);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(569, 43);
            textBoxName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 137);
            label2.Name = "label2";
            label2.Size = new Size(81, 37);
            label2.TabIndex = 1;
            label2.Text = "Текст";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 52);
            label1.Name = "label1";
            label1.Size = new Size(136, 37);
            label1.TabIndex = 0;
            label1.Text = "Название";
            // 
            // WorkerForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1224, 1000);
            Controls.Add(groupBoxAddBook);
            Controls.Add(button2);
            Controls.Add(buttonPlay);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "WorkerForm";
            Text = "WorkerForm";
            DoubleClick += DB_Click;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBoxAddBook.ResumeLayout(false);
            groupBoxAddBook.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ListBox listBoxBook;
        private ListBox listBoxClients;
        private Button buttonPlay;
        private Button button2;
        private GroupBox groupBoxAddBook;
        private TextBox textBoxText;
        private TextBox textBoxName;
        private Label label2;
        private Label label1;
        private Button buttonAddBook;
    }
}