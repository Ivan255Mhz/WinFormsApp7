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
            groupBox2 = new GroupBox();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            buttonPlay = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listBox1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(473, 608);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Книги";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listBox2);
            groupBox2.Location = new Point(514, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(509, 608);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Клиенты";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 37;
            listBox1.Location = new Point(12, 43);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(455, 559);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 37;
            listBox2.Location = new Point(6, 42);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(497, 559);
            listBox2.TabIndex = 0;
            // 
            // buttonPlay
            // 
            buttonPlay.Location = new Point(399, 626);
            buttonPlay.Name = "buttonPlay";
            buttonPlay.Size = new Size(169, 52);
            buttonPlay.TabIndex = 2;
            buttonPlay.Text = "Выдать";
            buttonPlay.UseVisualStyleBackColor = true;
            buttonPlay.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(399, 721);
            button2.Name = "button2";
            button2.Size = new Size(169, 52);
            button2.TabIndex = 3;
            button2.Text = "Отчет";
            button2.UseVisualStyleBackColor = true;
            // 
            // WorkerForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1044, 874);
            Controls.Add(button2);
            Controls.Add(buttonPlay);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "WorkerForm";
            Text = "WorkerForm";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ListBox listBox1;
        private ListBox listBox2;
        private Button buttonPlay;
        private Button button2;
    }
}