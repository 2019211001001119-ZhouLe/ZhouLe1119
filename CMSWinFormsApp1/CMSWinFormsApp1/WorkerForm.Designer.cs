namespace CMSWinFormsApp1
{
    partial class WorkerForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.collectionViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingListCollectionViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listCollectionViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.canSortDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.canFilterDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.canGroupDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBySelectorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isEmptyDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isDataInGroupOrderDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.newItemPlaceholderPositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.canAddNewDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isAddingNewDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.currentAddItemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.canRemoveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.canCancelEditDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isEditingItemDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.currentEditItemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.canChangeLiveSortingDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.canChangeLiveFilteringDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.canChangeLiveGroupingDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isLiveSortingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isLiveFilteringDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isLiveGroupingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cultureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sourceCollectionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentItemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentPositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isCurrentAfterLastDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isCurrentBeforeFirstDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.comparerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.needsRefreshDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isInUseDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dispatcherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.collectionViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingListCollectionViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listCollectionViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(204, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Click on the edit button to load the records";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(128, 314);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(258, 314);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(94, 29);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(404, 314);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(536, 314);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 29);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.canSortDataGridViewCheckBoxColumn,
            this.canFilterDataGridViewCheckBoxColumn,
            this.canGroupDataGridViewCheckBoxColumn,
            this.groupBySelectorDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn,
            this.isEmptyDataGridViewCheckBoxColumn,
            this.isDataInGroupOrderDataGridViewCheckBoxColumn,
            this.newItemPlaceholderPositionDataGridViewTextBoxColumn,
            this.canAddNewDataGridViewCheckBoxColumn,
            this.isAddingNewDataGridViewCheckBoxColumn,
            this.currentAddItemDataGridViewTextBoxColumn,
            this.canRemoveDataGridViewCheckBoxColumn,
            this.canCancelEditDataGridViewCheckBoxColumn,
            this.isEditingItemDataGridViewCheckBoxColumn,
            this.currentEditItemDataGridViewTextBoxColumn,
            this.canChangeLiveSortingDataGridViewCheckBoxColumn,
            this.canChangeLiveFilteringDataGridViewCheckBoxColumn,
            this.canChangeLiveGroupingDataGridViewCheckBoxColumn,
            this.isLiveSortingDataGridViewTextBoxColumn,
            this.isLiveFilteringDataGridViewTextBoxColumn,
            this.isLiveGroupingDataGridViewTextBoxColumn,
            this.cultureDataGridViewTextBoxColumn,
            this.sourceCollectionDataGridViewTextBoxColumn,
            this.filterDataGridViewTextBoxColumn,
            this.currentItemDataGridViewTextBoxColumn,
            this.currentPositionDataGridViewTextBoxColumn,
            this.isCurrentAfterLastDataGridViewCheckBoxColumn,
            this.isCurrentBeforeFirstDataGridViewCheckBoxColumn,
            this.comparerDataGridViewTextBoxColumn,
            this.needsRefreshDataGridViewCheckBoxColumn,
            this.isInUseDataGridViewCheckBoxColumn,
            this.dispatcherDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.listCollectionViewBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(258, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(300, 188);
            this.dataGridView1.TabIndex = 5;
            // 
            // bindingListCollectionViewBindingSource
            // 
            // 
            // listCollectionViewBindingSource
            // 
            // 
            // canSortDataGridViewCheckBoxColumn
            // 
            this.canSortDataGridViewCheckBoxColumn.DataPropertyName = "CanSort";
            this.canSortDataGridViewCheckBoxColumn.HeaderText = "CanSort";
            this.canSortDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.canSortDataGridViewCheckBoxColumn.Name = "canSortDataGridViewCheckBoxColumn";
            this.canSortDataGridViewCheckBoxColumn.ReadOnly = true;
            this.canSortDataGridViewCheckBoxColumn.Width = 125;
            // 
            // canFilterDataGridViewCheckBoxColumn
            // 
            this.canFilterDataGridViewCheckBoxColumn.DataPropertyName = "CanFilter";
            this.canFilterDataGridViewCheckBoxColumn.HeaderText = "CanFilter";
            this.canFilterDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.canFilterDataGridViewCheckBoxColumn.Name = "canFilterDataGridViewCheckBoxColumn";
            this.canFilterDataGridViewCheckBoxColumn.ReadOnly = true;
            this.canFilterDataGridViewCheckBoxColumn.Width = 125;
            // 
            // canGroupDataGridViewCheckBoxColumn
            // 
            this.canGroupDataGridViewCheckBoxColumn.DataPropertyName = "CanGroup";
            this.canGroupDataGridViewCheckBoxColumn.HeaderText = "CanGroup";
            this.canGroupDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.canGroupDataGridViewCheckBoxColumn.Name = "canGroupDataGridViewCheckBoxColumn";
            this.canGroupDataGridViewCheckBoxColumn.ReadOnly = true;
            this.canGroupDataGridViewCheckBoxColumn.Width = 125;
            // 
            // groupBySelectorDataGridViewTextBoxColumn
            // 
            this.groupBySelectorDataGridViewTextBoxColumn.DataPropertyName = "GroupBySelector";
            this.groupBySelectorDataGridViewTextBoxColumn.HeaderText = "GroupBySelector";
            this.groupBySelectorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.groupBySelectorDataGridViewTextBoxColumn.Name = "groupBySelectorDataGridViewTextBoxColumn";
            this.groupBySelectorDataGridViewTextBoxColumn.Width = 125;
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "Count";
            this.countDataGridViewTextBoxColumn.HeaderText = "Count";
            this.countDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            this.countDataGridViewTextBoxColumn.ReadOnly = true;
            this.countDataGridViewTextBoxColumn.Width = 125;
            // 
            // isEmptyDataGridViewCheckBoxColumn
            // 
            this.isEmptyDataGridViewCheckBoxColumn.DataPropertyName = "IsEmpty";
            this.isEmptyDataGridViewCheckBoxColumn.HeaderText = "IsEmpty";
            this.isEmptyDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.isEmptyDataGridViewCheckBoxColumn.Name = "isEmptyDataGridViewCheckBoxColumn";
            this.isEmptyDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isEmptyDataGridViewCheckBoxColumn.Width = 125;
            // 
            // isDataInGroupOrderDataGridViewCheckBoxColumn
            // 
            this.isDataInGroupOrderDataGridViewCheckBoxColumn.DataPropertyName = "IsDataInGroupOrder";
            this.isDataInGroupOrderDataGridViewCheckBoxColumn.HeaderText = "IsDataInGroupOrder";
            this.isDataInGroupOrderDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.isDataInGroupOrderDataGridViewCheckBoxColumn.Name = "isDataInGroupOrderDataGridViewCheckBoxColumn";
            this.isDataInGroupOrderDataGridViewCheckBoxColumn.Width = 125;
            // 
            // newItemPlaceholderPositionDataGridViewTextBoxColumn
            // 
            this.newItemPlaceholderPositionDataGridViewTextBoxColumn.DataPropertyName = "NewItemPlaceholderPosition";
            this.newItemPlaceholderPositionDataGridViewTextBoxColumn.HeaderText = "NewItemPlaceholderPosition";
            this.newItemPlaceholderPositionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.newItemPlaceholderPositionDataGridViewTextBoxColumn.Name = "newItemPlaceholderPositionDataGridViewTextBoxColumn";
            this.newItemPlaceholderPositionDataGridViewTextBoxColumn.Width = 125;
            // 
            // canAddNewDataGridViewCheckBoxColumn
            // 
            this.canAddNewDataGridViewCheckBoxColumn.DataPropertyName = "CanAddNew";
            this.canAddNewDataGridViewCheckBoxColumn.HeaderText = "CanAddNew";
            this.canAddNewDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.canAddNewDataGridViewCheckBoxColumn.Name = "canAddNewDataGridViewCheckBoxColumn";
            this.canAddNewDataGridViewCheckBoxColumn.ReadOnly = true;
            this.canAddNewDataGridViewCheckBoxColumn.Width = 125;
            // 
            // isAddingNewDataGridViewCheckBoxColumn
            // 
            this.isAddingNewDataGridViewCheckBoxColumn.DataPropertyName = "IsAddingNew";
            this.isAddingNewDataGridViewCheckBoxColumn.HeaderText = "IsAddingNew";
            this.isAddingNewDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.isAddingNewDataGridViewCheckBoxColumn.Name = "isAddingNewDataGridViewCheckBoxColumn";
            this.isAddingNewDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isAddingNewDataGridViewCheckBoxColumn.Width = 125;
            // 
            // currentAddItemDataGridViewTextBoxColumn
            // 
            this.currentAddItemDataGridViewTextBoxColumn.DataPropertyName = "CurrentAddItem";
            this.currentAddItemDataGridViewTextBoxColumn.HeaderText = "CurrentAddItem";
            this.currentAddItemDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.currentAddItemDataGridViewTextBoxColumn.Name = "currentAddItemDataGridViewTextBoxColumn";
            this.currentAddItemDataGridViewTextBoxColumn.ReadOnly = true;
            this.currentAddItemDataGridViewTextBoxColumn.Width = 125;
            // 
            // canRemoveDataGridViewCheckBoxColumn
            // 
            this.canRemoveDataGridViewCheckBoxColumn.DataPropertyName = "CanRemove";
            this.canRemoveDataGridViewCheckBoxColumn.HeaderText = "CanRemove";
            this.canRemoveDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.canRemoveDataGridViewCheckBoxColumn.Name = "canRemoveDataGridViewCheckBoxColumn";
            this.canRemoveDataGridViewCheckBoxColumn.ReadOnly = true;
            this.canRemoveDataGridViewCheckBoxColumn.Width = 125;
            // 
            // canCancelEditDataGridViewCheckBoxColumn
            // 
            this.canCancelEditDataGridViewCheckBoxColumn.DataPropertyName = "CanCancelEdit";
            this.canCancelEditDataGridViewCheckBoxColumn.HeaderText = "CanCancelEdit";
            this.canCancelEditDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.canCancelEditDataGridViewCheckBoxColumn.Name = "canCancelEditDataGridViewCheckBoxColumn";
            this.canCancelEditDataGridViewCheckBoxColumn.ReadOnly = true;
            this.canCancelEditDataGridViewCheckBoxColumn.Width = 125;
            // 
            // isEditingItemDataGridViewCheckBoxColumn
            // 
            this.isEditingItemDataGridViewCheckBoxColumn.DataPropertyName = "IsEditingItem";
            this.isEditingItemDataGridViewCheckBoxColumn.HeaderText = "IsEditingItem";
            this.isEditingItemDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.isEditingItemDataGridViewCheckBoxColumn.Name = "isEditingItemDataGridViewCheckBoxColumn";
            this.isEditingItemDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isEditingItemDataGridViewCheckBoxColumn.Width = 125;
            // 
            // currentEditItemDataGridViewTextBoxColumn
            // 
            this.currentEditItemDataGridViewTextBoxColumn.DataPropertyName = "CurrentEditItem";
            this.currentEditItemDataGridViewTextBoxColumn.HeaderText = "CurrentEditItem";
            this.currentEditItemDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.currentEditItemDataGridViewTextBoxColumn.Name = "currentEditItemDataGridViewTextBoxColumn";
            this.currentEditItemDataGridViewTextBoxColumn.ReadOnly = true;
            this.currentEditItemDataGridViewTextBoxColumn.Width = 125;
            // 
            // canChangeLiveSortingDataGridViewCheckBoxColumn
            // 
            this.canChangeLiveSortingDataGridViewCheckBoxColumn.DataPropertyName = "CanChangeLiveSorting";
            this.canChangeLiveSortingDataGridViewCheckBoxColumn.HeaderText = "CanChangeLiveSorting";
            this.canChangeLiveSortingDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.canChangeLiveSortingDataGridViewCheckBoxColumn.Name = "canChangeLiveSortingDataGridViewCheckBoxColumn";
            this.canChangeLiveSortingDataGridViewCheckBoxColumn.ReadOnly = true;
            this.canChangeLiveSortingDataGridViewCheckBoxColumn.Width = 125;
            // 
            // canChangeLiveFilteringDataGridViewCheckBoxColumn
            // 
            this.canChangeLiveFilteringDataGridViewCheckBoxColumn.DataPropertyName = "CanChangeLiveFiltering";
            this.canChangeLiveFilteringDataGridViewCheckBoxColumn.HeaderText = "CanChangeLiveFiltering";
            this.canChangeLiveFilteringDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.canChangeLiveFilteringDataGridViewCheckBoxColumn.Name = "canChangeLiveFilteringDataGridViewCheckBoxColumn";
            this.canChangeLiveFilteringDataGridViewCheckBoxColumn.ReadOnly = true;
            this.canChangeLiveFilteringDataGridViewCheckBoxColumn.Width = 125;
            // 
            // canChangeLiveGroupingDataGridViewCheckBoxColumn
            // 
            this.canChangeLiveGroupingDataGridViewCheckBoxColumn.DataPropertyName = "CanChangeLiveGrouping";
            this.canChangeLiveGroupingDataGridViewCheckBoxColumn.HeaderText = "CanChangeLiveGrouping";
            this.canChangeLiveGroupingDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.canChangeLiveGroupingDataGridViewCheckBoxColumn.Name = "canChangeLiveGroupingDataGridViewCheckBoxColumn";
            this.canChangeLiveGroupingDataGridViewCheckBoxColumn.ReadOnly = true;
            this.canChangeLiveGroupingDataGridViewCheckBoxColumn.Width = 125;
            // 
            // isLiveSortingDataGridViewTextBoxColumn
            // 
            this.isLiveSortingDataGridViewTextBoxColumn.DataPropertyName = "IsLiveSorting";
            this.isLiveSortingDataGridViewTextBoxColumn.HeaderText = "IsLiveSorting";
            this.isLiveSortingDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.isLiveSortingDataGridViewTextBoxColumn.Name = "isLiveSortingDataGridViewTextBoxColumn";
            this.isLiveSortingDataGridViewTextBoxColumn.Width = 125;
            // 
            // isLiveFilteringDataGridViewTextBoxColumn
            // 
            this.isLiveFilteringDataGridViewTextBoxColumn.DataPropertyName = "IsLiveFiltering";
            this.isLiveFilteringDataGridViewTextBoxColumn.HeaderText = "IsLiveFiltering";
            this.isLiveFilteringDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.isLiveFilteringDataGridViewTextBoxColumn.Name = "isLiveFilteringDataGridViewTextBoxColumn";
            this.isLiveFilteringDataGridViewTextBoxColumn.Width = 125;
            // 
            // isLiveGroupingDataGridViewTextBoxColumn
            // 
            this.isLiveGroupingDataGridViewTextBoxColumn.DataPropertyName = "IsLiveGrouping";
            this.isLiveGroupingDataGridViewTextBoxColumn.HeaderText = "IsLiveGrouping";
            this.isLiveGroupingDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.isLiveGroupingDataGridViewTextBoxColumn.Name = "isLiveGroupingDataGridViewTextBoxColumn";
            this.isLiveGroupingDataGridViewTextBoxColumn.Width = 125;
            // 
            // cultureDataGridViewTextBoxColumn
            // 
            this.cultureDataGridViewTextBoxColumn.DataPropertyName = "Culture";
            this.cultureDataGridViewTextBoxColumn.HeaderText = "Culture";
            this.cultureDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cultureDataGridViewTextBoxColumn.Name = "cultureDataGridViewTextBoxColumn";
            this.cultureDataGridViewTextBoxColumn.Width = 125;
            // 
            // sourceCollectionDataGridViewTextBoxColumn
            // 
            this.sourceCollectionDataGridViewTextBoxColumn.DataPropertyName = "SourceCollection";
            this.sourceCollectionDataGridViewTextBoxColumn.HeaderText = "SourceCollection";
            this.sourceCollectionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sourceCollectionDataGridViewTextBoxColumn.Name = "sourceCollectionDataGridViewTextBoxColumn";
            this.sourceCollectionDataGridViewTextBoxColumn.ReadOnly = true;
            this.sourceCollectionDataGridViewTextBoxColumn.Width = 125;
            // 
            // filterDataGridViewTextBoxColumn
            // 
            this.filterDataGridViewTextBoxColumn.DataPropertyName = "Filter";
            this.filterDataGridViewTextBoxColumn.HeaderText = "Filter";
            this.filterDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.filterDataGridViewTextBoxColumn.Name = "filterDataGridViewTextBoxColumn";
            this.filterDataGridViewTextBoxColumn.Width = 125;
            // 
            // currentItemDataGridViewTextBoxColumn
            // 
            this.currentItemDataGridViewTextBoxColumn.DataPropertyName = "CurrentItem";
            this.currentItemDataGridViewTextBoxColumn.HeaderText = "CurrentItem";
            this.currentItemDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.currentItemDataGridViewTextBoxColumn.Name = "currentItemDataGridViewTextBoxColumn";
            this.currentItemDataGridViewTextBoxColumn.ReadOnly = true;
            this.currentItemDataGridViewTextBoxColumn.Width = 125;
            // 
            // currentPositionDataGridViewTextBoxColumn
            // 
            this.currentPositionDataGridViewTextBoxColumn.DataPropertyName = "CurrentPosition";
            this.currentPositionDataGridViewTextBoxColumn.HeaderText = "CurrentPosition";
            this.currentPositionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.currentPositionDataGridViewTextBoxColumn.Name = "currentPositionDataGridViewTextBoxColumn";
            this.currentPositionDataGridViewTextBoxColumn.ReadOnly = true;
            this.currentPositionDataGridViewTextBoxColumn.Width = 125;
            // 
            // isCurrentAfterLastDataGridViewCheckBoxColumn
            // 
            this.isCurrentAfterLastDataGridViewCheckBoxColumn.DataPropertyName = "IsCurrentAfterLast";
            this.isCurrentAfterLastDataGridViewCheckBoxColumn.HeaderText = "IsCurrentAfterLast";
            this.isCurrentAfterLastDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.isCurrentAfterLastDataGridViewCheckBoxColumn.Name = "isCurrentAfterLastDataGridViewCheckBoxColumn";
            this.isCurrentAfterLastDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isCurrentAfterLastDataGridViewCheckBoxColumn.Width = 125;
            // 
            // isCurrentBeforeFirstDataGridViewCheckBoxColumn
            // 
            this.isCurrentBeforeFirstDataGridViewCheckBoxColumn.DataPropertyName = "IsCurrentBeforeFirst";
            this.isCurrentBeforeFirstDataGridViewCheckBoxColumn.HeaderText = "IsCurrentBeforeFirst";
            this.isCurrentBeforeFirstDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.isCurrentBeforeFirstDataGridViewCheckBoxColumn.Name = "isCurrentBeforeFirstDataGridViewCheckBoxColumn";
            this.isCurrentBeforeFirstDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isCurrentBeforeFirstDataGridViewCheckBoxColumn.Width = 125;
            // 
            // comparerDataGridViewTextBoxColumn
            // 
            this.comparerDataGridViewTextBoxColumn.DataPropertyName = "Comparer";
            this.comparerDataGridViewTextBoxColumn.HeaderText = "Comparer";
            this.comparerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.comparerDataGridViewTextBoxColumn.Name = "comparerDataGridViewTextBoxColumn";
            this.comparerDataGridViewTextBoxColumn.ReadOnly = true;
            this.comparerDataGridViewTextBoxColumn.Width = 125;
            // 
            // needsRefreshDataGridViewCheckBoxColumn
            // 
            this.needsRefreshDataGridViewCheckBoxColumn.DataPropertyName = "NeedsRefresh";
            this.needsRefreshDataGridViewCheckBoxColumn.HeaderText = "NeedsRefresh";
            this.needsRefreshDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.needsRefreshDataGridViewCheckBoxColumn.Name = "needsRefreshDataGridViewCheckBoxColumn";
            this.needsRefreshDataGridViewCheckBoxColumn.ReadOnly = true;
            this.needsRefreshDataGridViewCheckBoxColumn.Width = 125;
            // 
            // isInUseDataGridViewCheckBoxColumn
            // 
            this.isInUseDataGridViewCheckBoxColumn.DataPropertyName = "IsInUse";
            this.isInUseDataGridViewCheckBoxColumn.HeaderText = "IsInUse";
            this.isInUseDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.isInUseDataGridViewCheckBoxColumn.Name = "isInUseDataGridViewCheckBoxColumn";
            this.isInUseDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isInUseDataGridViewCheckBoxColumn.Width = 125;
            // 
            // dispatcherDataGridViewTextBoxColumn
            // 
            this.dispatcherDataGridViewTextBoxColumn.DataPropertyName = "Dispatcher";
            this.dispatcherDataGridViewTextBoxColumn.HeaderText = "Dispatcher";
            this.dispatcherDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dispatcherDataGridViewTextBoxColumn.Name = "dispatcherDataGridViewTextBoxColumn";
            this.dispatcherDataGridViewTextBoxColumn.ReadOnly = true;
            this.dispatcherDataGridViewTextBoxColumn.Width = 125;
            // 
            // WorkerForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Name = "WorkerForm";
            this.Text = "WorkerForm";
            ((System.ComponentModel.ISupportInitialize)(this.collectionViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingListCollectionViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listCollectionViewBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnSave;
        private Button btnEdit;
        private Button btnCancel;
        private Button btnExit;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn4;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn7;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private BindingSource collectionViewBindingSource;
        private DataGridView dataGridView1;
        private BindingSource bindingListCollectionViewBindingSource;
        private BindingSource listCollectionViewBindingSource;
        private DataGridViewCheckBoxColumn canSortDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn canFilterDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn canGroupDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn groupBySelectorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isEmptyDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn isDataInGroupOrderDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn newItemPlaceholderPositionDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn canAddNewDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn isAddingNewDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn currentAddItemDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn canRemoveDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn canCancelEditDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn isEditingItemDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn currentEditItemDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn canChangeLiveSortingDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn canChangeLiveFilteringDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn canChangeLiveGroupingDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn isLiveSortingDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn isLiveFilteringDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn isLiveGroupingDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cultureDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sourceCollectionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn filterDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn currentItemDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn currentPositionDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isCurrentAfterLastDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn isCurrentBeforeFirstDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn comparerDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn needsRefreshDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn isInUseDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn dispatcherDataGridViewTextBoxColumn;
    }
}