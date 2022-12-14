using System;
using System.Windows.Forms;

namespace ROB19002438_LP20549A1_advDB
{
    public partial class UserAccountTable : Form
    {
        public UserAccountTable()
        {
            InitializeComponent();
        }
        // Function that runs when the form is loaded
        private void HotelTable_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotel_bookingDataSet.postcode' table. You can move, or remove it, as needed.
            this.postcodeTableAdapter.Fill(this.hotel_bookingDataSet.postcode);
            // TODO: This line of code loads data into the 'hotel_bookingDataSet.user_account' table. You can move, or remove it, as needed.
            this.user_accountTableAdapter.Fill(this.hotel_bookingDataSet.user_account);

        }
        // Function that runs when the save button is clicked.
        private void user_accountBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.user_accountBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hotel_bookingDataSet);
            this.user_accountTableAdapter.Fill(this.hotel_bookingDataSet.user_account);
        }
        // Function that runs when the form is closed.
        private void HotelTable_FormClosed(object sender, FormClosedEventArgs e)
        {
            user_accountDataGridView.DataSource = null; // This is a fix to automatic API behaviour that causes an exception when the user closes the form.

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
        // Function that runs when the back button is clicked.
        private void backButton_Click(object sender, EventArgs e)
        {
            // Checks the active forms to make sure multiple of the same forms aren't opened at once.
            foreach (Form f in Application.OpenForms)
            {
                if (f is AdminMenu)
                {
                    // If a form is open, change focus to it and end check. Otherwise continue to open new form.
                    f.Focus();
                    return;
                }
            }
            // Generates instance of new form as variable.
            AdminMenu adminmenu = new AdminMenu();
            // Display instance with Show function.
            adminmenu.Show();
            adminmenu.Location = this.Location; // Set the new window's position to match the originator.
            this.Close();
        }
        // Function that runs when the log-out button is clicked.
        private void logOutButton_Click(object sender, EventArgs e)
        {
            this.Close(); // Closes the form.   
        }
        // Function that runs when the help button is clicked.
        private void helpButton_Click(object sender, EventArgs e)
        {
            // Loads the help documentation in the system web browser. 
            System.Diagnostics.Process.Start("..\\..\\AdminDocumentation.html");
        }

        // *** Solution to DataGridView selection error from Mark at Microsoft.
        // https://tinyurl.com/dgvFIX
        // Handles the error by storing it in a little icon and allowing the user to fix it rather than the default behaviour which is to throw the user out of edit mode and delete their data.
        private void user_accountDataGridView_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (user_accountDataGridView.IsCurrentRowDirty)
            {
                if (!String.IsNullOrEmpty(user_accountDataGridView.Rows[e.RowIndex].ErrorText))
                {
                    e.Cancel = true;
                }
            }
        }
        private void user_accountDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            user_accountDataGridView.Rows[e.RowIndex].ErrorText = e.Exception.Message + "Please complete content or delete row to continue.";
            e.Cancel = true;
        }
        private void user_accountDataGridView_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (user_accountDataGridView.IsCurrentRowDirty)
            {
                if (!String.IsNullOrEmpty(user_accountDataGridView.Rows[e.RowIndex].ErrorText))
                {
                    user_accountDataGridView.Rows[e.RowIndex].ErrorText = String.Empty;
                }
            }
        } // ***

    }
}
