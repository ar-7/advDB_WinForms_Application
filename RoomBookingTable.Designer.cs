
namespace ROB19002438_LP20549A1_advDB
{
    partial class RoomBookingTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomBookingTable));
            this.logOutButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.formTitle = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.hotel_bookingDataSet = new ROB19002438_LP20549A1_advDB.hotel_bookingDataSet();
            this.room_bookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.room_bookingTableAdapter = new ROB19002438_LP20549A1_advDB.hotel_bookingDataSetTableAdapters.room_bookingTableAdapter();
            this.tableAdapterManager = new ROB19002438_LP20549A1_advDB.hotel_bookingDataSetTableAdapters.TableAdapterManager();
            this.bookingTableAdapter = new ROB19002438_LP20549A1_advDB.hotel_bookingDataSetTableAdapters.bookingTableAdapter();
            this.hotel_roomTableAdapter = new ROB19002438_LP20549A1_advDB.hotel_bookingDataSetTableAdapters.hotel_roomTableAdapter();
            this.room_bookingBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.room_bookingBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.room_bookingDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.hotelroomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.hotel_roomDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.hotelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.roomtypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bookingDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.useraccountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.paymentrecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelTableAdapter = new ROB19002438_LP20549A1_advDB.hotel_bookingDataSetTableAdapters.hotelTableAdapter();
            this.room_typeTableAdapter = new ROB19002438_LP20549A1_advDB.hotel_bookingDataSetTableAdapters.room_typeTableAdapter();
            this.user_accountTableAdapter = new ROB19002438_LP20549A1_advDB.hotel_bookingDataSetTableAdapters.user_accountTableAdapter();
            this.payment_recordTableAdapter = new ROB19002438_LP20549A1_advDB.hotel_bookingDataSetTableAdapters.payment_recordTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_bookingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.room_bookingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.room_bookingBindingNavigator)).BeginInit();
            this.room_bookingBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.room_bookingDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelroomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_roomDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomtypeBindingSource)).BeginInit();
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
            this.formTitle.Size = new System.Drawing.Size(255, 20);
            this.formTitle.TabIndex = 6;
            this.formTitle.Text = "Room Booking Table Management";
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
            // room_bookingBindingSource
            // 
            this.room_bookingBindingSource.DataMember = "room_booking";
            this.room_bookingBindingSource.DataSource = this.hotel_bookingDataSet;
            // 
            // room_bookingTableAdapter
            // 
            this.room_bookingTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.admin_accountTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bookingTableAdapter = this.bookingTableAdapter;
            this.tableAdapterManager.cityTableAdapter = null;
            this.tableAdapterManager.hotel_roomTableAdapter = this.hotel_roomTableAdapter;
            this.tableAdapterManager.hotelTableAdapter = null;
            this.tableAdapterManager.imageTableAdapter = null;
            this.tableAdapterManager.payment_recordTableAdapter = null;
            this.tableAdapterManager.postcodeTableAdapter = null;
            this.tableAdapterManager.room_bookingTableAdapter = this.room_bookingTableAdapter;
            this.tableAdapterManager.room_typeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ROB19002438_LP20549A1_advDB.hotel_bookingDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.user_accountTableAdapter = null;
            // 
            // bookingTableAdapter
            // 
            this.bookingTableAdapter.ClearBeforeFill = true;
            // 
            // hotel_roomTableAdapter
            // 
            this.hotel_roomTableAdapter.ClearBeforeFill = true;
            // 
            // room_bookingBindingNavigator
            // 
            this.room_bookingBindingNavigator.AddNewItem = null;
            this.room_bookingBindingNavigator.BindingSource = this.room_bookingBindingSource;
            this.room_bookingBindingNavigator.CountItem = null;
            this.room_bookingBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.room_bookingBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.room_bookingBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorDeleteItem,
            this.bindingNavigatorSeparator2,
            this.room_bookingBindingNavigatorSaveItem});
            this.room_bookingBindingNavigator.Location = new System.Drawing.Point(27, 72);
            this.room_bookingBindingNavigator.MoveFirstItem = null;
            this.room_bookingBindingNavigator.MoveLastItem = null;
            this.room_bookingBindingNavigator.MoveNextItem = null;
            this.room_bookingBindingNavigator.MovePreviousItem = null;
            this.room_bookingBindingNavigator.Name = "room_bookingBindingNavigator";
            this.room_bookingBindingNavigator.PositionItem = null;
            this.room_bookingBindingNavigator.Size = new System.Drawing.Size(162, 25);
            this.room_bookingBindingNavigator.TabIndex = 10;
            this.room_bookingBindingNavigator.Text = "bindingNavigator1";
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
            // room_bookingBindingNavigatorSaveItem
            // 
            this.room_bookingBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("room_bookingBindingNavigatorSaveItem.Image")));
            this.room_bookingBindingNavigatorSaveItem.Name = "room_bookingBindingNavigatorSaveItem";
            this.room_bookingBindingNavigatorSaveItem.Size = new System.Drawing.Size(78, 22);
            this.room_bookingBindingNavigatorSaveItem.Text = "Save Data";
            this.room_bookingBindingNavigatorSaveItem.Click += new System.EventHandler(this.room_bookingBindingNavigatorSaveItem_Click);
            // 
            // room_bookingDataGridView
            // 
            this.room_bookingDataGridView.AutoGenerateColumns = false;
            this.room_bookingDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.room_bookingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.room_bookingDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.room_bookingDataGridView.DataSource = this.room_bookingBindingSource;
            this.room_bookingDataGridView.Location = new System.Drawing.Point(27, 100);
            this.room_bookingDataGridView.Name = "room_bookingDataGridView";
            this.room_bookingDataGridView.Size = new System.Drawing.Size(930, 374);
            this.room_bookingDataGridView.TabIndex = 10;
            this.room_bookingDataGridView.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.room_bookingDataGridView_CellValidated);
            this.room_bookingDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.room_bookingDataGridView_DataError);
            this.room_bookingDataGridView.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.room_bookingDataGridView_RowValidating);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "room_booking_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Room Booking ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.ToolTipText = "Read Only Unique Key";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "room_id";
            this.dataGridViewTextBoxColumn2.DataSource = this.hotelroomBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "room_id";
            this.dataGridViewTextBoxColumn2.HeaderText = "Room ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "room_id";
            // 
            // hotelroomBindingSource
            // 
            this.hotelroomBindingSource.DataMember = "hotel_room";
            this.hotelroomBindingSource.DataSource = this.hotel_bookingDataSet;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "booking_id";
            this.dataGridViewTextBoxColumn3.DataSource = this.bookingBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "booking_id";
            this.dataGridViewTextBoxColumn3.HeaderText = "Booking ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "booking_id";
            // 
            // bookingBindingSource
            // 
            this.bookingBindingSource.DataMember = "booking";
            this.bookingBindingSource.DataSource = this.hotel_bookingDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(23, 497);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Reference Tables";
            // 
            // hotel_roomDataGridView
            // 
            this.hotel_roomDataGridView.AllowUserToAddRows = false;
            this.hotel_roomDataGridView.AllowUserToDeleteRows = false;
            this.hotel_roomDataGridView.AutoGenerateColumns = false;
            this.hotel_roomDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hotel_roomDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.hotel_roomDataGridView.DataSource = this.hotelroomBindingSource;
            this.hotel_roomDataGridView.Location = new System.Drawing.Point(27, 551);
            this.hotel_roomDataGridView.Name = "hotel_roomDataGridView";
            this.hotel_roomDataGridView.ReadOnly = true;
            this.hotel_roomDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.hotel_roomDataGridView.Size = new System.Drawing.Size(450, 300);
            this.hotel_roomDataGridView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "room_id";
            this.dataGridViewTextBoxColumn4.HeaderText = "Room ID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "hotel_id";
            this.dataGridViewTextBoxColumn5.DataSource = this.hotelBindingSource;
            this.dataGridViewTextBoxColumn5.DisplayMember = "hotel_name";
            this.dataGridViewTextBoxColumn5.HeaderText = "Hotel Name";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn5.ValueMember = "hotel_id";
            // 
            // hotelBindingSource
            // 
            this.hotelBindingSource.DataMember = "hotel";
            this.hotelBindingSource.DataSource = this.hotel_bookingDataSet;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "room_number_or_name";
            this.dataGridViewTextBoxColumn6.HeaderText = "Room # or Name";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "type_id";
            this.dataGridViewTextBoxColumn7.DataSource = this.roomtypeBindingSource;
            this.dataGridViewTextBoxColumn7.DisplayMember = "type";
            this.dataGridViewTextBoxColumn7.HeaderText = "Room Type";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn7.ValueMember = "type_id";
            // 
            // roomtypeBindingSource
            // 
            this.roomtypeBindingSource.DataMember = "room_type";
            this.roomtypeBindingSource.DataSource = this.hotel_bookingDataSet;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "price_per_night";
            this.dataGridViewTextBoxColumn8.HeaderText = "Price Per Night";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(23, 526);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Hotel Room Table";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(504, 526);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Booking Table";
            // 
            // bookingDataGridView
            // 
            this.bookingDataGridView.AllowUserToAddRows = false;
            this.bookingDataGridView.AllowUserToDeleteRows = false;
            this.bookingDataGridView.AutoGenerateColumns = false;
            this.bookingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookingDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn14});
            this.bookingDataGridView.DataSource = this.bookingBindingSource;
            this.bookingDataGridView.Location = new System.Drawing.Point(507, 551);
            this.bookingDataGridView.Name = "bookingDataGridView";
            this.bookingDataGridView.ReadOnly = true;
            this.bookingDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bookingDataGridView.Size = new System.Drawing.Size(450, 300);
            this.bookingDataGridView.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "booking_id";
            this.dataGridViewTextBoxColumn9.HeaderText = "Booking ID";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "user_id";
            this.dataGridViewTextBoxColumn10.DataSource = this.useraccountBindingSource;
            this.dataGridViewTextBoxColumn10.DisplayMember = "user_name";
            this.dataGridViewTextBoxColumn10.HeaderText = "Username";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn10.ValueMember = "user_id";
            // 
            // useraccountBindingSource
            // 
            this.useraccountBindingSource.DataMember = "user_account";
            this.useraccountBindingSource.DataSource = this.hotel_bookingDataSet;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "payment_id";
            this.dataGridViewTextBoxColumn11.DataSource = this.paymentrecordBindingSource;
            this.dataGridViewTextBoxColumn11.DisplayMember = "payment_id";
            this.dataGridViewTextBoxColumn11.HeaderText = "Payment ID";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn11.ValueMember = "payment_id";
            // 
            // paymentrecordBindingSource
            // 
            this.paymentrecordBindingSource.DataMember = "payment_record";
            this.paymentrecordBindingSource.DataSource = this.hotel_bookingDataSet;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "review_text";
            this.dataGridViewTextBoxColumn12.HeaderText = "Review Content";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "review_score";
            this.dataGridViewTextBoxColumn13.HeaderText = "Review Score";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "check_in";
            this.dataGridViewTextBoxColumn15.HeaderText = "Check In Date";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "check_out";
            this.dataGridViewTextBoxColumn14.HeaderText = "Check Out Date";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // hotelTableAdapter
            // 
            this.hotelTableAdapter.ClearBeforeFill = true;
            // 
            // room_typeTableAdapter
            // 
            this.room_typeTableAdapter.ClearBeforeFill = true;
            // 
            // user_accountTableAdapter
            // 
            this.user_accountTableAdapter.ClearBeforeFill = true;
            // 
            // payment_recordTableAdapter
            // 
            this.payment_recordTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(484, 765);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(17, 131);
            this.panel1.TabIndex = 14;
            // 
            // RoomBookingTable
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(984, 581);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bookingDataGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hotel_roomDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.room_bookingDataGridView);
            this.Controls.Add(this.room_bookingBindingNavigator);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.formTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Name = "RoomBookingTable";
            this.Text = "Room Booking Table Management";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HotelTable_FormClosed);
            this.Load += new System.EventHandler(this.HotelTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hotel_bookingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.room_bookingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.room_bookingBindingNavigator)).EndInit();
            this.room_bookingBindingNavigator.ResumeLayout(false);
            this.room_bookingBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.room_bookingDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelroomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_roomDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomtypeBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource room_bookingBindingSource;
        private hotel_bookingDataSetTableAdapters.room_bookingTableAdapter room_bookingTableAdapter;
        private hotel_bookingDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator room_bookingBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton room_bookingBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView room_bookingDataGridView;
        private hotel_bookingDataSetTableAdapters.hotel_roomTableAdapter hotel_roomTableAdapter;
        private System.Windows.Forms.BindingSource hotelroomBindingSource;
        private hotel_bookingDataSetTableAdapters.bookingTableAdapter bookingTableAdapter;
        private System.Windows.Forms.BindingSource bookingBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView hotel_roomDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView bookingDataGridView;
        private System.Windows.Forms.BindingSource hotelBindingSource;
        private hotel_bookingDataSetTableAdapters.hotelTableAdapter hotelTableAdapter;
        private System.Windows.Forms.BindingSource roomtypeBindingSource;
        private hotel_bookingDataSetTableAdapters.room_typeTableAdapter room_typeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.BindingSource useraccountBindingSource;
        private hotel_bookingDataSetTableAdapters.user_accountTableAdapter user_accountTableAdapter;
        private System.Windows.Forms.BindingSource paymentrecordBindingSource;
        private hotel_bookingDataSetTableAdapters.payment_recordTableAdapter payment_recordTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.Panel panel1;
    }
}