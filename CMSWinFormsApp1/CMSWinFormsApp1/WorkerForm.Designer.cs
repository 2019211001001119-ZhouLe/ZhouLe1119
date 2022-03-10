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
            this.listCollectionViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingListCollectionViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.collectionViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listCollectionViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingListCollectionViewBindingSource)).BeginInit();
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
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(258, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(300, 188);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
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
            ((System.ComponentModel.ISupportInitialize)(this.listCollectionViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingListCollectionViewBindingSource)).EndInit();
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