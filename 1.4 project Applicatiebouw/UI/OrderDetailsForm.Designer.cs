using Model;

namespace UI
{
    partial class OrderDetailsForm
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
            newOrderLbl = new Label();
            tableNrLbl = new Label();
            itemsLv = new ListView();
            editBtn = new Button();
            sendBtn = new Button();
            cancelBtn = new Button();
            deleteBtn = new Button();
            splitContainer1 = new SplitContainer();
            currentOrderLbl = new Label();
            tabControlMenu = new TabControl();
            lunchTab = new TabPage();
            tabControlCategoryLunch = new TabControl();
            lunchStarterTab = new TabPage();
            lunchIntermediateTab = new TabPage();
            lunchMainTab = new TabPage();
            lunchDessertTab = new TabPage();
            dinerTab = new TabPage();
            tabControlCategoryDiner = new TabControl();
            dinerStarterTab = new TabPage();
            dinerIntermediateTab = new TabPage();
            dinerMainTab = new TabPage();
            dinerDessertTab = new TabPage();
            drinksTab = new TabPage();
            tabControlCategoryDrinks = new TabControl();
            softDrinksTab = new TabPage();
            coffeeTab = new TabPage();
            wineTab = new TabPage();
            beerTab = new TabPage();
            alcoholTab = new TabPage();
            addOrderLineLbl = new Label();
            ButtonLogout = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tabControlMenu.SuspendLayout();
            lunchTab.SuspendLayout();
            tabControlCategoryLunch.SuspendLayout();
            dinerTab.SuspendLayout();
            tabControlCategoryDiner.SuspendLayout();
            drinksTab.SuspendLayout();
            tabControlCategoryDrinks.SuspendLayout();
            SuspendLayout();
            // 
            // nieuweBestellingLbl
            // 
            newOrderLbl.AutoSize = true;
            newOrderLbl.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            newOrderLbl.Location = new Point(12, 9);
            newOrderLbl.Name = "nieuweBestellingLbl";
            newOrderLbl.Size = new Size(196, 30);
            newOrderLbl.TabIndex = 0;
            newOrderLbl.Text = "Nieuwe bestelling:";
            // 
            // tafelnrLbl
            // 
            tableNrLbl.AutoSize = true;
            tableNrLbl.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            tableNrLbl.Location = new Point(228, 9);
            tableNrLbl.Name = "tafelnrLbl";
            tableNrLbl.Size = new Size(0, 30);
            tableNrLbl.TabIndex = 1;
            // 
            // itemsLv
            // 
            itemsLv.Location = new Point(12, 41);
            itemsLv.Name = "itemsLv";
            itemsLv.Size = new Size(374, 273);
            itemsLv.TabIndex = 2;
            itemsLv.UseCompatibleStateImageBehavior = false;
            // 
            // editBtn
            // 
            editBtn.Location = new Point(12, 323);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(119, 51);
            editBtn.TabIndex = 4;
            editBtn.Text = "Wijzig / Comment";
            editBtn.UseVisualStyleBackColor = true;
            editBtn.Click += editBtn_Click;
            // 
            // sendBtn
            // 
            sendBtn.Location = new Point(710, 432);
            sendBtn.Name = "sendBtn";
            sendBtn.Size = new Size(174, 58);
            sendBtn.TabIndex = 5;
            sendBtn.Text = "Bestelling versturen...";
            sendBtn.UseVisualStyleBackColor = true;
            sendBtn.Click += sendBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(12, 432);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(144, 58);
            cancelBtn.TabIndex = 6;
            cancelBtn.Text = "Annuleren";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(267, 320);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(119, 51);
            deleteBtn.TabIndex = 7;
            deleteBtn.Text = "Regel verwijderen";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(12, 42);
            splitContainer1.Name = "splitContainer1";
            
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = SystemColors.ActiveBorder;
            splitContainer1.Panel1.Controls.Add(currentOrderLbl);
            splitContainer1.Panel1.Controls.Add(deleteBtn);
            splitContainer1.Panel1.Controls.Add(itemsLv);
            splitContainer1.Panel1.Controls.Add(editBtn);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = SystemColors.AppWorkspace;
            splitContainer1.Panel2.Controls.Add(tabControlMenu);
            splitContainer1.Panel2.Controls.Add(addOrderLineLbl);
            splitContainer1.Size = new Size(872, 384);
            splitContainer1.SplitterDistance = 392;
            splitContainer1.TabIndex = 8;
            // 
            // huidigeBestellingLbl
            // 
            currentOrderLbl.AutoSize = true;
            currentOrderLbl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            currentOrderLbl.Location = new Point(12, 17);
            currentOrderLbl.Name = "currentOrderLbl";
            currentOrderLbl.Size = new Size(146, 21);
            currentOrderLbl.TabIndex = 8;
            currentOrderLbl.Text = "Huidige bestelling:";
            // 
            // tabControlMenu
            // 
            tabControlMenu.Controls.Add(lunchTab);
            tabControlMenu.Controls.Add(dinerTab);
            tabControlMenu.Controls.Add(drinksTab);
            tabControlMenu.ItemSize = new Size(167, 30);
            tabControlMenu.Location = new Point(16, 41);
            tabControlMenu.Name = "tabControlMenu";
            tabControlMenu.Padding = new Point(0, 0);
            tabControlMenu.SelectedIndex = 0;
            tabControlMenu.Size = new Size(445, 333);
            tabControlMenu.SizeMode = TabSizeMode.Fixed;
            tabControlMenu.TabIndex = 9;
            // 
            // lunchTab
            // 
            lunchTab.BackColor = Color.White;
            lunchTab.BackgroundImageLayout = ImageLayout.None;
            lunchTab.Controls.Add(tabControlCategoryLunch);
            lunchTab.Location = new Point(4, 34);
            lunchTab.Name = "lunchTab";
            lunchTab.Padding = new Padding(3);
            lunchTab.Size = new Size(437, 295);
            lunchTab.TabIndex = 0;
            lunchTab.Text = "Lunch Menu";
            // 
            // tabControlCategoryLunch
            // 
            tabControlCategoryLunch.TabPages.Add(lunchStarterTab);
            tabControlCategoryLunch.Controls.Add(lunchIntermediateTab);
            tabControlCategoryLunch.Controls.Add(lunchMainTab);
            tabControlCategoryLunch.Controls.Add(lunchDessertTab);
            tabControlCategoryLunch.ItemSize = new Size(126, 30);
            tabControlCategoryLunch.Location = new Point(-4, 0);
            tabControlCategoryLunch.Name = "tabControlCategoryLunch";
            tabControlCategoryLunch.Padding = new Point(0, 0);
            tabControlCategoryLunch.SelectedIndex = 0;
            tabControlCategoryLunch.Size = new Size(445, 299);
            tabControlCategoryLunch.SizeMode = TabSizeMode.Fixed;
            tabControlCategoryLunch.TabIndex = 0;
            // 
            // lunchVoorTab
            // 
            lunchStarterTab.AutoScroll = true;
            lunchStarterTab.Location = new Point(4, 34);
            lunchStarterTab.Name = "lunchStarterTab";
            lunchStarterTab.Padding = new Padding(3);
            lunchStarterTab.Size = new Size(437, 261);
            lunchStarterTab.TabIndex = 0;
            lunchStarterTab.Tag = ItemType.Starter;
            lunchStarterTab.Text = "Voorgerechten";
            lunchStarterTab.UseVisualStyleBackColor = true;
            lunchStarterTab.AutoScroll= true;
            // 
            // lunchTussenTab
            // 
            lunchIntermediateTab.Location = new Point(4, 34);
            lunchIntermediateTab.Name = "lunchIntermediateTab";
            lunchIntermediateTab.Padding = new Padding(3);
            lunchIntermediateTab.Size = new Size(437, 261);
            lunchIntermediateTab.TabIndex = 1;
            lunchIntermediateTab.Tag = ItemType.Intermediate;
            lunchIntermediateTab.Text = "Tussengerechten";
            lunchIntermediateTab.UseVisualStyleBackColor = true;
            lunchIntermediateTab.AutoScroll = true;
            // 
            // lunchHoofdTab
            // 
            lunchMainTab.Location = new Point(4, 34);
            lunchMainTab.Name = "lunchMainTab";
            lunchMainTab.Padding = new Padding(3);
            lunchMainTab.Size = new Size(437, 261);
            lunchMainTab.TabIndex = 2;
            lunchMainTab.Tag = ItemType.Main;
            lunchMainTab.Text = "Hoofdgerechten";
            lunchMainTab.UseVisualStyleBackColor = true;
            lunchMainTab.AutoScroll = true;
            // 
            // lunchNaTab
            // 
            lunchDessertTab.Location = new Point(4, 34);
            lunchDessertTab.Name = "lunchDessertTab";
            lunchDessertTab.Padding = new Padding(3);
            lunchDessertTab.Size = new Size(437, 261);
            lunchDessertTab.TabIndex = 3;
            lunchDessertTab.Tag = ItemType.Dessert;
            lunchDessertTab.Text = "Nagerechten";
            lunchDessertTab.UseVisualStyleBackColor = true;
            lunchDessertTab.AutoScroll = true;
            // 
            // dinerTab
            // 
            dinerTab.Controls.Add(tabControlCategoryDiner);
            dinerTab.Location = new Point(4, 34);
            dinerTab.Name = "dinerTab";
            dinerTab.Padding = new Padding(3);
            dinerTab.Size = new Size(437, 295);
            dinerTab.TabIndex = 1;
            dinerTab.Text = "Diner Menu";
            dinerTab.UseVisualStyleBackColor = true;
            // 
            // tabControlCategoryDiner
            // 
            tabControlCategoryDiner.Controls.Add(dinerStarterTab);
            tabControlCategoryDiner.Controls.Add(dinerIntermediateTab);
            tabControlCategoryDiner.Controls.Add(dinerMainTab);
            tabControlCategoryDiner.Controls.Add(dinerDessertTab);
            tabControlCategoryDiner.ItemSize = new Size(126, 30);
            tabControlCategoryDiner.Location = new Point(-4, 0);
            tabControlCategoryDiner.Name = "tabControlCategoryDiner";
            tabControlCategoryDiner.Padding = new Point(0, 0);
            tabControlCategoryDiner.SelectedIndex = 0;
            tabControlCategoryDiner.Size = new Size(445, 299);
            tabControlCategoryDiner.SizeMode = TabSizeMode.Fixed;
            tabControlCategoryDiner.TabIndex = 1;
            // 
            // dinerVoorTab
            // 
            dinerStarterTab.AutoScroll = true;
            dinerStarterTab.Location = new Point(4, 34);
            dinerStarterTab.Name = "dinerStarterTab";
            dinerStarterTab.Padding = new Padding(3);
            dinerStarterTab.Size = new Size(437, 261);
            dinerStarterTab.Tag = ItemType.Starter;
            dinerStarterTab.TabIndex = 0;
            dinerStarterTab.Text = "Voorgerechten";
            dinerStarterTab.UseVisualStyleBackColor = true;
            dinerStarterTab.AutoScroll = true;
            // 
            // dinerTussenTab
            // 
            dinerIntermediateTab.Location = new Point(4, 34);
            dinerIntermediateTab.Name = "dinerIntermediateTab";
            dinerIntermediateTab.Padding = new Padding(3);
            dinerIntermediateTab.Size = new Size(437, 261);
            dinerIntermediateTab.TabIndex = 1;
            dinerIntermediateTab.Tag = ItemType.Intermediate;
            dinerIntermediateTab.Text = "Tussengerechten";
            dinerIntermediateTab.UseVisualStyleBackColor = true;
            dinerIntermediateTab.AutoScroll = true;
            // 
            // dinerHoofdTab
            // 
            dinerMainTab.Location = new Point(4, 34);
            dinerMainTab.Name = "dinerMainTab";
            dinerMainTab.Padding = new Padding(3);
            dinerMainTab.Size = new Size(437, 261);
            dinerMainTab.TabIndex = 2;
            dinerMainTab.Tag = ItemType.Main;
            dinerMainTab.Text = "Hoofdgerechten";
            dinerMainTab.UseVisualStyleBackColor = true;
            dinerMainTab.AutoScroll = true;
            // 
            // dinerNaTab
            // 
            dinerDessertTab.Location = new Point(4, 34);
            dinerDessertTab.Name = "dinerDessertTab";
            dinerDessertTab.Padding = new Padding(3);
            dinerDessertTab.Size = new Size(437, 261);
            dinerDessertTab.Tag = ItemType.Dessert;
            dinerDessertTab.TabIndex = 3;
            dinerDessertTab.Text = "Nagerechten";
            dinerDessertTab.UseVisualStyleBackColor = true;
            dinerDessertTab.AutoScroll = true;
            // 
            // drinksTab
            // 
            drinksTab.Controls.Add(tabControlCategoryDrinks);
            drinksTab.Location = new Point(4, 34);
            drinksTab.Name = "drinksTab";
            drinksTab.Padding = new Padding(3);
            drinksTab.Size = new Size(437, 295);
            drinksTab.TabIndex = 2;
            drinksTab.Text = "Drinks Menu";
            drinksTab.UseVisualStyleBackColor = true;
            // 
            // tabControlCategoryDrinks
            // 
            tabControlCategoryDrinks.Controls.Add(softDrinksTab);
            tabControlCategoryDrinks.Controls.Add(coffeeTab);
            tabControlCategoryDrinks.Controls.Add(wineTab);
            tabControlCategoryDrinks.Controls.Add(beerTab);
            tabControlCategoryDrinks.Controls.Add(alcoholTab);
            tabControlCategoryDrinks.ItemSize = new Size(100, 30);
            tabControlCategoryDrinks.Location = new Point(-4, -2);
            tabControlCategoryDrinks.Name = "tabControlCategoryDrinks";
            tabControlCategoryDrinks.Padding = new Point(0, 0);
            tabControlCategoryDrinks.SelectedIndex = 0;
            tabControlCategoryDrinks.Size = new Size(445, 299);
            tabControlCategoryDrinks.SizeMode = TabSizeMode.Fixed;
            tabControlCategoryDrinks.TabIndex = 1;
            // 
            // frisdrankTab
            // 
            softDrinksTab.AutoScroll = true;
            softDrinksTab.Location = new Point(4, 34);
            softDrinksTab.Name = "softDrinksTab";
            softDrinksTab.Padding = new Padding(3);
            softDrinksTab.Size = new Size(437, 261);
            softDrinksTab.TabIndex = 0;
            softDrinksTab.Text = "Frisdranken";
            softDrinksTab.Tag = ItemType.SoftDrinks;
            softDrinksTab.UseVisualStyleBackColor = true;
            softDrinksTab.AutoScroll = true;
            // 
            // koffieTab
            // 
            coffeeTab.Location = new Point(4, 34);
            coffeeTab.Name = "coffeeTab";
            coffeeTab.Padding = new Padding(3);
            coffeeTab.Size = new Size(437, 261);
            coffeeTab.TabIndex = 1;
            coffeeTab.Text = "Koffie/Thee";
            coffeeTab.Tag = ItemType.TeaAndCoffee;
            coffeeTab.UseVisualStyleBackColor = true;
            coffeeTab.AutoScroll = true;
            // 
            // wijnTab
            // 
            wineTab.Location = new Point(4, 34);
            wineTab.Name = "wineTab";
            wineTab.Padding = new Padding(3);
            wineTab.Size = new Size(437, 261);
            wineTab.TabIndex = 2;
            wineTab.Text = "Wijn";
            wineTab.Tag = ItemType.Wine;
            wineTab.UseVisualStyleBackColor = true;
            wineTab.AutoScroll = true;
            // 
            // bierTab
            // 
            beerTab.Location = new Point(4, 34);
            beerTab.Name = "beerTab";
            beerTab.Padding = new Padding(3);
            beerTab.Size = new Size(437, 261);
            beerTab.TabIndex = 3;
            beerTab.Text = "Bier";
            beerTab.Tag = ItemType.Beer;
            beerTab.UseVisualStyleBackColor = true;
            beerTab.AutoScroll = true;
            // 
            // gedistileerdTab
            // 
            alcoholTab.Location = new Point(4, 34);
            alcoholTab.Name = "alcoholTab";
            alcoholTab.Padding = new Padding(3);
            alcoholTab.Size = new Size(437, 261);
            alcoholTab.TabIndex = 4;
            alcoholTab.Text = "Gedistileerd";
            alcoholTab.Tag = ItemType.Spirits;
            alcoholTab.UseVisualStyleBackColor = true;
            alcoholTab.AutoScroll = true;
            // 
            // regelToevoegenLbl
            // 
            addOrderLineLbl.AutoSize = true;
            addOrderLineLbl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            addOrderLineLbl.Location = new Point(16, 17);
            addOrderLineLbl.Name = "addOrderLineLbl";
            addOrderLineLbl.Size = new Size(132, 21);
            addOrderLineLbl.TabIndex = 9;
            addOrderLineLbl.Text = "Regel toevoegen:";
            // 
            // ButtonLogout
            // 
            ButtonLogout.Location = new Point(802, 17);
            ButtonLogout.Margin = new Padding(3, 2, 3, 2);
            ButtonLogout.Name = "ButtonLogout";
            ButtonLogout.Size = new Size(82, 22);
            ButtonLogout.TabIndex = 9;
            ButtonLogout.Text = "Logout";
            ButtonLogout.UseVisualStyleBackColor = true;
            ButtonLogout.Click += ButtonLogout_Click;
            // 
            // OrderDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 498);
            Controls.Add(ButtonLogout);
            Controls.Add(cancelBtn);
            Controls.Add(sendBtn);
            Controls.Add(tableNrLbl);
            Controls.Add(newOrderLbl);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "OrderDetailsForm";
            ShowIcon = false;
            Text = "Bestellen";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tabControlMenu.ResumeLayout(false);
            lunchTab.ResumeLayout(false);
            tabControlCategoryLunch.ResumeLayout(false);
            dinerTab.ResumeLayout(false);
            tabControlCategoryDiner.ResumeLayout(false);
            drinksTab.ResumeLayout(false);
            tabControlCategoryDrinks.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label newOrderLbl;
        private Label tableNrLbl;
        private ListView itemsLv;
        private Button editBtn;
        private Button sendBtn;
        private Button cancelBtn;
        private Button deleteBtn;
        private SplitContainer splitContainer1;
        private Label currentOrderLbl;
        private Label addOrderLineLbl;
        private TabControl tabControlMenu;
        private TabPage lunchTab;
        private TabPage dinerTab;
        private Button ButtonLogout;
        private TabControl tabControlCategoryLunch;
        private TabPage lunchStarterTab;
        private TabPage lunchIntermediateTab;
        private TabPage drinksTab;
        private TabPage lunchMainTab;
        private TabPage lunchDessertTab;
        private TabControl tabControlCategoryDiner;
        private TabPage dinerStarterTab;
        private TabPage dinerIntermediateTab;
        private TabPage dinerMainTab;
        private TabPage dinerDessertTab;
        private TabControl tabControlCategoryDrinks;
        private TabPage softDrinksTab;
        private TabPage coffeeTab;
        private TabPage wineTab;
        private TabPage beerTab;
        private TabPage alcoholTab;
    }
}