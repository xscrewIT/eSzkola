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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateLesson));
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboSchoolSubjects = new ComboBox();
            comboClass = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            txtSubject = new TextBox();
            btnCancel = new Button();
            btnApply = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.Location = new Point(182, 20);
            label3.Name = "label3";
            label3.Size = new Size(835, 37);
            label3.TabIndex = 5;
            label3.Text = "Stwórz lekcję";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label4.Location = new Point(396, 122);
            label4.Name = "label4";
            label4.Size = new Size(387, 25);
            label4.TabIndex = 6;
            label4.Text = "Przedmiot:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboSchoolSubjects
            // 
            comboSchoolSubjects.DropDownStyle = ComboBoxStyle.DropDownList;
            comboSchoolSubjects.FormattingEnabled = true;
            comboSchoolSubjects.Location = new Point(490, 150);
            comboSchoolSubjects.Name = "comboSchoolSubjects";
            comboSchoolSubjects.Size = new Size(197, 23);
            comboSchoolSubjects.TabIndex = 8;
            comboSchoolSubjects.DropDown += comboSchoolSubjects_DropDown;
            // 
            // comboClass
            // 
            comboClass.DropDownStyle = ComboBoxStyle.DropDownList;
            comboClass.FormattingEnabled = true;
            comboClass.Location = new Point(490, 221);
            comboClass.Name = "comboClass";
            comboClass.Size = new Size(197, 23);
            comboClass.TabIndex = 10;
            comboClass.DropDown += comboClass_DropDown;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label5.Location = new Point(396, 193);
            label5.Name = "label5";
            label5.Size = new Size(387, 25);
            label5.TabIndex = 9;
            label5.Text = "Klasa:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label6.Location = new Point(396, 264);
            label6.Name = "label6";
            label6.Size = new Size(387, 25);
            label6.TabIndex = 11;
            label6.Text = "Temat:";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtSubject
            // 
            txtSubject.Location = new Point(490, 292);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(197, 23);
            txtSubject.TabIndex = 12;
            txtSubject.KeyPress += txtSubject_KeyPress;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(499, 415);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Anuluj";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnApply
            // 
            btnApply.Location = new Point(612, 415);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(75, 23);
            btnApply.TabIndex = 16;
            btnApply.Text = "Zatwierdź";
            btnApply.UseVisualStyleBackColor = true;
            btnApply.Click += btnApply_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.notebook_freepik;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(32, 150);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // CreateLesson
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 450);
            Controls.Add(pictureBox1);
            Controls.Add(btnApply);
            Controls.Add(btnCancel);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CreateLesson";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "e-Szkoła";
            FormClosing += btnX_Click;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Button btnCancel;
        private Button btnApply;
        private PictureBox pictureBox1;
    }
}