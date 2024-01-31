namespace eSzkola
{
    partial class PresenceRaports
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
            btnApply = new Button();
            btnCancel = new Button();
            label7 = new Label();
            label5 = new Label();
            label6 = new Label();
            dataGridIncomingEvents = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridIncomingEvents).BeginInit();
            SuspendLayout();
            // 
            // btnApply
            // 
            btnApply.Location = new Point(632, 405);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(75, 23);
            btnApply.TabIndex = 46;
            btnApply.Text = "Zatwierdź";
            btnApply.UseVisualStyleBackColor = true;
            btnApply.Click += btnApply_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(519, 405);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 45;
            btnCancel.Text = "Anuluj";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label7.Location = new Point(471, 17);
            label7.Name = "label7";
            label7.Size = new Size(242, 37);
            label7.TabIndex = 44;
            label7.Text = "Raporty obecności:";
            // 
            // label5
            // 
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Location = new Point(173, 21);
            label5.Name = "label5";
            label5.Size = new Size(3, 407);
            label5.TabIndex = 43;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label6.Location = new Point(12, 21);
            label6.Name = "label6";
            label6.Size = new Size(155, 96);
            label6.TabIndex = 42;
            label6.Text = "Elektroniczny\r\nSystem\r\nOceniania";
            // 
            // dataGridIncomingEvents
            // 
            dataGridIncomingEvents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridIncomingEvents.Location = new Point(199, 65);
            dataGridIncomingEvents.Name = "dataGridIncomingEvents";
            dataGridIncomingEvents.Size = new Size(807, 294);
            dataGridIncomingEvents.TabIndex = 41;
            // 
            // PresenceRaports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 450);
            Controls.Add(btnApply);
            Controls.Add(btnCancel);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(dataGridIncomingEvents);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PresenceRaports";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "e-Szkoła";
            FormClosing += btnX_Click;
            ((System.ComponentModel.ISupportInitialize)dataGridIncomingEvents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnApply;
        private Button btnCancel;
        private Label label7;
        private Label label5;
        private Label label6;
        private DataGridView dataGridIncomingEvents;
    }
}