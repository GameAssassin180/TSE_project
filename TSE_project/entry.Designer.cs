namespace TSE_project
{
    partial class entry
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
            this.MoodDrop = new System.Windows.Forms.ComboBox();
            this.LocationDrop = new System.Windows.Forms.ComboBox();
            this.ActivityDrop = new System.Windows.Forms.ComboBox();
            this.DiaryTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MoodDrop
            // 
            this.MoodDrop.FormattingEnabled = true;
            this.MoodDrop.Location = new System.Drawing.Point(12, 185);
            this.MoodDrop.Name = "MoodDrop";
            this.MoodDrop.Size = new System.Drawing.Size(119, 21);
            this.MoodDrop.TabIndex = 0;
            // 
            // LocationDrop
            // 
            this.LocationDrop.FormattingEnabled = true;
            this.LocationDrop.Location = new System.Drawing.Point(12, 101);
            this.LocationDrop.Name = "LocationDrop";
            this.LocationDrop.Size = new System.Drawing.Size(119, 21);
            this.LocationDrop.TabIndex = 1;
            // 
            // ActivityDrop
            // 
            this.ActivityDrop.FormattingEnabled = true;
            this.ActivityDrop.Location = new System.Drawing.Point(12, 143);
            this.ActivityDrop.Name = "ActivityDrop";
            this.ActivityDrop.Size = new System.Drawing.Size(119, 21);
            this.ActivityDrop.TabIndex = 2;
            // 
            // DiaryTextBox
            // 
            this.DiaryTextBox.Location = new System.Drawing.Point(12, 27);
            this.DiaryTextBox.Multiline = true;
            this.DiaryTextBox.Name = "DiaryTextBox";
            this.DiaryTextBox.Size = new System.Drawing.Size(119, 53);
            this.DiaryTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Diary Entry:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mood:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Location:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Activity:";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(12, 213);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(120, 23);
            this.Save.TabIndex = 10;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(144, 252);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DiaryTextBox);
            this.Controls.Add(this.ActivityDrop);
            this.Controls.Add(this.LocationDrop);
            this.Controls.Add(this.MoodDrop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "entry";
            this.Text = "Entry";
            this.Load += new System.EventHandler(this.entry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox MoodDrop;
        private System.Windows.Forms.ComboBox LocationDrop;
        private System.Windows.Forms.ComboBox ActivityDrop;
        private System.Windows.Forms.TextBox DiaryTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Save;
    }
}