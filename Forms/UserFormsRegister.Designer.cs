namespace WinFormsApp7.Forms
{
    partial class UserFormsRegister
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
            textBoxName = new TextBox();
            textBoxEmail = new TextBox();
            textBoxPassword = new TextBox();
            buttonResult = new Button();
            buttonClear = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 77);
            label1.Name = "label1";
            label1.Size = new Size(70, 37);
            label1.TabIndex = 0;
            label1.Text = "Имя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 165);
            label2.Name = "label2";
            label2.Size = new Size(82, 37);
            label2.TabIndex = 1;
            label2.Text = "email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 257);
            label3.Name = "label3";
            label3.Size = new Size(107, 37);
            label3.TabIndex = 2;
            label3.Text = "пароль";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(143, 77);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(343, 43);
            textBoxName.TabIndex = 3;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(143, 165);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(343, 43);
            textBoxEmail.TabIndex = 4;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(143, 251);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(343, 43);
            textBoxPassword.TabIndex = 5;
            // 
            // buttonResult
            // 
            buttonResult.Location = new Point(47, 376);
            buttonResult.Name = "buttonResult";
            buttonResult.Size = new Size(169, 52);
            buttonResult.TabIndex = 6;
            buttonResult.Text = "Регистрация";
            buttonResult.UseVisualStyleBackColor = true;
            buttonResult.Click += buttonResult_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(317, 376);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(169, 52);
            buttonClear.TabIndex = 7;
            buttonClear.Text = "Очистить";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // UserFormsRegister
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 515);
            Controls.Add(buttonClear);
            Controls.Add(buttonResult);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UserFormsRegister";
            Text = "Регистрация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxName;
        private TextBox textBoxEmail;
        private TextBox textBoxPassword;
        private Button buttonResult;
        private Button buttonClear;
    }
}