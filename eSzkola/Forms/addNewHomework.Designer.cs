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
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnApply
            // 
            btnApply.Location = new Point(617, 422);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(75, 23);
            btnApply.TabIndex = 56;
            btnApply.Text = "Zatwierdź";
            btnApply.UseVisualStyleBackColor = true;
            btnApply.Click += btnApply_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(504, 422);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 55;
            btnCancel.Text = "Anuluj";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // calendarHomeworkDeadline
            // 
            calendarHomeworkDeadline.Location = new Point(669, 139);
            calendarHomeworkDeadline.MaxSelectionCount = 1;
            calendarHomeworkDeadline.MinDate = new DateTime(2024, 2, 2, 0, 0, 0, 0);
            calendarHomeworkDeadline.Name = "calendarHomeworkDeadline";
            calendarHomeworkDeadline.TabIndex = 52;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.Location = new Point(184, 7);
            label2.Name = "label2";
            label2.Size = new Size(833, 37);
            label2.TabIndex = 51;
            label2.Text = "Dodaj zadanie domowe";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label7.Location = new Point(669, 111);
            label7.Name = "label7";
            label7.Size = new Size(227, 25);
            label7.TabIndex = 50;
            label7.Text = "Data wykonania:";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(311, 202);
            label1.Name = "label1";
            label1.Size = new Size(227, 25);
            label1.TabIndex = 48;
            label1.Text = "Opis zadania:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboChooseLesson
            // 
            comboChooseLesson.DropDownStyle = ComboBoxStyle.DropDownList;
            comboChooseLesson.FormattingEnabled = true;
            comboChooseLesson.Location = new Point(311, 118);
            comboChooseLesson.Name = "comboChooseLesson";
            comboChooseLesson.Size = new Size(227, 23);
            comboChooseLesson.TabIndex = 47;
            comboChooseLesson.DropDown += comboChooseLesson_DropDown;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label4.Location = new Point(311, 90);
            label4.Name = "label4";
            label4.Size = new Size(227, 25);
            label4.TabIndex = 46;
            label4.Text = "Wybierz lekcję:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
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
            txtHomeworkDescription.Location = new Point(311, 230);
            txtHomeworkDescription.Multiline = true;
            txtHomeworkDescription.Name = "txtHomeworkDescription";
            txtHomeworkDescription.Size = new Size(227, 114);
            txtHomeworkDescription.TabIndex = 57;
            txtHomeworkDescription.KeyPress += txtHomeworkDescription_KeyPress;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.notebook_freepik;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(33, 157);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.TabIndex = 58;
            pictureBox1.TabStop = false;
            // 
            // AddNewHomework
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 450);
            Controls.Add(pictureBox1);
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
            Load += AddNewHomework_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
    }
}