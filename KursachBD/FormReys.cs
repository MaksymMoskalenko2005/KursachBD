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
    public partial class FormReys : Form
    {
        public FormReys()
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
        private void rEYSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rEYSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kursach_PerevezennyaDataSet);

        }

        private void FormReys_Load(object sender, EventArgs e)
        {
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kursach_PerevezennyaDataSet.REYS". При необходимости она может быть перемещена или удалена.
            this.rEYSTableAdapter.Fill(this.kursach_PerevezennyaDataSet.REYS);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sortColumn = ""; // Default column to sort
            string sortOrder = "";  // Default sorting order

            // Determine which column to sort by
            if (radioButton3.Checked)
                sortColumn = "ID_Reysu";
            else if (radioButton4.Checked)
                sortColumn = "ID_Transporta";
            else if (radioButton5.Checked)
                sortColumn = "ID_Vodiya";
            else if (radioButton6.Checked)
                sortColumn = "ID_Marshruta";
            else if (radioButton7.Checked)
                sortColumn = "DataVyizdu";
            else if (radioButton8.Checked)
                sortColumn = "DataPovernennya";
            // Determine if sorting is ascending or descending
            if (radioButton1.Checked)
                sortOrder = "ASC";  // Ascending order
            else if (radioButton2.Checked)
                sortOrder = "DESC"; // Descending order

            // If a column is selected, apply the sort
            if (!string.IsNullOrEmpty(sortColumn))
            {
                // Apply sorting to the DataView
                DataView dataView = new DataView(kursach_PerevezennyaDataSet.REYS);
                dataView.Sort = $"{sortColumn} {sortOrder}";

                // Assign sorted DataView back to DataGridView
                rEYSDataGridView.DataSource = dataView;
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
                selectedColumn = "ID_Reysu";
            else if (radioButton4.Checked)
                selectedColumn = "ID_Transporta";
            else if (radioButton5.Checked)
                selectedColumn = "ID_Vodiya";
            else if (radioButton6.Checked)
                selectedColumn = "ID_Marshruta";
            else if (radioButton7.Checked)
                selectedColumn = "DataVyizdu";
            else if (radioButton8.Checked)
                selectedColumn = "DataPovernennya";
            // Перевірка на вибраний стовпець
            if (!string.IsNullOrEmpty(selectedColumn))
            {
                DataView dataView = new DataView(kursach_PerevezennyaDataSet.REYS);

                // Для DateTime, фільтруємо за діапазоном
                if (selectedColumn == "DataVyizdu" || selectedColumn == "DataPovernennya")
                {
                    if (!string.IsNullOrEmpty(rangeStart) && !string.IsNullOrEmpty(rangeEnd))
                    {
                        // Форматуємо дати у рядок, щоб передати у RowFilter
                        DateTime startDate;
                        DateTime endDate;

                        // Перевірка на правильність формату дати
                        if (DateTime.TryParse(rangeStart, out startDate) && DateTime.TryParse(rangeEnd, out endDate))
                        {
                            string filter = $"({selectedColumn} >= #{startDate.ToString("MM/dd/yyyy")}#) AND ({selectedColumn} <= #{endDate.ToString("MM/dd/yyyy")}#)";
                            dataView.RowFilter = filter;
                        }
                        else
                        {
                            MessageBox.Show("Будь ласка, введіть дійсні дати у правильному форматі.");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Будь ласка, введіть дійсний діапазон для дати.");
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
                rEYSDataGridView.DataSource = dataView;
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть стовпець для пошуку.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = @"
        SELECT ID_Reysu = R.ID_Reysu, 
               PochtovaTochkaStart = M.PochtovaTochka, 
               PochtovaTochkaKinec = M.KincevaTochka, 
               Dystanciya = M.Dystanciya
        FROM dbo.MARSHRUT M
        INNER JOIN dbo.REYS R ON M.ID_Marshruta = R.ID_Marshruta;";

            ExecuteQuery(query);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            string query = @"
        SELECT ID_Reysu = R.ID_Reysu, 
               ImyaVodiya = V.Imya, 
               PrizvyshcheVodiya = V.Prizvyshche, 
               StazhVodiya = V.Stazh
        FROM dbo.VODIY V
        INNER JOIN dbo.REYS R ON V.ID_Vodiya = R.ID_Vodiya;";

            ExecuteQuery(query);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            string query = @"
        SELECT ID_Reysu = R.ID_Reysu, 
               TransportNomer = T.Nomer, 
               TransportModel = T.Model, 
               TransportMarka = T.Marka
        FROM dbo.TRANSPORT T
        INNER JOIN dbo.REYS R ON T.ID_Transporta = R.ID_Transporta;";

            ExecuteQuery(query);
        }
    }
}
