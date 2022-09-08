
namespace ROB19002438_LP20549A1_advDB
{
    partial class AdminAccountTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminAccountTable));
            this.logOutButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.formTitle = new System.Windows.Forms.Label();
            this.admin_accountBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.admin_accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotel_bookingDataSet = new ROB19002438_LP20549A1_advDB.hotel_bookingDataSet();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.admin_accountBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.admin_accountDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admin_accountTableAdapter = new ROB19002438_LP20549A1_advDB.hotel_bookingDataSetTableAdapters.admin_accountTableAdapter();
            this.tableAdapterManager = new ROB19002438_LP20549A1_advDB.hotel_bookingDataSetTableAdapters.TableAdapterManager();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.admin_accountBindingNavigator)).BeginInit();
            this.admin_accountBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.admin_accountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_bookingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.admin_accountDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // logOutButton
            // 
            this.logOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.logOutButton.Location = new System.Drawing.Point(763, 23);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(100, 30);
            this.logOutButton.TabIndex = 4;
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
            this.helpButton.TabIndex = 5;
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
            this.formTitle.Size = new System.Drawing.Size(258, 20);
            this.formTitle.TabIndex = 3;
            this.formTitle.Text = "Admin Account Table Management";
            // 
            // admin_accountBindingNavigator
            // 
            this.admin_accountBindingNavigator.AddNewItem = null;
            this.admin_accountBindingNavigator.BindingSource = this.admin_accountBindingSource;
            this.admin_accountBindingNavigator.CountItem = null;
            this.admin_accountBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.admin_accountBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.admin_accountBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorSeparator,
            this.bindingNavigatorDeleteItem,
            this.bindingNavigatorSeparator2,
            this.admin_accountBindingNavigatorSaveItem});
            this.admin_accountBindingNavigator.Location = new System.Drawing.Point(27, 72);
            this.admin_accountBindingNavigator.MoveFirstItem = null;
            this.admin_accountBindingNavigator.MoveLastItem = null;
            this.admin_accountBindingNavigator.MoveNextItem = null;
            this.admin_accountBindingNavigator.MovePreviousItem = null;
            this.admin_accountBindingNavigator.Name = "admin_accountBindingNavigator";
            this.admin_accountBindingNavigator.PositionItem = null;
            this.admin_accountBindingNavigator.Size = new System.Drawing.Size(162, 25);
            this.admin_accountBindingNavigator.TabIndex = 6;
            this.admin_accountBindingNavigator.Text = "bindingNavigator1";
            // 
            // admin_accountBindingSource
            // 
            this.admin_accountBindingSource.DataMember = "admin_account";
            this.admin_accountBindingSource.DataSource = this.hotel_bookingDataSet;
            // 
            // hotel_bookingDataSet
            // 
            this.hotel_bookingDataSet.DataSetName = "hotel_bookingDataSet";
            this.hotel_bookingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // admin_accountBindingNavigatorSaveItem
            // 
            this.admin_accountBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("admin_accountBindingNavigatorSaveItem.Image")));
            this.admin_accountBindingNavigatorSaveItem.Name = "admin_accountBindingNavigatorSaveItem";
            this.admin_accountBindingNavigatorSaveItem.Size = new System.Drawing.Size(78, 22);
            this.admin_accountBindingNavigatorSaveItem.Text = "Save Data";
            this.admin_accountBindingNavigatorSaveItem.Click += new System.EventHandler(this.admin_accountBindingNavigatorSaveItem_Click);
            // 
            // admin_accountDataGridView
            // 
            this.admin_accountDataGridView.AutoGenerateColumns = false;
            this.admin_accountDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.admin_accountDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.admin_accountDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.admin_accountDataGridView.DataSource = this.admin_accountBindingSource;
            this.admin_accountDataGridView.Location = new System.Drawing.Point(27, 100);
            this.admin_accountDataGridView.Name = "admin_accountDataGridView";
            this.admin_accountDataGridView.Size = new System.Drawing.Size(930, 430);
            this.admin_accountDataGridView.TabIndex = 6;
            this.admin_accountDataGridView.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellValidated);
            this.admin_accountDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DataGridView_DataError);
            this.admin_accountDataGridView.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.DataGridView_RowValidating);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "admin_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Admin ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.ToolTipText = "Read Only Unique ID";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "admin_username";
            this.dataGridViewTextBoxColumn2.HeaderText = "Username";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "admin_password";
            this.dataGridViewTextBoxColumn3.HeaderText = "Password";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "admin_email";
            this.dataGridViewTextBoxColumn4.HeaderText = "Email";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "admin_access_level";
            this.dataGridViewTextBoxColumn5.HeaderText = "Access Level";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // admin_accountTableAdapter
            // 
            this.admin_accountTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.admin_accountTableAdapter = this.admin_accountTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bookingTableAdapter = null;
            this.tableAdapterManager.cityTableAdapter = null;
            this.tableAdapterManager.hotel_roomTableAdapter = null;
            this.tableAdapterManager.hotelTableAdapter = null;
            this.tableAdapterManager.imageTableAdapter = null;
            this.tableAdapterManager.payment_recordTableAdapter = null;
            this.tableAdapterManager.postcodeTableAdapter = null;
            this.tableAdapterManager.room_bookingTableAdapter = null;
            this.tableAdapterManager.room_typeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ROB19002438_LP20549A1_advDB.hotel_bookingDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.user_accountTableAdapter = null;
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.backButton.Location = new System.Drawing.Point(589, 23);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(158, 30);
            this.backButton.TabIndex = 19;
            this.backButton.Text = "Return to Admin Menu";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // AdminAccountTable
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.admin_accountDataGridView);
            this.Controls.Add(this.admin_accountBindingNavigator);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.formTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Name = "AdminAccountTable";
            this.Text = "Admin Account Table Management";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminAccountTable_FormClosed);
            this.Load += new System.EventHandler(this.AdminAccountTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.admin_accountBindingNavigator)).EndInit();
            this.admin_accountBindingNavigator.ResumeLayout(false);
            this.admin_accountBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.admin_accountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_bookingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.admin_accountDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Label formTitle;
        private hotel_bookingDataSet hotel_bookingDataSet;
        private System.Windows.Forms.BindingSource admin_accountBindingSource;
        private hotel_bookingDataSetTableAdapters.admin_accountTableAdapter admin_accountTableAdapter;
        private hotel_bookingDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator admin_accountBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripButton admin_accountBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView admin_accountDataGridView;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}