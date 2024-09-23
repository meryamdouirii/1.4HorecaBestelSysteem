namespace UI
{
    partial class ManagerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ListViewEmployee = new ListView();
            ButtonRemoveEmployee = new Button();
            ButtonGoToAddEmployee = new Button();
            ButtonBack = new Button();
            ButtonLogout = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // ListViewEmployee
            // 
            ListViewEmployee.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ListViewEmployee.Location = new Point(12, 78);
            ListViewEmployee.Name = "ListViewEmployee";
            ListViewEmployee.Size = new Size(507, 360);
            ListViewEmployee.TabIndex = 0;
            ListViewEmployee.UseCompatibleStateImageBehavior = false;
            // 
            // ButtonRemoveEmployee
            // 
            ButtonRemoveEmployee.BackColor = Color.Red;
            ButtonRemoveEmployee.FlatAppearance.BorderColor = Color.Black;
            ButtonRemoveEmployee.FlatAppearance.BorderSize = 3;
            ButtonRemoveEmployee.FlatStyle = FlatStyle.Flat;
            ButtonRemoveEmployee.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonRemoveEmployee.ForeColor = Color.White;
            ButtonRemoveEmployee.Location = new Point(525, 78);
            ButtonRemoveEmployee.Name = "ButtonRemoveEmployee";
            ButtonRemoveEmployee.Size = new Size(263, 85);
            ButtonRemoveEmployee.TabIndex = 1;
            ButtonRemoveEmployee.Text = "Werknemer verwijderen";
            ButtonRemoveEmployee.UseVisualStyleBackColor = false;
            ButtonRemoveEmployee.Click += ButtonRemoveEmployee_Click;
            // 
            // ButtonGoToAddEmployee
            // 
            ButtonGoToAddEmployee.BackColor = Color.Lime;
            ButtonGoToAddEmployee.FlatAppearance.BorderColor = Color.Black;
            ButtonGoToAddEmployee.FlatAppearance.BorderSize = 3;
            ButtonGoToAddEmployee.FlatStyle = FlatStyle.Flat;
            ButtonGoToAddEmployee.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonGoToAddEmployee.ForeColor = Color.White;
            ButtonGoToAddEmployee.Location = new Point(525, 177);
            ButtonGoToAddEmployee.Name = "ButtonGoToAddEmployee";
            ButtonGoToAddEmployee.Size = new Size(263, 85);
            ButtonGoToAddEmployee.TabIndex = 2;
            ButtonGoToAddEmployee.Text = "Werknemer toevoegen";
            ButtonGoToAddEmployee.UseVisualStyleBackColor = false;
            ButtonGoToAddEmployee.Click += ButtonGoToAddEmployee_Click;
            // 
            // ButtonBack
            // 
            ButtonBack.Location = new Point(12, 12);
            ButtonBack.Name = "ButtonBack";
            ButtonBack.Size = new Size(94, 29);
            ButtonBack.TabIndex = 7;
            ButtonBack.Text = "<< Back";
            ButtonBack.UseVisualStyleBackColor = true;
            ButtonBack.Click += ButtonBack_Click;
            // 
            // ButtonLogout
            // 
            ButtonLogout.Location = new Point(694, 409);
            ButtonLogout.Name = "ButtonLogout";
            ButtonLogout.Size = new Size(94, 29);
            ButtonLogout.TabIndex = 8;
            ButtonLogout.Text = "Logout";
            ButtonLogout.UseVisualStyleBackColor = true;
            ButtonLogout.Click += ButtonLogout_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 25.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(181, 9);
            label1.Name = "label1";
            label1.Size = new Size(473, 57);
            label1.TabIndex = 9;
            label1.Text = "Werknemer overzicht";
            // 
            // ManagerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(ButtonLogout);
            Controls.Add(ButtonBack);
            Controls.Add(ButtonGoToAddEmployee);
            Controls.Add(ButtonRemoveEmployee);
            Controls.Add(ListViewEmployee);
            Name = "ManagerForm";
            Text = "Manager";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView ListViewEmployee;
        private Button ButtonRemoveEmployee;
        private Button ButtonGoToAddEmployee;
        private Button ButtonBack;
        private Button ButtonLogout;
        private Label label1;
    }
}
