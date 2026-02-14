namespace WinFormsApp7.Forms
{
    partial class RefBook
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
            textBoxName = new TextBox();
            textBoxText = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 62);
            label1.Name = "label1";
            label1.Size = new Size(136, 37);
            label1.TabIndex = 0;
            label1.Text = "Название";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 140);
            label2.Name = "label2";
            label2.Size = new Size(81, 37);
            label2.TabIndex = 1;
            label2.Text = "Текст";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(155, 56);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(620, 43);
            textBoxName.TabIndex = 2;
            // 
            // textBoxText
            // 
            textBoxText.Location = new Point(155, 137);
            textBoxText.Multiline = true;
            textBoxText.Name = "textBoxText";
            textBoxText.Size = new Size(620, 924);
            textBoxText.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(350, 1091);
            button1.Name = "button1";
            button1.Size = new Size(169, 52);
            button1.TabIndex = 4;
            button1.Text = "Изменить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // RefBook
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 1185);
            Controls.Add(button1);
            Controls.Add(textBoxText);
            Controls.Add(textBoxName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RefBook";
            Text = "RefBook";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxName;
        private TextBox textBoxText;
        private Button button1;
    }
}