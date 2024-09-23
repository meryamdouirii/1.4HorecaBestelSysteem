namespace UI
{
    partial class EditOrderRegelForm
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
            itemNameLb = new Label();
            countNum = new NumericUpDown();
            commentTb = new TextBox();
            label3 = new Label();
            label4 = new Label();
            SaveBtn = new Button();
            cancelBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)countNum).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 28);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 0;
            label1.Text = "Selected item:";
            // 
            // itemNameLb
            // 
            itemNameLb.Location = new Point(113, 12);
            itemNameLb.Name = "itemNameLb";
            itemNameLb.Size = new Size(174, 55);
            itemNameLb.TabIndex = 1;
            // 
            // countNum
            // 
            countNum.Location = new Point(113, 71);
            countNum.Margin = new Padding(3, 4, 3, 4);
            countNum.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            countNum.Name = "countNum";
            countNum.Size = new Size(174, 27);
            countNum.TabIndex = 2;
            countNum.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // commentTb
            // 
            commentTb.Location = new Point(113, 109);
            commentTb.Margin = new Padding(3, 4, 3, 4);
            commentTb.Multiline = true;
            commentTb.Name = "commentTb";
            commentTb.Size = new Size(173, 57);
            commentTb.TabIndex = 3;
            commentTb.MaxLength = 95;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 73);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 4;
            label3.Text = "Aantal:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 113);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 5;
            label4.Text = "Comment:";
            // 
            // SaveBtn
            // 
            SaveBtn.Location = new Point(201, 217);
            SaveBtn.Margin = new Padding(3, 4, 3, 4);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(86, 31);
            SaveBtn.TabIndex = 6;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click_1;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(14, 217);
            cancelBtn.Margin = new Padding(3, 4, 3, 4);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(86, 31);
            cancelBtn.TabIndex = 7;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // EditOrderRegelForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(301, 264);
            ControlBox = false;
            Controls.Add(cancelBtn);
            Controls.Add(SaveBtn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(commentTb);
            Controls.Add(countNum);
            Controls.Add(itemNameLb);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "EditOrderRegelForm";
            Text = "Order wijzigen...";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)countNum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label itemNameLb;
        private NumericUpDown countNum;
        private TextBox commentTb;
        private Label label3;
        private Label label4;
        private Button SaveBtn;
        private Button cancelBtn;
    }
}