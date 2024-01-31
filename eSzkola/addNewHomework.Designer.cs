namespace eSzkola
{
    partial class AddNewHomework
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
            calendarHomeworkDeadline = new MonthCalendar();
            label2 = new Label();
            label7 = new Label();
            label1 = new Label();
            comboChooseLesson = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtHomeworkDescription = new TextBox();
            SuspendLayout();
            // 
            // btnApply
            // 
            btnApply.Location = new Point(362, 515);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(75, 23);
            btnApply.TabIndex = 56;
            btnApply.Text = "Zatwierdź";
            btnApply.UseVisualStyleBackColor = true;
            btnApply.Click += btnApply_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(249, 515);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 55;
            btnCancel.Text = "Anuluj";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // calendarHomeworkDeadline
            // 
            calendarHomeworkDeadline.Location = new Point(229, 331);
            calendarHomeworkDeadline.Name = "calendarHomeworkDeadline";
            calendarHomeworkDeadline.TabIndex = 52;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.Location = new Point(205, 7);
            label2.Name = "label2";
            label2.Size = new Size(306, 37);
            label2.TabIndex = 51;
            label2.Text = "Dodaj zadanie domowe:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label7.Location = new Point(267, 303);
            label7.Name = "label7";
            label7.Size = new Size(150, 25);
            label7.TabIndex = 50;
            label7.Text = "Data wykonania:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(279, 138);
            label1.Name = "label1";
            label1.Size = new Size(125, 25);
            label1.TabIndex = 48;
            label1.Text = "Opis zadania:";
            // 
            // comboChooseLesson
            // 
            comboChooseLesson.FormattingEnabled = true;
            comboChooseLesson.Location = new Point(233, 97);
            comboChooseLesson.Name = "comboChooseLesson";
            comboChooseLesson.Size = new Size(227, 23);
            comboChooseLesson.TabIndex = 47;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label4.Location = new Point(279, 69);
            label4.Name = "label4";
            label4.Size = new Size(138, 25);
            label4.TabIndex = 46;
            label4.Text = "Wybierz lekcję:";
            // 
            // label5
            // 
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Location = new Point(173, 21);
            label5.Name = "label5";
            label5.Size = new Size(3, 530);
            label5.TabIndex = 45;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label6.Location = new Point(12, 21);
            label6.Name = "label6";
            label6.Size = new Size(155, 96);
            label6.TabIndex = 44;
            label6.Text = "Elektroniczny\r\nSystem\r\nOceniania";
            // 
            // txtHomeworkDescription
            // 
            txtHomeworkDescription.Location = new Point(229, 166);
            txtHomeworkDescription.Multiline = true;
            txtHomeworkDescription.Name = "txtHomeworkDescription";
            txtHomeworkDescription.Size = new Size(227, 114);
            txtHomeworkDescription.TabIndex = 57;
            // 
            // AddNewHomework
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 573);
            Controls.Add(txtHomeworkDescription);
            Controls.Add(btnApply);
            Controls.Add(btnCancel);
            Controls.Add(calendarHomeworkDeadline);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(comboChooseLesson);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddNewHomework";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "e-Szkoła";
            FormClosing += btnX_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnApply;
        private Button btnCancel;
        private MonthCalendar calendarHomeworkDeadline;
        private Label label2;
        private Label label7;
        private Label label1;
        private ComboBox comboChooseLesson;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtHomeworkDescription;
    }
}