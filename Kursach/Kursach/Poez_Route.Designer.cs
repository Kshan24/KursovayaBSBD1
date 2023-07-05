namespace Kursach
{
    partial class Poez_Route
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
            System.Windows.Forms.Label plazcartLabel;
            System.Windows.Forms.Label coupeLabel;
            System.Windows.Forms.Label poez_NumLabel;
            System.Windows.Forms.Label month_StartLabel;
            System.Windows.Forms.Label month_EndLabel;
            System.Windows.Forms.Label total_CoupeLabel;
            System.Windows.Forms.Label total_PlazLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Poez_Route));
            this.poezdDataSet = new Kursach.poezdDataSet();
            this.poez_RouteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.poez_RouteTableAdapter = new Kursach.poezdDataSetTableAdapters.Poez_RouteTableAdapter();
            this.tableAdapterManager = new Kursach.poezdDataSetTableAdapters.TableAdapterManager();
            this.route_inf1TableAdapter = new Kursach.poezdDataSetTableAdapters.Route_inf1TableAdapter();
            this.ticket_SumTableAdapter = new Kursach.poezdDataSetTableAdapters.Ticket_SumTableAdapter();
            this.poez_RouteBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.poez_RouteBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.poez_RouteDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.route_inf1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ticket_SumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.plazcartTextBox = new System.Windows.Forms.TextBox();
            this.coupeTextBox = new System.Windows.Forms.TextBox();
            this.poez_NumTextBox = new System.Windows.Forms.TextBox();
            this.month_StartTextBox = new System.Windows.Forms.TextBox();
            this.month_EndTextBox = new System.Windows.Forms.TextBox();
            this.total_CoupeTextBox = new System.Windows.Forms.TextBox();
            this.total_PlazTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.route_inf1DataGridView = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            plazcartLabel = new System.Windows.Forms.Label();
            coupeLabel = new System.Windows.Forms.Label();
            poez_NumLabel = new System.Windows.Forms.Label();
            month_StartLabel = new System.Windows.Forms.Label();
            month_EndLabel = new System.Windows.Forms.Label();
            total_CoupeLabel = new System.Windows.Forms.Label();
            total_PlazLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.poezdDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poez_RouteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poez_RouteBindingNavigator)).BeginInit();
            this.poez_RouteBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poez_RouteDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.route_inf1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticket_SumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.route_inf1DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // plazcartLabel
            // 
            plazcartLabel.AutoSize = true;
            plazcartLabel.Location = new System.Drawing.Point(317, 228);
            plazcartLabel.Name = "plazcartLabel";
            plazcartLabel.Size = new System.Drawing.Size(48, 13);
            plazcartLabel.TabIndex = 10;
            plazcartLabel.Text = "Plazcart:";
            // 
            // coupeLabel
            // 
            coupeLabel.AutoSize = true;
            coupeLabel.Location = new System.Drawing.Point(317, 197);
            coupeLabel.Name = "coupeLabel";
            coupeLabel.Size = new System.Drawing.Size(41, 13);
            coupeLabel.TabIndex = 8;
            coupeLabel.Text = "Coupe:";
            // 
            // poez_NumLabel
            // 
            poez_NumLabel.AutoSize = true;
            poez_NumLabel.Location = new System.Drawing.Point(60, 56);
            poez_NumLabel.Name = "poez_NumLabel";
            poez_NumLabel.Size = new System.Drawing.Size(59, 13);
            poez_NumLabel.TabIndex = 6;
            poez_NumLabel.Text = "Poez Num:";
            // 
            // month_StartLabel
            // 
            month_StartLabel.AutoSize = true;
            month_StartLabel.Location = new System.Drawing.Point(316, 306);
            month_StartLabel.Name = "month_StartLabel";
            month_StartLabel.Size = new System.Drawing.Size(65, 13);
            month_StartLabel.TabIndex = 13;
            month_StartLabel.Text = "Month Start:";
            // 
            // month_EndLabel
            // 
            month_EndLabel.AutoSize = true;
            month_EndLabel.Location = new System.Drawing.Point(507, 309);
            month_EndLabel.Name = "month_EndLabel";
            month_EndLabel.Size = new System.Drawing.Size(62, 13);
            month_EndLabel.TabIndex = 15;
            month_EndLabel.Text = "Month End:";
            // 
            // total_CoupeLabel
            // 
            total_CoupeLabel.AutoSize = true;
            total_CoupeLabel.Location = new System.Drawing.Point(517, 201);
            total_CoupeLabel.Name = "total_CoupeLabel";
            total_CoupeLabel.Size = new System.Drawing.Size(68, 13);
            total_CoupeLabel.TabIndex = 17;
            total_CoupeLabel.Text = "Total Coupe:";
            // 
            // total_PlazLabel
            // 
            total_PlazLabel.AutoSize = true;
            total_PlazLabel.Location = new System.Drawing.Point(517, 227);
            total_PlazLabel.Name = "total_PlazLabel";
            total_PlazLabel.Size = new System.Drawing.Size(57, 13);
            total_PlazLabel.TabIndex = 19;
            total_PlazLabel.Text = "Total Plaz:";
            // 
            // poezdDataSet
            // 
            this.poezdDataSet.DataSetName = "poezdDataSet";
            this.poezdDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // poez_RouteBindingSource
            // 
            this.poez_RouteBindingSource.DataMember = "Poez_Route";
            this.poez_RouteBindingSource.DataSource = this.poezdDataSet;
            // 
            // poez_RouteTableAdapter
            // 
            this.poez_RouteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Poez_RouteTableAdapter = this.poez_RouteTableAdapter;
            this.tableAdapterManager.Route_inf1TableAdapter = this.route_inf1TableAdapter;
            this.tableAdapterManager.Ticket_SumTableAdapter = this.ticket_SumTableAdapter;
            this.tableAdapterManager.UpdateOrder = Kursach.poezdDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // route_inf1TableAdapter
            // 
            this.route_inf1TableAdapter.ClearBeforeFill = true;
            // 
            // ticket_SumTableAdapter
            // 
            this.ticket_SumTableAdapter.ClearBeforeFill = true;
            // 
            // poez_RouteBindingNavigator
            // 
            this.poez_RouteBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.poez_RouteBindingNavigator.BindingSource = this.poez_RouteBindingSource;
            this.poez_RouteBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.poez_RouteBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.poez_RouteBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.poez_RouteBindingNavigatorSaveItem});
            this.poez_RouteBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.poez_RouteBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.poez_RouteBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.poez_RouteBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.poez_RouteBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.poez_RouteBindingNavigator.Name = "poez_RouteBindingNavigator";
            this.poez_RouteBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.poez_RouteBindingNavigator.Size = new System.Drawing.Size(872, 25);
            this.poez_RouteBindingNavigator.TabIndex = 0;
            this.poez_RouteBindingNavigator.Text = "bindingNavigator1";
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
            // poez_RouteBindingNavigatorSaveItem
            // 
            this.poez_RouteBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.poez_RouteBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("poez_RouteBindingNavigatorSaveItem.Image")));
            this.poez_RouteBindingNavigatorSaveItem.Name = "poez_RouteBindingNavigatorSaveItem";
            this.poez_RouteBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.poez_RouteBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.poez_RouteBindingNavigatorSaveItem.Click += new System.EventHandler(this.poez_RouteBindingNavigatorSaveItem_Click);
            // 
            // poez_RouteDataGridView
            // 
            this.poez_RouteDataGridView.AutoGenerateColumns = false;
            this.poez_RouteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.poez_RouteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.poez_RouteDataGridView.DataSource = this.poez_RouteBindingSource;
            this.poez_RouteDataGridView.Location = new System.Drawing.Point(279, 53);
            this.poez_RouteDataGridView.Name = "poez_RouteDataGridView";
            this.poez_RouteDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.poez_RouteDataGridView.Size = new System.Drawing.Size(438, 90);
            this.poez_RouteDataGridView.TabIndex = 1;
            this.poez_RouteDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.poez_RouteDataGridView_CellClick);
            this.poez_RouteDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.poez_RouteDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Poez";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_Poez";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "City_From";
            this.dataGridViewTextBoxColumn2.HeaderText = "City_From";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "City_To";
            this.dataGridViewTextBoxColumn3.HeaderText = "City_To";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Max_People";
            this.dataGridViewTextBoxColumn4.HeaderText = "Max_People";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // route_inf1BindingSource
            // 
            this.route_inf1BindingSource.DataMember = "Route_inf1";
            this.route_inf1BindingSource.DataSource = this.poezdDataSet;
            // 
            // ticket_SumBindingSource
            // 
            this.ticket_SumBindingSource.DataMember = "Ticket_Sum";
            this.ticket_SumBindingSource.DataSource = this.poezdDataSet;
            // 
            // plazcartTextBox
            // 
            this.plazcartTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.route_inf1BindingSource, "Plazcart", true));
            this.plazcartTextBox.Location = new System.Drawing.Point(382, 225);
            this.plazcartTextBox.Name = "plazcartTextBox";
            this.plazcartTextBox.Size = new System.Drawing.Size(36, 20);
            this.plazcartTextBox.TabIndex = 11;
            // 
            // coupeTextBox
            // 
            this.coupeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.route_inf1BindingSource, "Coupe", true));
            this.coupeTextBox.Location = new System.Drawing.Point(382, 194);
            this.coupeTextBox.Name = "coupeTextBox";
            this.coupeTextBox.Size = new System.Drawing.Size(36, 20);
            this.coupeTextBox.TabIndex = 9;
            this.coupeTextBox.TextChanged += new System.EventHandler(this.coupeTextBox_TextChanged);
            // 
            // poez_NumTextBox
            // 
            this.poez_NumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.route_inf1BindingSource, "Poez_Num", true));
            this.poez_NumTextBox.Location = new System.Drawing.Point(125, 53);
            this.poez_NumTextBox.Name = "poez_NumTextBox";
            this.poez_NumTextBox.Size = new System.Drawing.Size(100, 20);
            this.poez_NumTextBox.TabIndex = 7;
            // 
            // month_StartTextBox
            // 
            this.month_StartTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ticket_SumBindingSource, "Month_Start", true));
            this.month_StartTextBox.Location = new System.Drawing.Point(390, 303);
            this.month_StartTextBox.Name = "month_StartTextBox";
            this.month_StartTextBox.Size = new System.Drawing.Size(100, 20);
            this.month_StartTextBox.TabIndex = 14;
            // 
            // month_EndTextBox
            // 
            this.month_EndTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ticket_SumBindingSource, "Month_End", true));
            this.month_EndTextBox.Location = new System.Drawing.Point(581, 306);
            this.month_EndTextBox.Name = "month_EndTextBox";
            this.month_EndTextBox.Size = new System.Drawing.Size(100, 20);
            this.month_EndTextBox.TabIndex = 16;
            // 
            // total_CoupeTextBox
            // 
            this.total_CoupeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ticket_SumBindingSource, "Total_Coupe", true));
            this.total_CoupeTextBox.Location = new System.Drawing.Point(591, 198);
            this.total_CoupeTextBox.Name = "total_CoupeTextBox";
            this.total_CoupeTextBox.Size = new System.Drawing.Size(100, 20);
            this.total_CoupeTextBox.TabIndex = 18;
            // 
            // total_PlazTextBox
            // 
            this.total_PlazTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ticket_SumBindingSource, "Total_Plaz", true));
            this.total_PlazTextBox.Location = new System.Drawing.Point(591, 224);
            this.total_PlazTextBox.Name = "total_PlazTextBox";
            this.total_PlazTextBox.Size = new System.Drawing.Size(100, 20);
            this.total_PlazTextBox.TabIndex = 20;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(390, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 21;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(499, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "ID";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Plazcart";
            this.dataGridViewTextBoxColumn8.HeaderText = "Plazcart";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Coupe";
            this.dataGridViewTextBoxColumn7.HeaderText = "Coupe";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Poez_Num";
            this.dataGridViewTextBoxColumn6.HeaderText = "Poez_Num";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ID_Poez";
            this.dataGridViewTextBoxColumn5.HeaderText = "ID_Poez";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // route_inf1DataGridView
            // 
            this.route_inf1DataGridView.AutoGenerateColumns = false;
            this.route_inf1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.route_inf1DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.route_inf1DataGridView.DataSource = this.route_inf1BindingSource;
            this.route_inf1DataGridView.Location = new System.Drawing.Point(690, 575);
            this.route_inf1DataGridView.Name = "route_inf1DataGridView";
            this.route_inf1DataGridView.Size = new System.Drawing.Size(30, 10);
            this.route_inf1DataGridView.TabIndex = 22;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(90, 409);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 49);
            this.button2.TabIndex = 23;
            this.button2.Text = "Back to Main Menu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // Poez_Route
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kursach.Properties.Resources._1646995570_38_gamerwall_pro_p_vokzal_art_krasivie_oboi_61;
            this.ClientSize = new System.Drawing.Size(872, 658);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(month_StartLabel);
            this.Controls.Add(this.month_StartTextBox);
            this.Controls.Add(month_EndLabel);
            this.Controls.Add(this.month_EndTextBox);
            this.Controls.Add(total_CoupeLabel);
            this.Controls.Add(this.total_CoupeTextBox);
            this.Controls.Add(total_PlazLabel);
            this.Controls.Add(this.total_PlazTextBox);
            this.Controls.Add(poez_NumLabel);
            this.Controls.Add(this.poez_NumTextBox);
            this.Controls.Add(coupeLabel);
            this.Controls.Add(this.coupeTextBox);
            this.Controls.Add(plazcartLabel);
            this.Controls.Add(this.plazcartTextBox);
            this.Controls.Add(this.poez_RouteDataGridView);
            this.Controls.Add(this.poez_RouteBindingNavigator);
            this.Controls.Add(this.route_inf1DataGridView);
            this.Name = "Poez_Route";
            this.Text = "Poez_Route";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Poez_Route_FormClosing);
            this.Load += new System.EventHandler(this.Poez_Route_Load);
            ((System.ComponentModel.ISupportInitialize)(this.poezdDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poez_RouteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poez_RouteBindingNavigator)).EndInit();
            this.poez_RouteBindingNavigator.ResumeLayout(false);
            this.poez_RouteBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poez_RouteDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.route_inf1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticket_SumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.route_inf1DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private poezdDataSet poezdDataSet;
        private System.Windows.Forms.BindingSource poez_RouteBindingSource;
        private poezdDataSetTableAdapters.Poez_RouteTableAdapter poez_RouteTableAdapter;
        private poezdDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator poez_RouteBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton poez_RouteBindingNavigatorSaveItem;
        private poezdDataSetTableAdapters.Route_inf1TableAdapter route_inf1TableAdapter;
        private System.Windows.Forms.DataGridView poez_RouteDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource route_inf1BindingSource;
        private poezdDataSetTableAdapters.Ticket_SumTableAdapter ticket_SumTableAdapter;
        private System.Windows.Forms.BindingSource ticket_SumBindingSource;
        private System.Windows.Forms.TextBox plazcartTextBox;
        private System.Windows.Forms.TextBox coupeTextBox;
        private System.Windows.Forms.TextBox poez_NumTextBox;
        private System.Windows.Forms.TextBox month_StartTextBox;
        private System.Windows.Forms.TextBox month_EndTextBox;
        private System.Windows.Forms.TextBox total_CoupeTextBox;
        private System.Windows.Forms.TextBox total_PlazTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridView route_inf1DataGridView;
        private System.Windows.Forms.Button button2;
    }
}