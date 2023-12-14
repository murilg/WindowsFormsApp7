namespace WindowsFormsApp7
{
    partial class Form17
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form17));
            this.button1 = new System.Windows.Forms.Button();
            this.rTADataSet2 = new WindowsFormsApp7.RTADataSet2();
            this.getRtaDetailsByTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getRtaDetailsByTypeTableAdapter = new WindowsFormsApp7.RTADataSet2TableAdapters.GetRtaDetailsByTypeTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp7.RTADataSet2TableAdapters.TableAdapterManager();
            this.getRtaDetailsByTypeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.getRtaDetailsByTypeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.rtaTypeToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.rtaTypeToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.getRtaDetailsByTypeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.rTADataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getRtaDetailsByTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getRtaDetailsByTypeBindingNavigator)).BeginInit();
            this.getRtaDetailsByTypeBindingNavigator.SuspendLayout();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getRtaDetailsByTypeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(73, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rTADataSet2
            // 
            this.rTADataSet2.DataSetName = "RTADataSet2";
            this.rTADataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getRtaDetailsByTypeBindingSource
            // 
            this.getRtaDetailsByTypeBindingSource.DataMember = "GetRtaDetailsByType";
            this.getRtaDetailsByTypeBindingSource.DataSource = this.rTADataSet2;
            // 
            // getRtaDetailsByTypeTableAdapter
            // 
            this.getRtaDetailsByTypeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.Driver_InsuranceTableAdapter = null;
            this.tableAdapterManager.DriverTableAdapter = null;
            this.tableAdapterManager.GIBDD_officerTableAdapter = null;
            this.tableAdapterManager.Insurance_companyTableAdapter = null;
            this.tableAdapterManager.InsuranceTableAdapter = null;
            this.tableAdapterManager.RTA_DriverTableAdapter = null;
            this.tableAdapterManager.RTATableAdapter = null;
            this.tableAdapterManager.Tag_mapTableAdapter = null;
            this.tableAdapterManager.TagTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp7.RTADataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VehicleTableAdapter = null;
            this.tableAdapterManager.WitnessTableAdapter = null;
            // 
            // getRtaDetailsByTypeBindingNavigator
            // 
            this.getRtaDetailsByTypeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.getRtaDetailsByTypeBindingNavigator.BindingSource = this.getRtaDetailsByTypeBindingSource;
            this.getRtaDetailsByTypeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.getRtaDetailsByTypeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.getRtaDetailsByTypeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.getRtaDetailsByTypeBindingNavigatorSaveItem});
            this.getRtaDetailsByTypeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.getRtaDetailsByTypeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.getRtaDetailsByTypeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.getRtaDetailsByTypeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.getRtaDetailsByTypeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.getRtaDetailsByTypeBindingNavigator.Name = "getRtaDetailsByTypeBindingNavigator";
            this.getRtaDetailsByTypeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.getRtaDetailsByTypeBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.getRtaDetailsByTypeBindingNavigator.TabIndex = 4;
            this.getRtaDetailsByTypeBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // getRtaDetailsByTypeBindingNavigatorSaveItem
            // 
            this.getRtaDetailsByTypeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.getRtaDetailsByTypeBindingNavigatorSaveItem.Enabled = false;
            this.getRtaDetailsByTypeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("getRtaDetailsByTypeBindingNavigatorSaveItem.Image")));
            this.getRtaDetailsByTypeBindingNavigatorSaveItem.Name = "getRtaDetailsByTypeBindingNavigatorSaveItem";
            this.getRtaDetailsByTypeBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.getRtaDetailsByTypeBindingNavigatorSaveItem.Text = "Сохранить данные";
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rtaTypeToolStripLabel,
            this.rtaTypeToolStripTextBox,
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 25);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(800, 25);
            this.fillToolStrip.TabIndex = 5;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // rtaTypeToolStripLabel
            // 
            this.rtaTypeToolStripLabel.Name = "rtaTypeToolStripLabel";
            this.rtaTypeToolStripLabel.Size = new System.Drawing.Size(121, 22);
            this.rtaTypeToolStripLabel.Text = "Обстоятельство ДТП";
            // 
            // rtaTypeToolStripTextBox
            // 
            this.rtaTypeToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rtaTypeToolStripTextBox.Name = "rtaTypeToolStripTextBox";
            this.rtaTypeToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(46, 22);
            this.fillToolStripButton.Text = "Поиск";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // getRtaDetailsByTypeDataGridView
            // 
            this.getRtaDetailsByTypeDataGridView.AutoGenerateColumns = false;
            this.getRtaDetailsByTypeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.getRtaDetailsByTypeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.getRtaDetailsByTypeDataGridView.DataSource = this.getRtaDetailsByTypeBindingSource;
            this.getRtaDetailsByTypeDataGridView.Location = new System.Drawing.Point(236, 121);
            this.getRtaDetailsByTypeDataGridView.Name = "getRtaDetailsByTypeDataGridView";
            this.getRtaDetailsByTypeDataGridView.Size = new System.Drawing.Size(300, 220);
            this.getRtaDetailsByTypeDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Обстоятельство ДТП";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PeopleCount";
            this.dataGridViewTextBoxColumn2.HeaderText = "Количество водителей";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Form17
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.getRtaDetailsByTypeDataGridView);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.getRtaDetailsByTypeBindingNavigator);
            this.Controls.Add(this.button1);
            this.Name = "Form17";
            this.Text = "Количество водителей в ДТП определенного типа";
            ((System.ComponentModel.ISupportInitialize)(this.rTADataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getRtaDetailsByTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getRtaDetailsByTypeBindingNavigator)).EndInit();
            this.getRtaDetailsByTypeBindingNavigator.ResumeLayout(false);
            this.getRtaDetailsByTypeBindingNavigator.PerformLayout();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getRtaDetailsByTypeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private RTADataSet2 rTADataSet2;
        private System.Windows.Forms.BindingSource getRtaDetailsByTypeBindingSource;
        private RTADataSet2TableAdapters.GetRtaDetailsByTypeTableAdapter getRtaDetailsByTypeTableAdapter;
        private RTADataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator getRtaDetailsByTypeBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton getRtaDetailsByTypeBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel rtaTypeToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox rtaTypeToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private System.Windows.Forms.DataGridView getRtaDetailsByTypeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}