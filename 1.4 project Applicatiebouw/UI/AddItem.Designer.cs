namespace UI
{
    partial class AddItem
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
            txtName = new TextBox();
            txtPrice = new TextBox();
            chkBoxAlcohol = new CheckBox();
            txtStock = new TextBox();
            label3 = new Label();
            comboBoxMenu = new ComboBox();
            comboBoxType = new ComboBox();
            radioBtnFood = new RadioButton();
            radioBtnDrink = new RadioButton();
            btnAddItem = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            btnReturn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(26, 31);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 0;
            label1.Text = "AddItem:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(26, 64);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 1;
            label2.Text = "Item name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(133, 62);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 2;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(133, 104);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 3;
            // 
            // chkBoxAlcohol
            // 
            chkBoxAlcohol.AutoSize = true;
            chkBoxAlcohol.Location = new Point(133, 146);
            chkBoxAlcohol.Name = "chkBoxAlcohol";
            chkBoxAlcohol.Size = new Size(97, 19);
            chkBoxAlcohol.TabIndex = 4;
            chkBoxAlcohol.Text = "Bevat alcohol";
            chkBoxAlcohol.UseVisualStyleBackColor = true;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(133, 184);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(100, 23);
            txtStock.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 107);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 6;
            label3.Text = "Price";
            // 
            // comboBoxMenu
            // 
            comboBoxMenu.FormattingEnabled = true;
            comboBoxMenu.Location = new Point(133, 226);
            comboBoxMenu.Name = "comboBoxMenu";
            comboBoxMenu.Size = new Size(100, 23);
            comboBoxMenu.TabIndex = 7;
            comboBoxMenu.SelectedIndexChanged += comboBoxMenu_SelectedIndexChanged;
            // 
            // comboBoxType
            // 
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Location = new Point(133, 270);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(100, 23);
            comboBoxType.TabIndex = 8;
            // 
            // radioBtnFood
            // 
            radioBtnFood.AutoSize = true;
            radioBtnFood.Location = new Point(133, 312);
            radioBtnFood.Name = "radioBtnFood";
            radioBtnFood.Size = new Size(52, 19);
            radioBtnFood.TabIndex = 9;
            radioBtnFood.TabStop = true;
            radioBtnFood.Text = "Food";
            radioBtnFood.UseVisualStyleBackColor = true;
            // 
            // radioBtnDrink
            // 
            radioBtnDrink.AutoSize = true;
            radioBtnDrink.Location = new Point(133, 337);
            radioBtnDrink.Name = "radioBtnDrink";
            radioBtnDrink.Size = new Size(53, 19);
            radioBtnDrink.TabIndex = 10;
            radioBtnDrink.TabStop = true;
            radioBtnDrink.Text = "Drink";
            radioBtnDrink.UseVisualStyleBackColor = true;
            // 
            // btnAddItem
            // 
            btnAddItem.Location = new Point(106, 388);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(145, 46);
            btnAddItem.TabIndex = 11;
            btnAddItem.Text = "Add item";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 273);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 29;
            label6.Text = "Type";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 229);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 28;
            label5.Text = "Menu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 187);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 27;
            label4.Text = "Stock";
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(300, 12);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(75, 23);
            btnReturn.TabIndex = 30;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // AddItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 491);
            Controls.Add(btnReturn);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnAddItem);
            Controls.Add(radioBtnDrink);
            Controls.Add(radioBtnFood);
            Controls.Add(comboBoxType);
            Controls.Add(comboBoxMenu);
            Controls.Add(label3);
            Controls.Add(txtStock);
            Controls.Add(chkBoxAlcohol);
            Controls.Add(txtPrice);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddItem";
            Text = "AddItem";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtName;
        private TextBox txtPrice;
        private CheckBox chkBoxAlcohol;
        private TextBox txtStock;
        private Label label3;
        private ComboBox comboBoxMenu;
        private ComboBox comboBoxType;
        private RadioButton radioBtnFood;
        private RadioButton radioBtnDrink;
        private Button btnAddItem;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btnReturn;
    }
}