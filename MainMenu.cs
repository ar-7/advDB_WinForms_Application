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
*This forms provides the main menu for the application.
*/

namespace ROB19002438_LP20549A1_advDB
{
    public partial class MainMenu : Form
    {
        static public bool adminVerified = false; // bool for admin session
        static public bool staffVerified = false; // bool for staff session
        public MainMenu()
        {
            InitializeComponent();
        }
        // Function that runs when the staff button is clicked
        private void staffFuncButton_Click(object sender, EventArgs e)
        {
            // Checks the active forms to make sure multiple of the same forms aren't opened at once.
            foreach (Form f in Application.OpenForms)
            {
                if (f is StaffMenu)
                {
                    // If a form is open, change focus to it and end check. Otherwise continue to open new form
                    f.Focus();
                    return;
                }
            }
            // Generates instance of new form as variable.
            StaffMenu staffmenu = new StaffMenu();

            // Display instance with Show function.
            staffmenu.Show();
            staffmenu.Location = this.Location; // Set the new window's position to match the originator.
            this.Hide(); // Hides this form so that it can return when the staff member logs out. 
        }
        // Function that runs when the admin button is clicked
        private void adminFuncButton_Click(object sender, EventArgs e)
        {
            // Checks the active forms to make sure multiple of the same forms aren't opened at once.
            foreach (Form f in Application.OpenForms)
            {
                if (f is AdminMenu)
                {
                    // If a form is open, change focus to it and end check. Otherwise continue to open new form
                    f.Focus();
                    return;
                }
            }
            // Generates instance of new form as variable.
            AdminMenu adminmenu = new AdminMenu();
            // Display instance with Show function.
            adminmenu.Show();
            adminmenu.Location = this.Location; // Set the new window's position to match the originator.
            this.Hide(); // Hides this form so that it can return when the staff member logs out. 
        }
        // Function that runs when the help button is clicked.
        private void helpButton_Click(object sender, EventArgs e)
        {
            // Loads the help documentation in the system web browser. 
            System.Diagnostics.Process.Start("..\\..\\MainMenuDocumentation.html");
        }
    }
}
