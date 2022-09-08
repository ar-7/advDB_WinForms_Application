
namespace ROB19002438_LP20549A1_advDB
{
    partial class BookingTable
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingTable));
            this.logOutButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.formTitle = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.hotel_bookingDataSet = new ROB19002438_LP20549A1_advDB.hotel_bookingDataSet();
            this.bookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookingTableAdapter = new ROB19002438_LP20549A1_advDB.hotel_bookingDataSetTableAdapters.bookingTableAdapter();
            this.tableAdapterManager = new ROB19002438_LP20549A1_advDB.hotel_bookingDataSetTableAdapters.TableAdapterManager();
            this.payment_recordTableAdapter = new ROB19002438_LP20549A1_advDB.hotel_bookingDataSetTableAdapters.payment_recordTableAdapter();
            this.user_accountTableAdapter = new ROB19002438_LP20549A1_advDB.hotel_bookingDataSetTableAdapters.user_accountTableAdapter();
            this.bookingBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bookingBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bookingDataGridView = new System.Windows.Forms.DataGridView();
            this.useraccountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentrecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_bookingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingNavigator)).BeginInit();
            this.bookingBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookingDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.useraccountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentrecordBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // logOutButton
            // 
            this.logOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.logOutButton.Location = new System.Drawing.Point(763, 23);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(100, 30);
            this.logOutButton.TabIndex = 7;
            this.logOutButton.Text = "Log-out";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.helpButton.Location = new System.Drawing.Point(882, 23);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(75, 30);
            this.helpButton.TabIndex = 8;
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
            this.formTitle.Size = new System.Drawing.Size(208, 20);
            this.formTitle.TabIndex = 6;
            this.formTitle.Text = "Booking Table Management";
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.backButton.Location = new System.Drawing.Point(589, 23);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(158, 30);
            this.backButton.TabIndex = 9;
            this.backButton.Text = "Return to Admin Menu";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // hotel_bookingDataSet
            // 
            this.hotel_bookingDataSet.DataSetName = "hotel_bookingDataSet";
            this.hotel_bookingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookingBindingSource
            // 
            this.bookingBindingSource.DataMember = "booking";
            this.bookingBindingSource.DataSource = this.hotel_bookingDataSet;
            // 
            // bookingTableAdapter
            // 
            this.bookingTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.admin_accountTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bookingTableAdapter = this.bookingTableAdapter;
            this.tableAdapterManager.cityTableAdapter = null;
            this.tableAdapterManager.hotel_roomTableAdapter = null;
            this.tableAdapterManager.hotelTableAdapter = null;
            this.tableAdapterManager.imageTableAdapter = null;
            this.tableAdapterManager.payment_recordTableAdapter = this.payment_recordTableAdapter;
            this.tableAdapterManager.postcodeTableAdapter = null;
            this.tableAdapterManager.room_bookingTableAdapter = null;
            this.tableAdapterManager.room_typeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ROB19002438_LP20549A1_advDB.hotel_bookingDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.user_accountTableAdapter = this.user_accountTableAdapter;
            // 
            // payment_recordTableAdapter
            // 
            this.payment_recordTableAdapter.ClearBeforeFill = true;
            // 
            // user_accountTableAdapter
            // 
            this.user_accountTableAdapter.ClearBeforeFill = true;
            // 
            // bookingBindingNavigator
            // 
            this.bookingBindingNavigator.AddNewItem = null;
            this.bookingBindingNavigator.BindingSource = this.bookingBindingSource;
            this.bookingBindingNavigator.CountItem = null;
            this.bookingBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bookingBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.bookingBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorDeleteItem,
            this.bindingNavigatorSeparator2,
            this.bookingBindingNavigatorSaveItem});
            this.bookingBindingNavigator.Location = new System.Drawing.Point(27, 72);
            this.bookingBindingNavigator.MoveFirstItem = null;
            this.bookingBindingNavigator.MoveLastItem = null;
            this.bookingBindingNavigator.MoveNextItem = null;
            this.bookingBindingNavigator.MovePreviousItem = null;
            this.bookingBindingNavigator.Name = "bookingBindingNavigator";
            this.bookingBindingNavigator.PositionItem = null;
            this.bookingBindingNavigator.Size = new System.Drawing.Size(162, 25);
            this.bookingBindingNavigator.TabIndex = 10;
            this.bookingBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(60, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bookingBindingNavigatorSaveItem
            // 
            this.bookingBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bookingBindingNavigatorSaveItem.Image")));
            this.bookingBindingNavigatorSaveItem.Name = "bookingBindingNavigatorSaveItem";
            this.bookingBindingNavigatorSaveItem.Size = new System.Drawing.Size(78, 22);
            this.bookingBindingNavigatorSaveItem.Text = "Save Data";
            this.bookingBindingNavigatorSaveItem.Click += new System.EventHandler(this.bookingBindingNavigatorSaveItem_Click);
            // 
            // bookingDataGridView
            // 
            this.bookingDataGridView.AutoGenerateColumns = false;
            this.bookingDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bookingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookingDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn6});
            this.bookingDataGridView.DataSource = this.bookingBindingSource;
            this.bookingDataGridView.Location = new System.Drawing.Point(27, 100);
            this.bookingDataGridView.Name = "bookingDataGridView";
            this.bookingDataGridView.Size = new System.Drawing.Size(930, 430);
            this.bookingDataGridView.TabIndex = 10;
            this.bookingDataGridView.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.bookingDataGridView_CellValidated);
            this.bookingDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.bookingDataGridView_DataError);
            this.bookingDataGridView.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.bookingDataGridView_RowValidating);
            // 
            // useraccountBindingSource
            // 
            this.useraccountBindingSource.DataMember = "user_account";
            this.useraccountBindingSource.DataSource = this.hotel_bookingDataSet;
            // 
            // paymentrecordBindingSource
            // 
            this.paymentrecordBindingSource.DataMember = "payment_record";
            this.paymentrecordBindingSource.DataSource = this.hotel_bookingDataSet;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "booking_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Booking ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.ToolTipText = "Read Only Unique ID";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "user_id";
            this.dataGridViewTextBoxColumn2.DataSource = this.useraccountBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "user_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Username";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "user_id";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "payment_id";
            this.dataGridViewTextBoxColumn3.DataSource = this.paymentrecordBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "payment_id";
            this.dataGridViewTextBoxColumn3.HeaderText = "Payment ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "payment_id";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "review_text";
            this.dataGridViewTextBoxColumn4.HeaderText = "Review Content";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ToolTipText = "Can be empty";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "review_score";
            this.dataGridViewTextBoxColumn5.HeaderText = "Review Score";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ToolTipText = "Can be empty";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "check_in";
            this.dataGridViewTextBoxColumn7.HeaderText = "Check In Date";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ToolTipText = "Must be date format";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "check_out";
            this.dataGridViewTextBoxColumn6.HeaderText = "Check Out Date";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ToolTipText = "Must be date format";
            // 
            // BookingTable
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.bookingDataGridView);
            this.Controls.Add(this.bookingBindingNavigator);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.formTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Name = "BookingTable";
            this.Text = "Booking Table Management";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HotelTable_FormClosed);
            this.Load += new System.EventHandler(this.HotelTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hotel_bookingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingNavigator)).EndInit();
            this.bookingBindingNavigator.ResumeLayout(false);
            this.bookingBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookingDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.useraccountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentrecordBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Label formTitle;
        private System.Windows.Forms.Button backButton;
        private hotel_bookingDataSet hotel_bookingDataSet;
        private System.Windows.Forms.BindingSource bookingBindingSource;
        private hotel_bookingDataSetTableAdapters.bookingTableAdapter bookingTableAdapter;
        private hotel_bookingDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator bookingBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bookingBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView bookingDataGridView;
        private hotel_bookingDataSetTableAdapters.user_accountTableAdapter user_accountTableAdapter;
        private System.Windows.Forms.BindingSource useraccountBindingSource;
        private hotel_bookingDataSetTableAdapters.payment_recordTableAdapter payment_recordTableAdapter;
        private System.Windows.Forms.BindingSource paymentrecordBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}