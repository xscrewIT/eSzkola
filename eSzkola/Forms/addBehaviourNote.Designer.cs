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
            label7 = new Label();
            comboChooseStudent = new ComboBox();
            label1 = new Label();
            comboChooseClass = new ComboBox();
            label4 = new Label();
            label2 = new Label();
            calendarAddNoteDate = new MonthCalendar();
            label3 = new Label();
            txtBehaviourNote = new TextBox();
            btnApply = new Button();
            btnCancel = new Button();
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label7.Location = new Point(247, 198);
            label7.Name = "label7";
            label7.Size = new Size(109, 25);
            label7.TabIndex = 36;
            label7.Text = "Data wpisu:";
            // 
            // comboChooseStudent
            // 
            comboChooseStudent.DropDownStyle = ComboBoxStyle.DropDownList;
            comboChooseStudent.FormattingEnabled = true;
            comboChooseStudent.Location = new Point(188, 161);
            comboChooseStudent.Name = "comboChooseStudent";
            comboChooseStudent.Size = new Size(227, 23);
            comboChooseStudent.TabIndex = 35;
            comboChooseStudent.DropDown += comboChooseStudent_DropDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(234, 133);
            label1.Name = "label1";
            label1.Size = new Size(145, 25);
            label1.TabIndex = 34;
            label1.Text = "Wybierz ucznia:";
            // 
            // comboChooseClass
            // 
            comboChooseClass.DropDownStyle = ComboBoxStyle.DropDownList;
            comboChooseClass.FormattingEnabled = true;
            comboChooseClass.Location = new Point(188, 90);
            comboChooseClass.Name = "comboChooseClass";
            comboChooseClass.Size = new Size(227, 23);
            comboChooseClass.TabIndex = 33;
            comboChooseClass.DropDown += comboChooseClass_DropDown;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label4.Location = new Point(234, 62);
            label4.Name = "label4";
            label4.Size = new Size(132, 25);
            label4.TabIndex = 32;
            label4.Text = "Wybierz klasę:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.Location = new Point(399, 9);
            label2.Name = "label2";
            label2.Size = new Size(188, 37);
            label2.TabIndex = 38;
            label2.Text = "Wstaw uwagę:";
            // 
            // calendarAddNoteDate
            // 
            calendarAddNoteDate.Location = new Point(188, 230);
            calendarAddNoteDate.MaxSelectionCount = 1;
            calendarAddNoteDate.Name = "calendarAddNoteDate";
            calendarAddNoteDate.TabIndex = 39;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.Location = new Point(453, 62);
            label3.Name = "label3";
            label3.Size = new Size(114, 25);
            label3.TabIndex = 40;
            label3.Text = "Treść uwagi:";
            // 
            // txtBehaviourNote
            // 
            txtBehaviourNote.Location = new Point(453, 90);
            txtBehaviourNote.Multiline = true;
            txtBehaviourNote.Name = "txtBehaviourNote";
            txtBehaviourNote.Size = new Size(335, 302);
            txtBehaviourNote.TabIndex = 41;
            // 
            // btnApply
            // 
            btnApply.Location = new Point(492, 415);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(75, 23);
            btnApply.TabIndex = 43;
            btnApply.Text = "Zatwierdź";
            btnApply.UseVisualStyleBackColor = true;
            btnApply.Click += btnApply_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(379, 415);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 42;
            btnCancel.Text = "Anuluj";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // AddBehaviourNote
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnApply);
            Controls.Add(btnCancel);
            Controls.Add(txtBehaviourNote);
            Controls.Add(label3);
            Controls.Add(calendarAddNoteDate);
            Controls.Add(label2);
            Controls.Add(label7);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox comboChooseStudent;
        private Label label1;
        private ComboBox comboChooseClass;
        private Label label4;
        private Label label2;
        private MonthCalendar calendarAddNoteDate;
        private Label label3;
        private TextBox txtBehaviourNote;
        private Button btnApply;
        private Button btnCancel;
    }
}