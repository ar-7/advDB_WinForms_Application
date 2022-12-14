
namespace ROB19002438_LP20549A1_advDB
{
    partial class StaffMenu
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
            this.helpButton = new System.Windows.Forms.Button();
            this.formTitle = new System.Windows.Forms.Label();
            this.passwordPanel = new System.Windows.Forms.Panel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordSubmitButton = new System.Windows.Forms.Button();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.subHeadingLabel = new System.Windows.Forms.Label();
            this.logOutButton = new System.Windows.Forms.Button();
            this.staffFuncButton = new System.Windows.Forms.Button();
            this.passwordPanel.SuspendLayout();
            this.menuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // helpButton
            // 
            this.helpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.helpButton.Location = new System.Drawing.Point(882, 23);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(75, 30);
            this.helpButton.TabIndex = 7;
            this.helpButton.Text = "Help";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // formTitle
            // 
            this.formTitle.AutoSize = true;
            this.formTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.formTitle.Location = new System.Drawing.Point(23, 27);
            this.formTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.formTitle.Name = "formTitle";
            this.formTitle.Size = new System.Drawing.Size(222, 20);
            this.formTitle.TabIndex = 10;
            this.formTitle.Text = "Hotel Booking Staff Functions";
            // 
            // passwordPanel
            // 
            this.passwordPanel.Controls.Add(this.cancelButton);
            this.passwordPanel.Controls.Add(this.label1);
            this.passwordPanel.Controls.Add(this.passwordSubmitButton);
            this.passwordPanel.Controls.Add(this.passwordBox);
            this.passwordPanel.Controls.Add(this.label4);
            this.passwordPanel.Location = new System.Drawing.Point(270, 70);
            this.passwordPanel.Name = "passwordPanel";
            this.passwordPanel.Size = new System.Drawing.Size(444, 420);
            this.passwordPanel.TabIndex = 40;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(109, 240);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 28);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(85, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Note for evaluation: Password is hotelStaff";
            // 
            // passwordSubmitButton
            // 
            this.passwordSubmitButton.Location = new System.Drawing.Point(253, 240);
            this.passwordSubmitButton.Name = "passwordSubmitButton";
            this.passwordSubmitButton.Size = new System.Drawing.Size(75, 28);
            this.passwordSubmitButton.TabIndex = 5;
            this.passwordSubmitButton.Text = "Submit";
            this.passwordSubmitButton.UseVisualStyleBackColor = true;
            this.passwordSubmitButton.Click += new System.EventHandler(this.passwordSubmitButton_Click);
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(107, 193);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(221, 23);
            this.passwordBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(422, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "To access staff functions, please log in using your staff password:";
            // 
            // menuPanel
            // 
            this.menuPanel.Controls.Add(this.subHeadingLabel);
            this.menuPanel.Controls.Add(this.logOutButton);
            this.menuPanel.Controls.Add(this.staffFuncButton);
            this.menuPanel.Location = new System.Drawing.Point(142, 117);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(700, 297);
            this.menuPanel.TabIndex = 41;
            this.menuPanel.Visible = false;
            // 
            // subHeadingLabel
            // 
            this.subHeadingLabel.AutoSize = true;
            this.subHeadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subHeadingLabel.Location = new System.Drawing.Point(250, 67);
            this.subHeadingLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.subHeadingLabel.Name = "subHeadingLabel";
            this.subHeadingLabel.Size = new System.Drawing.Size(208, 20);
            this.subHeadingLabel.TabIndex = 16;
            this.subHeadingLabel.Text = "Please Make Your Selection";
            // 
            // logOutButton
            // 
            this.logOutButton.Location = new System.Drawing.Point(233, 188);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(235, 45);
            this.logOutButton.TabIndex = 3;
            this.logOutButton.Text = "Log-out";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // staffFuncButton
            // 
            this.staffFuncButton.Location = new System.Drawing.Point(233, 115);
            this.staffFuncButton.Name = "staffFuncButton";
            this.staffFuncButton.Size = new System.Drawing.Size(235, 45);
            this.staffFuncButton.TabIndex = 2;
            this.staffFuncButton.Text = "Review Bookings and Update Hotel Descriptions";
            this.staffFuncButton.UseVisualStyleBackColor = true;
            this.staffFuncButton.Click += new System.EventHandler(this.staffFuncButton_Click);
            // 
            // StaffMenu
            // 
            this.AcceptButton = this.passwordSubmitButton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.passwordPanel);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.formTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Name = "StaffMenu";
            this.Text = "Hotel Booking Management - Staff Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StaffMenu_FormClosed);
            this.Load += new System.EventHandler(this.StaffMenu_Load);
            this.passwordPanel.ResumeLayout(false);
            this.passwordPanel.PerformLayout();
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Label formTitle;
        private System.Windows.Forms.Panel passwordPanel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button passwordSubmitButton;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Label subHeadingLabel;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button staffFuncButton;
    }
}

