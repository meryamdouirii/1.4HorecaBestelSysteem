namespace UI
{
    partial class SingleTableForm
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
            ButtonBack = new Button();
            ButtonLogout = new Button();
            ButtonSeat = new Button();
            ButtonUnseat = new Button();
            ButtonBestelling = new Button();
            LabelWaitingTime = new Label();
            SuspendLayout();
            // 
            // ButtonBack
            // 
            ButtonBack.Location = new Point(12, 12);
            ButtonBack.Name = "ButtonBack";
            ButtonBack.Size = new Size(94, 29);
            ButtonBack.TabIndex = 10;
            ButtonBack.Text = "<< Back";
            ButtonBack.UseVisualStyleBackColor = true;
            ButtonBack.Click += ButtonBack_Click;
            // 
            // ButtonLogout
            // 
            ButtonLogout.Location = new Point(694, 409);
            ButtonLogout.Name = "ButtonLogout";
            ButtonLogout.Size = new Size(94, 29);
            ButtonLogout.TabIndex = 11;
            ButtonLogout.Text = "Logout";
            ButtonLogout.UseVisualStyleBackColor = true;
            ButtonLogout.Click += ButtonLogout_Click;
            // 
            // ButtonSeat
            // 
            ButtonSeat.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonSeat.Location = new Point(157, 307);
            ButtonSeat.Name = "ButtonSeat";
            ButtonSeat.Size = new Size(196, 68);
            ButtonSeat.TabIndex = 12;
            ButtonSeat.Text = "Klant plaatsen";
            ButtonSeat.UseVisualStyleBackColor = true;
            ButtonSeat.Click += ButtonSeat_Click;
            // 
            // ButtonUnseat
            // 
            ButtonUnseat.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonUnseat.Location = new Point(157, 307);
            ButtonUnseat.Name = "ButtonUnseat";
            ButtonUnseat.Size = new Size(196, 68);
            ButtonUnseat.TabIndex = 13;
            ButtonUnseat.Text = "Tafel legen";
            ButtonUnseat.UseVisualStyleBackColor = true;
            ButtonUnseat.Click += ButtonUnseat_Click;
            // 
            // ButtonBestelling
            // 
            ButtonBestelling.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonBestelling.Location = new Point(359, 307);
            ButtonBestelling.Name = "ButtonBestelling";
            ButtonBestelling.Size = new Size(276, 68);
            ButtonBestelling.TabIndex = 15;
            ButtonBestelling.Text = "Bestelling plaatsen";
            ButtonBestelling.UseVisualStyleBackColor = true;
            ButtonBestelling.Click += ButtonBestelling_Click;
            // 
            // LabelWaitingTime
            // 
            LabelWaitingTime.AutoSize = true;
            LabelWaitingTime.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            LabelWaitingTime.Location = new Point(157, 158);
            LabelWaitingTime.Name = "LabelWaitingTime";
            LabelWaitingTime.Size = new Size(0, 35);
            LabelWaitingTime.TabIndex = 16;
            // 
            // SingleTableForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LabelWaitingTime);
            Controls.Add(ButtonBestelling);
            Controls.Add(ButtonUnseat);
            Controls.Add(ButtonSeat);
            Controls.Add(ButtonLogout);
            Controls.Add(ButtonBack);
            Name = "SingleTableForm";
            Text = "SingleTableForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonBack;
        private Button ButtonLogout;
        private Button ButtonSeat;
        private Button ButtonUnseat;
        private Button ButtonBestelling;
        private Label LabelWaitingTime;
    }
}