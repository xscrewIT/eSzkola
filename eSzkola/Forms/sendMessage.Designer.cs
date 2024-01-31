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
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(371, 15);
            label1.Name = "label1";
            label1.Size = new Size(235, 37);
            label1.TabIndex = 34;
            label1.Text = "Wyślij wiadomość:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.Location = new Point(182, 78);
            label2.Name = "label2";
            label2.Size = new Size(94, 25);
            label2.TabIndex = 35;
            label2.Text = "Odbiorca:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.Location = new Point(194, 116);
            label3.Name = "label3";
            label3.Size = new Size(66, 25);
            label3.TabIndex = 36;
            label3.Text = "Temat:";
            // 
            // comboRecipient
            // 
            comboRecipient.FormattingEnabled = true;
            comboRecipient.Location = new Point(282, 80);
            comboRecipient.Name = "comboRecipient";
            comboRecipient.Size = new Size(506, 23);
            comboRecipient.TabIndex = 37;
            // 
            // txtMsgSubject
            // 
            txtMsgSubject.Location = new Point(282, 118);
            txtMsgSubject.Name = "txtMsgSubject";
            txtMsgSubject.Size = new Size(506, 23);
            txtMsgSubject.TabIndex = 38;
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(182, 154);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(606, 252);
            txtMessage.TabIndex = 39;
            txtMessage.Text = "Wpisz treść...";
            // 
            // btnSend
            // 
            btnSend.Location = new Point(495, 415);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(75, 23);
            btnSend.TabIndex = 69;
            btnSend.Text = "Wyślij";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(382, 415);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 68;
            btnCancel.Text = "Anuluj";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // SendMessage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SendMessage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "e-Szkoła";
            FormClosing += btnX_Click;
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
    }
}