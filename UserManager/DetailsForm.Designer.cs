namespace UserManager
{
    partial class DetailsForm
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
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            txtFullName = new TextBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, 30);
            label1.Name = "label1";
            label1.Size = new Size(178, 33);
            label1.TabIndex = 2;
            label1.Text = "User Details";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(33, 207);
            label3.Name = "label3";
            label3.Size = new Size(75, 16);
            label3.TabIndex = 8;
            label3.Text = "Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(33, 163);
            label2.Name = "label2";
            label2.Size = new Size(76, 16);
            label2.TabIndex = 7;
            label2.Text = "Username:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(33, 122);
            label4.Name = "label4";
            label4.Size = new Size(71, 16);
            label4.TabIndex = 6;
            label4.Text = "Full Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(33, 88);
            label5.Name = "label5";
            label5.Size = new Size(55, 16);
            label5.TabIndex = 9;
            label5.Text = "UserID:";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.Cursor = Cursors.No;
            button1.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Cornsilk;
            button1.Location = new Point(427, 281);
            button1.Name = "button1";
            button1.Size = new Size(114, 35);
            button1.TabIndex = 10;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = false;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(126, 191);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(336, 39);
            txtPassword.TabIndex = 13;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.InactiveBorder;
            txtUsername.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(126, 148);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(336, 39);
            txtUsername.TabIndex = 12;
            // 
            // txtFullName
            // 
            txtFullName.BackColor = Color.AliceBlue;
            txtFullName.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFullName.Location = new Point(126, 109);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(336, 35);
            txtFullName.TabIndex = 11;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.AliceBlue;
            textBox1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(126, 68);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(336, 35);
            textBox1.TabIndex = 14;
            // 
            // DetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 328);
            Controls.Add(textBox1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtFullName);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "DetailsForm";
            Text = "DetailsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private Button button1;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private TextBox txtFullName;
        private TextBox textBox1;
    }
}