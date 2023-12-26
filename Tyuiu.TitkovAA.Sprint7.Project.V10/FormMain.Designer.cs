
namespace Tyuiu.TitkovAA.Sprint7.Project.V10
{
    partial class FormMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl_TAA = new System.Windows.Forms.TabControl();
            this.tabPageOrderData_TAA = new System.Windows.Forms.TabPage();
            this.groupBoxMovesOrders_TAA = new System.Windows.Forms.GroupBox();
            this.dataGridViewTableOrders_TAA = new System.Windows.Forms.DataGridView();
            this.FIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOrder_TAA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateDone_TAA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceOrder_TAA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameOrder_TAA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price_TAA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity_TAA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelSearchword_TAA = new System.Windows.Forms.Label();
            this.labelColumn_TAA = new System.Windows.Forms.Label();
            this.comboBoxColumnNames_TAA = new System.Windows.Forms.ComboBox();
            this.labelSearchObj_TAA = new System.Windows.Forms.Label();
            this.textBoxFilter_TAA = new System.Windows.Forms.TextBox();
            this.textBoxSearch_TAA = new System.Windows.Forms.TextBox();
            this.buttonOpenZakaz_TAA = new System.Windows.Forms.Button();
            this.buttonRemZakaz_TAA = new System.Windows.Forms.Button();
            this.buttonFilter_TAA = new System.Windows.Forms.Button();
            this.buttonAddZakaz_TAA = new System.Windows.Forms.Button();
            this.buttonSaveZakaz_TAA = new System.Windows.Forms.Button();
            this.tabPageStatistics_TAA = new System.Windows.Forms.TabPage();
            this.chartStatistics_TAA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip_TAA = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuFile_TAA = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAdd_TAA = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemOpen_TAA = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSave_TAA = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchToolStripMenuItem_TAA = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBoxSearch_TAA = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItemInfo_TAA = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemInstruction_TAA = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAbout_TAA = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExit_TAA = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialogTable_TAA = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogTable_TAA = new System.Windows.Forms.SaveFileDialog();
            this.buttonGetStats_TAA = new System.Windows.Forms.Button();
            this.tabControl_TAA.SuspendLayout();
            this.tabPageOrderData_TAA.SuspendLayout();
            this.groupBoxMovesOrders_TAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTableOrders_TAA)).BeginInit();
            this.tabPageStatistics_TAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatistics_TAA)).BeginInit();
            this.menuStrip_TAA.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_TAA
            // 
            this.tabControl_TAA.Controls.Add(this.tabPageOrderData_TAA);
            this.tabControl_TAA.Controls.Add(this.tabPageStatistics_TAA);
            this.tabControl_TAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_TAA.Location = new System.Drawing.Point(0, 24);
            this.tabControl_TAA.Name = "tabControl_TAA";
            this.tabControl_TAA.SelectedIndex = 0;
            this.tabControl_TAA.Size = new System.Drawing.Size(1730, 779);
            this.tabControl_TAA.TabIndex = 5;
            // 
            // tabPageOrderData_TAA
            // 
            this.tabPageOrderData_TAA.Controls.Add(this.groupBoxMovesOrders_TAA);
            this.tabPageOrderData_TAA.Location = new System.Drawing.Point(4, 22);
            this.tabPageOrderData_TAA.Name = "tabPageOrderData_TAA";
            this.tabPageOrderData_TAA.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOrderData_TAA.Size = new System.Drawing.Size(1722, 753);
            this.tabPageOrderData_TAA.TabIndex = 1;
            this.tabPageOrderData_TAA.Text = "База данных по заказам";
            this.tabPageOrderData_TAA.UseVisualStyleBackColor = true;
            // 
            // groupBoxMovesOrders_TAA
            // 
            this.groupBoxMovesOrders_TAA.BackColor = System.Drawing.SystemColors.Menu;
            this.groupBoxMovesOrders_TAA.Controls.Add(this.dataGridViewTableOrders_TAA);
            this.groupBoxMovesOrders_TAA.Controls.Add(this.labelSearchword_TAA);
            this.groupBoxMovesOrders_TAA.Controls.Add(this.labelColumn_TAA);
            this.groupBoxMovesOrders_TAA.Controls.Add(this.comboBoxColumnNames_TAA);
            this.groupBoxMovesOrders_TAA.Controls.Add(this.labelSearchObj_TAA);
            this.groupBoxMovesOrders_TAA.Controls.Add(this.textBoxFilter_TAA);
            this.groupBoxMovesOrders_TAA.Controls.Add(this.textBoxSearch_TAA);
            this.groupBoxMovesOrders_TAA.Controls.Add(this.buttonOpenZakaz_TAA);
            this.groupBoxMovesOrders_TAA.Controls.Add(this.buttonRemZakaz_TAA);
            this.groupBoxMovesOrders_TAA.Controls.Add(this.buttonFilter_TAA);
            this.groupBoxMovesOrders_TAA.Controls.Add(this.buttonAddZakaz_TAA);
            this.groupBoxMovesOrders_TAA.Controls.Add(this.buttonSaveZakaz_TAA);
            this.groupBoxMovesOrders_TAA.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxMovesOrders_TAA.Location = new System.Drawing.Point(3, 3);
            this.groupBoxMovesOrders_TAA.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxMovesOrders_TAA.Name = "groupBoxMovesOrders_TAA";
            this.groupBoxMovesOrders_TAA.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxMovesOrders_TAA.Size = new System.Drawing.Size(1716, 747);
            this.groupBoxMovesOrders_TAA.TabIndex = 4;
            this.groupBoxMovesOrders_TAA.TabStop = false;
            this.groupBoxMovesOrders_TAA.Text = "Действия";
            // 
            // dataGridViewTableOrders_TAA
            // 
            this.dataGridViewTableOrders_TAA.AllowUserToAddRows = false;
            this.dataGridViewTableOrders_TAA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTableOrders_TAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTableOrders_TAA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FIO,
            this.phon,
            this.NumberOrder_TAA,
            this.DateDone_TAA,
            this.PriceOrder_TAA,
            this.NameOrder_TAA,
            this.Price_TAA,
            this.Quantity_TAA});
            this.dataGridViewTableOrders_TAA.Location = new System.Drawing.Point(4, 103);
            this.dataGridViewTableOrders_TAA.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewTableOrders_TAA.Name = "dataGridViewTableOrders_TAA";
            this.dataGridViewTableOrders_TAA.RowHeadersWidth = 51;
            this.dataGridViewTableOrders_TAA.RowTemplate.Height = 24;
            this.dataGridViewTableOrders_TAA.Size = new System.Drawing.Size(1708, 640);
            this.dataGridViewTableOrders_TAA.TabIndex = 1;
            // 
            // FIO
            // 
            this.FIO.HeaderText = "ФИО";
            this.FIO.Name = "FIO";
            // 
            // phon
            // 
            this.phon.HeaderText = "Телефон";
            this.phon.Name = "phon";
            // 
            // NumberOrder_TAA
            // 
            this.NumberOrder_TAA.HeaderText = "Номер заказа";
            this.NumberOrder_TAA.MinimumWidth = 6;
            this.NumberOrder_TAA.Name = "NumberOrder_TAA";
            // 
            // DateDone_TAA
            // 
            this.DateDone_TAA.HeaderText = "Дата исполнения";
            this.DateDone_TAA.MinimumWidth = 6;
            this.DateDone_TAA.Name = "DateDone_TAA";
            this.DateDone_TAA.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // PriceOrder_TAA
            // 
            this.PriceOrder_TAA.HeaderText = "Стоимость заказа";
            this.PriceOrder_TAA.MinimumWidth = 6;
            this.PriceOrder_TAA.Name = "PriceOrder_TAA";
            // 
            // NameOrder_TAA
            // 
            this.NameOrder_TAA.HeaderText = "Название товара";
            this.NameOrder_TAA.MinimumWidth = 6;
            this.NameOrder_TAA.Name = "NameOrder_TAA";
            this.NameOrder_TAA.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NameOrder_TAA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Price_TAA
            // 
            this.Price_TAA.HeaderText = "Цена товара";
            this.Price_TAA.Name = "Price_TAA";
            // 
            // Quantity_TAA
            // 
            this.Quantity_TAA.HeaderText = "Количество товаров";
            this.Quantity_TAA.Name = "Quantity_TAA";
            // 
            // labelSearchword_TAA
            // 
            this.labelSearchword_TAA.AutoSize = true;
            this.labelSearchword_TAA.Location = new System.Drawing.Point(503, 20);
            this.labelSearchword_TAA.Name = "labelSearchword_TAA";
            this.labelSearchword_TAA.Size = new System.Drawing.Size(131, 13);
            this.labelSearchword_TAA.TabIndex = 4;
            this.labelSearchword_TAA.Text = "Напишите нужное слово";
            // 
            // labelColumn_TAA
            // 
            this.labelColumn_TAA.AutoSize = true;
            this.labelColumn_TAA.Location = new System.Drawing.Point(332, 62);
            this.labelColumn_TAA.Name = "labelColumn_TAA";
            this.labelColumn_TAA.Size = new System.Drawing.Size(101, 13);
            this.labelColumn_TAA.TabIndex = 4;
            this.labelColumn_TAA.Text = "Выберите столбец";
            // 
            // comboBoxColumnNames_TAA
            // 
            this.comboBoxColumnNames_TAA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxColumnNames_TAA.FormattingEnabled = true;
            this.comboBoxColumnNames_TAA.Items.AddRange(new object[] {
            "",
            "ФИО",
            "Телефон",
            "Номер заказа",
            "Дата исполнения",
            "Стоимость заказа",
            "Название товара",
            "Цена товара",
            "Количество товаров"});
            this.comboBoxColumnNames_TAA.Location = new System.Drawing.Point(332, 78);
            this.comboBoxColumnNames_TAA.Name = "comboBoxColumnNames_TAA";
            this.comboBoxColumnNames_TAA.Size = new System.Drawing.Size(167, 21);
            this.comboBoxColumnNames_TAA.TabIndex = 3;
            // 
            // labelSearchObj_TAA
            // 
            this.labelSearchObj_TAA.AutoSize = true;
            this.labelSearchObj_TAA.Location = new System.Drawing.Point(332, 20);
            this.labelSearchObj_TAA.Name = "labelSearchObj_TAA";
            this.labelSearchObj_TAA.Size = new System.Drawing.Size(148, 13);
            this.labelSearchObj_TAA.TabIndex = 2;
            this.labelSearchObj_TAA.Text = "Введите объект для поиска\r\n";
            // 
            // textBoxFilter_TAA
            // 
            this.textBoxFilter_TAA.Enabled = false;
            this.textBoxFilter_TAA.Location = new System.Drawing.Point(506, 36);
            this.textBoxFilter_TAA.Name = "textBoxFilter_TAA";
            this.textBoxFilter_TAA.Size = new System.Drawing.Size(168, 20);
            this.textBoxFilter_TAA.TabIndex = 1;
            this.textBoxFilter_TAA.TextChanged += new System.EventHandler(this.textBoxFilter_TAA_TextChanged);
            // 
            // textBoxSearch_TAA
            // 
            this.textBoxSearch_TAA.Location = new System.Drawing.Point(332, 36);
            this.textBoxSearch_TAA.Name = "textBoxSearch_TAA";
            this.textBoxSearch_TAA.Size = new System.Drawing.Size(168, 20);
            this.textBoxSearch_TAA.TabIndex = 1;
            this.textBoxSearch_TAA.TextChanged += new System.EventHandler(this.textBoxSearch_TAA_TextChanged);
            // 
            // buttonOpenZakaz_TAA
            // 
            this.buttonOpenZakaz_TAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenZakaz_TAA.Location = new System.Drawing.Point(7, 17);
            this.buttonOpenZakaz_TAA.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOpenZakaz_TAA.Name = "buttonOpenZakaz_TAA";
            this.buttonOpenZakaz_TAA.Size = new System.Drawing.Size(144, 39);
            this.buttonOpenZakaz_TAA.TabIndex = 0;
            this.buttonOpenZakaz_TAA.Text = "Открыть базу данных по заказам";
            this.buttonOpenZakaz_TAA.UseVisualStyleBackColor = true;
            this.buttonOpenZakaz_TAA.Click += new System.EventHandler(this.buttonOpenZakaz_TAA_Click);
            // 
            // buttonRemZakaz_TAA
            // 
            this.buttonRemZakaz_TAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemZakaz_TAA.Enabled = false;
            this.buttonRemZakaz_TAA.Location = new System.Drawing.Point(160, 60);
            this.buttonRemZakaz_TAA.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRemZakaz_TAA.Name = "buttonRemZakaz_TAA";
            this.buttonRemZakaz_TAA.Size = new System.Drawing.Size(161, 39);
            this.buttonRemZakaz_TAA.TabIndex = 0;
            this.buttonRemZakaz_TAA.Text = "Удалить заказ";
            this.buttonRemZakaz_TAA.UseVisualStyleBackColor = true;
            this.buttonRemZakaz_TAA.Click += new System.EventHandler(this.buttonRemZakaz_TAA_Click);
            // 
            // buttonFilter_TAA
            // 
            this.buttonFilter_TAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFilter_TAA.Enabled = false;
            this.buttonFilter_TAA.Location = new System.Drawing.Point(504, 62);
            this.buttonFilter_TAA.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFilter_TAA.Name = "buttonFilter_TAA";
            this.buttonFilter_TAA.Size = new System.Drawing.Size(169, 39);
            this.buttonFilter_TAA.TabIndex = 0;
            this.buttonFilter_TAA.Text = "Отфильтровать";
            this.buttonFilter_TAA.UseVisualStyleBackColor = true;
            this.buttonFilter_TAA.Click += new System.EventHandler(this.buttonFilter_TAA_Click);
            // 
            // buttonAddZakaz_TAA
            // 
            this.buttonAddZakaz_TAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddZakaz_TAA.Location = new System.Drawing.Point(160, 17);
            this.buttonAddZakaz_TAA.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddZakaz_TAA.Name = "buttonAddZakaz_TAA";
            this.buttonAddZakaz_TAA.Size = new System.Drawing.Size(161, 39);
            this.buttonAddZakaz_TAA.TabIndex = 0;
            this.buttonAddZakaz_TAA.Text = "Добавить заказ";
            this.buttonAddZakaz_TAA.UseVisualStyleBackColor = true;
            this.buttonAddZakaz_TAA.Click += new System.EventHandler(this.buttonAddZakaz_TAA_Click);
            // 
            // buttonSaveZakaz_TAA
            // 
            this.buttonSaveZakaz_TAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveZakaz_TAA.Location = new System.Drawing.Point(4, 60);
            this.buttonSaveZakaz_TAA.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSaveZakaz_TAA.Name = "buttonSaveZakaz_TAA";
            this.buttonSaveZakaz_TAA.Size = new System.Drawing.Size(147, 39);
            this.buttonSaveZakaz_TAA.TabIndex = 0;
            this.buttonSaveZakaz_TAA.Text = "Сохранить базу данных по заказам";
            this.buttonSaveZakaz_TAA.UseVisualStyleBackColor = true;
            this.buttonSaveZakaz_TAA.Click += new System.EventHandler(this.buttonSaveZakaz_TAA_Click);
            // 
            // tabPageStatistics_TAA
            // 
            this.tabPageStatistics_TAA.Controls.Add(this.buttonGetStats_TAA);
            this.tabPageStatistics_TAA.Controls.Add(this.chartStatistics_TAA);
            this.tabPageStatistics_TAA.Location = new System.Drawing.Point(4, 22);
            this.tabPageStatistics_TAA.Name = "tabPageStatistics_TAA";
            this.tabPageStatistics_TAA.Size = new System.Drawing.Size(1722, 753);
            this.tabPageStatistics_TAA.TabIndex = 2;
            this.tabPageStatistics_TAA.Text = "Статистика";
            this.tabPageStatistics_TAA.UseVisualStyleBackColor = true;
            // 
            // chartStatistics_TAA
            // 
            chartArea6.Name = "ChartArea1";
            this.chartStatistics_TAA.ChartAreas.Add(chartArea6);
            legend6.Enabled = false;
            legend6.Name = "Legend1";
            this.chartStatistics_TAA.Legends.Add(legend6);
            this.chartStatistics_TAA.Location = new System.Drawing.Point(345, 3);
            this.chartStatistics_TAA.Name = "chartStatistics_TAA";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chartStatistics_TAA.Series.Add(series6);
            this.chartStatistics_TAA.Size = new System.Drawing.Size(1374, 742);
            this.chartStatistics_TAA.TabIndex = 2;
            this.chartStatistics_TAA.Text = "chart1";
            this.chartStatistics_TAA.Click += new System.EventHandler(this.chartStatistics_TAA_Click);
            // 
            // menuStrip_TAA
            // 
            this.menuStrip_TAA.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuFile_TAA,
            this.SearchToolStripMenuItem_TAA,
            this.toolStripMenuItemInfo_TAA,
            this.toolStripMenuItemExit_TAA});
            this.menuStrip_TAA.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_TAA.Name = "menuStrip_TAA";
            this.menuStrip_TAA.Size = new System.Drawing.Size(1730, 24);
            this.menuStrip_TAA.TabIndex = 6;
            this.menuStrip_TAA.Text = "menuStrip1";
            // 
            // toolStripMenuFile_TAA
            // 
            this.toolStripMenuFile_TAA.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAdd_TAA,
            this.toolStripMenuItemOpen_TAA,
            this.toolStripMenuItemSave_TAA});
            this.toolStripMenuFile_TAA.Name = "toolStripMenuFile_TAA";
            this.toolStripMenuFile_TAA.Size = new System.Drawing.Size(48, 20);
            this.toolStripMenuFile_TAA.Text = "Файл";
            // 
            // toolStripMenuItemAdd_TAA
            // 
            this.toolStripMenuItemAdd_TAA.Name = "toolStripMenuItemAdd_TAA";
            this.toolStripMenuItemAdd_TAA.Size = new System.Drawing.Size(133, 22);
            this.toolStripMenuItemAdd_TAA.Text = "Добавить";
            this.toolStripMenuItemAdd_TAA.Click += new System.EventHandler(this.buttonAddZakaz_TAA_Click);
            // 
            // toolStripMenuItemOpen_TAA
            // 
            this.toolStripMenuItemOpen_TAA.Name = "toolStripMenuItemOpen_TAA";
            this.toolStripMenuItemOpen_TAA.Size = new System.Drawing.Size(133, 22);
            this.toolStripMenuItemOpen_TAA.Text = "Открыть";
            this.toolStripMenuItemOpen_TAA.Click += new System.EventHandler(this.buttonOpenZakaz_TAA_Click);
            // 
            // toolStripMenuItemSave_TAA
            // 
            this.toolStripMenuItemSave_TAA.Name = "toolStripMenuItemSave_TAA";
            this.toolStripMenuItemSave_TAA.Size = new System.Drawing.Size(133, 22);
            this.toolStripMenuItemSave_TAA.Text = "Сохранить";
            this.toolStripMenuItemSave_TAA.Click += new System.EventHandler(this.buttonSaveZakaz_TAA_Click);
            // 
            // SearchToolStripMenuItem_TAA
            // 
            this.SearchToolStripMenuItem_TAA.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBoxSearch_TAA});
            this.SearchToolStripMenuItem_TAA.Name = "SearchToolStripMenuItem_TAA";
            this.SearchToolStripMenuItem_TAA.Size = new System.Drawing.Size(53, 20);
            this.SearchToolStripMenuItem_TAA.Text = "Найти";
            // 
            // toolStripTextBoxSearch_TAA
            // 
            this.toolStripTextBoxSearch_TAA.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxSearch_TAA.Name = "toolStripTextBoxSearch_TAA";
            this.toolStripTextBoxSearch_TAA.Size = new System.Drawing.Size(100, 23);
            // 
            // toolStripMenuItemInfo_TAA
            // 
            this.toolStripMenuItemInfo_TAA.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemInstruction_TAA,
            this.toolStripMenuItemAbout_TAA});
            this.toolStripMenuItemInfo_TAA.Name = "toolStripMenuItemInfo_TAA";
            this.toolStripMenuItemInfo_TAA.Size = new System.Drawing.Size(65, 20);
            this.toolStripMenuItemInfo_TAA.Text = "Справка";
            // 
            // toolStripMenuItemInstruction_TAA
            // 
            this.toolStripMenuItemInstruction_TAA.Name = "toolStripMenuItemInstruction_TAA";
            this.toolStripMenuItemInstruction_TAA.Size = new System.Drawing.Size(268, 22);
            this.toolStripMenuItemInstruction_TAA.Text = "Краткое руководство пользователя";
            this.toolStripMenuItemInstruction_TAA.Click += new System.EventHandler(this.toolStripMenuItemInstruction_TAA_Click);
            // 
            // toolStripMenuItemAbout_TAA
            // 
            this.toolStripMenuItemAbout_TAA.Name = "toolStripMenuItemAbout_TAA";
            this.toolStripMenuItemAbout_TAA.Size = new System.Drawing.Size(268, 22);
            this.toolStripMenuItemAbout_TAA.Text = "О программе ";
            this.toolStripMenuItemAbout_TAA.Click += new System.EventHandler(this.toolStripMenuItemAbout_TAA_Click);
            // 
            // toolStripMenuItemExit_TAA
            // 
            this.toolStripMenuItemExit_TAA.Name = "toolStripMenuItemExit_TAA";
            this.toolStripMenuItemExit_TAA.Size = new System.Drawing.Size(54, 20);
            this.toolStripMenuItemExit_TAA.Text = "Выход";
            // 
            // openFileDialogTable_TAA
            // 
            this.openFileDialogTable_TAA.FileName = "openFileDialog1";
            // 
            // buttonGetStats_TAA
            // 
            this.buttonGetStats_TAA.Location = new System.Drawing.Point(8, 3);
            this.buttonGetStats_TAA.Name = "buttonGetStats_TAA";
            this.buttonGetStats_TAA.Size = new System.Drawing.Size(158, 61);
            this.buttonGetStats_TAA.TabIndex = 3;
            this.buttonGetStats_TAA.Text = "Жмяк для статистики по популярности товаров";
            this.buttonGetStats_TAA.UseVisualStyleBackColor = true;
            this.buttonGetStats_TAA.Click += new System.EventHandler(this.buttonGetStats_TAA_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1730, 803);
            this.Controls.Add(this.tabControl_TAA);
            this.Controls.Add(this.menuStrip_TAA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заказы";
            this.tabControl_TAA.ResumeLayout(false);
            this.tabPageOrderData_TAA.ResumeLayout(false);
            this.groupBoxMovesOrders_TAA.ResumeLayout(false);
            this.groupBoxMovesOrders_TAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTableOrders_TAA)).EndInit();
            this.tabPageStatistics_TAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartStatistics_TAA)).EndInit();
            this.menuStrip_TAA.ResumeLayout(false);
            this.menuStrip_TAA.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_TAA;
        private System.Windows.Forms.TabPage tabPageOrderData_TAA;
        private System.Windows.Forms.DataGridView dataGridViewTableOrders_TAA;
        private System.Windows.Forms.GroupBox groupBoxMovesOrders_TAA;
        private System.Windows.Forms.Label labelSearchword_TAA;
        private System.Windows.Forms.Label labelColumn_TAA;
        private System.Windows.Forms.ComboBox comboBoxColumnNames_TAA;
        private System.Windows.Forms.Label labelSearchObj_TAA;
        private System.Windows.Forms.TextBox textBoxFilter_TAA;
        private System.Windows.Forms.TextBox textBoxSearch_TAA;
        private System.Windows.Forms.Button buttonOpenZakaz_TAA;
        private System.Windows.Forms.Button buttonRemZakaz_TAA;
        private System.Windows.Forms.Button buttonFilter_TAA;
        private System.Windows.Forms.Button buttonAddZakaz_TAA;
        private System.Windows.Forms.Button buttonSaveZakaz_TAA;
        private System.Windows.Forms.TabPage tabPageStatistics_TAA;
        private System.Windows.Forms.MenuStrip menuStrip_TAA;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuFile_TAA;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAdd_TAA;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOpen_TAA;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSave_TAA;
        private System.Windows.Forms.ToolStripMenuItem SearchToolStripMenuItem_TAA;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxSearch_TAA;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemInfo_TAA;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemInstruction_TAA;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAbout_TAA;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit_TAA;
        private System.Windows.Forms.OpenFileDialog openFileDialogTable_TAA;
        private System.Windows.Forms.SaveFileDialog saveFileDialogTable_TAA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStatistics_TAA;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn phon;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOrder_TAA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateDone_TAA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceOrder_TAA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameOrder_TAA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price_TAA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity_TAA;
        private System.Windows.Forms.Button buttonGetStats_TAA;
    }
}

