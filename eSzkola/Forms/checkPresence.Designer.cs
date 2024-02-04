namespace eSzkola
{
    partial class CheckPresence
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
            comboChooseLesson = new ComboBox();
            btnApply = new Button();
            btnCancel = new Button();
            label5 = new Label();
            calendarLessons = new MonthCalendar();
            SuspendLayout();
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Location = new Point(173, 18);
            label2.Name = "label2";
            label2.Size = new Size(3, 440);
            label2.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(155, 96);
            label1.TabIndex = 5;
            label1.Text = "Elektroniczny\r\nSystem\r\nOceniania";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.Location = new Point(182, 14);
            label3.Name = "label3";
            label3.Size = new Size(310, 37);
            label3.TabIndex = 7;
            label3.Text = "Obecność:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label4.Location = new Point(182, 284);
            label4.Name = "label4";
            label4.Size = new Size(310, 30);
            label4.TabIndex = 8;
            label4.Text = "Wybierz lekcję:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboChooseLesson
            // 
            comboChooseLesson.DropDownStyle = ComboBoxStyle.DropDownList;
            comboChooseLesson.FormattingEnabled = true;
            comboChooseLesson.Location = new Point(225, 330);
            comboChooseLesson.Name = "comboChooseLesson";
            comboChooseLesson.Size = new Size(215, 23);
            comboChooseLesson.TabIndex = 9;
            comboChooseLesson.DropDown += comboChooseLesson_DropDown;
            // 
            // btnApply
            // 
            btnApply.Location = new Point(349, 417);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(75, 23);
            btnApply.TabIndex = 18;
            btnApply.Text = "Zatwierdź";
            btnApply.UseVisualStyleBackColor = true;
            btnApply.Click += btnApply_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(236, 417);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 17;
            btnCancel.Text = "Anuluj";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label5.Location = new Point(182, 70);
            label5.Name = "label5";
            label5.Size = new Size(310, 30);
            label5.TabIndex = 19;
            label5.Text = "Wskaż datę:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // calendarLessons
            // 
            calendarLessons.Location = new Point(221, 109);
            calendarLessons.MaxSelectionCount = 1;
            calendarLessons.Name = "calendarLessons";
            calendarLessons.TabIndex = 20;
            // 
            // CheckPresence
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 475);
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
            Name = "CheckPresence";
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
        private ComboBox comboChooseLesson;
        private Button btnApply;
        private Button btnCancel;
        private Label label5;
        private MonthCalendar calendarLessons;
    }
}