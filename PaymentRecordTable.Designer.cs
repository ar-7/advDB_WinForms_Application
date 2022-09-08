
namespace ROB19002438_LP20549A1_advDB
{
    partial class PaymentRecordTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentRecordTable));
            this.logOutButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.formTitle = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.hotel_bookingDataSet = new ROB19002438_LP20549A1_advDB.hotel_bookingDataSet();
            this.payment_recordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.payment_recordTableAdapter = new ROB19002438_LP20549A1_advDB.hotel_bookingDataSetTableAdapters.payment_recordTableAdapter();
            this.tableAdapterManager = new ROB19002438_LP20549A1_advDB.hotel_bookingDataSetTableAdapters.TableAdapterManager();
            this.payment_recordBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.payment_recordBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.payment_recordDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_bookingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payment_recordBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payment_recordBindingNavigator)).BeginInit();
            this.payment_recordBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payment_recordDataGridView)).BeginInit();
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
            this.formTitle.Size = new System.Drawing.Size(212, 20);
            this.formTitle.TabIndex = 6;
            this.formTitle.Text = "Payment Table Management";
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
            // payment_recordBindingSource
            // 
            this.payment_recordBindingSource.DataMember = "payment_record";
            this.payment_recordBindingSource.DataSource = this.hotel_bookingDataSet;
            // 
            // payment_recordTableAdapter
            // 
            this.payment_recordTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.payment_recordTableAdapter = this.payment_recordTableAdapter;
            this.tableAdapterManager.postcodeTableAdapter = null;
            this.tableAdapterManager.room_bookingTableAdapter = null;
            this.tableAdapterManager.room_typeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ROB19002438_LP20549A1_advDB.hotel_bookingDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.user_accountTableAdapter = null;
            // 
            // payment_recordBindingNavigator
            // 
            this.payment_recordBindingNavigator.AddNewItem = null;
            this.payment_recordBindingNavigator.BindingSource = this.payment_recordBindingSource;
            this.payment_recordBindingNavigator.CountItem = null;
            this.payment_recordBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.payment_recordBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.payment_recordBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorDeleteItem,
            this.bindingNavigatorSeparator1,
            this.payment_recordBindingNavigatorSaveItem});
            this.payment_recordBindingNavigator.Location = new System.Drawing.Point(27, 72);
            this.payment_recordBindingNavigator.MoveFirstItem = null;
            this.payment_recordBindingNavigator.MoveLastItem = null;
            this.payment_recordBindingNavigator.MoveNextItem = null;
            this.payment_recordBindingNavigator.MovePreviousItem = null;
            this.payment_recordBindingNavigator.Name = "payment_recordBindingNavigator";
            this.payment_recordBindingNavigator.PositionItem = null;
            this.payment_recordBindingNavigator.Size = new System.Drawing.Size(162, 25);
            this.payment_recordBindingNavigator.TabIndex = 10;
            this.payment_recordBindingNavigator.Text = "bindingNavigator1";
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
            // payment_recordBindingNavigatorSaveItem
            // 
            this.payment_recordBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("payment_recordBindingNavigatorSaveItem.Image")));
            this.payment_recordBindingNavigatorSaveItem.Name = "payment_recordBindingNavigatorSaveItem";
            this.payment_recordBindingNavigatorSaveItem.Size = new System.Drawing.Size(78, 22);
            this.payment_recordBindingNavigatorSaveItem.Text = "Save Data";
            this.payment_recordBindingNavigatorSaveItem.Click += new System.EventHandler(this.payment_recordBindingNavigatorSaveItem_Click);
            // 
            // payment_recordDataGridView
            // 
            this.payment_recordDataGridView.AutoGenerateColumns = false;
            this.payment_recordDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.payment_recordDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.payment_recordDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewCheckBoxColumn1});
            this.payment_recordDataGridView.DataSource = this.payment_recordBindingSource;
            this.payment_recordDataGridView.Location = new System.Drawing.Point(27, 100);
            this.payment_recordDataGridView.Name = "payment_recordDataGridView";
            this.payment_recordDataGridView.Size = new System.Drawing.Size(930, 430);
            this.payment_recordDataGridView.TabIndex = 10;
            this.payment_recordDataGridView.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.payment_recordDataGridView_CellValidated);
            this.payment_recordDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.payment_recordDataGridView_DataError);
            this.payment_recordDataGridView.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.payment_recordDataGridView_RowValidating);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "payment_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Payment ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.ToolTipText = "Read Only Unique ID";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "payment_amount";
            this.dataGridViewTextBoxColumn2.HeaderText = "payment_amount";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "payment_paid";
            this.dataGridViewCheckBoxColumn1.HeaderText = "payment_paid";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // PaymentRecordTable
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.payment_recordDataGridView);
            this.Controls.Add(this.payment_recordBindingNavigator);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.formTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Name = "PaymentRecordTable";
            this.Text = "Payment Table Management";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HotelTable_FormClosed);
            this.Load += new System.EventHandler(this.HotelTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hotel_bookingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payment_recordBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payment_recordBindingNavigator)).EndInit();
            this.payment_recordBindingNavigator.ResumeLayout(false);
            this.payment_recordBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payment_recordDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Label formTitle;
        private System.Windows.Forms.Button backButton;
        private hotel_bookingDataSet hotel_bookingDataSet;
        private System.Windows.Forms.BindingSource payment_recordBindingSource;
        private hotel_bookingDataSetTableAdapters.payment_recordTableAdapter payment_recordTableAdapter;
        private hotel_bookingDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator payment_recordBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton payment_recordBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView payment_recordDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    }
}