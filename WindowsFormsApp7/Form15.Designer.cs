namespace WindowsFormsApp7
{
    partial class Form15
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form15));
            this.button1 = new System.Windows.Forms.Button();
            this.rTADataSet2 = new WindowsFormsApp7.RTADataSet2();
            this.countWoundedAndDeadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countWoundedAndDeadTableAdapter = new WindowsFormsApp7.RTADataSet2TableAdapters.CountWoundedAndDeadTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp7.RTADataSet2TableAdapters.TableAdapterManager();
            this.countWoundedAndDeadBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.countWoundedAndDeadBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.countWoundedAndDeadDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.rTADataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countWoundedAndDeadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countWoundedAndDeadBindingNavigator)).BeginInit();
            this.countWoundedAndDeadBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countWoundedAndDeadDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(81, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rTADataSet2
            // 
            this.rTADataSet2.DataSetName = "RTADataSet2";
            this.rTADataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // countWoundedAndDeadBindingSource
            // 
            this.countWoundedAndDeadBindingSource.DataMember = "CountWoundedAndDead";
            this.countWoundedAndDeadBindingSource.DataSource = this.rTADataSet2;
            // 
            // countWoundedAndDeadTableAdapter
            // 
            this.countWoundedAndDeadTableAdapter.ClearBeforeFill = true;
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
            // countWoundedAndDeadBindingNavigator
            // 
            this.countWoundedAndDeadBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.countWoundedAndDeadBindingNavigator.BindingSource = this.countWoundedAndDeadBindingSource;
            this.countWoundedAndDeadBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.countWoundedAndDeadBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.countWoundedAndDeadBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.countWoundedAndDeadBindingNavigatorSaveItem});
            this.countWoundedAndDeadBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.countWoundedAndDeadBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.countWoundedAndDeadBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.countWoundedAndDeadBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.countWoundedAndDeadBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.countWoundedAndDeadBindingNavigator.Name = "countWoundedAndDeadBindingNavigator";
            this.countWoundedAndDeadBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.countWoundedAndDeadBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.countWoundedAndDeadBindingNavigator.TabIndex = 3;
            this.countWoundedAndDeadBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 15);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // countWoundedAndDeadBindingNavigatorSaveItem
            // 
            this.countWoundedAndDeadBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.countWoundedAndDeadBindingNavigatorSaveItem.Enabled = false;
            this.countWoundedAndDeadBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("countWoundedAndDeadBindingNavigatorSaveItem.Image")));
            this.countWoundedAndDeadBindingNavigatorSaveItem.Name = "countWoundedAndDeadBindingNavigatorSaveItem";
            this.countWoundedAndDeadBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 20);
            this.countWoundedAndDeadBindingNavigatorSaveItem.Text = "Сохранить данные";
            // 
            // countWoundedAndDeadDataGridView
            // 
            this.countWoundedAndDeadDataGridView.AutoGenerateColumns = false;
            this.countWoundedAndDeadDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.countWoundedAndDeadDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.countWoundedAndDeadDataGridView.DataSource = this.countWoundedAndDeadBindingSource;
            this.countWoundedAndDeadDataGridView.Location = new System.Drawing.Point(202, 81);
            this.countWoundedAndDeadDataGridView.Name = "countWoundedAndDeadDataGridView";
            this.countWoundedAndDeadDataGridView.Size = new System.Drawing.Size(364, 220);
            this.countWoundedAndDeadDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Обстоятельство ДТП";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Number_of_wounded";
            this.dataGridViewTextBoxColumn2.HeaderText = "Количество раненых";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Number_of_dead";
            this.dataGridViewTextBoxColumn3.HeaderText = "Количество погибших";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Form15
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.countWoundedAndDeadDataGridView);
            this.Controls.Add(this.countWoundedAndDeadBindingNavigator);
            this.Controls.Add(this.button1);
            this.Name = "Form15";
            this.Text = " Кол-во раненых и погибших в определённом типе ДТП";
            this.Load += new System.EventHandler(this.Form15_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rTADataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countWoundedAndDeadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countWoundedAndDeadBindingNavigator)).EndInit();
            this.countWoundedAndDeadBindingNavigator.ResumeLayout(false);
            this.countWoundedAndDeadBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countWoundedAndDeadDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private RTADataSet2 rTADataSet2;
        private System.Windows.Forms.BindingSource countWoundedAndDeadBindingSource;
        private RTADataSet2TableAdapters.CountWoundedAndDeadTableAdapter countWoundedAndDeadTableAdapter;
        private RTADataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator countWoundedAndDeadBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton countWoundedAndDeadBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView countWoundedAndDeadDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}