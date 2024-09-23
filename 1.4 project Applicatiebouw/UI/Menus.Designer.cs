namespace UI
{
    partial class Menus
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
            btnAddItem = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            lsvItemMenu = new ListView();
            menuStrip1 = new MenuStrip();
            ReturnTSMI = new ToolStripMenuItem();
            lunchMenuTSMI = new ToolStripMenuItem();
            dinnerMenuTSMI = new ToolStripMenuItem();
            drinkMenuTSMI = new ToolStripMenuItem();
            overviewToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAddItem
            // 
            btnAddItem.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddItem.Location = new Point(283, 491);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(213, 60);
            btnAddItem.TabIndex = 0;
            btnAddItem.Text = "AddItem";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(51, 491);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(213, 60);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(516, 491);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(213, 60);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Change";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // lsvItemMenu
            // 
            lsvItemMenu.Location = new Point(51, 48);
            lsvItemMenu.Name = "lsvItemMenu";
            lsvItemMenu.Size = new Size(678, 418);
            lsvItemMenu.TabIndex = 3;
            lsvItemMenu.UseCompatibleStateImageBehavior = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { ReturnTSMI, lunchMenuTSMI, dinnerMenuTSMI, drinkMenuTSMI, overviewToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // ReturnTSMI
            // 
            ReturnTSMI.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ReturnTSMI.Name = "ReturnTSMI";
            ReturnTSMI.Size = new Size(70, 24);
            ReturnTSMI.Text = "Return";
            ReturnTSMI.Click += foodToolStripMenuItem_Click;
            // 
            // lunchMenuTSMI
            // 
            lunchMenuTSMI.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lunchMenuTSMI.Name = "lunchMenuTSMI";
            lunchMenuTSMI.Size = new Size(109, 24);
            lunchMenuTSMI.Text = "Lunch menu";
            lunchMenuTSMI.Click += lunchMenuTSMI_Click;
            // 
            // dinnerMenuTSMI
            // 
            dinnerMenuTSMI.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dinnerMenuTSMI.Name = "dinnerMenuTSMI";
            dinnerMenuTSMI.Size = new Size(112, 24);
            dinnerMenuTSMI.Text = "Dinner Menu";
            dinnerMenuTSMI.Click += dinnerMenuTSMI_Click;
            // 
            // drinkMenuTSMI
            // 
            drinkMenuTSMI.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            drinkMenuTSMI.Name = "drinkMenuTSMI";
            drinkMenuTSMI.Size = new Size(102, 24);
            drinkMenuTSMI.Text = "Drink Menu";
            drinkMenuTSMI.Click += drinkMenuToolStripMenuItem_Click;
            // 
            // overviewToolStripMenuItem
            // 
            overviewToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            overviewToolStripMenuItem.Name = "overviewToolStripMenuItem";
            overviewToolStripMenuItem.Size = new Size(84, 24);
            overviewToolStripMenuItem.Text = "Overview";
            overviewToolStripMenuItem.Click += overviewToolStripMenuItem_Click;
            // 
            // Menus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 599);
            Controls.Add(lsvItemMenu);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAddItem);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Menus";
            Text = "Menus";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private ListView lsvItemMenu;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ReturnTSMI;
        private ToolStripMenuItem lunchMenuTSMI;
        private ToolStripMenuItem dinnerMenuTSMI;
        private ToolStripMenuItem drinkMenuTSMI;
        private Button btnAddItem;
        private Button btnDelete;
        private Button btnUpdate;
        private ToolStripMenuItem overviewToolStripMenuItem;
    }
}