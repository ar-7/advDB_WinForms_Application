
namespace ROB19002438_LP20549A1_advDB
{
    partial class RoomTypeTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomTypeTable));
            this.logOutButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.formTitle = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.hotel_bookingDataSet = new ROB19002438_LP20549A1_advDB.hotel_bookingDataSet();
            this.room_typeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.room_typeTableAdapter = new ROB19002438_LP20549A1_advDB.hotel_bookingDataSetTableAdapters.room_typeTableAdapter();
            this.tableAdapterManager = new ROB19002438_LP20549A1_advDB.hotel_bookingDataSetTableAdapters.TableAdapterManager();
            this.room_typeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.room_typeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.room_typeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_bookingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.room_typeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.room_typeBindingNavigator)).BeginInit();
            this.room_typeBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.room_typeDataGridView)).BeginInit();
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
            this.formTitle.Size = new System.Drawing.Size(231, 20);
            this.formTitle.TabIndex = 6;
            this.formTitle.Text = "Room Type Table Management";
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
            // room_typeBindingSource
            // 
            this.room_typeBindingSource.DataMember = "room_type";
            this.room_typeBindingSource.DataSource = this.hotel_bookingDataSet;
            // 
            // room_typeTableAdapter
            // 
            this.room_typeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.admin_accountTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bookingTableAdapter = null;
            this.tableAdapterManager.cityTableAdapter = null;
            this.tableAdapterManager.hotel_roomTableAdapter = null;
            this.tableAdapterManager.hotelTableAdapter = null;
            this.tableAdapterManager.imageTableAdapter = null;
            this.tableAdapterManager.payment_recordTableAdapter = null;
            this.tableAdapterManager.postcodeTableAdapter = null;
            this.tableAdapterManager.room_bookingTableAdapter = null;
            this.tableAdapterManager.room_typeTableAdapter = this.room_typeTableAdapter;
            this.tableAdapterManager.UpdateOrder = ROB19002438_LP20549A1_advDB.hotel_bookingDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.user_accountTableAdapter = null;
            // 
            // room_typeBindingNavigator
            // 
            this.room_typeBindingNavigator.AddNewItem = null;
            this.room_typeBindingNavigator.BindingSource = this.room_typeBindingSource;
            this.room_typeBindingNavigator.CountItem = null;
            this.room_typeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.room_typeBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.room_typeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorSeparator,
            this.bindingNavigatorDeleteItem,
            this.bindingNavigatorSeparator2,
            this.room_typeBindingNavigatorSaveItem});
            this.room_typeBindingNavigator.Location = new System.Drawing.Point(27, 72);
            this.room_typeBindingNavigator.MoveFirstItem = null;
            this.room_typeBindingNavigator.MoveLastItem = null;
            this.room_typeBindingNavigator.MoveNextItem = null;
            this.room_typeBindingNavigator.MovePreviousItem = null;
            this.room_typeBindingNavigator.Name = "room_typeBindingNavigator";
            this.room_typeBindingNavigator.PositionItem = null;
            this.room_typeBindingNavigator.Size = new System.Drawing.Size(162, 25);
            this.room_typeBindingNavigator.TabIndex = 10;
            this.room_typeBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(60, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // room_typeBindingNavigatorSaveItem
            // 
            this.room_typeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("room_typeBindingNavigatorSaveItem.Image")));
            this.room_typeBindingNavigatorSaveItem.Name = "room_typeBindingNavigatorSaveItem";
            this.room_typeBindingNavigatorSaveItem.Size = new System.Drawing.Size(78, 22);
            this.room_typeBindingNavigatorSaveItem.Text = "Save Data";
            this.room_typeBindingNavigatorSaveItem.Click += new System.EventHandler(this.room_typeBindingNavigatorSaveItem_Click);
            // 
            // room_typeDataGridView
            // 
            this.room_typeDataGridView.AutoGenerateColumns = false;
            this.room_typeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.room_typeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.room_typeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.room_typeDataGridView.DataSource = this.room_typeBindingSource;
            this.room_typeDataGridView.Location = new System.Drawing.Point(27, 100);
            this.room_typeDataGridView.Name = "room_typeDataGridView";
            this.room_typeDataGridView.Size = new System.Drawing.Size(930, 430);
            this.room_typeDataGridView.TabIndex = 10;
            this.room_typeDataGridView.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.room_typeDataGridView_CellValidated);
            this.room_typeDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.room_typeDataGridView_DataError);
            this.room_typeDataGridView.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.room_typeDataGridView_RowValidating);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "type_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Type ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.ToolTipText = "Read Only Unique ID";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "type";
            this.dataGridViewTextBoxColumn2.HeaderText = "Room Type";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "capacity";
            this.dataGridViewTextBoxColumn3.HeaderText = "Capacity";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // RoomTypeTable
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.room_typeDataGridView);
            this.Controls.Add(this.room_typeBindingNavigator);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.formTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Name = "RoomTypeTable";
            this.Text = "Room Type Table Management";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HotelTable_FormClosed);
            this.Load += new System.EventHandler(this.HotelTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hotel_bookingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.room_typeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.room_typeBindingNavigator)).EndInit();
            this.room_typeBindingNavigator.ResumeLayout(false);
            this.room_typeBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.room_typeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Label formTitle;
        private System.Windows.Forms.Button backButton;
        private hotel_bookingDataSet hotel_bookingDataSet;
        private System.Windows.Forms.BindingSource room_typeBindingSource;
        private hotel_bookingDataSetTableAdapters.room_typeTableAdapter room_typeTableAdapter;
        private hotel_bookingDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator room_typeBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton room_typeBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView room_typeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}