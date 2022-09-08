
namespace ROB19002438_LP20549A1_advDB
{
    partial class PostcodeTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PostcodeTable));
            this.logOutButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.formTitle = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.hotel_bookingDataSet = new ROB19002438_LP20549A1_advDB.hotel_bookingDataSet();
            this.postcodeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postcodeTableAdapter = new ROB19002438_LP20549A1_advDB.hotel_bookingDataSetTableAdapters.postcodeTableAdapter();
            this.tableAdapterManager = new ROB19002438_LP20549A1_advDB.hotel_bookingDataSetTableAdapters.TableAdapterManager();
            this.postcodeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.postcodeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.postcodeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_bookingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postcodeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postcodeBindingNavigator)).BeginInit();
            this.postcodeBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postcodeDataGridView)).BeginInit();
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
            this.formTitle.Size = new System.Drawing.Size(217, 20);
            this.formTitle.TabIndex = 6;
            this.formTitle.Text = "Postcode Table Management";
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
            // postcodeBindingSource
            // 
            this.postcodeBindingSource.DataMember = "postcode";
            this.postcodeBindingSource.DataSource = this.hotel_bookingDataSet;
            // 
            // postcodeTableAdapter
            // 
            this.postcodeTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.user_accountTableAdapter = null;
            // 
            // postcodeBindingNavigator
            // 
            this.postcodeBindingNavigator.AddNewItem = null;
            this.postcodeBindingNavigator.BindingSource = this.postcodeBindingSource;
            this.postcodeBindingNavigator.CountItem = null;
            this.postcodeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.postcodeBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.postcodeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorSeparator,
            this.bindingNavigatorDeleteItem,
            this.bindingNavigatorSeparator2,
            this.postcodeBindingNavigatorSaveItem});
            this.postcodeBindingNavigator.Location = new System.Drawing.Point(27, 72);
            this.postcodeBindingNavigator.MoveFirstItem = null;
            this.postcodeBindingNavigator.MoveLastItem = null;
            this.postcodeBindingNavigator.MoveNextItem = null;
            this.postcodeBindingNavigator.MovePreviousItem = null;
            this.postcodeBindingNavigator.Name = "postcodeBindingNavigator";
            this.postcodeBindingNavigator.PositionItem = null;
            this.postcodeBindingNavigator.Size = new System.Drawing.Size(162, 25);
            this.postcodeBindingNavigator.TabIndex = 10;
            this.postcodeBindingNavigator.Text = "bindingNavigator1";
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
            // postcodeBindingNavigatorSaveItem
            // 
            this.postcodeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("postcodeBindingNavigatorSaveItem.Image")));
            this.postcodeBindingNavigatorSaveItem.Name = "postcodeBindingNavigatorSaveItem";
            this.postcodeBindingNavigatorSaveItem.Size = new System.Drawing.Size(78, 22);
            this.postcodeBindingNavigatorSaveItem.Text = "Save Data";
            this.postcodeBindingNavigatorSaveItem.Click += new System.EventHandler(this.postcodeBindingNavigatorSaveItem_Click);
            // 
            // postcodeDataGridView
            // 
            this.postcodeDataGridView.AutoGenerateColumns = false;
            this.postcodeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.postcodeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.postcodeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.postcodeDataGridView.DataSource = this.postcodeBindingSource;
            this.postcodeDataGridView.Location = new System.Drawing.Point(27, 100);
            this.postcodeDataGridView.Name = "postcodeDataGridView";
            this.postcodeDataGridView.Size = new System.Drawing.Size(930, 430);
            this.postcodeDataGridView.TabIndex = 10;
            this.postcodeDataGridView.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.postcodeDataGridView_CellValidated);
            this.postcodeDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.postcodeDataGridView_DataError);
            this.postcodeDataGridView.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.postcodeDataGridView_RowValidating);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "postcode_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Postcode ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.ToolTipText = "Read Only Unique ID";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "postcode";
            this.dataGridViewTextBoxColumn2.HeaderText = "Postcode";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // PostcodeTable
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.postcodeDataGridView);
            this.Controls.Add(this.postcodeBindingNavigator);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.formTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Name = "PostcodeTable";
            this.Text = "Postcode Table Management";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HotelTable_FormClosed);
            this.Load += new System.EventHandler(this.HotelTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hotel_bookingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postcodeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postcodeBindingNavigator)).EndInit();
            this.postcodeBindingNavigator.ResumeLayout(false);
            this.postcodeBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postcodeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Label formTitle;
        private System.Windows.Forms.Button backButton;
        private hotel_bookingDataSet hotel_bookingDataSet;
        private System.Windows.Forms.BindingSource postcodeBindingSource;
        private hotel_bookingDataSetTableAdapters.postcodeTableAdapter postcodeTableAdapter;
        private hotel_bookingDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator postcodeBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton postcodeBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView postcodeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}