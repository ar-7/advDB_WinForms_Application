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
*This forms provides access to the admin functionality of the application. This functionality is password protected.
*/

namespace ROB19002438_LP20549A1_advDB
{
    public partial class AdminMenu : Form
    {
        // This var stores the admin password needed to access the staff area.
        readonly string adminPass = "hotelDBAdmin";
        public AdminMenu()
        {
            InitializeComponent();
        }
        // Function that runs when the form is loaded.
        private void AdminMenu_Load(object sender, EventArgs e)
        {
            // Checks whether the login session is active and hides the password prompt if it is.
            if (MainMenu.adminVerified == true)
            {
                passwordPanel.Visible = false; // Hides password panel.
                menuPanel.Visible = true; // Reveals main menu.
                logOutButton.Visible = true; // Reveals log-out button.
            }
        }
        // Check admin password against stored variable and confirm or deny access.
        private void passwordSubmitButton_Click(object sender, EventArgs e)
        {
            if (passwordBox.Text.Trim() == adminPass)
            {
                MessageBox.Show("Thank you. Access granted.");
                passwordPanel.Visible = false; // Hides password panel.
                menuPanel.Visible = true; // Reveals main menu.
                logOutButton.Visible = true; // Reveals log-out button.
                MainMenu.adminVerified = true; // Begin admin session.
            }
            else
            {
                MessageBox.Show("Password incorrect. Please try again."); // Displays error and nothing else happens.
            }
        }
        // Function that runs when the cancel button is clicked on the password screen.
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close(); // Closes the form, which triggers the FormClosed function.
        }
        // Function that runs when the log-out button is clicked
        private void logOutButton_Click(object sender, EventArgs e)
        {
            this.Close(); // Closes the form, which triggers the FormClosed function.
        }
        // Function that runs when the help button is clicked.
        private void helpButton_Click(object sender, EventArgs e)
        {
            // Loads the help documentation in the system web browser. 
            System.Diagnostics.Process.Start("..\\..\\AdminDocumentation.html");
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
                        MainMenu.adminVerified = false; // reset admin session
                        f.Show();
                        return;
                    }
                }
            }
        }
        // Function that runs when the submit function is clicked.
        private void submitButton_Click(object sender, EventArgs e)
        {
            string selection = formSelectComboBox.Text; // Store the text of the selection made.
            Form formChosen = null; // Declare the variable to store the selection.
            // Switch operates as a multiple choice if statement.
            // Generates instance of new forms as variable, corresponding to the option selected.
            switch (selection)
            {
                case "Room Booking":
                    formChosen = new RoomBookingTable();
                    break;
                case "Booking":
                    formChosen = new BookingTable();
                    break;
                case "Hotel":
                    formChosen = new HotelTable();
                    break;
                case "User Account":
                    formChosen = new UserAccountTable();
                    break;
                case "Hotel Room":
                    formChosen = new HotelRoomTable();
                    break;
                case "Room Type":
                    formChosen = new RoomTypeTable();
                    break;
                case "Payment Record":
                    formChosen = new PaymentRecordTable();
                    break;
                case "City":
                    formChosen = new CityTable();
                    break;
                case "Postcode":
                    formChosen = new PostcodeTable();
                    break;
                case "Admin Account":
                    formChosen = new AdminAccountTable();
                    break;
                case "Image":
                    formChosen = new ImageTable();
                    break;
                default: // If the user makes no selection.
                    MessageBox.Show("Please make a selection."); // Display message.
                    return; // Breaks out of the function.
            }
            // Checks the active forms to make sure multiple of the same forms aren't opened at once.
            foreach (Form f in Application.OpenForms)
            {
                if (f == formChosen)
                {
                    // If a form is open, change focus to it and end check. Otherwise continue to open new form.
                    f.Focus();
                    return;
                }
            }
            // Display instance with Show function.
            formChosen.Show();
            formChosen.Location = this.Location; // Sets the new form's location to match this one.
            this.Close(); // Closes the form, which triggers the FormClosed function.
        }
    }
}
