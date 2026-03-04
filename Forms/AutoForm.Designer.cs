namespace WinFormsApp7.Forms
{
    partial class AutoForm
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
            buttonIN = new Button();
            buttonClear = new Button();
            label1 = new Label();
            label2 = new Label();
            textBoxEmail = new TextBox();
            textBoxPassword = new TextBox();
            SuspendLayout();
            // 
            // buttonIN
            // 
            buttonIN.Location = new Point(73, 166);
            buttonIN.Margin = new Padding(2, 2, 2, 2);
            buttonIN.Name = "buttonIN";
            buttonIN.Size = new Size(102, 44);
            buttonIN.TabIndex = 0;
            buttonIN.Text = "Вход";
            buttonIN.UseVisualStyleBackColor = true;
            buttonIN.Click += buttonIN_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(241, 166);
            buttonClear.Margin = new Padding(2, 2, 2, 2);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(102, 44);
            buttonClear.TabIndex = 1;
            buttonClear.Text = "Очистить";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 58);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 2;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 101);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(137, 56);
            textBoxEmail.Margin = new Padding(2, 2, 2, 2);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(169, 27);
            textBoxEmail.TabIndex = 4;
            textBoxEmail.TextChanged += textBox1_TextChanged;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(137, 99);
            textBoxPassword.Margin = new Padding(2, 2, 2, 2);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(169, 27);
            textBoxPassword.TabIndex = 5;
            // 
            // AutoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 243);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonClear);
            Controls.Add(buttonIN);
            Margin = new Padding(2, 2, 2, 2);
            Name = "AutoForm";
            Text = "Вход";
            Load += AutoForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonIN;
        private Button buttonClear;
        private Label label1;
        private Label label2;
        private TextBox textBoxEmail;
        private TextBox textBoxPassword;
    }
}