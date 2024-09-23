namespace UI
{
    partial class KeukenBarOverzicht
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
            btnLogout = new Button();
            listViewOrders = new ListView();
            lblTypeOfOrders = new Label();
            btnAfgerondeBestellingen = new Button();
            btnLopendeBestellingen = new Button();
            listViewTussengerechten = new ListView();
            listViewVoorgerechten = new ListView();
            listViewHoofdgerecht = new ListView();
            listViewNagerecht = new ListView();
            lblVoorgerechten = new Label();
            lblTussengerechten = new Label();
            lblHoofdgerecht = new Label();
            lblNagerecht = new Label();
            btnGereeed = new Button();
            btnVoorbereiden = new Button();
            lblStateOrder = new Label();
            SuspendLayout();
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.IndianRed;
            btnLogout.Location = new Point(25, 12);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(94, 29);
            btnLogout.TabIndex = 0;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // listViewOrders
            // 
            listViewOrders.Location = new Point(203, 113);
            listViewOrders.Name = "listViewOrders";
            listViewOrders.Size = new Size(523, 283);
            listViewOrders.TabIndex = 1;
            listViewOrders.UseCompatibleStateImageBehavior = false;
            listViewOrders.SelectedIndexChanged += listViewOrders_SelectedIndexChanged_1;
            // 
            // lblTypeOfOrders
            // 
            lblTypeOfOrders.AutoSize = true;
            lblTypeOfOrders.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTypeOfOrders.Location = new Point(367, 70);
            lblTypeOfOrders.Name = "lblTypeOfOrders";
            lblTypeOfOrders.Size = new Size(234, 28);
            lblTypeOfOrders.TabIndex = 2;
            lblTypeOfOrders.Text = "running/finishedOrders";
            // 
            // btnAfgerondeBestellingen
            // 
            btnAfgerondeBestellingen.Location = new Point(203, 38);
            btnAfgerondeBestellingen.Name = "btnAfgerondeBestellingen";
            btnAfgerondeBestellingen.Size = new Size(251, 29);
            btnAfgerondeBestellingen.TabIndex = 3;
            btnAfgerondeBestellingen.Text = "Laat afgeronde bestellingen zien";
            btnAfgerondeBestellingen.UseVisualStyleBackColor = true;
            btnAfgerondeBestellingen.Click += btnAfgerondeBestellingen_Click;
            // 
            // btnLopendeBestellingen
            // 
            btnLopendeBestellingen.Location = new Point(485, 38);
            btnLopendeBestellingen.Name = "btnLopendeBestellingen";
            btnLopendeBestellingen.Size = new Size(241, 29);
            btnLopendeBestellingen.TabIndex = 4;
            btnLopendeBestellingen.Text = "Laat lopende bestellingen zien";
            btnLopendeBestellingen.UseVisualStyleBackColor = true;
            btnLopendeBestellingen.Click += btnLopendeBestellingen_Click;
            // 
            // listViewTussengerechten
            // 
            listViewTussengerechten.Location = new Point(485, 136);
            listViewTussengerechten.Name = "listViewTussengerechten";
            listViewTussengerechten.Size = new Size(409, 124);
            listViewTussengerechten.TabIndex = 5;
            listViewTussengerechten.UseCompatibleStateImageBehavior = false;
            // 
            // listViewVoorgerechten
            // 
            listViewVoorgerechten.Location = new Point(25, 136);
            listViewVoorgerechten.Name = "listViewVoorgerechten";
            listViewVoorgerechten.Size = new Size(429, 124);
            listViewVoorgerechten.TabIndex = 6;
            listViewVoorgerechten.UseCompatibleStateImageBehavior = false;
            // 
            // listViewHoofdgerecht
            // 
            listViewHoofdgerecht.Location = new Point(25, 304);
            listViewHoofdgerecht.Name = "listViewHoofdgerecht";
            listViewHoofdgerecht.Size = new Size(429, 119);
            listViewHoofdgerecht.TabIndex = 7;
            listViewHoofdgerecht.UseCompatibleStateImageBehavior = false;
            // 
            // listViewNagerecht
            // 
            listViewNagerecht.Location = new Point(485, 304);
            listViewNagerecht.Name = "listViewNagerecht";
            listViewNagerecht.Size = new Size(409, 119);
            listViewNagerecht.TabIndex = 8;
            listViewNagerecht.UseCompatibleStateImageBehavior = false;
            // 
            // lblVoorgerechten
            // 
            lblVoorgerechten.AutoSize = true;
            lblVoorgerechten.Location = new Point(25, 113);
            lblVoorgerechten.Name = "lblVoorgerechten";
            lblVoorgerechten.Size = new Size(106, 20);
            lblVoorgerechten.TabIndex = 9;
            lblVoorgerechten.Text = "Voorgerechten";
            // 
            // lblTussengerechten
            // 
            lblTussengerechten.AutoSize = true;
            lblTussengerechten.Location = new Point(485, 113);
            lblTussengerechten.Name = "lblTussengerechten";
            lblTussengerechten.Size = new Size(116, 20);
            lblTussengerechten.TabIndex = 10;
            lblTussengerechten.Text = "tussengerechten";
            // 
            // lblHoofdgerecht
            // 
            lblHoofdgerecht.AutoSize = true;
            lblHoofdgerecht.Location = new Point(25, 281);
            lblHoofdgerecht.Name = "lblHoofdgerecht";
            lblHoofdgerecht.Size = new Size(102, 20);
            lblHoofdgerecht.TabIndex = 11;
            lblHoofdgerecht.Text = "Hoofdgerecht";
            // 
            // lblNagerecht
            // 
            lblNagerecht.AutoSize = true;
            lblNagerecht.Location = new Point(485, 281);
            lblNagerecht.Name = "lblNagerecht";
            lblNagerecht.Size = new Size(78, 20);
            lblNagerecht.TabIndex = 12;
            lblNagerecht.Text = "Nagerecht";
            // 
            // btnGereeed
            // 
            btnGereeed.BackColor = Color.MediumSeaGreen;
            btnGereeed.Location = new Point(438, 453);
            btnGereeed.Name = "btnGereeed";
            btnGereeed.Size = new Size(125, 41);
            btnGereeed.TabIndex = 13;
            btnGereeed.Text = "Gereed";
            btnGereeed.UseVisualStyleBackColor = false;
            btnGereeed.Click += btnGereeed_Click;
            // 
            // btnVoorbereiden
            // 
            btnVoorbereiden.BackColor = Color.Gold;
            btnVoorbereiden.Location = new Point(574, 453);
            btnVoorbereiden.Name = "btnVoorbereiden";
            btnVoorbereiden.Size = new Size(120, 41);
            btnVoorbereiden.TabIndex = 14;
            btnVoorbereiden.Text = "Voorbereiden";
            btnVoorbereiden.UseVisualStyleBackColor = false;
            btnVoorbereiden.Click += btnVoorbereiden_Click;
            // 
            // lblStateOrder
            // 
            lblStateOrder.AutoSize = true;
            lblStateOrder.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblStateOrder.Location = new Point(25, 70);
            lblStateOrder.Name = "lblStateOrder";
            lblStateOrder.Size = new Size(115, 28);
            lblStateOrder.TabIndex = 15;
            lblStateOrder.Text = "StateOrder";
            // 
            // KeukenBarOverzicht
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(938, 519);
            Controls.Add(lblStateOrder);
            Controls.Add(btnVoorbereiden);
            Controls.Add(btnGereeed);
            Controls.Add(lblNagerecht);
            Controls.Add(lblHoofdgerecht);
            Controls.Add(lblTussengerechten);
            Controls.Add(lblVoorgerechten);
            Controls.Add(listViewNagerecht);
            Controls.Add(listViewHoofdgerecht);
            Controls.Add(listViewVoorgerechten);
            Controls.Add(listViewTussengerechten);
            Controls.Add(btnLopendeBestellingen);
            Controls.Add(btnAfgerondeBestellingen);
            Controls.Add(lblTypeOfOrders);
            Controls.Add(listViewOrders);
            Controls.Add(btnLogout);
            Name = "KeukenBarOverzicht";
            Text = "KeukenBarOverzicht";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogout;
        private ListView listViewOrders;
        private Label lblTypeOfOrders;
        private Button btnAfgerondeBestellingen;
        private Button btnLopendeBestellingen;
        private ListView listViewTussengerechten;
        private ListView listViewVoorgerechten;
        private ListView listViewHoofdgerecht;
        private ListView listViewNagerecht;
        private Label lblVoorgerechten;
        private Label lblTussengerechten;
        private Label lblHoofdgerecht;
        private Label lblNagerecht;
        private Button btnGereeed;
        private Button btnVoorbereiden;
        private Label lblStateOrder;
    }
}