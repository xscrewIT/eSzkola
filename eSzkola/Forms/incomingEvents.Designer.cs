namespace eSzkola
{
    partial class IncomingEvents
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
            label7 = new Label();
            label5 = new Label();
            label6 = new Label();
            dataGridIncomingHomework = new DataGridView();
            btnApply = new Button();
            btnCancel = new Button();
            dataGridIncomingTest = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridIncomingHomework).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridIncomingTest).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label7.Location = new Point(183, 16);
            label7.Name = "label7";
            label7.Size = new Size(838, 37);
            label7.TabIndex = 38;
            label7.Text = "Nadchodzące wydarzenia:";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Location = new Point(173, 20);
            label5.Name = "label5";
            label5.Size = new Size(3, 407);
            label5.TabIndex = 37;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label6.Location = new Point(12, 20);
            label6.Name = "label6";
            label6.Size = new Size(155, 96);
            label6.TabIndex = 36;
            label6.Text = "Elektroniczny\r\nSystem\r\nOceniania";
            // 
            // dataGridIncomingHomework
            // 
            dataGridIncomingHomework.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridIncomingHomework.Location = new Point(182, 100);
            dataGridIncomingHomework.Name = "dataGridIncomingHomework";
            dataGridIncomingHomework.ReadOnly = true;
            dataGridIncomingHomework.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridIncomingHomework.Size = new Size(416, 294);
            dataGridIncomingHomework.TabIndex = 35;
            // 
            // btnApply
            // 
            btnApply.Location = new Point(621, 404);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(75, 23);
            btnApply.TabIndex = 40;
            btnApply.Text = "Zatwierdź";
            btnApply.UseVisualStyleBackColor = true;
            btnApply.Click += btnApply_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(508, 404);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 39;
            btnCancel.Text = "Anuluj";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // dataGridIncomingTest
            // 
            dataGridIncomingTest.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridIncomingTest.Location = new Point(604, 100);
            dataGridIncomingTest.Name = "dataGridIncomingTest";
            dataGridIncomingTest.ReadOnly = true;
            dataGridIncomingTest.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridIncomingTest.Size = new Size(416, 294);
            dataGridIncomingTest.TabIndex = 41;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(182, 72);
            label1.Name = "label1";
            label1.Size = new Size(416, 19);
            label1.TabIndex = 42;
            label1.Text = "Zadania domowe:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(604, 72);
            label2.Name = "label2";
            label2.Size = new Size(416, 19);
            label2.TabIndex = 43;
            label2.Text = "Egzaminy:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // IncomingEvents
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridIncomingTest);
            Controls.Add(btnApply);
            Controls.Add(btnCancel);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(dataGridIncomingHomework);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "IncomingEvents";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "e-Szkoła";
            FormClosing += btnX_Click;
            Load += IncomingEvents_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridIncomingHomework).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridIncomingTest).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Label label5;
        private Label label6;
        private DataGridView dataGridIncomingHomework;
        private Button btnApply;
        private Button btnCancel;
        private DataGridView dataGridIncomingTest;
        private Label label1;
        private Label label2;
    }
}