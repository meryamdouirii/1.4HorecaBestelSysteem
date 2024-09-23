namespace UI
{
    partial class Payment
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
            combobox_TableNumbers = new ComboBox();
            listViewOrdersByTables = new ListView();
            btn_Pay = new Button();
            txtbox_Comment = new RichTextBox();
            combobox_SelectPaymentMethod = new ComboBox();
            label2 = new Label();
            label4 = new Label();
            txtbox_AmountToBePaid = new TextBox();
            label5 = new Label();
            txtbox_Tip = new TextBox();
            txt_boxOrderId = new TextBox();
            label6 = new Label();
            ButtonBack = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(20, 19);
            label1.Name = "label1";
            label1.Size = new Size(92, 19);
            label1.TabIndex = 0;
            label1.Text = "Select a table:";
            // 
            // combobox_TableNumbers
            // 
            combobox_TableNumbers.DropDownStyle = ComboBoxStyle.DropDownList;
            combobox_TableNumbers.FormattingEnabled = true;
            combobox_TableNumbers.Location = new Point(20, 42);
            combobox_TableNumbers.Margin = new Padding(3, 2, 3, 2);
            combobox_TableNumbers.Name = "combobox_TableNumbers";
            combobox_TableNumbers.Size = new Size(133, 23);
            combobox_TableNumbers.TabIndex = 1;
            combobox_TableNumbers.SelectedIndexChanged += combobox_TableNumbers_SelectedIndexChanged;
            // 
            // listViewOrdersByTables
            // 
            listViewOrdersByTables.Location = new Point(245, 60);
            listViewOrdersByTables.Margin = new Padding(3, 2, 3, 2);
            listViewOrdersByTables.Name = "listViewOrdersByTables";
            listViewOrdersByTables.Size = new Size(391, 234);
            listViewOrdersByTables.TabIndex = 2;
            listViewOrdersByTables.UseCompatibleStateImageBehavior = false;
            listViewOrdersByTables.SelectedIndexChanged += listViewOrdersByTables_SelectedIndexChanged;
            // 
            // btn_Pay
            // 
            btn_Pay.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Pay.Location = new Point(566, 313);
            btn_Pay.Margin = new Padding(3, 2, 3, 2);
            btn_Pay.Name = "btn_Pay";
            btn_Pay.Size = new Size(145, 57);
            btn_Pay.TabIndex = 3;
            btn_Pay.Text = "Pay";
            btn_Pay.UseVisualStyleBackColor = true;
            btn_Pay.Click += btn_Pay_Click;
            // 
            // txtbox_Comment
            // 
            txtbox_Comment.Location = new Point(245, 298);
            txtbox_Comment.Margin = new Padding(3, 2, 3, 2);
            txtbox_Comment.Name = "txtbox_Comment";
            txtbox_Comment.Size = new Size(289, 91);
            txtbox_Comment.TabIndex = 5;
            txtbox_Comment.Text = "";
            // 
            // combobox_SelectPaymentMethod
            // 
            combobox_SelectPaymentMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            combobox_SelectPaymentMethod.FormattingEnabled = true;
            combobox_SelectPaymentMethod.Location = new Point(20, 105);
            combobox_SelectPaymentMethod.Margin = new Padding(3, 2, 3, 2);
            combobox_SelectPaymentMethod.Name = "combobox_SelectPaymentMethod";
            combobox_SelectPaymentMethod.Size = new Size(133, 23);
            combobox_SelectPaymentMethod.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(20, 74);
            label2.Name = "label2";
            label2.Size = new Size(157, 19);
            label2.TabIndex = 7;
            label2.Text = "Select payment method:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(20, 162);
            label4.Name = "label4";
            label4.Size = new Size(128, 19);
            label4.TabIndex = 13;
            label4.Text = "Amount to be paid:";
            // 
            // txtbox_AmountToBePaid
            // 
            txtbox_AmountToBePaid.Location = new Point(20, 183);
            txtbox_AmountToBePaid.Margin = new Padding(3, 2, 3, 2);
            txtbox_AmountToBePaid.Name = "txtbox_AmountToBePaid";
            txtbox_AmountToBePaid.ReadOnly = true;
            txtbox_AmountToBePaid.Size = new Size(110, 23);
            txtbox_AmountToBePaid.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(20, 221);
            label5.Name = "label5";
            label5.Size = new Size(30, 19);
            label5.TabIndex = 15;
            label5.Text = "Tip:";
            // 
            // txtbox_Tip
            // 
            txtbox_Tip.Location = new Point(20, 242);
            txtbox_Tip.Margin = new Padding(3, 2, 3, 2);
            txtbox_Tip.Name = "txtbox_Tip";
            txtbox_Tip.Size = new Size(110, 23);
            txtbox_Tip.TabIndex = 16;
            // 
            // txt_boxOrderId
            // 
            txt_boxOrderId.Location = new Point(245, 35);
            txt_boxOrderId.Margin = new Padding(3, 2, 3, 2);
            txt_boxOrderId.Name = "txt_boxOrderId";
            txt_boxOrderId.ReadOnly = true;
            txt_boxOrderId.Size = new Size(53, 23);
            txt_boxOrderId.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(245, 19);
            label6.Name = "label6";
            label6.Size = new Size(47, 15);
            label6.TabIndex = 18;
            label6.Text = "OrderId";
            // 
            // ButtonBack
            // 
            ButtonBack.Location = new Point(20, 366);
            ButtonBack.Margin = new Padding(3, 2, 3, 2);
            ButtonBack.Name = "ButtonBack";
            ButtonBack.Size = new Size(82, 22);
            ButtonBack.TabIndex = 20;
            ButtonBack.Text = "<< Back";
            ButtonBack.UseVisualStyleBackColor = true;

            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 409);
            Controls.Add(ButtonBack);
            Controls.Add(label6);
            Controls.Add(txt_boxOrderId);
            Controls.Add(txtbox_Tip);
            Controls.Add(label5);
            Controls.Add(txtbox_AmountToBePaid);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(combobox_SelectPaymentMethod);
            Controls.Add(txtbox_Comment);
            Controls.Add(btn_Pay);
            Controls.Add(listViewOrdersByTables);
            Controls.Add(combobox_TableNumbers);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Payment";
            Text = "Payment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox combobox_TableNumbers;
        private ListView listViewOrdersByTables;
        private Button btn_Pay;
        private RichTextBox txtbox_Comment;
        private ComboBox combobox_SelectPaymentMethod;
        private Label label2;
        private Label label4;
        private TextBox txtbox_AmountToBePaid;
        private Label label5;
        private TextBox txtbox_Tip;
        private TextBox txt_boxOrderId;
        private Label label6;
        private Button ButtonBack;
    }
}