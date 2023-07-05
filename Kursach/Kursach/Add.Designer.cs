namespace Kursach
{
    partial class Add
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
            System.Windows.Forms.Label iD_PoezLabel;
            System.Windows.Forms.Label month_StartLabel;
            System.Windows.Forms.Label month_EndLabel;
            System.Windows.Forms.Label total_CoupeLabel;
            System.Windows.Forms.Label total_PlazLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add));
            this.poezdDataSet = new Kursach.poezdDataSet();
            this.ticket_SumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ticket_SumTableAdapter = new Kursach.poezdDataSetTableAdapters.Ticket_SumTableAdapter();
            this.tableAdapterManager = new Kursach.poezdDataSetTableAdapters.TableAdapterManager();
            this.ticket_SumBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.textBoxIDPoez = new System.Windows.Forms.TextBox();
            this.textBoxMonthStart = new System.Windows.Forms.TextBox();
            this.textBoxMonthEnd = new System.Windows.Forms.TextBox();
            this.textBoxTotalCoupe = new System.Windows.Forms.TextBox();
            this.textBoxTotalPlaz = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.ticket_SumBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.ticket_SumDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            iD_PoezLabel = new System.Windows.Forms.Label();
            month_StartLabel = new System.Windows.Forms.Label();
            month_EndLabel = new System.Windows.Forms.Label();
            total_CoupeLabel = new System.Windows.Forms.Label();
            total_PlazLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.poezdDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticket_SumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticket_SumBindingNavigator)).BeginInit();
            this.ticket_SumBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticket_SumDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // poezdDataSet
            // 
            this.poezdDataSet.DataSetName = "poezdDataSet";
            this.poezdDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ticket_SumBindingSource
            // 
            this.ticket_SumBindingSource.DataMember = "Ticket_Sum";
            this.ticket_SumBindingSource.DataSource = this.poezdDataSet;
            // 
            // ticket_SumTableAdapter
            // 
            this.ticket_SumTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Poez_RouteTableAdapter = null;
            this.tableAdapterManager.Route_inf1TableAdapter = null;
            this.tableAdapterManager.Ticket_SumTableAdapter = this.ticket_SumTableAdapter;
            this.tableAdapterManager.UpdateOrder = Kursach.poezdDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ticket_SumBindingNavigator
            // 
            this.ticket_SumBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.ticket_SumBindingNavigator.BindingSource = this.ticket_SumBindingSource;
            this.ticket_SumBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.ticket_SumBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.ticket_SumBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.ticket_SumBindingNavigatorSaveItem});
            this.ticket_SumBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.ticket_SumBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ticket_SumBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ticket_SumBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ticket_SumBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ticket_SumBindingNavigator.Name = "ticket_SumBindingNavigator";
            this.ticket_SumBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.ticket_SumBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.ticket_SumBindingNavigator.TabIndex = 0;
            this.ticket_SumBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // iD_PoezLabel
            // 
            iD_PoezLabel.AutoSize = true;
            iD_PoezLabel.Location = new System.Drawing.Point(245, 126);
            iD_PoezLabel.Name = "iD_PoezLabel";
            iD_PoezLabel.Size = new System.Drawing.Size(48, 13);
            iD_PoezLabel.TabIndex = 1;
            iD_PoezLabel.Text = "ID Poez:";
            // 
            // textBoxIDPoez
            // 
            this.textBoxIDPoez.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ticket_SumBindingSource, "ID_Poez", true));
            this.textBoxIDPoez.Location = new System.Drawing.Point(319, 123);
            this.textBoxIDPoez.Name = "textBoxIDPoez";
            this.textBoxIDPoez.Size = new System.Drawing.Size(213, 20);
            this.textBoxIDPoez.TabIndex = 2;
            this.textBoxIDPoez.TextChanged += new System.EventHandler(this.iD_PoezTextBox_TextChanged);
            // 
            // month_StartLabel
            // 
            month_StartLabel.AutoSize = true;
            month_StartLabel.Location = new System.Drawing.Point(245, 152);
            month_StartLabel.Name = "month_StartLabel";
            month_StartLabel.Size = new System.Drawing.Size(65, 13);
            month_StartLabel.TabIndex = 3;
            month_StartLabel.Text = "Month Start:";
            // 
            // textBoxMonthStart
            // 
            this.textBoxMonthStart.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ticket_SumBindingSource, "Month_Start", true));
            this.textBoxMonthStart.Location = new System.Drawing.Point(319, 149);
            this.textBoxMonthStart.Name = "textBoxMonthStart";
            this.textBoxMonthStart.Size = new System.Drawing.Size(213, 20);
            this.textBoxMonthStart.TabIndex = 4;
            // 
            // month_EndLabel
            // 
            month_EndLabel.AutoSize = true;
            month_EndLabel.Location = new System.Drawing.Point(245, 178);
            month_EndLabel.Name = "month_EndLabel";
            month_EndLabel.Size = new System.Drawing.Size(62, 13);
            month_EndLabel.TabIndex = 5;
            month_EndLabel.Text = "Month End:";
            // 
            // textBoxMonthEnd
            // 
            this.textBoxMonthEnd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ticket_SumBindingSource, "Month_End", true));
            this.textBoxMonthEnd.Location = new System.Drawing.Point(319, 175);
            this.textBoxMonthEnd.Name = "textBoxMonthEnd";
            this.textBoxMonthEnd.Size = new System.Drawing.Size(213, 20);
            this.textBoxMonthEnd.TabIndex = 6;
            // 
            // total_CoupeLabel
            // 
            total_CoupeLabel.AutoSize = true;
            total_CoupeLabel.Location = new System.Drawing.Point(245, 204);
            total_CoupeLabel.Name = "total_CoupeLabel";
            total_CoupeLabel.Size = new System.Drawing.Size(68, 13);
            total_CoupeLabel.TabIndex = 7;
            total_CoupeLabel.Text = "Total Coupe:";
            // 
            // textBoxTotalCoupe
            // 
            this.textBoxTotalCoupe.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ticket_SumBindingSource, "Total_Coupe", true));
            this.textBoxTotalCoupe.Location = new System.Drawing.Point(319, 201);
            this.textBoxTotalCoupe.Name = "textBoxTotalCoupe";
            this.textBoxTotalCoupe.Size = new System.Drawing.Size(213, 20);
            this.textBoxTotalCoupe.TabIndex = 8;
            // 
            // total_PlazLabel
            // 
            total_PlazLabel.AutoSize = true;
            total_PlazLabel.Location = new System.Drawing.Point(245, 230);
            total_PlazLabel.Name = "total_PlazLabel";
            total_PlazLabel.Size = new System.Drawing.Size(57, 13);
            total_PlazLabel.TabIndex = 9;
            total_PlazLabel.Text = "Total Plaz:";
            // 
            // textBoxTotalPlaz
            // 
            this.textBoxTotalPlaz.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ticket_SumBindingSource, "Total_Plaz", true));
            this.textBoxTotalPlaz.Location = new System.Drawing.Point(319, 227);
            this.textBoxTotalPlaz.Name = "textBoxTotalPlaz";
            this.textBoxTotalPlaz.Size = new System.Drawing.Size(213, 20);
            this.textBoxTotalPlaz.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(353, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 48);
            this.button1.TabIndex = 11;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // ticket_SumBindingNavigatorSaveItem
            // 
            this.ticket_SumBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ticket_SumBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("ticket_SumBindingNavigatorSaveItem.Image")));
            this.ticket_SumBindingNavigatorSaveItem.Name = "ticket_SumBindingNavigatorSaveItem";
            this.ticket_SumBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.ticket_SumBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.ticket_SumBindingNavigatorSaveItem.Click += new System.EventHandler(this.ticket_SumBindingNavigatorSaveItem_Click);
            // 
            // ticket_SumDataGridView
            // 
            this.ticket_SumDataGridView.AutoGenerateColumns = false;
            this.ticket_SumDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ticket_SumDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.ticket_SumDataGridView.DataSource = this.ticket_SumBindingSource;
            this.ticket_SumDataGridView.Location = new System.Drawing.Point(163, 396);
            this.ticket_SumDataGridView.Name = "ticket_SumDataGridView";
            this.ticket_SumDataGridView.Size = new System.Drawing.Size(523, 220);
            this.ticket_SumDataGridView.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Poez";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_Poez";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Month_Start";
            this.dataGridViewTextBoxColumn2.HeaderText = "Month_Start";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Month_End";
            this.dataGridViewTextBoxColumn3.HeaderText = "Month_End";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Total_Coupe";
            this.dataGridViewTextBoxColumn4.HeaderText = "Total_Coupe";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Total_Plaz";
            this.dataGridViewTextBoxColumn5.HeaderText = "Total_Plaz";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(43, 318);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 49);
            this.button2.TabIndex = 13;
            this.button2.Text = "Back to Main Menu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 636);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ticket_SumDataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(iD_PoezLabel);
            this.Controls.Add(this.textBoxIDPoez);
            this.Controls.Add(month_StartLabel);
            this.Controls.Add(this.textBoxMonthStart);
            this.Controls.Add(month_EndLabel);
            this.Controls.Add(this.textBoxMonthEnd);
            this.Controls.Add(total_CoupeLabel);
            this.Controls.Add(this.textBoxTotalCoupe);
            this.Controls.Add(total_PlazLabel);
            this.Controls.Add(this.textBoxTotalPlaz);
            this.Controls.Add(this.ticket_SumBindingNavigator);
            this.Name = "Add";
            this.Text = "Add";
            this.Load += new System.EventHandler(this.Add_Load);
            ((System.ComponentModel.ISupportInitialize)(this.poezdDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticket_SumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticket_SumBindingNavigator)).EndInit();
            this.ticket_SumBindingNavigator.ResumeLayout(false);
            this.ticket_SumBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticket_SumDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private poezdDataSet poezdDataSet;
        private System.Windows.Forms.BindingSource ticket_SumBindingSource;
        private poezdDataSetTableAdapters.Ticket_SumTableAdapter ticket_SumTableAdapter;
        private poezdDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator ticket_SumBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton ticket_SumBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox textBoxIDPoez;
        private System.Windows.Forms.TextBox textBoxMonthStart;
        private System.Windows.Forms.TextBox textBoxMonthEnd;
        private System.Windows.Forms.TextBox textBoxTotalCoupe;
        private System.Windows.Forms.TextBox textBoxTotalPlaz;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView ticket_SumDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button button2;
    }
}