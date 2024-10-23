using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursachBD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kLIENTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kLIENTBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kursach_PerevezennyaDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursach_PerevezennyaDataSet.ZAMOVLENNYA". При необходимости она может быть перемещена или удалена.
            this.zAMOVLENNYATableAdapter.Fill(this.kursach_PerevezennyaDataSet.ZAMOVLENNYA);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursach_PerevezennyaDataSet.VODIY". При необходимости она может быть перемещена или удалена.
            this.vODIYTableAdapter.Fill(this.kursach_PerevezennyaDataSet.VODIY);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursach_PerevezennyaDataSet.TRANSPORT". При необходимости она может быть перемещена или удалена.
            this.tRANSPORTTableAdapter.Fill(this.kursach_PerevezennyaDataSet.TRANSPORT);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursach_PerevezennyaDataSet.REYS". При необходимости она может быть перемещена или удалена.
            this.rEYSTableAdapter.Fill(this.kursach_PerevezennyaDataSet.REYS);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursach_PerevezennyaDataSet.PLATA". При необходимости она может быть перемещена или удалена.
            this.pLATATableAdapter.Fill(this.kursach_PerevezennyaDataSet.PLATA);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursach_PerevezennyaDataSet.MARSHRUT". При необходимости она может быть перемещена или удалена.
            this.mARSHRUTTableAdapter.Fill(this.kursach_PerevezennyaDataSet.MARSHRUT);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursach_PerevezennyaDataSet.KLIENT". При необходимости она может быть перемещена или удалена.
            this.kLIENTTableAdapter.Fill(this.kursach_PerevezennyaDataSet.KLIENT);

        }

        private void клієнтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKlient fk = new FormKlient();
            fk.Show();
        }
        private void маршрутToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMarshrut fm = new FormMarshrut();
            fm.Show();
        }
        private void платаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPlata fp = new FormPlata();
            fp.Show();
        }
        private void рейсToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReys fr = new FormReys();
            fr.Show(); 
        }
        private void транспортToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTransport ft = new FormTransport();
            ft.Show();
        }
        private void водійToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVodiy fv = new FormVodiy();
            fv.Show();
        }
        private void замовленняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormZamovlennya fz = new FormZamovlennya();
            fz.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                // Оновлюємо дані для кожної таблиці
                this.kLIENTTableAdapter.Fill(this.kursach_PerevezennyaDataSet.KLIENT);
                this.mARSHRUTTableAdapter.Fill(this.kursach_PerevezennyaDataSet.MARSHRUT);
                this.pLATATableAdapter.Fill(this.kursach_PerevezennyaDataSet.PLATA);
                this.rEYSTableAdapter.Fill(this.kursach_PerevezennyaDataSet.REYS);
                this.tRANSPORTTableAdapter.Fill(this.kursach_PerevezennyaDataSet.TRANSPORT);
                this.vODIYTableAdapter.Fill(this.kursach_PerevezennyaDataSet.VODIY);
                this.zAMOVLENNYATableAdapter.Fill(this.kursach_PerevezennyaDataSet.ZAMOVLENNYA);
                MessageBox.Show("Дані успішно оновлено.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Сталася помилка під час оновлення даних: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormKlient fk = new FormKlient();
            fk.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormMarshrut fm = new FormMarshrut();
            fm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormPlata fp = new FormPlata();
            fp.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormReys fr = new FormReys();
            fr.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormTransport ft = new FormTransport();
            ft.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormVodiy fv = new FormVodiy();
            fv.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormZamovlennya fz = new FormZamovlennya();
            fz.Show();
        }
    }
}
