namespace Praktikum_23_Mei_2022
{
    partial class Form1
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
            this.Btn_First = new System.Windows.Forms.Button();
            this.BtnPrevious = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.BtnLast = new System.Windows.Forms.Button();
            this.LblPlayerID = new System.Windows.Forms.Label();
            this.LblPlayerName = new System.Windows.Forms.Label();
            this.LblBirthDate = new System.Windows.Forms.Label();
            this.LblNationality = new System.Windows.Forms.Label();
            this.LblTeam = new System.Windows.Forms.Label();
            this.LblTeamNumber = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.TboxPlayerID = new System.Windows.Forms.TextBox();
            this.TboxPlayerName = new System.Windows.Forms.TextBox();
            this.DateTimeBirthdate = new System.Windows.Forms.DateTimePicker();
            this.CboxTeam = new System.Windows.Forms.ComboBox();
            this.NumUpDown = new System.Windows.Forms.NumericUpDown();
            this.CboxNationality = new System.Windows.Forms.ComboBox();
            this.LblAvailable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_First
            // 
            this.Btn_First.Location = new System.Drawing.Point(45, 30);
            this.Btn_First.Name = "Btn_First";
            this.Btn_First.Size = new System.Drawing.Size(75, 23);
            this.Btn_First.TabIndex = 0;
            this.Btn_First.Text = "<<";
            this.Btn_First.UseVisualStyleBackColor = true;
            this.Btn_First.Click += new System.EventHandler(this.Btn_First_Click);
            // 
            // BtnPrevious
            // 
            this.BtnPrevious.Location = new System.Drawing.Point(165, 30);
            this.BtnPrevious.Name = "BtnPrevious";
            this.BtnPrevious.Size = new System.Drawing.Size(75, 23);
            this.BtnPrevious.TabIndex = 1;
            this.BtnPrevious.Text = "<";
            this.BtnPrevious.UseVisualStyleBackColor = true;
            this.BtnPrevious.Click += new System.EventHandler(this.BtnPrevious_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.Location = new System.Drawing.Point(290, 30);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(75, 23);
            this.BtnNext.TabIndex = 2;
            this.BtnNext.Text = ">";
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // BtnLast
            // 
            this.BtnLast.Location = new System.Drawing.Point(414, 30);
            this.BtnLast.Name = "BtnLast";
            this.BtnLast.Size = new System.Drawing.Size(75, 23);
            this.BtnLast.TabIndex = 3;
            this.BtnLast.Text = ">>";
            this.BtnLast.UseVisualStyleBackColor = true;
            this.BtnLast.Click += new System.EventHandler(this.BtnLast_Click);
            // 
            // LblPlayerID
            // 
            this.LblPlayerID.AutoSize = true;
            this.LblPlayerID.Location = new System.Drawing.Point(42, 99);
            this.LblPlayerID.Name = "LblPlayerID";
            this.LblPlayerID.Size = new System.Drawing.Size(65, 16);
            this.LblPlayerID.TabIndex = 4;
            this.LblPlayerID.Text = " Player ID";
            // 
            // LblPlayerName
            // 
            this.LblPlayerName.AutoSize = true;
            this.LblPlayerName.Location = new System.Drawing.Point(42, 139);
            this.LblPlayerName.Name = "LblPlayerName";
            this.LblPlayerName.Size = new System.Drawing.Size(86, 16);
            this.LblPlayerName.TabIndex = 5;
            this.LblPlayerName.Text = "Player Name";
            // 
            // LblBirthDate
            // 
            this.LblBirthDate.AutoSize = true;
            this.LblBirthDate.Location = new System.Drawing.Point(42, 178);
            this.LblBirthDate.Name = "LblBirthDate";
            this.LblBirthDate.Size = new System.Drawing.Size(62, 16);
            this.LblBirthDate.TabIndex = 6;
            this.LblBirthDate.Text = "BirthDate";
            // 
            // LblNationality
            // 
            this.LblNationality.AutoSize = true;
            this.LblNationality.Location = new System.Drawing.Point(42, 219);
            this.LblNationality.Name = "LblNationality";
            this.LblNationality.Size = new System.Drawing.Size(70, 16);
            this.LblNationality.TabIndex = 7;
            this.LblNationality.Text = "Nationality";
            // 
            // LblTeam
            // 
            this.LblTeam.AutoSize = true;
            this.LblTeam.Location = new System.Drawing.Point(42, 265);
            this.LblTeam.Name = "LblTeam";
            this.LblTeam.Size = new System.Drawing.Size(43, 16);
            this.LblTeam.TabIndex = 8;
            this.LblTeam.Text = "Team";
            // 
            // LblTeamNumber
            // 
            this.LblTeamNumber.AutoSize = true;
            this.LblTeamNumber.Location = new System.Drawing.Point(42, 307);
            this.LblTeamNumber.Name = "LblTeamNumber";
            this.LblTeamNumber.Size = new System.Drawing.Size(94, 16);
            this.LblTeamNumber.TabIndex = 9;
            this.LblTeamNumber.Text = "Team Number";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(165, 365);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 10;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(290, 365);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 11;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // TboxPlayerID
            // 
            this.TboxPlayerID.Location = new System.Drawing.Point(165, 96);
            this.TboxPlayerID.Name = "TboxPlayerID";
            this.TboxPlayerID.Size = new System.Drawing.Size(148, 22);
            this.TboxPlayerID.TabIndex = 12;
            // 
            // TboxPlayerName
            // 
            this.TboxPlayerName.Location = new System.Drawing.Point(165, 133);
            this.TboxPlayerName.Name = "TboxPlayerName";
            this.TboxPlayerName.Size = new System.Drawing.Size(148, 22);
            this.TboxPlayerName.TabIndex = 13;
            // 
            // DateTimeBirthdate
            // 
            this.DateTimeBirthdate.CustomFormat = "dddd, MMMM, dd, yyyy";
            this.DateTimeBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimeBirthdate.Location = new System.Drawing.Point(165, 172);
            this.DateTimeBirthdate.Name = "DateTimeBirthdate";
            this.DateTimeBirthdate.Size = new System.Drawing.Size(283, 22);
            this.DateTimeBirthdate.TabIndex = 14;
            // 
            // CboxTeam
            // 
            this.CboxTeam.FormattingEnabled = true;
            this.CboxTeam.Location = new System.Drawing.Point(165, 257);
            this.CboxTeam.Name = "CboxTeam";
            this.CboxTeam.Size = new System.Drawing.Size(121, 24);
            this.CboxTeam.TabIndex = 18;
            // 
            // NumUpDown
            // 
            this.NumUpDown.Location = new System.Drawing.Point(166, 307);
            this.NumUpDown.Name = "NumUpDown";
            this.NumUpDown.Size = new System.Drawing.Size(120, 22);
            this.NumUpDown.TabIndex = 20;
            // 
            // CboxNationality
            // 
            this.CboxNationality.FormattingEnabled = true;
            this.CboxNationality.Location = new System.Drawing.Point(166, 216);
            this.CboxNationality.Name = "CboxNationality";
            this.CboxNationality.Size = new System.Drawing.Size(121, 24);
            this.CboxNationality.TabIndex = 21;
            // 
            // LblAvailable
            // 
            this.LblAvailable.AutoSize = true;
            this.LblAvailable.Location = new System.Drawing.Point(339, 313);
            this.LblAvailable.Name = "LblAvailable";
            this.LblAvailable.Size = new System.Drawing.Size(64, 16);
            this.LblAvailable.TabIndex = 22;
            this.LblAvailable.Text = "Available";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblAvailable);
            this.Controls.Add(this.CboxNationality);
            this.Controls.Add(this.NumUpDown);
            this.Controls.Add(this.CboxTeam);
            this.Controls.Add(this.DateTimeBirthdate);
            this.Controls.Add(this.TboxPlayerName);
            this.Controls.Add(this.TboxPlayerID);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.LblTeamNumber);
            this.Controls.Add(this.LblTeam);
            this.Controls.Add(this.LblNationality);
            this.Controls.Add(this.LblBirthDate);
            this.Controls.Add(this.LblPlayerName);
            this.Controls.Add(this.LblPlayerID);
            this.Controls.Add(this.BtnLast);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.BtnPrevious);
            this.Controls.Add(this.Btn_First);
            this.Name = "Form1";
            this.Text = "Player";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_First;
        private System.Windows.Forms.Button BtnPrevious;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Button BtnLast;
        private System.Windows.Forms.Label LblPlayerID;
        private System.Windows.Forms.Label LblPlayerName;
        private System.Windows.Forms.Label LblBirthDate;
        private System.Windows.Forms.Label LblNationality;
        private System.Windows.Forms.Label LblTeam;
        private System.Windows.Forms.Label LblTeamNumber;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.TextBox TboxPlayerID;
        private System.Windows.Forms.TextBox TboxPlayerName;
        private System.Windows.Forms.DateTimePicker DateTimeBirthdate;
        private System.Windows.Forms.ComboBox CboxTeam;
        private System.Windows.Forms.NumericUpDown NumUpDown;
        private System.Windows.Forms.ComboBox CboxNationality;
        private System.Windows.Forms.Label LblAvailable;
    }
}

