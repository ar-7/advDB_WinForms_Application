
namespace ROB19002438_LP20549A1_advDB
{
    partial class HotelRoomTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HotelRoomTable));
            this.logOutButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.formTitle = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.hotel_bookingDataSet = new ROB19002438_LP20549A1_advDB.hotel_bookingDataSet();
            this.hotel_roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotel_roomTableAdapter = new ROB19002438_LP20549A1_advDB.hotel_bookingDataSetTableAdapters.hotel_roomTableAdapter();
            this.tableAdapterManager = new ROB19002438_LP20549A1_advDB.hotel_bookingDataSetTableAdapters.TableAdapterManager();
            this.hotelTableAdapter = new ROB19002438_LP20549A1_advDB.hotel_bookingDataSetTableAdapters.hotelTableAdapter();
            this.room_typeTableAdapter = new ROB19002438_LP20549A1_advDB.hotel_bookingDataSetTableAdapters.room_typeTableAdapter();
            this.hotel_roomBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.hotel_roomBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.hotel_roomDataGridView = new System.Windows.Forms.DataGridView();
            this.hotelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomtypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_bookingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_roomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_roomBindingNavigator)).BeginInit();
            this.hotel_roomBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_roomDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomtypeBindingSource)).BeginInit();
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
            this.formTitle.Size = new System.Drawing.Size(235, 20);
            this.formTitle.TabIndex = 6;
            this.formTitle.Text = "Hotel Room Table Management";
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
            // hotel_roomBindingSource
            // 
            this.hotel_roomBindingSource.DataMember = "hotel_room";
            this.hotel_roomBindingSource.DataSource = this.hotel_bookingDataSet;
            // 
            // hotel_roomTableAdapter
            // 
            this.hotel_roomTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.admin_accountTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bookingTableAdapter = null;
            this.tableAdapterManager.cityTableAdapter = null;
            this.tableAdapterManager.hotel_roomTableAdapter = this.hotel_roomTableAdapter;
            this.tableAdapterManager.hotelTableAdapter = this.hotelTableAdapter;
            this.tableAdapterManager.imageTableAdapter = null;
            this.tableAdapterManager.payment_recordTableAdapter = null;
            this.tableAdapterManager.postcodeTableAdapter = null;
            this.tableAdapterManager.room_bookingTableAdapter = null;
            this.tableAdapterManager.room_typeTableAdapter = this.room_typeTableAdapter;
            this.tableAdapterManager.UpdateOrder = ROB19002438_LP20549A1_advDB.hotel_bookingDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.user_accountTableAdapter = null;
            // 
            // hotelTableAdapter
            // 
            this.hotelTableAdapter.ClearBeforeFill = true;
            // 
            // room_typeTableAdapter
            // 
            this.room_typeTableAdapter.ClearBeforeFill = true;
            // 
            // hotel_roomBindingNavigator
            // 
            this.hotel_roomBindingNavigator.AddNewItem = null;
            this.hotel_roomBindingNavigator.BindingSource = this.hotel_roomBindingSource;
            this.hotel_roomBindingNavigator.CountItem = null;
            this.hotel_roomBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.hotel_roomBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.hotel_roomBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorDeleteItem,
            this.bindingNavigatorSeparator2,
            this.hotel_roomBindingNavigatorSaveItem});
            this.hotel_roomBindingNavigator.Location = new System.Drawing.Point(27, 72);
            this.hotel_roomBindingNavigator.MoveFirstItem = null;
            this.hotel_roomBindingNavigator.MoveLastItem = null;
            this.hotel_roomBindingNavigator.MoveNextItem = null;
            this.hotel_roomBindingNavigator.MovePreviousItem = null;
            this.hotel_roomBindingNavigator.Name = "hotel_roomBindingNavigator";
            this.hotel_roomBindingNavigator.PositionItem = null;
            this.hotel_roomBindingNavigator.Size = new System.Drawing.Size(162, 25);
            this.hotel_roomBindingNavigator.TabIndex = 10;
            this.hotel_roomBindingNavigator.Text = "bindingNavigator1";
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
            // hotel_roomBindingNavigatorSaveItem
            // 
            this.hotel_roomBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("hotel_roomBindingNavigatorSaveItem.Image")));
            this.hotel_roomBindingNavigatorSaveItem.Name = "hotel_roomBindingNavigatorSaveItem";
            this.hotel_roomBindingNavigatorSaveItem.Size = new System.Drawing.Size(78, 22);
            this.hotel_roomBindingNavigatorSaveItem.Text = "Save Data";
            this.hotel_roomBindingNavigatorSaveItem.Click += new System.EventHandler(this.hotel_roomBindingNavigatorSaveItem_Click);
            // 
            // hotel_roomDataGridView
            // 
            this.hotel_roomDataGridView.AutoGenerateColumns = false;
            this.hotel_roomDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.hotel_roomDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hotel_roomDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.hotel_roomDataGridView.DataSource = this.hotel_roomBindingSource;
            this.hotel_roomDataGridView.Location = new System.Drawing.Point(27, 100);
            this.hotel_roomDataGridView.Name = "hotel_roomDataGridView";
            this.hotel_roomDataGridView.Size = new System.Drawing.Size(930, 430);
            this.hotel_roomDataGridView.TabIndex = 10;
            this.hotel_roomDataGridView.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.hotel_roomDataGridView_CellValidated);
            this.hotel_roomDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.hotel_roomDataGridView_DataError);
            this.hotel_roomDataGridView.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.hotel_roomDataGridView_RowValidating);
            // 
            // hotelBindingSource
            // 
            this.hotelBindingSource.DataMember = "hotel";
            this.hotelBindingSource.DataSource = this.hotel_bookingDataSet;
            // 
            // roomtypeBindingSource
            // 
            this.roomtypeBindingSource.DataMember = "room_type";
            this.roomtypeBindingSource.DataSource = this.hotel_bookingDataSet;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "room_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Room ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.ToolTipText = "Read Only Unique ID";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "hotel_id";
            this.dataGridViewTextBoxColumn2.DataSource = this.hotelBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "hotel_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Hotel Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "hotel_id";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "room_number_or_name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Room # or Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "type_id";
            this.dataGridViewTextBoxColumn4.DataSource = this.roomtypeBindingSource;
            this.dataGridViewTextBoxColumn4.DisplayMember = "type";
            this.dataGridViewTextBoxColumn4.HeaderText = "Room Type";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn4.ValueMember = "type_id";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "price_per_night";
            this.dataGridViewTextBoxColumn5.HeaderText = "Price Per Night";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // HotelRoomTable
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.hotel_roomDataGridView);
            this.Controls.Add(this.hotel_roomBindingNavigator);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.formTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Name = "HotelRoomTable";
            this.Text = "Hotel Room Table Management";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HotelTable_FormClosed);
            this.Load += new System.EventHandler(this.HotelTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hotel_bookingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_roomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_roomBindingNavigator)).EndInit();
            this.hotel_roomBindingNavigator.ResumeLayout(false);
            this.hotel_roomBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_roomDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomtypeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Label formTitle;
        private System.Windows.Forms.Button backButton;
        private hotel_bookingDataSet hotel_bookingDataSet;
        private System.Windows.Forms.BindingSource hotel_roomBindingSource;
        private hotel_bookingDataSetTableAdapters.hotel_roomTableAdapter hotel_roomTableAdapter;
        private hotel_bookingDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator hotel_roomBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton hotel_roomBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView hotel_roomDataGridView;
        private hotel_bookingDataSetTableAdapters.hotelTableAdapter hotelTableAdapter;
        private System.Windows.Forms.BindingSource hotelBindingSource;
        private hotel_bookingDataSetTableAdapters.room_typeTableAdapter room_typeTableAdapter;
        private System.Windows.Forms.BindingSource roomtypeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}