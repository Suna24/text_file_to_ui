namespace TextFileToUI
{
    partial class UserInfoForm
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
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.YearOfBirthLabel = new System.Windows.Forms.Label();
            this.CityLabel = new System.Windows.Forms.Label();
            this.FacultyLabel = new System.Windows.Forms.Label();
            this.RoleLabel = new System.Windows.Forms.Label();
            this.RoleSpecificAttributeLabel = new System.Windows.Forms.Label();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.YearOfBirthTextBox = new System.Windows.Forms.TextBox();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.FacultyTextBox = new System.Windows.Forms.TextBox();
            this.RoleTextBox = new System.Windows.Forms.TextBox();
            this.RoleSpecificAttributeTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Location = new System.Drawing.Point(30, 75);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(71, 16);
            this.FullNameLabel.TabIndex = 0;
            this.FullNameLabel.Text = "Full Name:";
            // 
            // YearOfBirthLabel
            // 
            this.YearOfBirthLabel.AutoSize = true;
            this.YearOfBirthLabel.Location = new System.Drawing.Point(30, 120);
            this.YearOfBirthLabel.Name = "YearOfBirthLabel";
            this.YearOfBirthLabel.Size = new System.Drawing.Size(81, 16);
            this.YearOfBirthLabel.TabIndex = 1;
            this.YearOfBirthLabel.Text = "Year of birth:";
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Location = new System.Drawing.Point(30, 165);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(32, 16);
            this.CityLabel.TabIndex = 2;
            this.CityLabel.Text = "City:";
            // 
            // FacultyLabel
            // 
            this.FacultyLabel.AutoSize = true;
            this.FacultyLabel.Location = new System.Drawing.Point(30, 210);
            this.FacultyLabel.Name = "FacultyLabel";
            this.FacultyLabel.Size = new System.Drawing.Size(53, 16);
            this.FacultyLabel.TabIndex = 3;
            this.FacultyLabel.Text = "Faculty:";
            // 
            // RoleLabel
            // 
            this.RoleLabel.AutoSize = true;
            this.RoleLabel.Location = new System.Drawing.Point(30, 255);
            this.RoleLabel.Name = "RoleLabel";
            this.RoleLabel.Size = new System.Drawing.Size(39, 16);
            this.RoleLabel.TabIndex = 4;
            this.RoleLabel.Text = "Role:";
            // 
            // RoleSpecificAttributeLabel
            // 
            this.RoleSpecificAttributeLabel.AutoSize = true;
            this.RoleSpecificAttributeLabel.Location = new System.Drawing.Point(30, 300);
            this.RoleSpecificAttributeLabel.Name = "RoleSpecificAttributeLabel";
            this.RoleSpecificAttributeLabel.Size = new System.Drawing.Size(140, 16);
            this.RoleSpecificAttributeLabel.TabIndex = 5;
            this.RoleSpecificAttributeLabel.Text = "[role specific attribute]:";
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Location = new System.Drawing.Point(190, 71);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(200, 22);
            this.FullNameTextBox.TabIndex = 6;
            // 
            // YearOfBirthTextBox
            // 
            this.YearOfBirthTextBox.Location = new System.Drawing.Point(190, 116);
            this.YearOfBirthTextBox.Name = "YearOfBirthTextBox";
            this.YearOfBirthTextBox.Size = new System.Drawing.Size(200, 22);
            this.YearOfBirthTextBox.TabIndex = 7;
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(190, 161);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(200, 22);
            this.CityTextBox.TabIndex = 8;
            // 
            // FacultyTextBox
            // 
            this.FacultyTextBox.Location = new System.Drawing.Point(190, 206);
            this.FacultyTextBox.Name = "FacultyTextBox";
            this.FacultyTextBox.Size = new System.Drawing.Size(200, 22);
            this.FacultyTextBox.TabIndex = 9;
            // 
            // RoleTextBox
            // 
            this.RoleTextBox.Location = new System.Drawing.Point(190, 251);
            this.RoleTextBox.Name = "RoleTextBox";
            this.RoleTextBox.Size = new System.Drawing.Size(200, 22);
            this.RoleTextBox.TabIndex = 10;
            // 
            // RoleSpecificAttributeTextBox
            // 
            this.RoleSpecificAttributeTextBox.Location = new System.Drawing.Point(190, 296);
            this.RoleSpecificAttributeTextBox.Name = "RoleSpecificAttributeTextBox";
            this.RoleSpecificAttributeTextBox.Size = new System.Drawing.Size(200, 22);
            this.RoleSpecificAttributeTextBox.TabIndex = 11;
            // 
            // UserInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 371);
            this.Controls.Add(this.RoleSpecificAttributeTextBox);
            this.Controls.Add(this.RoleTextBox);
            this.Controls.Add(this.FacultyTextBox);
            this.Controls.Add(this.CityTextBox);
            this.Controls.Add(this.YearOfBirthTextBox);
            this.Controls.Add(this.FullNameTextBox);
            this.Controls.Add(this.RoleSpecificAttributeLabel);
            this.Controls.Add(this.RoleLabel);
            this.Controls.Add(this.FacultyLabel);
            this.Controls.Add(this.CityLabel);
            this.Controls.Add(this.YearOfBirthLabel);
            this.Controls.Add(this.FullNameLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserInfoForm";
            this.ShowIcon = false;
            this.Text = "User data display";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.Label YearOfBirthLabel;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.Label FacultyLabel;
        private System.Windows.Forms.Label RoleLabel;
        private System.Windows.Forms.Label RoleSpecificAttributeLabel;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.TextBox YearOfBirthTextBox;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.TextBox FacultyTextBox;
        private System.Windows.Forms.TextBox RoleTextBox;
        private System.Windows.Forms.TextBox RoleSpecificAttributeTextBox;
    }
}

