namespace eSzkola
{
    partial class ChangePresence
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePresence));
            dataGridPresence = new DataGridView();
            label1 = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            comboPresence = new ComboBox();
            txtAddNote = new TextBox();
            btnApply = new Button();
            btnCancel = new Button();
            label7 = new Label();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridPresence).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridPresence
            // 
            dataGridPresence.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPresence.Location = new Point(200, 61);
            dataGridPresence.MultiSelect = false;
            dataGridPresence.Name = "dataGridPresence";
            dataGridPresence.ReadOnly = true;
            dataGridPresence.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridPresence.Size = new Size(626, 294);
            dataGridPresence.TabIndex = 0;
            dataGridPresence.CellClick += dataGridPresence_CellClick;
            dataGridPresence.SelectionChanged += dataGridPresence_SelectionChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(202, 364);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 1;
            label1.Text = "Imię";
            // 
            // txtFirstName
            // 
            txtFirstName.Enabled = false;
            txtFirstName.Location = new Point(242, 361);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.ReadOnly = true;
            txtFirstName.Size = new Size(123, 23);
            txtFirstName.TabIndex = 2;
            // 
            // txtLastName
            // 
            txtLastName.Enabled = false;
            txtLastName.Location = new Point(443, 361);
            txtLastName.Name = "txtLastName";
            txtLastName.ReadOnly = true;
            txtLastName.Size = new Size(123, 23);
            txtLastName.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(380, 364);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "Nazwisko";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(782, 364);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 7;
            label3.Text = "Uwagi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(580, 364);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 5;
            label4.Text = "Obecność";
            // 
            // label5
            // 
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Location = new Point(173, 24);
            label5.Name = "label5";
            label5.Size = new Size(3, 407);
            label5.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label6.Location = new Point(12, 24);
            label6.Name = "label6";
            label6.Size = new Size(155, 96);
            label6.TabIndex = 9;
            label6.Text = "Elektroniczny\r\nSystem\r\nOceniania";
            // 
            // comboPresence
            // 
            comboPresence.DropDownStyle = ComboBoxStyle.DropDownList;
            comboPresence.FormattingEnabled = true;
            comboPresence.Items.AddRange(new object[] { "+", "x", "*", "s", "?" });
            comboPresence.Location = new Point(646, 361);
            comboPresence.Name = "comboPresence";
            comboPresence.Size = new Size(121, 23);
            comboPresence.TabIndex = 11;
            comboPresence.DropDownClosed += comboPresence_DropDownClosed;
            // 
            // txtAddNote
            // 
            txtAddNote.Location = new Point(825, 361);
            txtAddNote.Name = "txtAddNote";
            txtAddNote.Size = new Size(182, 23);
            txtAddNote.TabIndex = 12;
            txtAddNote.KeyPress += txtAddNote_KeyPress;
            txtAddNote.Leave += txtAddNote_Leave;
            // 
            // btnApply
            // 
            btnApply.Location = new Point(622, 415);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(75, 23);
            btnApply.TabIndex = 20;
            btnApply.Text = "Zatwierdź";
            btnApply.UseVisualStyleBackColor = true;
            btnApply.Click += btnApply_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(509, 415);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 19;
            btnCancel.Text = "Anuluj";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label7.Location = new Point(182, 9);
            label7.Name = "label7";
            label7.Size = new Size(835, 37);
            label7.TabIndex = 21;
            label7.Text = "Sprawdź frekwencję";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label8.Location = new Point(832, 173);
            label8.Name = "label8";
            label8.Size = new Size(185, 60);
            label8.TabIndex = 22;
            label8.Text = "+ - obecność\r\nx - nieobecność\r\n* - nieobecność usprawiedliwiona\r\ns - spoźnienie";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.notebook_freepik;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(35, 149);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // ChangePresence
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(btnApply);
            Controls.Add(btnCancel);
            Controls.Add(txtAddNote);
            Controls.Add(comboPresence);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(txtLastName);
            Controls.Add(label2);
            Controls.Add(txtFirstName);
            Controls.Add(label1);
            Controls.Add(dataGridPresence);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ChangePresence";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "e-Szkoła";
            FormClosing += btnX_Click;
            Load += ChangePresence_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridPresence).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridPresence;
        private Label label1;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox comboPresence;
        private TextBox txtAddNote;
        private Button btnApply;
        private Button btnCancel;
        private Label label7;
        private Label label8;
        private PictureBox pictureBox1;
    }
}