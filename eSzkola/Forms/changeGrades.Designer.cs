namespace eSzkola
{
    partial class ChangeGrades
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
            comboGrade = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            txtLastName = new TextBox();
            label2 = new Label();
            txtFirstName = new TextBox();
            label1 = new Label();
            dataGridGrades = new DataGridView();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridGrades).BeginInit();
            SuspendLayout();
            // 
            // btnApply
            // 
            btnApply.Location = new Point(615, 405);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(75, 23);
            btnApply.TabIndex = 33;
            btnApply.Text = "Zatwierdź";
            btnApply.UseVisualStyleBackColor = true;
            btnApply.Click += btnApply_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(502, 405);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 32;
            btnCancel.Text = "Anuluj";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // comboGrade
            // 
            comboGrade.DropDownStyle = ComboBoxStyle.DropDownList;
            comboGrade.FormattingEnabled = true;
            comboGrade.Items.AddRange(new object[] { "6", "5", "4", "3", "2", "1" });
            comboGrade.Location = new Point(768, 351);
            comboGrade.Name = "comboGrade";
            comboGrade.Size = new Size(121, 23);
            comboGrade.TabIndex = 30;
            comboGrade.DropDownClosed += comboGrade_DropDownClosed;
            // 
            // label5
            // 
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Location = new Point(173, 21);
            label5.Name = "label5";
            label5.Size = new Size(3, 407);
            label5.TabIndex = 29;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label6.Location = new Point(12, 21);
            label6.Name = "label6";
            label6.Size = new Size(155, 96);
            label6.TabIndex = 28;
            label6.Text = "Elektroniczny\r\nSystem\r\nOceniania";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(714, 354);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 26;
            label4.Text = "Ocena";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(565, 351);
            txtLastName.Name = "txtLastName";
            txtLastName.ReadOnly = true;
            txtLastName.Size = new Size(123, 23);
            txtLastName.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(502, 354);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 24;
            label2.Text = "Nazwisko";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(364, 351);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.ReadOnly = true;
            txtFirstName.Size = new Size(123, 23);
            txtFirstName.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(326, 354);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 22;
            label1.Text = "Imie";
            // 
            // dataGridGrades
            // 
            dataGridGrades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridGrades.Location = new Point(197, 51);
            dataGridGrades.MultiSelect = false;
            dataGridGrades.Name = "dataGridGrades";
            dataGridGrades.ReadOnly = true;
            dataGridGrades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridGrades.Size = new Size(807, 294);
            dataGridGrades.TabIndex = 21;
            dataGridGrades.CellClick += dataGridGrades_CellClick;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label7.Location = new Point(185, 9);
            label7.Name = "label7";
            label7.Size = new Size(835, 37);
            label7.TabIndex = 34;
            label7.Text = "Modyfikuj oceny:";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ChangeGrades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 450);
            Controls.Add(label7);
            Controls.Add(btnApply);
            Controls.Add(btnCancel);
            Controls.Add(comboGrade);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(txtLastName);
            Controls.Add(label2);
            Controls.Add(txtFirstName);
            Controls.Add(label1);
            Controls.Add(dataGridGrades);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ChangeGrades";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "e-Szkoła";
            FormClosing += btnX_Click;
            Load += ChangeGrades_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridGrades).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnApply;
        private Button btnCancel;
        private ComboBox comboGrade;
        private Label label5;
        private Label label6;
        private Label label4;
        private TextBox txtLastName;
        private Label label2;
        private TextBox txtFirstName;
        private Label label1;
        private DataGridView dataGridGrades;
        private Label label7;
    }
}