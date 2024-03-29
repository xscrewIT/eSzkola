﻿namespace eSzkola
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckGrades));
            calendarLessons = new MonthCalendar();
            label5 = new Label();
            btnApply = new Button();
            btnCancel = new Button();
            comboChooseLesson = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // calendarLessons
            // 
            calendarLessons.Location = new Point(490, 107);
            calendarLessons.MaxSelectionCount = 1;
            calendarLessons.Name = "calendarLessons";
            calendarLessons.TabIndex = 29;
            calendarLessons.DateChanged += calendarLessons_DateChanged;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label5.Location = new Point(456, 68);
            label5.Name = "label5";
            label5.Size = new Size(294, 30);
            label5.TabIndex = 28;
            label5.Text = "Wskaż datę:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnApply
            // 
            btnApply.Location = new Point(615, 415);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(75, 23);
            btnApply.TabIndex = 27;
            btnApply.Text = "Zatwierdź";
            btnApply.UseVisualStyleBackColor = true;
            btnApply.Click += btnApply_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(502, 415);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 26;
            btnCancel.Text = "Anuluj";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // comboChooseLesson
            // 
            comboChooseLesson.DropDownStyle = ComboBoxStyle.DropDownList;
            comboChooseLesson.FormattingEnabled = true;
            comboChooseLesson.Location = new Point(494, 328);
            comboChooseLesson.Name = "comboChooseLesson";
            comboChooseLesson.Size = new Size(215, 23);
            comboChooseLesson.TabIndex = 25;
            comboChooseLesson.DropDown += comboChooseLesson_DropDown;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label4.Location = new Point(456, 282);
            label4.Name = "label4";
            label4.Size = new Size(294, 30);
            label4.TabIndex = 24;
            label4.Text = "Wybierz lekcję:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.Location = new Point(184, 5);
            label3.Name = "label3";
            label3.Size = new Size(833, 37);
            label3.TabIndex = 23;
            label3.Text = "Oceny";
            label3.TextAlign = ContentAlignment.MiddleCenter;
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
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.notebook_freepik;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(34, 141);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // CheckGrades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 450);
            Controls.Add(pictureBox1);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CheckGrades";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "e-Szkoła";
            FormClosing += btnX_Click;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
    }
}