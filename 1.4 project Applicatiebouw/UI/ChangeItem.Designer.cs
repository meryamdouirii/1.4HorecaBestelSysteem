namespace UI
{
    partial class ChangeItem
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
            btnChangeItem = new Button();
            radioBtnDrink = new RadioButton();
            radioBtnFood = new RadioButton();
            comboBoxType = new ComboBox();
            comboBoxMenu = new ComboBox();
            label3 = new Label();
            txtStock = new TextBox();
            chkBoxAlcohol = new CheckBox();
            txtPrice = new TextBox();
            txtName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnReturn = new Button();
            SuspendLayout();
            // 
            // btnChangeItem
            // 
            btnChangeItem.Location = new Point(130, 376);
            btnChangeItem.Name = "btnChangeItem";
            btnChangeItem.Size = new Size(145, 46);
            btnChangeItem.TabIndex = 23;
            btnChangeItem.Text = "Change item";
            btnChangeItem.UseVisualStyleBackColor = true;
            btnChangeItem.Click += btnChangeItem_Click;
            // 
            // radioBtnDrink
            // 
            radioBtnDrink.AutoSize = true;
            radioBtnDrink.Location = new Point(157, 325);
            radioBtnDrink.Name = "radioBtnDrink";
            radioBtnDrink.Size = new Size(53, 19);
            radioBtnDrink.TabIndex = 22;
            radioBtnDrink.TabStop = true;
            radioBtnDrink.Text = "Drink";
            radioBtnDrink.UseVisualStyleBackColor = true;
            // 
            // radioBtnFood
            // 
            radioBtnFood.AutoSize = true;
            radioBtnFood.Location = new Point(157, 300);
            radioBtnFood.Name = "radioBtnFood";
            radioBtnFood.Size = new Size(52, 19);
            radioBtnFood.TabIndex = 21;
            radioBtnFood.TabStop = true;
            radioBtnFood.Text = "Food";
            radioBtnFood.UseVisualStyleBackColor = true;
            // 
            // comboBoxType
            // 
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Location = new Point(157, 258);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(100, 23);
            comboBoxType.TabIndex = 20;
            // 
            // comboBoxMenu
            // 
            comboBoxMenu.FormattingEnabled = true;
            comboBoxMenu.Location = new Point(157, 214);
            comboBoxMenu.Name = "comboBoxMenu";
            comboBoxMenu.Size = new Size(100, 23);
            comboBoxMenu.TabIndex = 19;
            comboBoxMenu.SelectedIndexChanged += comboBoxMenu_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 95);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 18;
            label3.Text = "Price";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(157, 172);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(100, 23);
            txtStock.TabIndex = 17;
            // 
            // chkBoxAlcohol
            // 
            chkBoxAlcohol.AutoSize = true;
            chkBoxAlcohol.Location = new Point(157, 134);
            chkBoxAlcohol.Name = "chkBoxAlcohol";
            chkBoxAlcohol.Size = new Size(97, 19);
            chkBoxAlcohol.TabIndex = 16;
            chkBoxAlcohol.Text = "Bevat alcohol";
            chkBoxAlcohol.UseVisualStyleBackColor = true;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(157, 92);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 15;
            // 
            // txtName
            // 
            txtName.Location = new Point(157, 50);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(50, 52);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 13;
            label2.Text = "Item name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(50, 19);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 12;
            label1.Text = "ChangeItem:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 175);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 24;
            label4.Text = "Stock";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 217);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 25;
            label5.Text = "Menu";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(50, 261);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 26;
            label6.Text = "Type";
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(331, 12);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(75, 23);
            btnReturn.TabIndex = 27;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // ChangeItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 450);
            Controls.Add(btnReturn);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnChangeItem);
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
            Name = "ChangeItem";
            Text = "ChangeItem";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnChangeItem;
        private RadioButton radioBtnDrink;
        private RadioButton radioBtnFood;
        private ComboBox comboBoxType;
        private ComboBox comboBoxMenu;
        private Label label3;
        private TextBox txtStock;
        private CheckBox chkBoxAlcohol;
        private TextBox txtPrice;
        private TextBox txtName;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnReturn;
    }
}