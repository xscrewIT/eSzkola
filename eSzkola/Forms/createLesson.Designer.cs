namespace eSzkola
{
    partial class CreateLesson
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
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboSchoolSubjects = new ComboBox();
            comboClass = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            txtSubject = new TextBox();
            label7 = new Label();
            btnCancel = new Button();
            btnApply = new Button();
            calendarCreateLesson = new MonthCalendar();
            SuspendLayout();
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Location = new Point(173, 20);
            label2.Name = "label2";
            label2.Size = new Size(3, 530);
            label2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(155, 96);
            label1.TabIndex = 3;
            label1.Text = "Elektroniczny\r\nSystem\r\nOceniania";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.Location = new Point(294, 20);
            label3.Name = "label3";
            label3.Size = new Size(176, 37);
            label3.TabIndex = 5;
            label3.Text = "Stwórz lekcję:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label4.Location = new Point(326, 79);
            label4.Name = "label4";
            label4.Size = new Size(102, 25);
            label4.TabIndex = 6;
            label4.Text = "Przedmiot:";
            // 
            // comboSchoolSubjects
            // 
            comboSchoolSubjects.FormattingEnabled = true;
            comboSchoolSubjects.Location = new Point(282, 107);
            comboSchoolSubjects.Name = "comboSchoolSubjects";
            comboSchoolSubjects.Size = new Size(197, 23);
            comboSchoolSubjects.TabIndex = 8;
            // 
            // comboClass
            // 
            comboClass.FormattingEnabled = true;
            comboClass.Location = new Point(282, 178);
            comboClass.Name = "comboClass";
            comboClass.Size = new Size(197, 23);
            comboClass.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label5.Location = new Point(343, 150);
            label5.Name = "label5";
            label5.Size = new Size(81, 25);
            label5.TabIndex = 9;
            label5.Text = "Oddział:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label6.Location = new Point(343, 221);
            label6.Name = "label6";
            label6.Size = new Size(66, 25);
            label6.TabIndex = 11;
            label6.Text = "Temat:";
            // 
            // txtSubject
            // 
            txtSubject.Location = new Point(282, 249);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(197, 23);
            txtSubject.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label7.Location = new Point(306, 299);
            label7.Name = "label7";
            label7.Size = new Size(154, 25);
            label7.TabIndex = 13;
            label7.Text = "Data utworzenia:";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(282, 522);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Anuluj";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnApply
            // 
            btnApply.Location = new Point(395, 522);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(75, 23);
            btnApply.TabIndex = 16;
            btnApply.Text = "Zatwierdź";
            btnApply.UseVisualStyleBackColor = true;
            btnApply.Click += btnApply_Click;
            // 
            // calendarCreateLesson
            // 
            calendarCreateLesson.Location = new Point(262, 333);
            calendarCreateLesson.Name = "calendarCreateLesson";
            calendarCreateLesson.TabIndex = 17;
            // 
            // CreateLesson
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 568);
            Controls.Add(calendarCreateLesson);
            Controls.Add(btnApply);
            Controls.Add(btnCancel);
            Controls.Add(label7);
            Controls.Add(txtSubject);
            Controls.Add(label6);
            Controls.Add(comboClass);
            Controls.Add(label5);
            Controls.Add(comboSchoolSubjects);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CreateLesson";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "e-Szkoła";
            FormClosing += btnX_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private ComboBox comboSchoolSubjects;
        private ComboBox comboClass;
        private Label label5;
        private Label label6;
        private TextBox txtSubject;
        private Label label7;
        private Button btnCancel;
        private Button btnApply;
        private MonthCalendar calendarCreateLesson;
    }
}