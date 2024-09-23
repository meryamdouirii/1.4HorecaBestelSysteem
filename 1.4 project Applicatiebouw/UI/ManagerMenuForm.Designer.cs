namespace UI
{
    partial class ManagerMenuForm
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
            ButtonLogout = new Button();
            paymentBtn = new Button();
            btnDrinkMenu = new Button();
            ButtonMainManager = new Button();
            tableOverviewBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(230, 9);
            label1.Name = "label1";
            label1.Size = new Size(311, 57);
            label1.TabIndex = 0;
            label1.Text = "Manager Menu";
            // 
            // ButtonLogout
            // 
            ButtonLogout.Location = new Point(694, 409);
            ButtonLogout.Name = "ButtonLogout";
            ButtonLogout.Size = new Size(94, 29);
            ButtonLogout.TabIndex = 9;
            ButtonLogout.Text = "Logout";
            ButtonLogout.UseVisualStyleBackColor = true;
            ButtonLogout.Click += ButtonLogout_Click;
            // 
            // paymentBtn
            // 
            paymentBtn.Location = new Point(89, 205);
            paymentBtn.Name = "paymentBtn";
            paymentBtn.Size = new Size(249, 73);
            paymentBtn.TabIndex = 12;
            paymentBtn.Text = "Payment";
            paymentBtn.UseVisualStyleBackColor = true;
            paymentBtn.Click += paymentBtn_Click;
            // 
            // btnDrinkMenu
            // 
            btnDrinkMenu.Location = new Point(447, 205);
            btnDrinkMenu.Name = "btnDrinkMenu";
            btnDrinkMenu.Size = new Size(249, 73);
            btnDrinkMenu.TabIndex = 14;
            btnDrinkMenu.Text = "menus";
            btnDrinkMenu.UseVisualStyleBackColor = true;
            btnDrinkMenu.Click += btnDrinkMenu_Click;
            // 
            // ButtonMainManager
            // 
            ButtonMainManager.Location = new Point(89, 101);
            ButtonMainManager.Name = "ButtonMainManager";
            ButtonMainManager.Size = new Size(249, 73);
            ButtonMainManager.TabIndex = 15;
            ButtonMainManager.Text = "Werknemer overzicht";
            ButtonMainManager.UseVisualStyleBackColor = true;
            ButtonMainManager.Click += ButtonMainManager_Click_1;
            // 
            // tableOverviewBtn
            // 
            tableOverviewBtn.Location = new Point(89, 309);
            tableOverviewBtn.Name = "tableOverviewBtn";
            tableOverviewBtn.Size = new Size(249, 73);
            tableOverviewBtn.TabIndex = 16;
            tableOverviewBtn.Text = "Tafel overzicht";
            tableOverviewBtn.UseVisualStyleBackColor = true;
            tableOverviewBtn.Click += tableOverviewBtn_Click;
            // 
            // ManagerMenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(tableOverviewBtn);
            Controls.Add(ButtonMainManager);
            Controls.Add(btnDrinkMenu);
            Controls.Add(paymentBtn);
            Controls.Add(ButtonLogout);
            Controls.Add(label1);
            Name = "ManagerMenuForm";
            Text = "MainmenuForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button ButtonLogout;
        private Button paymentBtn;
        private Button btnDrinkMenu;
        private Button ButtonMainManager;
        private Button tableOverviewBtn;
    }
}