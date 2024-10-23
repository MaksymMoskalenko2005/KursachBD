namespace KursachBD
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
            this.kursach_PerevezennyaDataSet = new KursachBD.Kursach_PerevezennyaDataSet();
            this.kLIENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kLIENTTableAdapter = new KursachBD.Kursach_PerevezennyaDataSetTableAdapters.KLIENTTableAdapter();
            this.tableAdapterManager = new KursachBD.Kursach_PerevezennyaDataSetTableAdapters.TableAdapterManager();
            this.kLIENTBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.mARSHRUTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mARSHRUTTableAdapter = new KursachBD.Kursach_PerevezennyaDataSetTableAdapters.MARSHRUTTableAdapter();
            this.pLATABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pLATATableAdapter = new KursachBD.Kursach_PerevezennyaDataSetTableAdapters.PLATATableAdapter();
            this.rEYSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rEYSTableAdapter = new KursachBD.Kursach_PerevezennyaDataSetTableAdapters.REYSTableAdapter();
            this.tRANSPORTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tRANSPORTTableAdapter = new KursachBD.Kursach_PerevezennyaDataSetTableAdapters.TRANSPORTTableAdapter();
            this.vODIYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vODIYTableAdapter = new KursachBD.Kursach_PerevezennyaDataSetTableAdapters.VODIYTableAdapter();
            this.zAMOVLENNYABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zAMOVLENNYATableAdapter = new KursachBD.Kursach_PerevezennyaDataSetTableAdapters.ZAMOVLENNYATableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.функціоналТаблицьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клієнтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.маршрутToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.платаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рейсToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.транспортToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.водійToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.замовленняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kursach_PerevezennyaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kLIENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kLIENTBindingNavigator)).BeginInit();
            this.kLIENTBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mARSHRUTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLATABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEYSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRANSPORTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vODIYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zAMOVLENNYABindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kursach_PerevezennyaDataSet
            // 
            this.kursach_PerevezennyaDataSet.DataSetName = "Kursach_PerevezennyaDataSet";
            this.kursach_PerevezennyaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kLIENTBindingSource
            // 
            this.kLIENTBindingSource.DataMember = "KLIENT";
            this.kLIENTBindingSource.DataSource = this.kursach_PerevezennyaDataSet;
            // 
            // kLIENTTableAdapter
            // 
            this.kLIENTTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KLIENTTableAdapter = this.kLIENTTableAdapter;
            this.tableAdapterManager.MARSHRUTTableAdapter = null;
            this.tableAdapterManager.PLATATableAdapter = null;
            this.tableAdapterManager.REYSTableAdapter = null;
            this.tableAdapterManager.TRANSPORTTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = KursachBD.Kursach_PerevezennyaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VODIYTableAdapter = null;
            this.tableAdapterManager.ZAMOVLENNYATableAdapter = null;
            // 
            // kLIENTBindingNavigator
            // 
            this.kLIENTBindingNavigator.AddNewItem = null;
            this.kLIENTBindingNavigator.BackColor = System.Drawing.Color.White;
            this.kLIENTBindingNavigator.BindingSource = this.kLIENTBindingSource;
            this.kLIENTBindingNavigator.CountItem = null;
            this.kLIENTBindingNavigator.DeleteItem = null;
            this.kLIENTBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.kLIENTBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.kLIENTBindingNavigator.Location = new System.Drawing.Point(0, 28);
            this.kLIENTBindingNavigator.MoveFirstItem = null;
            this.kLIENTBindingNavigator.MoveLastItem = null;
            this.kLIENTBindingNavigator.MoveNextItem = null;
            this.kLIENTBindingNavigator.MovePreviousItem = null;
            this.kLIENTBindingNavigator.Name = "kLIENTBindingNavigator";
            this.kLIENTBindingNavigator.PositionItem = null;
            this.kLIENTBindingNavigator.Size = new System.Drawing.Size(635, 27);
            this.kLIENTBindingNavigator.TabIndex = 0;
            this.kLIENTBindingNavigator.Text = "bindingNavigator1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(195, 24);
            this.toolStripButton1.Text = "Перезавантажити таблиці";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
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
            // pLATABindingSource
            // 
            this.pLATABindingSource.DataMember = "PLATA";
            this.pLATABindingSource.DataSource = this.kursach_PerevezennyaDataSet;
            // 
            // pLATATableAdapter
            // 
            this.pLATATableAdapter.ClearBeforeFill = true;
            // 
            // rEYSBindingSource
            // 
            this.rEYSBindingSource.DataMember = "REYS";
            this.rEYSBindingSource.DataSource = this.kursach_PerevezennyaDataSet;
            // 
            // rEYSTableAdapter
            // 
            this.rEYSTableAdapter.ClearBeforeFill = true;
            // 
            // tRANSPORTBindingSource
            // 
            this.tRANSPORTBindingSource.DataMember = "TRANSPORT";
            this.tRANSPORTBindingSource.DataSource = this.kursach_PerevezennyaDataSet;
            // 
            // tRANSPORTTableAdapter
            // 
            this.tRANSPORTTableAdapter.ClearBeforeFill = true;
            // 
            // vODIYBindingSource
            // 
            this.vODIYBindingSource.DataMember = "VODIY";
            this.vODIYBindingSource.DataSource = this.kursach_PerevezennyaDataSet;
            // 
            // vODIYTableAdapter
            // 
            this.vODIYTableAdapter.ClearBeforeFill = true;
            // 
            // zAMOVLENNYABindingSource
            // 
            this.zAMOVLENNYABindingSource.DataMember = "ZAMOVLENNYA";
            this.zAMOVLENNYABindingSource.DataSource = this.kursach_PerevezennyaDataSet;
            // 
            // zAMOVLENNYATableAdapter
            // 
            this.zAMOVLENNYATableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.функціоналТаблицьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(635, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // функціоналТаблицьToolStripMenuItem
            // 
            this.функціоналТаблицьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.клієнтToolStripMenuItem,
            this.маршрутToolStripMenuItem,
            this.платаToolStripMenuItem,
            this.рейсToolStripMenuItem,
            this.транспортToolStripMenuItem,
            this.водійToolStripMenuItem,
            this.замовленняToolStripMenuItem});
            this.функціоналТаблицьToolStripMenuItem.Name = "функціоналТаблицьToolStripMenuItem";
            this.функціоналТаблицьToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.функціоналТаблицьToolStripMenuItem.Text = "Функціонал таблиць";
            // 
            // клієнтToolStripMenuItem
            // 
            this.клієнтToolStripMenuItem.Name = "клієнтToolStripMenuItem";
            this.клієнтToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.клієнтToolStripMenuItem.Text = "Клієнт";
            this.клієнтToolStripMenuItem.Click += new System.EventHandler(this.клієнтToolStripMenuItem_Click);
            // 
            // маршрутToolStripMenuItem
            // 
            this.маршрутToolStripMenuItem.Name = "маршрутToolStripMenuItem";
            this.маршрутToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.маршрутToolStripMenuItem.Text = "Маршрут";
            this.маршрутToolStripMenuItem.Click += new System.EventHandler(this.маршрутToolStripMenuItem_Click);
            // 
            // платаToolStripMenuItem
            // 
            this.платаToolStripMenuItem.Name = "платаToolStripMenuItem";
            this.платаToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.платаToolStripMenuItem.Text = "Плата";
            this.платаToolStripMenuItem.Click += new System.EventHandler(this.платаToolStripMenuItem_Click);
            // 
            // рейсToolStripMenuItem
            // 
            this.рейсToolStripMenuItem.Name = "рейсToolStripMenuItem";
            this.рейсToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.рейсToolStripMenuItem.Text = "Рейс";
            this.рейсToolStripMenuItem.Click += new System.EventHandler(this.рейсToolStripMenuItem_Click);
            // 
            // транспортToolStripMenuItem
            // 
            this.транспортToolStripMenuItem.Name = "транспортToolStripMenuItem";
            this.транспортToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.транспортToolStripMenuItem.Text = "Транспорт";
            this.транспортToolStripMenuItem.Click += new System.EventHandler(this.транспортToolStripMenuItem_Click);
            // 
            // водійToolStripMenuItem
            // 
            this.водійToolStripMenuItem.Name = "водійToolStripMenuItem";
            this.водійToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.водійToolStripMenuItem.Text = "Водій";
            this.водійToolStripMenuItem.Click += new System.EventHandler(this.водійToolStripMenuItem_Click);
            // 
            // замовленняToolStripMenuItem
            // 
            this.замовленняToolStripMenuItem.Name = "замовленняToolStripMenuItem";
            this.замовленняToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.замовленняToolStripMenuItem.Text = "Замовлення";
            this.замовленняToolStripMenuItem.Click += new System.EventHandler(this.замовленняToolStripMenuItem_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(104, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(455, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Перейдіть до таблиці якою ви хочете керувати";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(142, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(365, 41);
            this.button1.TabIndex = 17;
            this.button1.Text = "Клієнт";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(142, 136);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(365, 41);
            this.button2.TabIndex = 18;
            this.button2.Text = "Маршрут";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(142, 183);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(365, 41);
            this.button3.TabIndex = 19;
            this.button3.Text = "Плата";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(142, 230);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(365, 41);
            this.button4.TabIndex = 20;
            this.button4.Text = "Рейс";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(142, 277);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(365, 41);
            this.button5.TabIndex = 21;
            this.button5.Text = "Транспорт";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(142, 324);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(365, 39);
            this.button6.TabIndex = 22;
            this.button6.Text = "Водій";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(142, 369);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(365, 41);
            this.button7.TabIndex = 23;
            this.button7.Text = "Замовлення";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(635, 424);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.kLIENTBindingNavigator);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kursach_PerevezennyaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kLIENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kLIENTBindingNavigator)).EndInit();
            this.kLIENTBindingNavigator.ResumeLayout(false);
            this.kLIENTBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mARSHRUTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLATABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEYSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRANSPORTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vODIYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zAMOVLENNYABindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Kursach_PerevezennyaDataSet kursach_PerevezennyaDataSet;
        private System.Windows.Forms.BindingSource kLIENTBindingSource;
        private Kursach_PerevezennyaDataSetTableAdapters.KLIENTTableAdapter kLIENTTableAdapter;
        private Kursach_PerevezennyaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator kLIENTBindingNavigator;
        private System.Windows.Forms.BindingSource mARSHRUTBindingSource;
        private Kursach_PerevezennyaDataSetTableAdapters.MARSHRUTTableAdapter mARSHRUTTableAdapter;
        private System.Windows.Forms.BindingSource pLATABindingSource;
        private Kursach_PerevezennyaDataSetTableAdapters.PLATATableAdapter pLATATableAdapter;
        private System.Windows.Forms.BindingSource rEYSBindingSource;
        private Kursach_PerevezennyaDataSetTableAdapters.REYSTableAdapter rEYSTableAdapter;
        private System.Windows.Forms.BindingSource tRANSPORTBindingSource;
        private Kursach_PerevezennyaDataSetTableAdapters.TRANSPORTTableAdapter tRANSPORTTableAdapter;
        private System.Windows.Forms.BindingSource vODIYBindingSource;
        private Kursach_PerevezennyaDataSetTableAdapters.VODIYTableAdapter vODIYTableAdapter;
        private System.Windows.Forms.BindingSource zAMOVLENNYABindingSource;
        private Kursach_PerevezennyaDataSetTableAdapters.ZAMOVLENNYATableAdapter zAMOVLENNYATableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem функціоналТаблицьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клієнтToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem маршрутToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem платаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рейсToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem транспортToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem водійToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem замовленняToolStripMenuItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}

