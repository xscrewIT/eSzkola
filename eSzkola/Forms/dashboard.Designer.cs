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
            btnPresenceRaports = new Button();
            btnIncommingEvents = new Button();
            lblCurrentDate = new Label();
            btnCreateTest = new Button();
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
            btnCreateLesson.Location = new Point(207, 92);
            btnCreateLesson.Name = "btnCreateLesson";
            btnCreateLesson.Size = new Size(112, 23);
            btnCreateLesson.TabIndex = 6;
            btnCreateLesson.Text = "Stwórz lekcję";
            btnCreateLesson.UseVisualStyleBackColor = true;
            btnCreateLesson.Click += btnCreateLesson_Click;
            // 
            // btnCheckPresence
            // 
            btnCheckPresence.Location = new Point(342, 92);
            btnCheckPresence.Name = "btnCheckPresence";
            btnCheckPresence.Size = new Size(136, 23);
            btnCheckPresence.TabIndex = 7;
            btnCheckPresence.Text = "Sprawdź frekwencję";
            btnCheckPresence.UseVisualStyleBackColor = true;
            btnCheckPresence.Click += btnCheckPresence_Click;
            // 
            // btnCheckGrades
            // 
            btnCheckGrades.Location = new Point(494, 92);
            btnCheckGrades.Name = "btnCheckGrades";
            btnCheckGrades.Size = new Size(112, 23);
            btnCheckGrades.TabIndex = 8;
            btnCheckGrades.Text = "Oceny";
            btnCheckGrades.UseVisualStyleBackColor = true;
            btnCheckGrades.Click += btnCheckGrades_Click;
            // 
            // btnSentMessage
            // 
            btnSentMessage.Location = new Point(207, 216);
            btnSentMessage.Name = "btnSentMessage";
            btnSentMessage.Size = new Size(112, 23);
            btnSentMessage.TabIndex = 11;
            btnSentMessage.Text = "Wyślij wiadomość";
            btnSentMessage.UseVisualStyleBackColor = true;
            btnSentMessage.Click += btnSentMessage_Click;
            // 
            // btnCreateHomeWork
            // 
            btnCreateHomeWork.Location = new Point(207, 156);
            btnCreateHomeWork.Name = "btnCreateHomeWork";
            btnCreateHomeWork.Size = new Size(160, 23);
            btnCreateHomeWork.TabIndex = 10;
            btnCreateHomeWork.Text = "Dodaj zadanie domowe";
            btnCreateHomeWork.UseVisualStyleBackColor = true;
            btnCreateHomeWork.Click += btnCreateHomeWork_Click;
            // 
            // btnInsertNote
            // 
            btnInsertNote.Location = new Point(628, 92);
            btnInsertNote.Name = "btnInsertNote";
            btnInsertNote.Size = new Size(112, 23);
            btnInsertNote.TabIndex = 9;
            btnInsertNote.Text = "Wstaw uwagę";
            btnInsertNote.UseVisualStyleBackColor = true;
            btnInsertNote.Click += btnInsertNote_Click;
            // 
            // btnPresenceRaports
            // 
            btnPresenceRaports.Location = new Point(333, 216);
            btnPresenceRaports.Name = "btnPresenceRaports";
            btnPresenceRaports.Size = new Size(145, 23);
            btnPresenceRaports.TabIndex = 14;
            btnPresenceRaports.Text = "Raporty obecności";
            btnPresenceRaports.UseVisualStyleBackColor = true;
            btnPresenceRaports.Click += btnPresenceRaports_Click;
            // 
            // btnIncommingEvents
            // 
            btnIncommingEvents.Location = new Point(558, 156);
            btnIncommingEvents.Name = "btnIncommingEvents";
            btnIncommingEvents.Size = new Size(182, 23);
            btnIncommingEvents.TabIndex = 13;
            btnIncommingEvents.Text = "Zbliżające się wydarzenia";
            btnIncommingEvents.UseVisualStyleBackColor = true;
            btnIncommingEvents.Click += btnIncommingEvents_Click;
            // 
            // lblCurrentDate
            // 
            lblCurrentDate.AutoSize = true;
            lblCurrentDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblCurrentDate.Location = new Point(700, 420);
            lblCurrentDate.Name = "lblCurrentDate";
            lblCurrentDate.Size = new Size(88, 21);
            lblCurrentDate.TabIndex = 15;
            lblCurrentDate.Text = "05.09.2023";
            // 
            // btnCreateTest
            // 
            btnCreateTest.Location = new Point(405, 156);
            btnCreateTest.Name = "btnCreateTest";
            btnCreateTest.Size = new Size(110, 23);
            btnCreateTest.TabIndex = 16;
            btnCreateTest.Text = "Zaplanuj test";
            btnCreateTest.UseVisualStyleBackColor = true;
            btnCreateTest.Click += btnCreateTest_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCreateTest);
            Controls.Add(lblCurrentDate);
            Controls.Add(btnPresenceRaports);
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
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "e-Szkoła";
            FormClosing += btnX_Click;
            Load += Dashboard_Load;
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
        private Button btnPresenceRaports;
        private Button btnIncommingEvents;
        private Label lblCurrentDate;
        private Button btnCreateTest;
    }
}