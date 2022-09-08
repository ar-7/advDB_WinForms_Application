
namespace ROB19002438_LP20549A1_advDB
{
    partial class ImageTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageTable));
            this.logOutButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.formTitle = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.hotel_bookingDataSet = new ROB19002438_LP20549A1_advDB.hotel_bookingDataSet();
            this.imageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imageTableAdapter = new ROB19002438_LP20549A1_advDB.hotel_bookingDataSetTableAdapters.imageTableAdapter();
            this.tableAdapterManager = new ROB19002438_LP20549A1_advDB.hotel_bookingDataSetTableAdapters.TableAdapterManager();
            this.hotelTableAdapter = new ROB19002438_LP20549A1_advDB.hotel_bookingDataSetTableAdapters.hotelTableAdapter();
            this.imageBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.imageBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.imageDataGridView = new System.Windows.Forms.DataGridView();
            this.hotelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_bookingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBindingNavigator)).BeginInit();
            this.imageBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelBindingSource)).BeginInit();
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
            this.formTitle.Size = new System.Drawing.Size(195, 20);
            this.formTitle.TabIndex = 6;
            this.formTitle.Text = "Image Table Management";
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
            // imageBindingSource
            // 
            this.imageBindingSource.DataMember = "image";
            this.imageBindingSource.DataSource = this.hotel_bookingDataSet;
            // 
            // imageTableAdapter
            // 
            this.imageTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.admin_accountTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.bookingTableAdapter = null;
            this.tableAdapterManager.cityTableAdapter = null;
            this.tableAdapterManager.hotel_roomTableAdapter = null;
            this.tableAdapterManager.hotelTableAdapter = this.hotelTableAdapter;
            this.tableAdapterManager.imageTableAdapter = this.imageTableAdapter;
            this.tableAdapterManager.payment_recordTableAdapter = null;
            this.tableAdapterManager.postcodeTableAdapter = null;
            this.tableAdapterManager.room_bookingTableAdapter = null;
            this.tableAdapterManager.room_typeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ROB19002438_LP20549A1_advDB.hotel_bookingDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.user_accountTableAdapter = null;
            // 
            // hotelTableAdapter
            // 
            this.hotelTableAdapter.ClearBeforeFill = true;
            // 
            // imageBindingNavigator
            // 
            this.imageBindingNavigator.AddNewItem = null;
            this.imageBindingNavigator.BindingSource = this.imageBindingSource;
            this.imageBindingNavigator.CountItem = null;
            this.imageBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.imageBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.imageBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorDeleteItem,
            this.bindingNavigatorSeparator2,
            this.imageBindingNavigatorSaveItem});
            this.imageBindingNavigator.Location = new System.Drawing.Point(27, 72);
            this.imageBindingNavigator.MoveFirstItem = null;
            this.imageBindingNavigator.MoveLastItem = null;
            this.imageBindingNavigator.MoveNextItem = null;
            this.imageBindingNavigator.MovePreviousItem = null;
            this.imageBindingNavigator.Name = "imageBindingNavigator";
            this.imageBindingNavigator.PositionItem = null;
            this.imageBindingNavigator.Size = new System.Drawing.Size(162, 25);
            this.imageBindingNavigator.TabIndex = 10;
            this.imageBindingNavigator.Text = "bindingNavigator1";
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
            // imageBindingNavigatorSaveItem
            // 
            this.imageBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("imageBindingNavigatorSaveItem.Image")));
            this.imageBindingNavigatorSaveItem.Name = "imageBindingNavigatorSaveItem";
            this.imageBindingNavigatorSaveItem.Size = new System.Drawing.Size(78, 22);
            this.imageBindingNavigatorSaveItem.Text = "Save Data";
            this.imageBindingNavigatorSaveItem.Click += new System.EventHandler(this.imageBindingNavigatorSaveItem_Click);
            // 
            // imageDataGridView
            // 
            this.imageDataGridView.AutoGenerateColumns = false;
            this.imageDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.imageDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.imageDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewImageColumn1});
            this.imageDataGridView.DataSource = this.imageBindingSource;
            this.imageDataGridView.Location = new System.Drawing.Point(27, 100);
            this.imageDataGridView.Name = "imageDataGridView";
            this.imageDataGridView.Size = new System.Drawing.Size(930, 430);
            this.imageDataGridView.TabIndex = 10;
            this.imageDataGridView.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.imageDataGridView_CellValidated);
            this.imageDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.imageDataGridView_DataError);
            this.imageDataGridView.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.imageDataGridView_RowValidating);
            // 
            // hotelBindingSource
            // 
            this.hotelBindingSource.DataMember = "hotel";
            this.hotelBindingSource.DataSource = this.hotel_bookingDataSet;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "image_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Image ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
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
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "image_location";
            this.dataGridViewImageColumn1.HeaderText = "image_location";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // ImageTable
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.imageDataGridView);
            this.Controls.Add(this.imageBindingNavigator);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.formTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Name = "ImageTable";
            this.Text = "Image Table Management";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HotelTable_FormClosed);
            this.Load += new System.EventHandler(this.HotelTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hotel_bookingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBindingNavigator)).EndInit();
            this.imageBindingNavigator.ResumeLayout(false);
            this.imageBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Label formTitle;
        private System.Windows.Forms.Button backButton;
        private hotel_bookingDataSet hotel_bookingDataSet;
        private System.Windows.Forms.BindingSource imageBindingSource;
        private hotel_bookingDataSetTableAdapters.imageTableAdapter imageTableAdapter;
        private hotel_bookingDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator imageBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton imageBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView imageDataGridView;
        private hotel_bookingDataSetTableAdapters.hotelTableAdapter hotelTableAdapter;
        private System.Windows.Forms.BindingSource hotelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
    }
}