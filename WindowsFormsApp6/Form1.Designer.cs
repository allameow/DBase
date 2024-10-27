namespace WindowsFormsApp6
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
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.oleDbCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbConnection2 = new System.Data.OleDb.OleDbConnection();
            this.oleDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDataAdapter2 = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbConnection3 = new System.Data.OleDb.OleDbConnection();
            this.allaDataSet1 = new WindowsFormsApp6.AllaDataSet();
            this.представленияTableAdapter1 = new WindowsFormsApp6.AllaDataSetTableAdapters.ПредставленияTableAdapter();
            this.программа_циркаTableAdapter1 = new WindowsFormsApp6.AllaDataSetTableAdapters.Программа_циркаTableAdapter();
            this.работники_циркаTableAdapter1 = new WindowsFormsApp6.AllaDataSetTableAdapters.Работники_циркаTableAdapter();
            this.расписание_гастролейTableAdapter1 = new WindowsFormsApp6.AllaDataSetTableAdapters.Расписание_гастролейTableAdapter();
            this.труппа_представления_циркаTableAdapter1 = new WindowsFormsApp6.AllaDataSetTableAdapters.Труппа_представления_циркаTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.allaDataSet = new WindowsFormsApp6.AllaDataSet();
            this.представленияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.кодпредставленияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.режиссерпостановщикDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.авторDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.жанрDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.типDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.программаЦиркаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.представлениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаПремьерыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.периодПроведенияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.дниИВремяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаБилетаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.работникиЦиркаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.кодработникаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.годРожденияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.годПоступленияНаРаботуDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стажDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.должностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.полDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.городDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.расписаниеГастролейBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.номерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.представлениеDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаНачалаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаОкончанияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.местаПроведенияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.труппаПредставленияЦиркаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.кодDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.преставлениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодАктераDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеРолиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.allaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.представленияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.программаЦиркаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.работникиЦиркаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.расписаниеГастролейBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.труппаПредставленияЦиркаBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // oleDbConnection1
            // 
            this.oleDbConnection1.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\andre\\OneDrive\\Documents\\A" +
    "lla.accdb";
            // 
            // oleDbCommand1
            // 
            this.oleDbCommand1.CommandText = resources.GetString("oleDbCommand1.CommandText");
            this.oleDbCommand1.Connection = this.oleDbConnection1;
            // 
            // oleDbSelectCommand1
            // 
            this.oleDbSelectCommand1.CommandText = resources.GetString("oleDbSelectCommand1.CommandText");
            this.oleDbSelectCommand1.Connection = this.oleDbConnection2;
            // 
            // oleDbDataAdapter1
            // 
            this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
            this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Представления", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Программа цирка.Код", "Программа цирка.Код"),
                        new System.Data.Common.DataColumnMapping("Программа цирка.Представление", "Программа цирка.Представление"),
                        new System.Data.Common.DataColumnMapping("Дата премьеры", "Дата премьеры"),
                        new System.Data.Common.DataColumnMapping("Период проведения", "Период проведения"),
                        new System.Data.Common.DataColumnMapping("Дни и время", "Дни и время"),
                        new System.Data.Common.DataColumnMapping("Цена билета", "Цена билета"),
                        new System.Data.Common.DataColumnMapping("Код_представления", "Код_представления"),
                        new System.Data.Common.DataColumnMapping("Название", "Название"),
                        new System.Data.Common.DataColumnMapping("Режиссер-постановщик", "Режиссер-постановщик"),
                        new System.Data.Common.DataColumnMapping("Автор", "Автор"),
                        new System.Data.Common.DataColumnMapping("Жанр", "Жанр"),
                        new System.Data.Common.DataColumnMapping("Тип", "Тип"),
                        new System.Data.Common.DataColumnMapping("Труппа представления цирка.Код", "Труппа представления цирка.Код"),
                        new System.Data.Common.DataColumnMapping("Преставление", "Преставление"),
                        new System.Data.Common.DataColumnMapping("Код актера", "Код актера"),
                        new System.Data.Common.DataColumnMapping("Название роли", "Название роли"),
                        new System.Data.Common.DataColumnMapping("Код_работника", "Код_работника"),
                        new System.Data.Common.DataColumnMapping("Фамилия", "Фамилия"),
                        new System.Data.Common.DataColumnMapping("Имя", "Имя"),
                        new System.Data.Common.DataColumnMapping("Отчество", "Отчество"),
                        new System.Data.Common.DataColumnMapping("Год рождения", "Год рождения"),
                        new System.Data.Common.DataColumnMapping("Год поступления на работу", "Год поступления на работу"),
                        new System.Data.Common.DataColumnMapping("Стаж", "Стаж"),
                        new System.Data.Common.DataColumnMapping("Должность", "Должность"),
                        new System.Data.Common.DataColumnMapping("Пол", "Пол"),
                        new System.Data.Common.DataColumnMapping("Адрес", "Адрес"),
                        new System.Data.Common.DataColumnMapping("Город", "Город"),
                        new System.Data.Common.DataColumnMapping("Телефон", "Телефон"),
                        new System.Data.Common.DataColumnMapping("Номер", "Номер"),
                        new System.Data.Common.DataColumnMapping("Расписание гастролей.Представление", "Расписание гастролей.Представление"),
                        new System.Data.Common.DataColumnMapping("Дата начала", "Дата начала"),
                        new System.Data.Common.DataColumnMapping("Дата окончания", "Дата окончания"),
                        new System.Data.Common.DataColumnMapping("Места проведения", "Места проведения")})});
            // 
            // oleDbConnection2
            // 
            this.oleDbConnection2.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Alla.accdb";
            // 
            // oleDbSelectCommand2
            // 
            this.oleDbSelectCommand2.CommandText = "SELECT [Программа цирка].*\r\nFROM     [Программа цирка]";
            this.oleDbSelectCommand2.Connection = this.oleDbConnection3;
            // 
            // oleDbInsertCommand1
            // 
            this.oleDbInsertCommand1.CommandText = "INSERT INTO `Программа цирка` (`Представление`, `Дата премьеры`, `Период проведен" +
    "ия`, `Дни и время`, `Цена билета`) VALUES (?, ?, ?, ?, ?)";
            this.oleDbInsertCommand1.Connection = this.oleDbConnection3;
            this.oleDbInsertCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Представление", System.Data.OleDb.OleDbType.Integer, 0, "Представление"),
            new System.Data.OleDb.OleDbParameter("Дата_премьеры", System.Data.OleDb.OleDbType.Date, 0, "Дата премьеры"),
            new System.Data.OleDb.OleDbParameter("Период_проведения", System.Data.OleDb.OleDbType.Integer, 0, "Период проведения"),
            new System.Data.OleDb.OleDbParameter("Дни_и_время", System.Data.OleDb.OleDbType.Date, 0, "Дни и время"),
            new System.Data.OleDb.OleDbParameter("Цена_билета", System.Data.OleDb.OleDbType.Currency, 0, "Цена билета")});
            // 
            // oleDbUpdateCommand1
            // 
            this.oleDbUpdateCommand1.CommandText = resources.GetString("oleDbUpdateCommand1.CommandText");
            this.oleDbUpdateCommand1.Connection = this.oleDbConnection3;
            this.oleDbUpdateCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Представление", System.Data.OleDb.OleDbType.Integer, 0, "Представление"),
            new System.Data.OleDb.OleDbParameter("Дата_премьеры", System.Data.OleDb.OleDbType.Date, 0, "Дата премьеры"),
            new System.Data.OleDb.OleDbParameter("Период_проведения", System.Data.OleDb.OleDbType.Integer, 0, "Период проведения"),
            new System.Data.OleDb.OleDbParameter("Дни_и_время", System.Data.OleDb.OleDbType.Date, 0, "Дни и время"),
            new System.Data.OleDb.OleDbParameter("Цена_билета", System.Data.OleDb.OleDbType.Currency, 0, "Цена билета"),
            new System.Data.OleDb.OleDbParameter("Original_Код", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Код", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Представление", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Представление", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Представление", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Представление", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Дата_премьеры", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Дата премьеры", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Дата_премьеры", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Дата премьеры", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Период_проведения", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Период проведения", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Период_проведения", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Период проведения", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Дни_и_время", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Дни и время", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Дни_и_время", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Дни и время", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Цена_билета", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Цена билета", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Цена_билета", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Цена билета", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand1
            // 
            this.oleDbDeleteCommand1.CommandText = resources.GetString("oleDbDeleteCommand1.CommandText");
            this.oleDbDeleteCommand1.Connection = this.oleDbConnection3;
            this.oleDbDeleteCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_Код", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Код", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Представление", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Представление", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Представление", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Представление", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Дата_премьеры", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Дата премьеры", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Дата_премьеры", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Дата премьеры", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Период_проведения", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Период проведения", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Период_проведения", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Период проведения", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Дни_и_время", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Дни и время", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Дни_и_время", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Дни и время", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Цена_билета", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Цена билета", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Цена_билета", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Цена билета", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDataAdapter2
            // 
            this.oleDbDataAdapter2.DeleteCommand = this.oleDbDeleteCommand1;
            this.oleDbDataAdapter2.InsertCommand = this.oleDbInsertCommand1;
            this.oleDbDataAdapter2.SelectCommand = this.oleDbSelectCommand2;
            this.oleDbDataAdapter2.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Программа цирка", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Код", "Код"),
                        new System.Data.Common.DataColumnMapping("Представление", "Представление"),
                        new System.Data.Common.DataColumnMapping("Дата премьеры", "Дата премьеры"),
                        new System.Data.Common.DataColumnMapping("Период проведения", "Период проведения"),
                        new System.Data.Common.DataColumnMapping("Дни и время", "Дни и время"),
                        new System.Data.Common.DataColumnMapping("Цена билета", "Цена билета")})});
            this.oleDbDataAdapter2.UpdateCommand = this.oleDbUpdateCommand1;
            // 
            // oleDbConnection3
            // 
            this.oleDbConnection3.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Alla.accdb";
            // 
            // allaDataSet1
            // 
            this.allaDataSet1.DataSetName = "AllaDataSet";
            this.allaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // представленияTableAdapter1
            // 
            this.представленияTableAdapter1.ClearBeforeFill = true;
            // 
            // программа_циркаTableAdapter1
            // 
            this.программа_циркаTableAdapter1.ClearBeforeFill = true;
            // 
            // работники_циркаTableAdapter1
            // 
            this.работники_циркаTableAdapter1.ClearBeforeFill = true;
            // 
            // расписание_гастролейTableAdapter1
            // 
            this.расписание_гастролейTableAdapter1.ClearBeforeFill = true;
            // 
            // труппа_представления_циркаTableAdapter1
            // 
            this.труппа_представления_циркаTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодпредставленияDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn,
            this.режиссерпостановщикDataGridViewTextBoxColumn,
            this.авторDataGridViewTextBoxColumn,
            this.жанрDataGridViewTextBoxColumn,
            this.типDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.представленияBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-7, 309);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(828, 160);
            this.dataGridView1.TabIndex = 0;
            // 
            // allaDataSet
            // 
            this.allaDataSet.DataSetName = "AllaDataSet";
            this.allaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // представленияBindingSource
            // 
            this.представленияBindingSource.DataMember = "Представления";
            this.представленияBindingSource.DataSource = this.allaDataSet;
            // 
            // кодпредставленияDataGridViewTextBoxColumn
            // 
            this.кодпредставленияDataGridViewTextBoxColumn.DataPropertyName = "Код_представления";
            this.кодпредставленияDataGridViewTextBoxColumn.HeaderText = "Код_представления";
            this.кодпредставленияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодпредставленияDataGridViewTextBoxColumn.Name = "кодпредставленияDataGridViewTextBoxColumn";
            this.кодпредставленияDataGridViewTextBoxColumn.Width = 125;
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            this.названиеDataGridViewTextBoxColumn.Width = 125;
            // 
            // режиссерпостановщикDataGridViewTextBoxColumn
            // 
            this.режиссерпостановщикDataGridViewTextBoxColumn.DataPropertyName = "Режиссер-постановщик";
            this.режиссерпостановщикDataGridViewTextBoxColumn.HeaderText = "Режиссер-постановщик";
            this.режиссерпостановщикDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.режиссерпостановщикDataGridViewTextBoxColumn.Name = "режиссерпостановщикDataGridViewTextBoxColumn";
            this.режиссерпостановщикDataGridViewTextBoxColumn.Width = 125;
            // 
            // авторDataGridViewTextBoxColumn
            // 
            this.авторDataGridViewTextBoxColumn.DataPropertyName = "Автор";
            this.авторDataGridViewTextBoxColumn.HeaderText = "Автор";
            this.авторDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.авторDataGridViewTextBoxColumn.Name = "авторDataGridViewTextBoxColumn";
            this.авторDataGridViewTextBoxColumn.Width = 125;
            // 
            // жанрDataGridViewTextBoxColumn
            // 
            this.жанрDataGridViewTextBoxColumn.DataPropertyName = "Жанр";
            this.жанрDataGridViewTextBoxColumn.HeaderText = "Жанр";
            this.жанрDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.жанрDataGridViewTextBoxColumn.Name = "жанрDataGridViewTextBoxColumn";
            this.жанрDataGridViewTextBoxColumn.Width = 125;
            // 
            // типDataGridViewTextBoxColumn
            // 
            this.типDataGridViewTextBoxColumn.DataPropertyName = "Тип";
            this.типDataGridViewTextBoxColumn.HeaderText = "Тип";
            this.типDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.типDataGridViewTextBoxColumn.Name = "типDataGridViewTextBoxColumn";
            this.типDataGridViewTextBoxColumn.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Представления";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.представлениеDataGridViewTextBoxColumn,
            this.датаПремьерыDataGridViewTextBoxColumn,
            this.периодПроведенияDataGridViewTextBoxColumn,
            this.дниИВремяDataGridViewTextBoxColumn,
            this.ценаБилетаDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.программаЦиркаBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(-20, 309);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(841, 165);
            this.dataGridView2.TabIndex = 2;
            // 
            // программаЦиркаBindingSource
            // 
            this.программаЦиркаBindingSource.DataMember = "Программа цирка";
            this.программаЦиркаBindingSource.DataSource = this.allaDataSet;
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            this.кодDataGridViewTextBoxColumn.Width = 125;
            // 
            // представлениеDataGridViewTextBoxColumn
            // 
            this.представлениеDataGridViewTextBoxColumn.DataPropertyName = "Представление";
            this.представлениеDataGridViewTextBoxColumn.HeaderText = "Представление";
            this.представлениеDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.представлениеDataGridViewTextBoxColumn.Name = "представлениеDataGridViewTextBoxColumn";
            this.представлениеDataGridViewTextBoxColumn.Width = 125;
            // 
            // датаПремьерыDataGridViewTextBoxColumn
            // 
            this.датаПремьерыDataGridViewTextBoxColumn.DataPropertyName = "Дата премьеры";
            this.датаПремьерыDataGridViewTextBoxColumn.HeaderText = "Дата премьеры";
            this.датаПремьерыDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаПремьерыDataGridViewTextBoxColumn.Name = "датаПремьерыDataGridViewTextBoxColumn";
            this.датаПремьерыDataGridViewTextBoxColumn.Width = 125;
            // 
            // периодПроведенияDataGridViewTextBoxColumn
            // 
            this.периодПроведенияDataGridViewTextBoxColumn.DataPropertyName = "Период проведения";
            this.периодПроведенияDataGridViewTextBoxColumn.HeaderText = "Период проведения";
            this.периодПроведенияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.периодПроведенияDataGridViewTextBoxColumn.Name = "периодПроведенияDataGridViewTextBoxColumn";
            this.периодПроведенияDataGridViewTextBoxColumn.Width = 125;
            // 
            // дниИВремяDataGridViewTextBoxColumn
            // 
            this.дниИВремяDataGridViewTextBoxColumn.DataPropertyName = "Дни и время";
            this.дниИВремяDataGridViewTextBoxColumn.HeaderText = "Дни и время";
            this.дниИВремяDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.дниИВремяDataGridViewTextBoxColumn.Name = "дниИВремяDataGridViewTextBoxColumn";
            this.дниИВремяDataGridViewTextBoxColumn.Width = 125;
            // 
            // ценаБилетаDataGridViewTextBoxColumn
            // 
            this.ценаБилетаDataGridViewTextBoxColumn.DataPropertyName = "Цена билета";
            this.ценаБилетаDataGridViewTextBoxColumn.HeaderText = "Цена билета";
            this.ценаБилетаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ценаБилетаDataGridViewTextBoxColumn.Name = "ценаБилетаDataGridViewTextBoxColumn";
            this.ценаБилетаDataGridViewTextBoxColumn.Width = 125;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(22, 105);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(233, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Программа цирка";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодработникаDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.отчествоDataGridViewTextBoxColumn,
            this.годРожденияDataGridViewTextBoxColumn,
            this.годПоступленияНаРаботуDataGridViewTextBoxColumn,
            this.стажDataGridViewTextBoxColumn,
            this.должностьDataGridViewTextBoxColumn,
            this.полDataGridViewTextBoxColumn,
            this.адресDataGridViewTextBoxColumn,
            this.городDataGridViewTextBoxColumn,
            this.телефонDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.работникиЦиркаBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(-7, 309);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(871, 150);
            this.dataGridView3.TabIndex = 4;
            // 
            // работникиЦиркаBindingSource
            // 
            this.работникиЦиркаBindingSource.DataMember = "Работники цирка";
            this.работникиЦиркаBindingSource.DataSource = this.allaDataSet;
            // 
            // кодработникаDataGridViewTextBoxColumn
            // 
            this.кодработникаDataGridViewTextBoxColumn.DataPropertyName = "Код_работника";
            this.кодработникаDataGridViewTextBoxColumn.HeaderText = "Код_работника";
            this.кодработникаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодработникаDataGridViewTextBoxColumn.Name = "кодработникаDataGridViewTextBoxColumn";
            this.кодработникаDataGridViewTextBoxColumn.Width = 125;
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            this.фамилияDataGridViewTextBoxColumn.Width = 125;
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            this.имяDataGridViewTextBoxColumn.Width = 125;
            // 
            // отчествоDataGridViewTextBoxColumn
            // 
            this.отчествоDataGridViewTextBoxColumn.DataPropertyName = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.отчествоDataGridViewTextBoxColumn.Name = "отчествоDataGridViewTextBoxColumn";
            this.отчествоDataGridViewTextBoxColumn.Width = 125;
            // 
            // годРожденияDataGridViewTextBoxColumn
            // 
            this.годРожденияDataGridViewTextBoxColumn.DataPropertyName = "Год рождения";
            this.годРожденияDataGridViewTextBoxColumn.HeaderText = "Год рождения";
            this.годРожденияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.годРожденияDataGridViewTextBoxColumn.Name = "годРожденияDataGridViewTextBoxColumn";
            this.годРожденияDataGridViewTextBoxColumn.Width = 125;
            // 
            // годПоступленияНаРаботуDataGridViewTextBoxColumn
            // 
            this.годПоступленияНаРаботуDataGridViewTextBoxColumn.DataPropertyName = "Год поступления на работу";
            this.годПоступленияНаРаботуDataGridViewTextBoxColumn.HeaderText = "Год поступления на работу";
            this.годПоступленияНаРаботуDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.годПоступленияНаРаботуDataGridViewTextBoxColumn.Name = "годПоступленияНаРаботуDataGridViewTextBoxColumn";
            this.годПоступленияНаРаботуDataGridViewTextBoxColumn.Width = 125;
            // 
            // стажDataGridViewTextBoxColumn
            // 
            this.стажDataGridViewTextBoxColumn.DataPropertyName = "Стаж";
            this.стажDataGridViewTextBoxColumn.HeaderText = "Стаж";
            this.стажDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.стажDataGridViewTextBoxColumn.Name = "стажDataGridViewTextBoxColumn";
            this.стажDataGridViewTextBoxColumn.Width = 125;
            // 
            // должностьDataGridViewTextBoxColumn
            // 
            this.должностьDataGridViewTextBoxColumn.DataPropertyName = "Должность";
            this.должностьDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.должностьDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.должностьDataGridViewTextBoxColumn.Name = "должностьDataGridViewTextBoxColumn";
            this.должностьDataGridViewTextBoxColumn.Width = 125;
            // 
            // полDataGridViewTextBoxColumn
            // 
            this.полDataGridViewTextBoxColumn.DataPropertyName = "Пол";
            this.полDataGridViewTextBoxColumn.HeaderText = "Пол";
            this.полDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.полDataGridViewTextBoxColumn.Name = "полDataGridViewTextBoxColumn";
            this.полDataGridViewTextBoxColumn.Width = 125;
            // 
            // адресDataGridViewTextBoxColumn
            // 
            this.адресDataGridViewTextBoxColumn.DataPropertyName = "Адрес";
            this.адресDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.адресDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.адресDataGridViewTextBoxColumn.Name = "адресDataGridViewTextBoxColumn";
            this.адресDataGridViewTextBoxColumn.Width = 125;
            // 
            // городDataGridViewTextBoxColumn
            // 
            this.городDataGridViewTextBoxColumn.DataPropertyName = "Город";
            this.городDataGridViewTextBoxColumn.HeaderText = "Город";
            this.городDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.городDataGridViewTextBoxColumn.Name = "городDataGridViewTextBoxColumn";
            this.городDataGridViewTextBoxColumn.Width = 125;
            // 
            // телефонDataGridViewTextBoxColumn
            // 
            this.телефонDataGridViewTextBoxColumn.DataPropertyName = "Телефон";
            this.телефонDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.телефонDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.телефонDataGridViewTextBoxColumn.Name = "телефонDataGridViewTextBoxColumn";
            this.телефонDataGridViewTextBoxColumn.Width = 125;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(22, 134);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(233, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Работники цирка";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерDataGridViewTextBoxColumn,
            this.представлениеDataGridViewTextBoxColumn1,
            this.датаНачалаDataGridViewTextBoxColumn,
            this.датаОкончанияDataGridViewTextBoxColumn,
            this.местаПроведенияDataGridViewTextBoxColumn});
            this.dataGridView4.DataSource = this.расписаниеГастролейBindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(-7, 309);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(850, 185);
            this.dataGridView4.TabIndex = 6;
            // 
            // расписаниеГастролейBindingSource
            // 
            this.расписаниеГастролейBindingSource.DataMember = "Расписание гастролей";
            this.расписаниеГастролейBindingSource.DataSource = this.allaDataSet;
            // 
            // номерDataGridViewTextBoxColumn
            // 
            this.номерDataGridViewTextBoxColumn.DataPropertyName = "Номер";
            this.номерDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.номерDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.номерDataGridViewTextBoxColumn.Name = "номерDataGridViewTextBoxColumn";
            this.номерDataGridViewTextBoxColumn.Width = 125;
            // 
            // представлениеDataGridViewTextBoxColumn1
            // 
            this.представлениеDataGridViewTextBoxColumn1.DataPropertyName = "Представление";
            this.представлениеDataGridViewTextBoxColumn1.HeaderText = "Представление";
            this.представлениеDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.представлениеDataGridViewTextBoxColumn1.Name = "представлениеDataGridViewTextBoxColumn1";
            this.представлениеDataGridViewTextBoxColumn1.Width = 125;
            // 
            // датаНачалаDataGridViewTextBoxColumn
            // 
            this.датаНачалаDataGridViewTextBoxColumn.DataPropertyName = "Дата начала";
            this.датаНачалаDataGridViewTextBoxColumn.HeaderText = "Дата начала";
            this.датаНачалаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаНачалаDataGridViewTextBoxColumn.Name = "датаНачалаDataGridViewTextBoxColumn";
            this.датаНачалаDataGridViewTextBoxColumn.Width = 125;
            // 
            // датаОкончанияDataGridViewTextBoxColumn
            // 
            this.датаОкончанияDataGridViewTextBoxColumn.DataPropertyName = "Дата окончания";
            this.датаОкончанияDataGridViewTextBoxColumn.HeaderText = "Дата окончания";
            this.датаОкончанияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаОкончанияDataGridViewTextBoxColumn.Name = "датаОкончанияDataGridViewTextBoxColumn";
            this.датаОкончанияDataGridViewTextBoxColumn.Width = 125;
            // 
            // местаПроведенияDataGridViewTextBoxColumn
            // 
            this.местаПроведенияDataGridViewTextBoxColumn.DataPropertyName = "Места проведения";
            this.местаПроведенияDataGridViewTextBoxColumn.HeaderText = "Места проведения";
            this.местаПроведенияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.местаПроведенияDataGridViewTextBoxColumn.Name = "местаПроведенияDataGridViewTextBoxColumn";
            this.местаПроведенияDataGridViewTextBoxColumn.Width = 125;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(22, 163);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(233, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Расписание гастролей";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(22, 192);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(233, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "Труппа представления цирка";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView5
            // 
            this.dataGridView5.AutoGenerateColumns = false;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn1,
            this.преставлениеDataGridViewTextBoxColumn,
            this.кодАктераDataGridViewTextBoxColumn,
            this.названиеРолиDataGridViewTextBoxColumn});
            this.dataGridView5.DataSource = this.труппаПредставленияЦиркаBindingSource;
            this.dataGridView5.Location = new System.Drawing.Point(-7, 309);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.RowHeadersWidth = 51;
            this.dataGridView5.RowTemplate.Height = 24;
            this.dataGridView5.Size = new System.Drawing.Size(828, 149);
            this.dataGridView5.TabIndex = 9;
            // 
            // труппаПредставленияЦиркаBindingSource
            // 
            this.труппаПредставленияЦиркаBindingSource.DataMember = "Труппа представления цирка";
            this.труппаПредставленияЦиркаBindingSource.DataSource = this.allaDataSet;
            // 
            // кодDataGridViewTextBoxColumn1
            // 
            this.кодDataGridViewTextBoxColumn1.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn1.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.кодDataGridViewTextBoxColumn1.Name = "кодDataGridViewTextBoxColumn1";
            this.кодDataGridViewTextBoxColumn1.Width = 125;
            // 
            // преставлениеDataGridViewTextBoxColumn
            // 
            this.преставлениеDataGridViewTextBoxColumn.DataPropertyName = "Преставление";
            this.преставлениеDataGridViewTextBoxColumn.HeaderText = "Преставление";
            this.преставлениеDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.преставлениеDataGridViewTextBoxColumn.Name = "преставлениеDataGridViewTextBoxColumn";
            this.преставлениеDataGridViewTextBoxColumn.Width = 125;
            // 
            // кодАктераDataGridViewTextBoxColumn
            // 
            this.кодАктераDataGridViewTextBoxColumn.DataPropertyName = "Код актера";
            this.кодАктераDataGridViewTextBoxColumn.HeaderText = "Код актера";
            this.кодАктераDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодАктераDataGridViewTextBoxColumn.Name = "кодАктераDataGridViewTextBoxColumn";
            this.кодАктераDataGridViewTextBoxColumn.Width = 125;
            // 
            // названиеРолиDataGridViewTextBoxColumn
            // 
            this.названиеРолиDataGridViewTextBoxColumn.DataPropertyName = "Название роли";
            this.названиеРолиDataGridViewTextBoxColumn.HeaderText = "Название роли";
            this.названиеРолиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.названиеРолиDataGridViewTextBoxColumn.Name = "названиеРолиDataGridViewTextBoxColumn";
            this.названиеРолиDataGridViewTextBoxColumn.Width = 125;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(276, 192);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(233, 23);
            this.button6.TabIndex = 14;
            this.button6.Text = "Труппа представления цирка";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(276, 163);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(233, 23);
            this.button7.TabIndex = 13;
            this.button7.Text = "Расписание гастролей";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(276, 134);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(233, 23);
            this.button8.TabIndex = 12;
            this.button8.Text = "Работники цирка";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(276, 105);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(233, 23);
            this.button9.TabIndex = 11;
            this.button9.Text = "Программа цирка";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(276, 76);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(233, 23);
            this.button10.TabIndex = 10;
            this.button10.Text = "Представления";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(22, 236);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 15;
            this.button11.Text = "Выход";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Таблицы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Изменение";
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(552, 116);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(195, 26);
            this.button12.TabIndex = 18;
            this.button12.Text = "Сортировка и фильтрация";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(637, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 22);
            this.textBox1.TabIndex = 19;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(637, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(151, 22);
            this.textBox2.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(537, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Фильтрация";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(538, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Сортировка";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.dataGridView5);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.allaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.представленияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.программаЦиркаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.работникиЦиркаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.расписаниеГастролейBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.труппаПредставленияЦиркаBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.OleDb.OleDbConnection oleDbConnection1;
        private System.Data.OleDb.OleDbCommand oleDbCommand1;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
        private System.Data.OleDb.OleDbConnection oleDbConnection2;
        private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand2;
        private System.Data.OleDb.OleDbConnection oleDbConnection3;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
        private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter2;
        private AllaDataSet allaDataSet1;
        private AllaDataSetTableAdapters.ПредставленияTableAdapter представленияTableAdapter1;
        private AllaDataSetTableAdapters.Программа_циркаTableAdapter программа_циркаTableAdapter1;
        private AllaDataSetTableAdapters.Работники_циркаTableAdapter работники_циркаTableAdapter1;
        private AllaDataSetTableAdapters.Расписание_гастролейTableAdapter расписание_гастролейTableAdapter1;
        private AllaDataSetTableAdapters.Труппа_представления_циркаTableAdapter труппа_представления_циркаTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодпредставленияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn режиссерпостановщикDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn авторDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn жанрDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn типDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource представленияBindingSource;
        private AllaDataSet allaDataSet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn представлениеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаПремьерыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn периодПроведенияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn дниИВремяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаБилетаDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource программаЦиркаBindingSource;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодработникаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn годРожденияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn годПоступленияНаРаботуDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стажDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn должностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn полDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn городDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource работникиЦиркаBindingSource;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn представлениеDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаНачалаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаОкончанияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn местаПроведенияDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource расписаниеГастролейBindingSource;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn преставлениеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодАктераDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеРолиDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource труппаПредставленияЦиркаBindingSource;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

