namespace WindowsFormsApp7
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label badge_numberLabel;
            System.Windows.Forms.Label passwordLabel;
            this.rTADataSet = new WindowsFormsApp7.RTADataSet();
            this.gIBDD_officerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gIBDD_officerTableAdapter = new WindowsFormsApp7.RTADataSetTableAdapters.GIBDD_officerTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp7.RTADataSetTableAdapters.TableAdapterManager();
            this.gIBDD_officerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.gIBDD_officerBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.badge_numberTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            badge_numberLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rTADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIBDD_officerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIBDD_officerBindingNavigator)).BeginInit();
            this.gIBDD_officerBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // rTADataSet
            // 
            this.rTADataSet.DataSetName = "RTADataSet";
            this.rTADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gIBDD_officerBindingSource
            // 
            this.gIBDD_officerBindingSource.DataMember = "GIBDD_officer";
            this.gIBDD_officerBindingSource.DataSource = this.rTADataSet;
            // 
            // gIBDD_officerTableAdapter
            // 
            this.gIBDD_officerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Driver_InsuranceTableAdapter = null;
            this.tableAdapterManager.DriverTableAdapter = null;
            this.tableAdapterManager.GIBDD_officerTableAdapter = this.gIBDD_officerTableAdapter;
            this.tableAdapterManager.Insurance_companyTableAdapter = null;
            this.tableAdapterManager.InsuranceTableAdapter = null;
            this.tableAdapterManager.RTA_DriverTableAdapter = null;
            this.tableAdapterManager.RTATableAdapter = null;
            this.tableAdapterManager.Tag_mapTableAdapter = null;
            this.tableAdapterManager.TagTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp7.RTADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VehicleTableAdapter = null;
            this.tableAdapterManager.WitnessTableAdapter = null;
            // 
            // gIBDD_officerBindingNavigator
            // 
            this.gIBDD_officerBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.gIBDD_officerBindingNavigator.BindingSource = this.gIBDD_officerBindingSource;
            this.gIBDD_officerBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.gIBDD_officerBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.gIBDD_officerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.gIBDD_officerBindingNavigatorSaveItem});
            this.gIBDD_officerBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.gIBDD_officerBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.gIBDD_officerBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.gIBDD_officerBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.gIBDD_officerBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.gIBDD_officerBindingNavigator.Name = "gIBDD_officerBindingNavigator";
            this.gIBDD_officerBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.gIBDD_officerBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.gIBDD_officerBindingNavigator.TabIndex = 0;
            this.gIBDD_officerBindingNavigator.Text = "bindingNavigator1";
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
            // gIBDD_officerBindingNavigatorSaveItem
            // 
            this.gIBDD_officerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.gIBDD_officerBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("gIBDD_officerBindingNavigatorSaveItem.Image")));
            this.gIBDD_officerBindingNavigatorSaveItem.Name = "gIBDD_officerBindingNavigatorSaveItem";
            this.gIBDD_officerBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.gIBDD_officerBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.gIBDD_officerBindingNavigatorSaveItem.Click += new System.EventHandler(this.gIBDD_officerBindingNavigatorSaveItem_Click);
            // 
            // badge_numberLabel
            // 
            badge_numberLabel.AutoSize = true;
            badge_numberLabel.Location = new System.Drawing.Point(268, 152);
            badge_numberLabel.Name = "badge_numberLabel";
            badge_numberLabel.Size = new System.Drawing.Size(79, 13);
            badge_numberLabel.TabIndex = 1;
            badge_numberLabel.Text = "Badge number:";
            // 
            // badge_numberTextBox
            // 
            this.badge_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gIBDD_officerBindingSource, "Badge_number", true));
            this.badge_numberTextBox.Location = new System.Drawing.Point(353, 149);
            this.badge_numberTextBox.Name = "badge_numberTextBox";
            this.badge_numberTextBox.Size = new System.Drawing.Size(143, 20);
            this.badge_numberTextBox.TabIndex = 2;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(291, 212);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(56, 13);
            passwordLabel.TabIndex = 3;
            passwordLabel.Text = "Password:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gIBDD_officerBindingSource, "Password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(353, 209);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(143, 20);
            this.passwordTextBox.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(323, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Войти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(badge_numberLabel);
            this.Controls.Add(this.badge_numberTextBox);
            this.Controls.Add(this.gIBDD_officerBindingNavigator);
            this.Name = "Form1";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rTADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIBDD_officerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIBDD_officerBindingNavigator)).EndInit();
            this.gIBDD_officerBindingNavigator.ResumeLayout(false);
            this.gIBDD_officerBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RTADataSet rTADataSet;
        private System.Windows.Forms.BindingSource gIBDD_officerBindingSource;
        private RTADataSetTableAdapters.GIBDD_officerTableAdapter gIBDD_officerTableAdapter;
        private RTADataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator gIBDD_officerBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton gIBDD_officerBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox badge_numberTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button button1;
    }
}

