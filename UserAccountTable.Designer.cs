
namespace ROB19002438_LP20549A1_advDB
{
    partial class UserAccountTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserAccountTable));
            this.logOutButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.formTitle = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.hotel_bookingDataSet = new ROB19002438_LP20549A1_advDB.hotel_bookingDataSet();
            this.user_accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.user_accountTableAdapter = new ROB19002438_LP20549A1_advDB.hotel_bookingDataSetTableAdapters.user_accountTableAdapter();
            this.tableAdapterManager = new ROB19002438_LP20549A1_advDB.hotel_bookingDataSetTableAdapters.TableAdapterManager();
            this.postcodeTableAdapter = new ROB19002438_LP20549A1_advDB.hotel_bookingDataSetTableAdapters.postcodeTableAdapter();
            this.user_accountBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.user_accountBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.user_accountDataGridView = new System.Windows.Forms.DataGridView();
            this.postcodeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_bookingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_accountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_accountBindingNavigator)).BeginInit();
            this.user_accountBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_accountDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postcodeBindingSource)).BeginInit();
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
            this.formTitle.Size = new System.Drawing.Size(247, 20);
            this.formTitle.TabIndex = 6;
            this.formTitle.Text = "User Account Table Management";
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
            // user_accountBindingSource
            // 
            this.user_accountBindingSource.DataMember = "user_account";
            this.user_accountBindingSource.DataSource = this.hotel_bookingDataSet;
            // 
            // user_accountTableAdapter
            // 
            this.user_accountTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.postcodeTableAdapter = this.postcodeTableAdapter;
            this.tableAdapterManager.room_bookingTableAdapter = null;
            this.tableAdapterManager.room_typeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ROB19002438_LP20549A1_advDB.hotel_bookingDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.user_accountTableAdapter = this.user_accountTableAdapter;
            // 
            // postcodeTableAdapter
            // 
            this.postcodeTableAdapter.ClearBeforeFill = true;
            // 
            // user_accountBindingNavigator
            // 
            this.user_accountBindingNavigator.AddNewItem = null;
            this.user_accountBindingNavigator.BindingSource = this.user_accountBindingSource;
            this.user_accountBindingNavigator.CountItem = null;
            this.user_accountBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.user_accountBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.user_accountBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorDeleteItem,
            this.bindingNavigatorSeparator1,
            this.user_accountBindingNavigatorSaveItem});
            this.user_accountBindingNavigator.Location = new System.Drawing.Point(27, 72);
            this.user_accountBindingNavigator.MoveFirstItem = null;
            this.user_accountBindingNavigator.MoveLastItem = null;
            this.user_accountBindingNavigator.MoveNextItem = null;
            this.user_accountBindingNavigator.MovePreviousItem = null;
            this.user_accountBindingNavigator.Name = "user_accountBindingNavigator";
            this.user_accountBindingNavigator.PositionItem = null;
            this.user_accountBindingNavigator.Size = new System.Drawing.Size(162, 25);
            this.user_accountBindingNavigator.TabIndex = 10;
            this.user_accountBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(60, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // user_accountBindingNavigatorSaveItem
            // 
            this.user_accountBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("user_accountBindingNavigatorSaveItem.Image")));
            this.user_accountBindingNavigatorSaveItem.Name = "user_accountBindingNavigatorSaveItem";
            this.user_accountBindingNavigatorSaveItem.Size = new System.Drawing.Size(78, 22);
            this.user_accountBindingNavigatorSaveItem.Text = "Save Data";
            this.user_accountBindingNavigatorSaveItem.Click += new System.EventHandler(this.user_accountBindingNavigatorSaveItem_Click);
            // 
            // user_accountDataGridView
            // 
            this.user_accountDataGridView.AutoGenerateColumns = false;
            this.user_accountDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.user_accountDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.user_accountDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.user_accountDataGridView.DataSource = this.user_accountBindingSource;
            this.user_accountDataGridView.Location = new System.Drawing.Point(27, 100);
            this.user_accountDataGridView.Name = "user_accountDataGridView";
            this.user_accountDataGridView.Size = new System.Drawing.Size(930, 430);
            this.user_accountDataGridView.TabIndex = 10;
            this.user_accountDataGridView.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.user_accountDataGridView_CellValidated);
            this.user_accountDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.user_accountDataGridView_DataError);
            this.user_accountDataGridView.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.user_accountDataGridView_RowValidating);
            // 
            // postcodeBindingSource
            // 
            this.postcodeBindingSource.DataMember = "postcode";
            this.postcodeBindingSource.DataSource = this.hotel_bookingDataSet;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "user_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "User ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.ToolTipText = "Read Only Unique ID";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "user_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Username";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "user_password";
            this.dataGridViewTextBoxColumn3.HeaderText = "Password";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "user_email";
            this.dataGridViewTextBoxColumn4.HeaderText = "Email";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "user_fullname";
            this.dataGridViewTextBoxColumn5.HeaderText = "Full Name";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "user_address";
            this.dataGridViewTextBoxColumn6.HeaderText = "Address";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "postcode_id";
            this.dataGridViewTextBoxColumn7.DataSource = this.postcodeBindingSource;
            this.dataGridViewTextBoxColumn7.DisplayMember = "postcode";
            this.dataGridViewTextBoxColumn7.HeaderText = "Postcode";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn7.ValueMember = "postcode_id";
            // 
            // UserAccountTable
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.user_accountDataGridView);
            this.Controls.Add(this.user_accountBindingNavigator);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.formTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Name = "UserAccountTable";
            this.Text = "User Account Table Management";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HotelTable_FormClosed);
            this.Load += new System.EventHandler(this.HotelTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hotel_bookingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_accountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_accountBindingNavigator)).EndInit();
            this.user_accountBindingNavigator.ResumeLayout(false);
            this.user_accountBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_accountDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postcodeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Label formTitle;
        private System.Windows.Forms.Button backButton;
        private hotel_bookingDataSet hotel_bookingDataSet;
        private System.Windows.Forms.BindingSource user_accountBindingSource;
        private hotel_bookingDataSetTableAdapters.user_accountTableAdapter user_accountTableAdapter;
        private hotel_bookingDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator user_accountBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton user_accountBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView user_accountDataGridView;
        private hotel_bookingDataSetTableAdapters.postcodeTableAdapter postcodeTableAdapter;
        private System.Windows.Forms.BindingSource postcodeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn7;
    }
}