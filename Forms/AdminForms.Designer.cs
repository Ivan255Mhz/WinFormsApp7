namespace WinFormsApp7.Forms
{
    partial class AdminForms
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
            listBoxUsers = new ListBox();
            buttonDel = new Button();
            buttonRem = new Button();
            monthCalendar1 = new MonthCalendar();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listBoxUsers);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(622, 595);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Пользователи";
            // 
            // listBoxUsers
            // 
            listBoxUsers.FormattingEnabled = true;
            listBoxUsers.ItemHeight = 37;
            listBoxUsers.Location = new Point(6, 42);
            listBoxUsers.Name = "listBoxUsers";
            listBoxUsers.Size = new Size(576, 522);
            listBoxUsers.TabIndex = 0;
            // 
            // buttonDel
            // 
            buttonDel.Location = new Point(125, 640);
            buttonDel.Name = "buttonDel";
            buttonDel.Size = new Size(169, 52);
            buttonDel.TabIndex = 1;
            buttonDel.Text = "Удалить";
            buttonDel.UseVisualStyleBackColor = true;
            // 
            // buttonRem
            // 
            buttonRem.Location = new Point(325, 640);
            buttonRem.Name = "buttonRem";
            buttonRem.Size = new Size(169, 52);
            buttonRem.TabIndex = 2;
            buttonRem.Text = "Изменить";
            buttonRem.UseVisualStyleBackColor = true;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(679, 54);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 3;
            // 
            // AdminForms
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1075, 778);
            Controls.Add(monthCalendar1);
            Controls.Add(buttonRem);
            Controls.Add(buttonDel);
            Controls.Add(groupBox1);
            Name = "AdminForms";
            Text = "AdminForms";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListBox listBoxUsers;
        private Button buttonDel;
        private Button buttonRem;
        private MonthCalendar monthCalendar1;
    }
}