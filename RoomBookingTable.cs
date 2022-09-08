using System;
using System.Windows.Forms;

namespace ROB19002438_LP20549A1_advDB
{
    public partial class RoomBookingTable : Form
    {
        public RoomBookingTable()
        {
            InitializeComponent();
        }
        // Function that runs when the form is loaded
        private void HotelTable_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotel_bookingDataSet.payment_record' table. You can move, or remove it, as needed.
            this.payment_recordTableAdapter.Fill(this.hotel_bookingDataSet.payment_record);
            // TODO: This line of code loads data into the 'hotel_bookingDataSet.user_account' table. You can move, or remove it, as needed.
            this.user_accountTableAdapter.Fill(this.hotel_bookingDataSet.user_account);
            // TODO: This line of code loads data into the 'hotel_bookingDataSet.room_type' table. You can move, or remove it, as needed.
            this.room_typeTableAdapter.Fill(this.hotel_bookingDataSet.room_type);
            // TODO: This line of code loads data into the 'hotel_bookingDataSet.hotel' table. You can move, or remove it, as needed.
            this.hotelTableAdapter.Fill(this.hotel_bookingDataSet.hotel);
            // TODO: This line of code loads data into the 'hotel_bookingDataSet.booking' table. You can move, or remove it, as needed.
            this.bookingTableAdapter.Fill(this.hotel_bookingDataSet.booking);
            // TODO: This line of code loads data into the 'hotel_bookingDataSet.hotel_room' table. You can move, or remove it, as needed.
            this.hotel_roomTableAdapter.Fill(this.hotel_bookingDataSet.hotel_room);
            // TODO: This line of code loads data into the 'hotel_bookingDataSet.room_booking' table. You can move, or remove it, as needed.
            this.room_bookingTableAdapter.Fill(this.hotel_bookingDataSet.room_booking);

        }
        // Function that runs when the save button is clicked.
        private void room_bookingBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.room_bookingBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hotel_bookingDataSet);
            this.room_bookingTableAdapter.Fill(this.hotel_bookingDataSet.room_booking); // Refresh the data grid view, fixes the negative id display

        }
        // Function that runs when the form is closed.
        private void HotelTable_FormClosed(object sender, FormClosedEventArgs e)
        {
            room_bookingDataGridView.DataSource = null; // This is a fix to automatic API behaviour that causes an exception when the user closes the form.

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
        private void room_bookingDataGridView_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (room_bookingDataGridView.IsCurrentRowDirty)
            {
                if (!String.IsNullOrEmpty(room_bookingDataGridView.Rows[e.RowIndex].ErrorText))
                {
                    e.Cancel = true;
                }
            }
        }
        private void room_bookingDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            room_bookingDataGridView.Rows[e.RowIndex].ErrorText = e.Exception.Message + "Please complete content or delete row to continue.";
            e.Cancel = true;
        }
        private void room_bookingDataGridView_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (room_bookingDataGridView.IsCurrentRowDirty)
            {
                if (!String.IsNullOrEmpty(room_bookingDataGridView.Rows[e.RowIndex].ErrorText))
                {
                    room_bookingDataGridView.Rows[e.RowIndex].ErrorText = String.Empty;
                }
            }
        } // ***
    }
}
