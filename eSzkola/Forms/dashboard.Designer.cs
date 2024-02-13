namespace eSzkola
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblUserName = new Label();
            btnLogout = new Button();
            lblGreetings = new Label();
            btnCreateLesson = new Button();
            btnCheckPresence = new Button();
            btnCheckGrades = new Button();
            btnSentMessage = new Button();
            btnCreateHomeWork = new Button();
            btnInsertNote = new Button();
            btnIncommingEvents = new Button();
            lblCurrentDate = new Label();
            btnCreateTest = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox10 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(155, 96);
            label1.TabIndex = 0;
            label1.Text = "Elektroniczny\r\nSystem\r\nOceniania";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Location = new Point(173, 22);
            label2.Name = "label2";
            label2.Size = new Size(3, 407);
            label2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.Location = new Point(115, 159);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 2;
            label3.Text = "Kokpit";
            // 
            // lblUserName
            // 
            lblUserName.Location = new Point(28, 362);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(112, 15);
            lblUserName.TabIndex = 3;
            lblUserName.Text = "j.kowalski";
            lblUserName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(28, 389);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(112, 40);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Wyloguj";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblGreetings
            // 
            lblGreetings.AutoSize = true;
            lblGreetings.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblGreetings.Location = new Point(207, 28);
            lblGreetings.Name = "lblGreetings";
            lblGreetings.Size = new Size(171, 25);
            lblGreetings.TabIndex = 5;
            lblGreetings.Text = "Witaj, Jan Kowalski";
            // 
            // btnCreateLesson
            // 
            btnCreateLesson.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnCreateLesson.Location = new Point(247, 94);
            btnCreateLesson.Name = "btnCreateLesson";
            btnCreateLesson.Size = new Size(160, 61);
            btnCreateLesson.TabIndex = 6;
            btnCreateLesson.Text = "Stwórz lekcję";
            btnCreateLesson.UseVisualStyleBackColor = true;
            btnCreateLesson.Click += btnCreateLesson_Click;
            // 
            // btnCheckPresence
            // 
            btnCheckPresence.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnCheckPresence.Location = new Point(557, 94);
            btnCheckPresence.Name = "btnCheckPresence";
            btnCheckPresence.Size = new Size(160, 61);
            btnCheckPresence.TabIndex = 7;
            btnCheckPresence.Text = "Frekwencja";
            btnCheckPresence.UseVisualStyleBackColor = true;
            btnCheckPresence.Click += btnCheckPresence_Click;
            // 
            // btnCheckGrades
            // 
            btnCheckGrades.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnCheckGrades.Location = new Point(857, 94);
            btnCheckGrades.Name = "btnCheckGrades";
            btnCheckGrades.Size = new Size(160, 61);
            btnCheckGrades.TabIndex = 8;
            btnCheckGrades.Text = "Oceny";
            btnCheckGrades.UseVisualStyleBackColor = true;
            btnCheckGrades.Click += btnCheckGrades_Click;
            // 
            // btnSentMessage
            // 
            btnSentMessage.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnSentMessage.Location = new Point(557, 326);
            btnSentMessage.Name = "btnSentMessage";
            btnSentMessage.Size = new Size(160, 61);
            btnSentMessage.TabIndex = 11;
            btnSentMessage.Text = "Wyślij wiadomość";
            btnSentMessage.UseVisualStyleBackColor = true;
            btnSentMessage.Click += btnSentMessage_Click;
            // 
            // btnCreateHomeWork
            // 
            btnCreateHomeWork.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnCreateHomeWork.Location = new Point(247, 212);
            btnCreateHomeWork.Name = "btnCreateHomeWork";
            btnCreateHomeWork.Size = new Size(160, 61);
            btnCreateHomeWork.TabIndex = 10;
            btnCreateHomeWork.Text = "Dodaj zadanie domowe";
            btnCreateHomeWork.UseVisualStyleBackColor = true;
            btnCreateHomeWork.Click += btnCreateHomeWork_Click;
            // 
            // btnInsertNote
            // 
            btnInsertNote.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnInsertNote.Location = new Point(247, 326);
            btnInsertNote.Name = "btnInsertNote";
            btnInsertNote.Size = new Size(160, 61);
            btnInsertNote.TabIndex = 9;
            btnInsertNote.Text = "Wstaw uwagę";
            btnInsertNote.UseVisualStyleBackColor = true;
            btnInsertNote.Click += btnInsertNote_Click;
            // 
            // btnIncommingEvents
            // 
            btnIncommingEvents.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnIncommingEvents.Location = new Point(857, 326);
            btnIncommingEvents.Name = "btnIncommingEvents";
            btnIncommingEvents.Size = new Size(160, 61);
            btnIncommingEvents.TabIndex = 13;
            btnIncommingEvents.Text = "Zbliżające się wydarzenia";
            btnIncommingEvents.UseVisualStyleBackColor = true;
            btnIncommingEvents.Click += btnIncommingEvents_Click;
            // 
            // lblCurrentDate
            // 
            lblCurrentDate.AutoSize = true;
            lblCurrentDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblCurrentDate.Location = new Point(929, 420);
            lblCurrentDate.Name = "lblCurrentDate";
            lblCurrentDate.Size = new Size(88, 21);
            lblCurrentDate.TabIndex = 15;
            lblCurrentDate.Text = "05.09.2023";
            // 
            // btnCreateTest
            // 
            btnCreateTest.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnCreateTest.Location = new Point(557, 212);
            btnCreateTest.Name = "btnCreateTest";
            btnCreateTest.Size = new Size(160, 61);
            btnCreateTest.TabIndex = 16;
            btnCreateTest.Text = "Zaplanuj test";
            btnCreateTest.UseVisualStyleBackColor = true;
            btnCreateTest.Click += btnCreateTest_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.notebook_freepik;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(40, 216);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(177, 90);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(70, 70);
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(177, 207);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(70, 70);
            pictureBox3.TabIndex = 19;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(177, 323);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(70, 70);
            pictureBox4.TabIndex = 20;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.Location = new Point(487, 323);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(70, 70);
            pictureBox5.TabIndex = 23;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackgroundImage = (Image)resources.GetObject("pictureBox6.BackgroundImage");
            pictureBox6.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox6.Location = new Point(487, 207);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(70, 70);
            pictureBox6.TabIndex = 22;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.BackgroundImage = (Image)resources.GetObject("pictureBox7.BackgroundImage");
            pictureBox7.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox7.Location = new Point(487, 90);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(70, 70);
            pictureBox7.TabIndex = 21;
            pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.BackgroundImage = (Image)resources.GetObject("pictureBox8.BackgroundImage");
            pictureBox8.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox8.Location = new Point(787, 323);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(70, 70);
            pictureBox8.TabIndex = 26;
            pictureBox8.TabStop = false;
            // 
            // pictureBox10
            // 
            pictureBox10.BackgroundImage = (Image)resources.GetObject("pictureBox10.BackgroundImage");
            pictureBox10.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox10.Location = new Point(787, 90);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(70, 70);
            pictureBox10.TabIndex = 24;
            pictureBox10.TabStop = false;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 450);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox10);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnCreateTest);
            Controls.Add(lblCurrentDate);
            Controls.Add(btnIncommingEvents);
            Controls.Add(btnSentMessage);
            Controls.Add(btnCreateHomeWork);
            Controls.Add(btnInsertNote);
            Controls.Add(btnCheckGrades);
            Controls.Add(btnCheckPresence);
            Controls.Add(btnCreateLesson);
            Controls.Add(lblGreetings);
            Controls.Add(btnLogout);
            Controls.Add(lblUserName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "e-Szkoła";
            FormClosing += btnX_Click;
            Load += Dashboard_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblUserName;
        private Button btnLogout;
        private Label lblGreetings;
        private Button btnCreateLesson;
        private Button btnCheckPresence;
        private Button btnCheckGrades;
        private Button btnSentMessage;
        private Button btnCreateHomeWork;
        private Button btnInsertNote;
        private Button btnIncommingEvents;
        private Label lblCurrentDate;
        private Button btnCreateTest;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox10;
    }
}