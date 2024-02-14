namespace eSzkola
{
    partial class SendMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendMessage));
            label5 = new Label();
            label6 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboRecipient = new ComboBox();
            txtMsgSubject = new TextBox();
            txtMessage = new TextBox();
            btnSend = new Button();
            btnCancel = new Button();
            comboRecipientType = new ComboBox();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Location = new Point(173, 19);
            label5.Name = "label5";
            label5.Size = new Size(3, 407);
            label5.TabIndex = 33;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label6.Location = new Point(12, 19);
            label6.Name = "label6";
            label6.Size = new Size(155, 96);
            label6.TabIndex = 32;
            label6.Text = "Elektroniczny\r\nSystem\r\nOceniania";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(182, 15);
            label1.Name = "label1";
            label1.Size = new Size(835, 37);
            label1.TabIndex = 34;
            label1.Text = "Wyślij wiadomość";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.Location = new Point(191, 103);
            label2.Name = "label2";
            label2.Size = new Size(94, 25);
            label2.TabIndex = 35;
            label2.Text = "Odbiorca:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.Location = new Point(203, 139);
            label3.Name = "label3";
            label3.Size = new Size(66, 25);
            label3.TabIndex = 36;
            label3.Text = "Temat:";
            // 
            // comboRecipient
            // 
            comboRecipient.DropDownStyle = ComboBoxStyle.DropDownList;
            comboRecipient.FormattingEnabled = true;
            comboRecipient.Location = new Point(291, 105);
            comboRecipient.Name = "comboRecipient";
            comboRecipient.Size = new Size(726, 23);
            comboRecipient.TabIndex = 37;
            comboRecipient.DropDown += comboRecipient_DropDown;
            // 
            // txtMsgSubject
            // 
            txtMsgSubject.Location = new Point(291, 141);
            txtMsgSubject.Name = "txtMsgSubject";
            txtMsgSubject.Size = new Size(726, 23);
            txtMsgSubject.TabIndex = 38;
            txtMsgSubject.KeyPress += txtMsgSubject_KeyPress;
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(191, 173);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.ScrollBars = ScrollBars.Vertical;
            txtMessage.Size = new Size(826, 236);
            txtMessage.TabIndex = 39;
            txtMessage.Text = "Wpisz treść...";
            txtMessage.KeyPress += txtMessage_KeyPress;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(614, 415);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(75, 23);
            btnSend.TabIndex = 69;
            btnSend.Text = "Wyślij";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(501, 415);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 68;
            btnCancel.Text = "Anuluj";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // comboRecipientType
            // 
            comboRecipientType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboRecipientType.FormattingEnabled = true;
            comboRecipientType.Items.AddRange(new object[] { "Uczeń", "Rodzic" });
            comboRecipientType.Location = new Point(291, 70);
            comboRecipientType.Name = "comboRecipientType";
            comboRecipientType.Size = new Size(726, 23);
            comboRecipientType.TabIndex = 71;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label4.Location = new Point(191, 68);
            label4.Name = "label4";
            label4.Size = new Size(87, 25);
            label4.TabIndex = 70;
            label4.Text = "Do kogo:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.notebook_freepik;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(36, 148);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.TabIndex = 72;
            pictureBox1.TabStop = false;
            // 
            // SendMessage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 450);
            Controls.Add(pictureBox1);
            Controls.Add(comboRecipientType);
            Controls.Add(label4);
            Controls.Add(btnSend);
            Controls.Add(btnCancel);
            Controls.Add(txtMessage);
            Controls.Add(txtMsgSubject);
            Controls.Add(comboRecipient);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(label6);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SendMessage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "e-Szkoła";
            FormClosing += btnX_Click;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label6;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboRecipient;
        private TextBox txtMsgSubject;
        private TextBox txtMessage;
        private Button btnSend;
        private Button btnCancel;
        private ComboBox comboRecipientType;
        private Label label4;
        private PictureBox pictureBox1;
    }
}