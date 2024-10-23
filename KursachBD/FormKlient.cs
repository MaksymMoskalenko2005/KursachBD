using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursachBD
{
    public partial class FormKlient : Form
    {
        public FormKlient()
        {
            InitializeComponent();
        }
        private void ExecuteQuery(string query)
        {
            // Рядок підключення до бази даних
            string connectionString = "Data Source=Maksym;Initial Catalog=Kursach_Perevezennya;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Створення нового DataTable для зберігання результатів запиту
                    DataTable dataTable = new DataTable();

                    // Виконання запиту через SqlDataAdapter
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.Fill(dataTable);

                    // Прив'язка нових даних до DataGridView
                    dataGridView1.DataSource = dataTable; // Прив'язка нових даних до DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Сталася помилка: " + ex.Message);
                }
            }
        }
        private void kLIENTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kLIENTBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kursach_PerevezennyaDataSet);

        }

        private void FormKlient_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursach_PerevezennyaDataSet.KLIENT". При необходимости она может быть перемещена или удалена.
            this.kLIENTTableAdapter.Fill(this.kursach_PerevezennyaDataSet.KLIENT);

        }

        private void kLIENTDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sortColumn = ""; // Default column to sort
            string sortOrder = "";  // Default sorting order

            // Determine which column to sort by
            if (radioButton3.Checked)
                sortColumn = "ID_Klienta";
            else if (radioButton4.Checked)
                sortColumn = "Imya";
            else if (radioButton5.Checked)
                sortColumn = "Prizvyshche";
            else if (radioButton6.Checked)
                sortColumn = "Nomer";
            else if (radioButton7.Checked)
                sortColumn = "Email";
            else if (radioButton8.Checked)
                sortColumn = "Adresa";

            // Determine if sorting is ascending or descending
            if (radioButton1.Checked)
                sortOrder = "ASC";  // Ascending order
            else if (radioButton2.Checked)
                sortOrder = "DESC"; // Descending order

            // If a column is selected, apply the sort
            if (!string.IsNullOrEmpty(sortColumn))
            {
                // Apply sorting to the DataView
                DataView dataView = new DataView(kursach_PerevezennyaDataSet.KLIENT);
                dataView.Sort = $"{sortColumn} {sortOrder}";

                // Assign sorted DataView back to DataGridView
                kLIENTDataGridView.DataSource = dataView;
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть стовпець для сортування.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string selectedColumn = ""; // Стовпець для фільтрації
            string rangeStart = textBox1.Text; // Отримати початок діапазону з першого текстового поля
            string rangeEnd = textBox2.Text;   // Отримати кінець діапазону з другого текстового поля

            // Визначити, який радіокнопка для вибору стовпця вибрана
            if (radioButton3.Checked)
                selectedColumn = "ID_Klienta";
            else if (radioButton4.Checked)
                selectedColumn = "Imya";
            else if (radioButton5.Checked)
                selectedColumn = "Prizvyshche";
            else if (radioButton6.Checked)
                selectedColumn = "Nomer";  // Номер телефону, розглядаємо як текст
            else if (radioButton7.Checked)
                selectedColumn = "Email";
            else if (radioButton8.Checked)
                selectedColumn = "Adresa";

            // Перевірка на вибраний стовпець
            if (!string.IsNullOrEmpty(selectedColumn))
            {
                DataView dataView = new DataView(kursach_PerevezennyaDataSet.KLIENT);

                // Для текстових даних, пошук за підрядком
                if (selectedColumn == "Nomer" || selectedColumn == "Imya" || selectedColumn == "Prizvyshche" || selectedColumn == "Email" || selectedColumn == "Adresa")
                {
                    if (!string.IsNullOrEmpty(rangeStart))
                    {
                        // Використовуємо лише перше текстове поле для текстових стовпців, ігноруємо друге текстове поле
                        string filter = $"{selectedColumn} LIKE '{rangeStart}%'";
                        dataView.RowFilter = filter;
                    }
                    else
                    {
                        MessageBox.Show("Будь ласка, введіть текст для пошуку.");
                        return;
                    }
                }
                else
                {
                    // Для числових даних, фільтруємо за діапазоном
                    if (!string.IsNullOrEmpty(rangeStart) && !string.IsNullOrEmpty(rangeEnd))
                    {
                        string filter = $"{selectedColumn} >= {rangeStart} AND {selectedColumn} <= {rangeEnd}";
                        dataView.RowFilter = filter;
                    }
                    else
                    {
                        MessageBox.Show("Будь ласка, введіть дійсний діапазон для числових значень.");
                        return;
                    }
                }

                // Призначаємо відфільтровані дані назад до DataGridView
                kLIENTDataGridView.DataSource = dataView;
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть стовпець для пошуку.");
            }
        }
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            string query = @"
        SELECT K.Imya, K.Prizvyshche, Z.DataZamovlennya, Z.DataDostavky
        FROM dbo.KLIENT K
        JOIN dbo.ZAMOVLENNYA Z ON K.ID_Klienta = Z.ID_Klienta;";

            ExecuteQuery(query);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string query = @"
        SELECT K.Imya, K.Prizvyshche, P.SumaOplaty, P.DataOplaty
        FROM dbo.KLIENT K
        JOIN dbo.ZAMOVLENNYA Z ON K.ID_Klienta = Z.ID_Klienta
        JOIN dbo.PLATA P ON Z.ID_Zamovlennya = P.ID_Zamovlennya;";

            ExecuteQuery(query);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string query = @"
        SELECT K.Imya, K.Prizvyshche, M.PochtovaTochka, M.KincevaTochka
        FROM dbo.KLIENT K
        JOIN dbo.ZAMOVLENNYA Z ON K.ID_Klienta = Z.ID_Klienta
        JOIN dbo.REYS R ON R.ID_Vodiya = Z.ID_Klienta
        JOIN dbo.MARSHRUT M ON R.ID_Marshruta = M.ID_Marshruta;";

            ExecuteQuery(query);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
