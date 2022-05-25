namespace TSE_project
{
    partial class home
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
            this.Refresh = new System.Windows.Forms.Button();
            this.EntryButton = new System.Windows.Forms.Button();
            this.LogOut = new System.Windows.Forms.Button();
            this.EntryBox = new System.Windows.Forms.ListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.DiaryBox = new System.Windows.Forms.ListBox();
            this.LocationBox = new System.Windows.Forms.ListBox();
            this.ActivityBox = new System.Windows.Forms.ListBox();
            this.MoodBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(13, 365);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(75, 23);
            this.Refresh.TabIndex = 0;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // EntryButton
            // 
            this.EntryButton.Location = new System.Drawing.Point(94, 365);
            this.EntryButton.Name = "EntryButton";
            this.EntryButton.Size = new System.Drawing.Size(75, 23);
            this.EntryButton.TabIndex = 1;
            this.EntryButton.Text = "Add Entry";
            this.EntryButton.UseVisualStyleBackColor = true;
            this.EntryButton.Click += new System.EventHandler(this.EntryButton_Click);
            // 
            // LogOut
            // 
            this.LogOut.Location = new System.Drawing.Point(264, 365);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(75, 23);
            this.LogOut.TabIndex = 2;
            this.LogOut.Text = "Log Out";
            this.LogOut.UseVisualStyleBackColor = true;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // EntryBox
            // 
            this.EntryBox.FormattingEnabled = true;
            this.EntryBox.Location = new System.Drawing.Point(13, 40);
            this.EntryBox.Name = "EntryBox";
            this.EntryBox.Size = new System.Drawing.Size(120, 303);
            this.EntryBox.TabIndex = 3;
            this.EntryBox.SelectedIndexChanged += new System.EventHandler(this.EntryBox_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(139, 40);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.Value = new System.DateTime(2022, 5, 1, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // DiaryBox
            // 
            this.DiaryBox.FormattingEnabled = true;
            this.DiaryBox.Location = new System.Drawing.Point(139, 85);
            this.DiaryBox.Name = "DiaryBox";
            this.DiaryBox.Size = new System.Drawing.Size(200, 95);
            this.DiaryBox.TabIndex = 6;
            // 
            // LocationBox
            // 
            this.LocationBox.FormattingEnabled = true;
            this.LocationBox.Location = new System.Drawing.Point(139, 201);
            this.LocationBox.Name = "LocationBox";
            this.LocationBox.Size = new System.Drawing.Size(200, 30);
            this.LocationBox.TabIndex = 7;
            // 
            // ActivityBox
            // 
            this.ActivityBox.FormattingEnabled = true;
            this.ActivityBox.Location = new System.Drawing.Point(139, 252);
            this.ActivityBox.Name = "ActivityBox";
            this.ActivityBox.Size = new System.Drawing.Size(200, 30);
            this.ActivityBox.TabIndex = 8;
            // 
            // MoodBox
            // 
            this.MoodBox.FormattingEnabled = true;
            this.MoodBox.Location = new System.Drawing.Point(139, 303);
            this.MoodBox.Name = "MoodBox";
            this.MoodBox.Size = new System.Drawing.Size(200, 30);
            this.MoodBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "EntryTime:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(139, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Date Selection:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(139, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Diary Entry:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(139, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Location:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(139, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Activivty:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(139, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Mood:";
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 406);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MoodBox);
            this.Controls.Add(this.ActivityBox);
            this.Controls.Add(this.LocationBox);
            this.Controls.Add(this.DiaryBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.EntryBox);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.EntryButton);
            this.Controls.Add(this.Refresh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Button EntryButton;
        private System.Windows.Forms.Button LogOut;
        private System.Windows.Forms.ListBox EntryBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListBox DiaryBox;
        private System.Windows.Forms.ListBox LocationBox;
        private System.Windows.Forms.ListBox ActivityBox;
        private System.Windows.Forms.ListBox MoodBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}