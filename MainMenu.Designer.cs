
namespace ROB19002438_LP20549A1_advDB
{
    partial class MainMenu
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
            this.staffFuncButton = new System.Windows.Forms.Button();
            this.adminFuncButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.formTitle = new System.Windows.Forms.Label();
            this.subHeadingLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // staffFuncButton
            // 
            this.staffFuncButton.Location = new System.Drawing.Point(375, 195);
            this.staffFuncButton.Name = "staffFuncButton";
            this.staffFuncButton.Size = new System.Drawing.Size(235, 45);
            this.staffFuncButton.TabIndex = 1;
            this.staffFuncButton.Text = "Hotel Staff Functions";
            this.staffFuncButton.UseVisualStyleBackColor = true;
            this.staffFuncButton.Click += new System.EventHandler(this.staffFuncButton_Click);
            // 
            // adminFuncButton
            // 
            this.adminFuncButton.Location = new System.Drawing.Point(375, 268);
            this.adminFuncButton.Name = "adminFuncButton";
            this.adminFuncButton.Size = new System.Drawing.Size(235, 45);
            this.adminFuncButton.TabIndex = 2;
            this.adminFuncButton.Text = "Database Admin";
            this.adminFuncButton.UseVisualStyleBackColor = true;
            this.adminFuncButton.Click += new System.EventHandler(this.adminFuncButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.helpButton.Location = new System.Drawing.Point(882, 23);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(75, 30);
            this.helpButton.TabIndex = 3;
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
            this.formTitle.Size = new System.Drawing.Size(191, 20);
            this.formTitle.TabIndex = 10;
            this.formTitle.Text = "Hotel Booking Main Menu";
            // 
            // subHeadingLabel
            // 
            this.subHeadingLabel.AutoSize = true;
            this.subHeadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subHeadingLabel.Location = new System.Drawing.Point(392, 147);
            this.subHeadingLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.subHeadingLabel.Name = "subHeadingLabel";
            this.subHeadingLabel.Size = new System.Drawing.Size(208, 20);
            this.subHeadingLabel.TabIndex = 13;
            this.subHeadingLabel.Text = "Please Make Your Selection";
            // 
            // MainMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.subHeadingLabel);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.formTitle);
            this.Controls.Add(this.adminFuncButton);
            this.Controls.Add(this.staffFuncButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Name = "MainMenu";
            this.Text = "Hotel Booking Management - Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button staffFuncButton;
        private System.Windows.Forms.Button adminFuncButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Label formTitle;
        private System.Windows.Forms.Label subHeadingLabel;
    }
}

