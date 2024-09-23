namespace UI
{
    partial class LoginForm
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
            TextBoxPassword = new TextBox();
            ButtonLogin = new Button();
            label1 = new Label();
            TextBoxFirstname = new TextBox();
            LabelFirstname = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // TextBoxPassword
            // 
            TextBoxPassword.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxPassword.Location = new Point(389, 208);
            TextBoxPassword.Name = "TextBoxPassword";
            TextBoxPassword.Size = new Size(263, 41);
            TextBoxPassword.TabIndex = 1;
            // 
            // ButtonLogin
            // 
            ButtonLogin.BackColor = Color.Silver;
            ButtonLogin.FlatAppearance.BorderSize = 3;
            ButtonLogin.FlatStyle = FlatStyle.Flat;
            ButtonLogin.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonLogin.Location = new Point(187, 283);
            ButtonLogin.Name = "ButtonLogin";
            ButtonLogin.Size = new Size(465, 83);
            ButtonLogin.TabIndex = 2;
            ButtonLogin.Text = "Login";
            ButtonLogin.UseVisualStyleBackColor = false;
            ButtonLogin.Click += ButtonLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 25.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(344, 51);
            label1.Name = "label1";
            label1.Size = new Size(141, 57);
            label1.TabIndex = 3;
            label1.Text = "Login";
            // 
            // TextBoxFirstname
            // 
            TextBoxFirstname.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxFirstname.Location = new Point(389, 145);
            TextBoxFirstname.Name = "TextBoxFirstname";
            TextBoxFirstname.Size = new Size(263, 41);
            TextBoxFirstname.TabIndex = 4;
            // 
            // LabelFirstname
            // 
            LabelFirstname.AutoSize = true;
            LabelFirstname.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            LabelFirstname.Location = new Point(187, 145);
            LabelFirstname.Name = "LabelFirstname";
            LabelFirstname.Size = new Size(196, 35);
            LabelFirstname.TabIndex = 5;
            LabelFirstname.Text = "Gebruikersnaam";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(187, 208);
            label2.Name = "label2";
            label2.Size = new Size(156, 35);
            label2.TabIndex = 6;
            label2.Text = "Wachtwoord";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(LabelFirstname);
            Controls.Add(TextBoxFirstname);
            Controls.Add(label1);
            Controls.Add(ButtonLogin);
            Controls.Add(TextBoxPassword);
            Name = "LoginForm";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox TextBoxPassword;
        private Button ButtonLogin;
        private Label label1;
        private TextBox TextBoxFirstname;
        private Label LabelFirstname;
        private Label label2;
    }
}