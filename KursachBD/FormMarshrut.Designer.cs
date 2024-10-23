namespace KursachBD
{
    partial class FormMarshrut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMarshrut));
            this.kursach_PerevezennyaDataSet = new KursachBD.Kursach_PerevezennyaDataSet();
            this.mARSHRUTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mARSHRUTTableAdapter = new KursachBD.Kursach_PerevezennyaDataSetTableAdapters.MARSHRUTTableAdapter();
            this.tableAdapterManager = new KursachBD.Kursach_PerevezennyaDataSetTableAdapters.TableAdapterManager();
            this.mARSHRUTBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.mARSHRUTBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.mARSHRUTDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kursach_PerevezennyaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mARSHRUTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mARSHRUTBindingNavigator)).BeginInit();
            this.mARSHRUTBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mARSHRUTDataGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // kursach_PerevezennyaDataSet
            // 
            this.kursach_PerevezennyaDataSet.DataSetName = "Kursach_PerevezennyaDataSet";
            this.kursach_PerevezennyaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mARSHRUTBindingSource
            // 
            this.mARSHRUTBindingSource.DataMember = "MARSHRUT";
            this.mARSHRUTBindingSource.DataSource = this.kursach_PerevezennyaDataSet;
            // 
            // mARSHRUTTableAdapter
            // 
            this.mARSHRUTTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KLIENTTableAdapter = null;
            this.tableAdapterManager.MARSHRUTTableAdapter = this.mARSHRUTTableAdapter;
            this.tableAdapterManager.PLATATableAdapter = null;
            this.tableAdapterManager.REYSTableAdapter = null;
            this.tableAdapterManager.TRANSPORTTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = KursachBD.Kursach_PerevezennyaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VODIYTableAdapter = null;
            this.tableAdapterManager.ZAMOVLENNYATableAdapter = null;
            // 
            // mARSHRUTBindingNavigator
            // 
            this.mARSHRUTBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.mARSHRUTBindingNavigator.BackColor = System.Drawing.Color.SteelBlue;
            this.mARSHRUTBindingNavigator.BindingSource = this.mARSHRUTBindingSource;
            this.mARSHRUTBindingNavigator.CountItem = null;
            this.mARSHRUTBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.mARSHRUTBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mARSHRUTBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.mARSHRUTBindingNavigatorSaveItem});
            this.mARSHRUTBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.mARSHRUTBindingNavigator.MoveFirstItem = null;
            this.mARSHRUTBindingNavigator.MoveLastItem = null;
            this.mARSHRUTBindingNavigator.MoveNextItem = null;
            this.mARSHRUTBindingNavigator.MovePreviousItem = null;
            this.mARSHRUTBindingNavigator.Name = "mARSHRUTBindingNavigator";
            this.mARSHRUTBindingNavigator.PositionItem = null;
            this.mARSHRUTBindingNavigator.Size = new System.Drawing.Size(1049, 27);
            this.mARSHRUTBindingNavigator.TabIndex = 0;
            this.mARSHRUTBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // mARSHRUTBindingNavigatorSaveItem
            // 
            this.mARSHRUTBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mARSHRUTBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("mARSHRUTBindingNavigatorSaveItem.Image")));
            this.mARSHRUTBindingNavigatorSaveItem.Name = "mARSHRUTBindingNavigatorSaveItem";
            this.mARSHRUTBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.mARSHRUTBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.mARSHRUTBindingNavigatorSaveItem.Click += new System.EventHandler(this.mARSHRUTBindingNavigatorSaveItem_Click);
            // 
            // mARSHRUTDataGridView
            // 
            this.mARSHRUTDataGridView.AutoGenerateColumns = false;
            this.mARSHRUTDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mARSHRUTDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.mARSHRUTDataGridView.DataSource = this.mARSHRUTBindingSource;
            this.mARSHRUTDataGridView.Location = new System.Drawing.Point(12, 32);
            this.mARSHRUTDataGridView.Name = "mARSHRUTDataGridView";
            this.mARSHRUTDataGridView.RowHeadersWidth = 51;
            this.mARSHRUTDataGridView.RowTemplate.Height = 24;
            this.mARSHRUTDataGridView.Size = new System.Drawing.Size(855, 220);
            this.mARSHRUTDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Marshruta";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_Marshruta";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PochtovaTochka";
            this.dataGridViewTextBoxColumn2.HeaderText = "PochtovaTochka";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "KincevaTochka";
            this.dataGridViewTextBoxColumn3.HeaderText = "KincevaTochka";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Dystanciya";
            this.dataGridViewTextBoxColumn4.HeaderText = "Dystanciya";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ID_Zamovlennya";
            this.dataGridViewTextBoxColumn5.HeaderText = "ID_Zamovlennya";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Location = new System.Drawing.Point(446, 264);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(518, 114);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Пошук за заданим критерієм/діапазоном";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "До";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(294, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Для чисел ввести діапазон";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(372, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Для пошуку тексту введіть значення тільки в 1-ий рядок";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(291, 73);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(187, 22);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 22);
            this.textBox1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(446, 421);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 40);
            this.button2.TabIndex = 10;
            this.button2.Text = "Пошук";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(240, 421);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 40);
            this.button1.TabIndex = 9;
            this.button1.Text = "Сортувати весь список";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton7);
            this.groupBox2.Controls.Add(this.radioButton6);
            this.groupBox2.Controls.Add(this.radioButton5);
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Location = new System.Drawing.Point(12, 258);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 203);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Стовпець для операцій";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(6, 126);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(135, 20);
            this.radioButton7.TabIndex = 6;
            this.radioButton7.Text = "Код замовлення";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(6, 100);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(93, 20);
            this.radioButton6.TabIndex = 5;
            this.radioButton6.Text = "Дистанція";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(6, 74);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(120, 20);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.Text = "Кінцева точка";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 48);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(141, 20);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.Text = "Початкова точка";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 22);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(120, 20);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Код маршрута";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(240, 264);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 151);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вибір порядку сортування";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(7, 48);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(119, 20);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "За спаданням";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 22);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(126, 20);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "За зростанням";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(482, 469);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(292, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Таблиця для виведення об\'єднаних запитів";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 584);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(200, 59);
            this.button5.TabIndex = 15;
            this.button5.Text = "Маршрути та кількість рейсів";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 525);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 53);
            this.button4.TabIndex = 14;
            this.button4.Text = "Маршрути та транспортні засоби";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 469);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 50);
            this.button3.TabIndex = 13;
            this.button3.Text = "Водії маршрутів";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(228, 491);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(795, 152);
            this.dataGridView1.TabIndex = 12;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(873, 32);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(164, 45);
            this.button6.TabIndex = 17;
            this.button6.Text = "Сума відстаней";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(873, 83);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(164, 45);
            this.button7.TabIndex = 18;
            this.button7.Text = "Мінімальна відстань";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(873, 134);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(164, 45);
            this.button8.TabIndex = 19;
            this.button8.Text = "Максимальна відстань";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(873, 185);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(164, 45);
            this.button9.TabIndex = 20;
            this.button9.Text = "Середня відстань";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // FormMarshrut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1049, 657);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mARSHRUTDataGridView);
            this.Controls.Add(this.mARSHRUTBindingNavigator);
            this.Name = "FormMarshrut";
            this.Text = "FormMarshrut";
            this.Load += new System.EventHandler(this.FormMarshrut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kursach_PerevezennyaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mARSHRUTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mARSHRUTBindingNavigator)).EndInit();
            this.mARSHRUTBindingNavigator.ResumeLayout(false);
            this.mARSHRUTBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mARSHRUTDataGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Kursach_PerevezennyaDataSet kursach_PerevezennyaDataSet;
        private System.Windows.Forms.BindingSource mARSHRUTBindingSource;
        private Kursach_PerevezennyaDataSetTableAdapters.MARSHRUTTableAdapter mARSHRUTTableAdapter;
        private Kursach_PerevezennyaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator mARSHRUTBindingNavigator;
        private System.Windows.Forms.ToolStripButton mARSHRUTBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView mARSHRUTDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
    }
}