namespace eSzkola
{
    partial class AddBehaviourNote
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
            comboChooseStudent = new ComboBox();
            label1 = new Label();
            comboChooseClass = new ComboBox();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtBehaviourNote = new TextBox();
            btnApply = new Button();
            btnCancel = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Location = new Point(173, 22);
            label5.Name = "label5";
            label5.Size = new Size(3, 407);
            label5.TabIndex = 31;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label6.Location = new Point(12, 22);
            label6.Name = "label6";
            label6.Size = new Size(155, 96);
            label6.TabIndex = 30;
            label6.Text = "Elektroniczny\r\nSystem\r\nOceniania";
            // 
            // comboChooseStudent
            // 
            comboChooseStudent.DropDownStyle = ComboBoxStyle.DropDownList;
            comboChooseStudent.FormattingEnabled = true;
            comboChooseStudent.Location = new Point(266, 238);
            comboChooseStudent.Name = "comboChooseStudent";
            comboChooseStudent.Size = new Size(227, 23);
            comboChooseStudent.TabIndex = 35;
            comboChooseStudent.DropDown += comboChooseStudent_DropDown;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(266, 210);
            label1.Name = "label1";
            label1.Size = new Size(227, 25);
            label1.TabIndex = 34;
            label1.Text = "Wybierz ucznia:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboChooseClass
            // 
            comboChooseClass.DropDownStyle = ComboBoxStyle.DropDownList;
            comboChooseClass.FormattingEnabled = true;
            comboChooseClass.Location = new Point(266, 95);
            comboChooseClass.Name = "comboChooseClass";
            comboChooseClass.Size = new Size(227, 23);
            comboChooseClass.TabIndex = 33;
            comboChooseClass.DropDown += comboChooseClass_DropDown;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label4.Location = new Point(266, 67);
            label4.Name = "label4";
            label4.Size = new Size(227, 25);
            label4.TabIndex = 32;
            label4.Text = "Wybierz klasę:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.Location = new Point(184, 9);
            label2.Name = "label2";
            label2.Size = new Size(833, 37);
            label2.TabIndex = 38;
            label2.Text = "Wstaw uwagę";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.Location = new Point(525, 59);
            label3.Name = "label3";
            label3.Size = new Size(114, 25);
            label3.TabIndex = 40;
            label3.Text = "Treść uwagi:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtBehaviourNote
            // 
            txtBehaviourNote.Location = new Point(525, 87);
            txtBehaviourNote.Multiline = true;
            txtBehaviourNote.Name = "txtBehaviourNote";
            txtBehaviourNote.Size = new Size(431, 302);
            txtBehaviourNote.TabIndex = 41;
            txtBehaviourNote.KeyPress += txtBehaviourNote_KeyPress;
            // 
            // btnApply
            // 
            btnApply.Location = new Point(606, 415);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(75, 23);
            btnApply.TabIndex = 43;
            btnApply.Text = "Zatwierdź";
            btnApply.UseVisualStyleBackColor = true;
            btnApply.Click += btnApply_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(493, 415);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 42;
            btnCancel.Text = "Anuluj";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.notebook_freepik;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(31, 161);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.TabIndex = 44;
            pictureBox1.TabStop = false;
            // 
            // AddBehaviourNote
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 450);
            Controls.Add(pictureBox1);
            Controls.Add(btnApply);
            Controls.Add(btnCancel);
            Controls.Add(txtBehaviourNote);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboChooseStudent);
            Controls.Add(label1);
            Controls.Add(comboChooseClass);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddBehaviourNote";
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
        private ComboBox comboChooseStudent;
        private Label label1;
        private ComboBox comboChooseClass;
        private Label label4;
        private Label label2;
        private Label label3;
        private TextBox txtBehaviourNote;
        private Button btnApply;
        private Button btnCancel;
        private PictureBox pictureBox1;
    }
}