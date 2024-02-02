namespace eSzkola
{
    partial class CheckGrades
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
            calendarLessons = new MonthCalendar();
            label5 = new Label();
            btnApply = new Button();
            btnCancel = new Button();
            comboChooseLesson = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // calendarLessons
            // 
            calendarLessons.Location = new Point(221, 100);
            calendarLessons.Name = "calendarLessons";
            calendarLessons.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label5.Location = new Point(261, 61);
            label5.Name = "label5";
            label5.Size = new Size(125, 30);
            label5.TabIndex = 28;
            label5.Text = "Wskaż datę:";
            // 
            // btnApply
            // 
            btnApply.Location = new Point(337, 408);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(75, 23);
            btnApply.TabIndex = 27;
            btnApply.Text = "Zatwierdź";
            btnApply.UseVisualStyleBackColor = true;
            btnApply.Click += btnApply_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(224, 408);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 26;
            btnCancel.Text = "Anuluj";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // comboChooseLesson
            // 
            comboChooseLesson.FormattingEnabled = true;
            comboChooseLesson.Location = new Point(225, 321);
            comboChooseLesson.Name = "comboChooseLesson";
            comboChooseLesson.Size = new Size(215, 23);
            comboChooseLesson.TabIndex = 25;
            comboChooseLesson.DropDown += comboChooseLesson_DropDown;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label4.Location = new Point(255, 275);
            label4.Name = "label4";
            label4.Size = new Size(151, 30);
            label4.TabIndex = 24;
            label4.Text = "Wybierz lekcję:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.Location = new Point(278, 5);
            label3.Name = "label3";
            label3.Size = new Size(97, 37);
            label3.TabIndex = 23;
            label3.Text = "Oceny:";
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Location = new Point(173, 18);
            label2.Name = "label2";
            label2.Size = new Size(3, 407);
            label2.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(155, 96);
            label1.TabIndex = 21;
            label1.Text = "Elektroniczny\r\nSystem\r\nOceniania";
            // 
            // CheckGrades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 450);
            Controls.Add(calendarLessons);
            Controls.Add(label5);
            Controls.Add(btnApply);
            Controls.Add(btnCancel);
            Controls.Add(comboChooseLesson);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CheckGrades";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "e-Szkoła";
            FormClosing += btnX_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar calendarLessons;
        private Label label5;
        private Button btnApply;
        private Button btnCancel;
        private ComboBox comboChooseLesson;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}