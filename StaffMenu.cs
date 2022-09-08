using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
**All comments constitute technical documentation for the Hotel Database Management Application.**
*
*This forms provides access to the staff functionality of the application. This functionality is password protected.
*/

namespace ROB19002438_LP20549A1_advDB
{
    public partial class StaffMenu : Form
    {
        // This var stores the admin password needed to access the staff area.
        readonly string staffPass = "hotelStaff";
        public StaffMenu()
        {
            InitializeComponent();
        }
        // Function that runs when the form is loaded.
        private void StaffMenu_Load(object sender, EventArgs e)
        {
            // Checks whether the login session is active.
            if (MainMenu.staffVerified == true)
            {
                passwordPanel.Visible = false; // Hides password panel.
                menuPanel.Visible = true; // Reveals main menu.
                logOutButton.Visible = true; // Reveals log-out button.
            }
        }
        // Check admin password against stored variable and confirm or deny access.
        private void passwordSubmitButton_Click(object sender, EventArgs e)
        {
            if (passwordBox.Text.Trim() == staffPass)
            {
                MessageBox.Show("Thank you. Access granted.");
                passwordPanel.Visible = false; // Hides password panel.
                menuPanel.Visible = true; // Reveals main menu.
                MainMenu.staffVerified = true; // Begins logged in session
            }
            else
            {
                MessageBox.Show("Password incorrect. Please try again."); // Displays error and nothing else happens.
            }
        }
        // Function that runs when the cancel button is clicked on the password screen.
        private void cancelButton_Click(object sender, EventArgs e)
        {
            // Closes the form which causes the program to return the the main menu. 
            this.Close();
        }
        // Function that runs when the staff button is clicked
        private void staffFuncButton_Click(object sender, EventArgs e)
        {
            // Checks the active forms to make sure multiple of the same forms aren't opened at once.
            foreach (Form f in Application.OpenForms)
            {
                if (f is StaffFunctions)
                {
                    // If a form is open, change focus to it and end check. Otherwise continue to open new form.
                    f.Focus();
                    return;
                }
            }
            // Generates instance of new form as variable.
            StaffFunctions adminmanage = new StaffFunctions();
            // Display instance with Show function.
            adminmanage.Show();
            adminmanage.Location = this.Location; // Sets the new form's location to match this one.
            this.Close(); // Closes the form, which triggers the FormClosed function.
        }
        // Function that runs when the admin button is clicked
        private void logOutButton_Click(object sender, EventArgs e)
        {
            this.Close(); // Closes the form, which triggers the FormClosed function.
        }
        // Function that runs when the help button is clicked.
        private void helpButton_Click(object sender, EventArgs e)
        {
            // Loads the help documentation in the system web browser. 
            System.Diagnostics.Process.Start("..\\..\\StaffDocumentation.html");
        }
        // Function that runs when the form closes.
        private void StaffMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Checks the active forms to decide whether to switch to a new form or back to the main menu.
            foreach (Form f in Application.OpenForms)
            {
                // Does nothing if a new form has been opened.
                if (Application.OpenForms.Count > 1)
                {
                    break;
                }
                else
                {
                    // Finds the hidden main menu and restores it.
                    if (f is MainMenu)
                    {
                        MainMenu.staffVerified = false; // reset staff session
                        f.Show();
                        return;
                    }
                }
            }
        }
    }
}
