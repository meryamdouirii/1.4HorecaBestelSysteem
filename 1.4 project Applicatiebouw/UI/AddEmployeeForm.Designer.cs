namespace UI
{
    partial class AddEmployeeForm
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
            ButtonAddEmployee = new Button();
            ComboBoxRole = new ComboBox();
            DateTimePickerBirthDate = new DateTimePicker();
            TextBoxFirstname = new TextBox();
            TextBoxLastname = new TextBox();
            TextBoxPassword = new TextBox();
            ButtonBack = new Button();
            ButtonLogout = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // ButtonAddEmployee
            // 
            ButtonAddEmployee.BackColor = Color.Silver;
            ButtonAddEmployee.FlatAppearance.BorderSize = 3;
            ButtonAddEmployee.FlatStyle = FlatStyle.Flat;
            ButtonAddEmployee.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonAddEmployee.Location = new Point(300, 321);
            ButtonAddEmployee.Name = "ButtonAddEmployee";
            ButtonAddEmployee.Size = new Size(248, 89);
            ButtonAddEmployee.TabIndex = 0;
            ButtonAddEmployee.Text = "Werknemer toevoegen";
            ButtonAddEmployee.UseVisualStyleBackColor = false;
            ButtonAddEmployee.Click += ButtonAddEmployee_Click;
            // 
            // ComboBoxRole
            // 
            ComboBoxRole.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            ComboBoxRole.FormattingEnabled = true;
            ComboBoxRole.Location = new Point(327, 227);
            ComboBoxRole.Name = "ComboBoxRole";
            ComboBoxRole.Size = new Size(196, 43);
            ComboBoxRole.TabIndex = 1;
            // 
            // DateTimePickerBirthDate
            // 
            DateTimePickerBirthDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DateTimePickerBirthDate.Location = new Point(327, 179);
            DateTimePickerBirthDate.Name = "DateTimePickerBirthDate";
            DateTimePickerBirthDate.Size = new Size(274, 34);
            DateTimePickerBirthDate.TabIndex = 2;
            // 
            // TextBoxFirstname
            // 
            TextBoxFirstname.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxFirstname.Location = new Point(327, 87);
            TextBoxFirstname.Name = "TextBoxFirstname";
            TextBoxFirstname.Size = new Size(196, 41);
            TextBoxFirstname.TabIndex = 3;
            // 
            // TextBoxLastname
            // 
            TextBoxLastname.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxLastname.Location = new Point(327, 131);
            TextBoxLastname.Name = "TextBoxLastname";
            TextBoxLastname.Size = new Size(196, 41);
            TextBoxLastname.TabIndex = 4;
            // 
            // TextBoxPassword
            // 
            TextBoxPassword.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxPassword.Location = new Point(327, 274);
            TextBoxPassword.Name = "TextBoxPassword";
            TextBoxPassword.Size = new Size(196, 41);
            TextBoxPassword.TabIndex = 5;
            // 
            // ButtonBack
            // 
            ButtonBack.Location = new Point(12, 12);
            ButtonBack.Name = "ButtonBack";
            ButtonBack.Size = new Size(94, 29);
            ButtonBack.TabIndex = 6;
            ButtonBack.Text = "<< Back";
            ButtonBack.UseVisualStyleBackColor = true;
            ButtonBack.Click += ButtonBack_Click;
            // 
            // ButtonLogout
            // 
            ButtonLogout.Location = new Point(694, 409);
            ButtonLogout.Name = "ButtonLogout";
            ButtonLogout.Size = new Size(94, 29);
            ButtonLogout.TabIndex = 7;
            ButtonLogout.Text = "Logout";
            ButtonLogout.UseVisualStyleBackColor = true;
            ButtonLogout.Click += ButtonLogout_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(198, 87);
            label1.Name = "label1";
            label1.Size = new Size(130, 35);
            label1.TabIndex = 8;
            label1.Text = "Voornaam";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(179, 131);
            label2.Name = "label2";
            label2.Size = new Size(149, 35);
            label2.TabIndex = 9;
            label2.Text = "Achternaam";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(136, 179);
            label3.Name = "label3";
            label3.Size = new Size(192, 35);
            label3.TabIndex = 10;
            label3.Text = "Geboortedatum";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(271, 230);
            label4.Name = "label4";
            label4.Size = new Size(50, 35);
            label4.TabIndex = 11;
            label4.Text = "Rol";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(165, 274);
            label5.Name = "label5";
            label5.Size = new Size(156, 35);
            label5.TabIndex = 12;
            label5.Text = "Wachtwoord";
            // 
            // AddEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ButtonLogout);
            Controls.Add(ButtonBack);
            Controls.Add(TextBoxPassword);
            Controls.Add(TextBoxLastname);
            Controls.Add(TextBoxFirstname);
            Controls.Add(DateTimePickerBirthDate);
            Controls.Add(ComboBoxRole);
            Controls.Add(ButtonAddEmployee);
            Name = "AddEmployeeForm";
            Text = "AddEmployee";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonAddEmployee;
        private ComboBox ComboBoxRole;
        private DateTimePicker DateTimePickerBirthDate;
        private TextBox TextBoxFirstname;
        private TextBox TextBoxLastname;
        private TextBox TextBoxPassword;
        private Button ButtonBack;
        private Button ButtonLogout;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}