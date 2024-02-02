namespace eSzkola
{
    partial class AddNewTest
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
            txtTestDescription = new TextBox();
            btnApply = new Button();
            btnCancel = new Button();
            calendarTestDate = new MonthCalendar();
            label2 = new Label();
            label7 = new Label();
            label1 = new Label();
            comboChooseClass = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            comboTestType = new ComboBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtTestDescription
            // 
            txtTestDescription.Location = new Point(204, 244);
            txtTestDescription.Multiline = true;
            txtTestDescription.Name = "txtTestDescription";
            txtTestDescription.Size = new Size(227, 78);
            txtTestDescription.TabIndex = 68;
            // 
            // btnApply
            // 
            btnApply.Location = new Point(335, 556);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(75, 23);
            btnApply.TabIndex = 67;
            btnApply.Text = "Zatwierdź";
            btnApply.UseVisualStyleBackColor = true;
            btnApply.Click += btnApply_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(222, 556);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 66;
            btnCancel.Text = "Anuluj";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // calendarTestDate
            // 
            calendarTestDate.Location = new Point(204, 370);
            calendarTestDate.MaxSelectionCount = 1;
            calendarTestDate.Name = "calendarTestDate";
            calendarTestDate.TabIndex = 65;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.Location = new Point(234, 7);
            label2.Name = "label2";
            label2.Size = new Size(176, 37);
            label2.TabIndex = 64;
            label2.Text = "Zaplanuj test:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label7.Location = new Point(215, 342);
            label7.Name = "label7";
            label7.Size = new Size(206, 25);
            label7.TabIndex = 63;
            label7.Text = "Data przeprowadzenia:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(244, 215);
            label1.Name = "label1";
            label1.Size = new Size(156, 25);
            label1.TabIndex = 62;
            label1.Text = "Zakres materiału:";
            // 
            // comboChooseClass
            // 
            comboChooseClass.DropDownStyle = ComboBoxStyle.DropDownList;
            comboChooseClass.FormattingEnabled = true;
            comboChooseClass.Location = new Point(204, 95);
            comboChooseClass.Name = "comboChooseClass";
            comboChooseClass.Size = new Size(227, 23);
            comboChooseClass.TabIndex = 61;
            comboChooseClass.DropDown += comboChooseClass_DropDown;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label4.Location = new Point(250, 67);
            label4.Name = "label4";
            label4.Size = new Size(132, 25);
            label4.TabIndex = 60;
            label4.Text = "Wybierz klasę:";
            // 
            // label5
            // 
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Location = new Point(173, 22);
            label5.Name = "label5";
            label5.Size = new Size(3, 570);
            label5.TabIndex = 59;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label6.Location = new Point(12, 22);
            label6.Name = "label6";
            label6.Size = new Size(155, 96);
            label6.TabIndex = 58;
            label6.Text = "Elektroniczny\r\nSystem\r\nOceniania";
            // 
            // comboTestType
            // 
            comboTestType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboTestType.FormattingEnabled = true;
            comboTestType.Items.AddRange(new object[] { "Kartkówka", "Sprawdzian", "Odpowiedź ustna" });
            comboTestType.Location = new Point(204, 167);
            comboTestType.Name = "comboTestType";
            comboTestType.Size = new Size(227, 23);
            comboTestType.TabIndex = 70;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.Location = new Point(259, 139);
            label3.Name = "label3";
            label3.Size = new Size(118, 25);
            label3.TabIndex = 69;
            label3.Text = "Rodzaj testu:";
            // 
            // AddNewTest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 616);
            Controls.Add(comboTestType);
            Controls.Add(label3);
            Controls.Add(txtTestDescription);
            Controls.Add(btnApply);
            Controls.Add(btnCancel);
            Controls.Add(calendarTestDate);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(comboChooseClass);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddNewTest";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "e-Szkoła";
            FormClosing += btnX_Click;
            Load += AddNewTest_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTestDescription;
        private Button btnApply;
        private Button btnCancel;
        private MonthCalendar calendarTestDate;
        private Label label2;
        private Label label7;
        private Label label1;
        private ComboBox comboChooseClass;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox comboTestType;
        private Label label3;
    }
}