namespace WinFormsApp7.Forms
{
    partial class RefAdminForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxNane = new TextBox();
            textBoxPass = new TextBox();
            textBoxEmail = new TextBox();
            comboBoxRole = new ComboBox();
            buttonRem = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 41);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 0;
            label1.Text = "Имя";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 84);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 1;
            label2.Text = "Почта";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 132);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 2;
            label3.Text = "Пароль";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 183);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 3;
            label4.Text = "Роль";
            // 
            // textBoxNane
            // 
            textBoxNane.Location = new Point(79, 38);
            textBoxNane.Name = "textBoxNane";
            textBoxNane.Size = new Size(245, 27);
            textBoxNane.TabIndex = 4;
            // 
            // textBoxPass
            // 
            textBoxPass.Location = new Point(79, 129);
            textBoxPass.Name = "textBoxPass";
            textBoxPass.Size = new Size(245, 27);
            textBoxPass.TabIndex = 5;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(79, 81);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(245, 27);
            textBoxEmail.TabIndex = 6;
            // 
            // comboBoxRole
            // 
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Location = new Point(79, 179);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(245, 28);
            comboBoxRole.TabIndex = 7;
            // 
            // buttonRem
            // 
            buttonRem.Location = new Point(119, 254);
            buttonRem.Name = "buttonRem";
            buttonRem.Size = new Size(94, 29);
            buttonRem.TabIndex = 8;
            buttonRem.Text = "Изменить";
            buttonRem.UseVisualStyleBackColor = true;
            // 
            // RefAdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(356, 339);
            Controls.Add(buttonRem);
            Controls.Add(comboBoxRole);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxPass);
            Controls.Add(textBoxNane);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RefAdminForm";
            Text = "RefAdminForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxNane;
        private TextBox textBoxPass;
        private TextBox textBoxEmail;
        private ComboBox comboBoxRole;
        private Button buttonRem;
    }
}