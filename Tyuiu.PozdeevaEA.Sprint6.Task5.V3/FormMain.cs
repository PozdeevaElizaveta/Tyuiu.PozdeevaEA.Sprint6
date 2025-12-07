
using ScottPlot;
using System.Windows.Forms;
using Tyuiu.PozdeevaEA.Sprint6.Task5.V3.Lib;
namespace Tyuiu.PozdeevaEA.Sprint6.Task5.V3
{
    public partial class FormMain : Form
    {

        public FormMain()
        {
            InitializeComponent();
            InitializeDataGridView();
        }
        private void InitializeDataGridView()
        {
            // Настройка DataGridView
            dataGridViewRes_PEA.Columns.Clear();
            dataGridViewRes_PEA.Columns.Add("Index", "№");
            dataGridViewRes_PEA.Columns.Add("Value", "Значение");
            dataGridViewRes_PEA.Columns["Index"].Width = 50;
            dataGridViewRes_PEA.Columns["Value"].Width = 100;
            dataGridViewRes_PEA.Columns["Value"].DefaultCellStyle.Format = "F3"; // 3 знака после запятой
        }
        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void labelTask_PEA_Click(object sender, EventArgs e)
        {

        }

        private void textBoxTask_PEA_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDone_PEA_Click(object sender, EventArgs e)
        {
            try  // Начинаем блок обработки ошибок
            {
                string filePath = textBoxFilePath_PEA.Text;  // Сохраняем путь к файлу в переменную

                // 1. Загружаем данные через DataService
                DataService dataService = new DataService();  // Создаем объект нашего сервиса
                double[] numbers = dataService.LoadFromDataFile(filePath);  // Вызываем метод, который читает файл

                // 2. Выводим в DataGridView
                DisplayInDataGridView(numbers);  // Вызываем наш метод для отображения в таблице

                // 3. Строим график
                PlotChart(numbers);  // Вызываем метод для построения диаграммы
            }
            catch (Exception ex)  // Ловим любую ошибку, которая произошла в блоке try
            {
                MessageBox.Show($"Ошибка: {ex.Message}");  // Показываем окно с текстом ошибки
            }
        }
        private void PlotChart(double[] values)
        {
            formsPlotRes_PEA.Plot.Clear();

            // Создание массива индексов для оси X
            double[] indices = new double[values.Length];  
            for (int i = 0; i < values.Length; i++)  
            {
                indices[i] = i + 1;
            }

            // Добавление столбчатой диаграммы
            var barPlot = formsPlotRes_PEA.Plot.AddBar(values);  
            barPlot.FillColor = Color.FromArgb(100, 0, 120, 215);
            barPlot.BorderColor = Color.FromArgb(255, 0, 120, 215);
            barPlot.BorderLineWidth = 1;

            // Настройка осей
            formsPlotRes_PEA.Plot.XLabel("Индекс");
            formsPlotRes_PEA.Plot.YLabel("Значение");
            formsPlotRes_PEA.Plot.Title($"Диаграмма значений (n = {values.Length})");  

            // Настройка меток на оси X
            string[] labels = new string[values.Length];  
            for (int i = 0; i < values.Length; i++) 
            {
                labels[i] = (i + 1).ToString();
            }
            formsPlotRes_PEA.Plot.XTicks(labels);

            // Автомасштабирование с небольшим отступом
            formsPlotRes_PEA.Plot.SetAxisLimits(xMin: 0, xMax: values.Length + 1,
                                         yMin: values.Min() * 0.9, yMax: values.Max() * 1.1);

            // Включение сетки
            formsPlotRes_PEA.Plot.Grid(enable: true);

            // Обновление графика
            formsPlotRes_PEA.Refresh();
        }

        private void DisplayInDataGridView(double[] numbers)
        {
            dataGridViewRes_PEA.Rows.Clear();  // Очищаем все строки в таблице

            for (int i = 0; i < numbers.Length; i++)  // Проходим по всем числам в массиве
            {
                dataGridViewRes_PEA.Rows.Add(i + 1, numbers[i]);  // Добавляем новую строку: № и значение
            }

            // Автоподбор ширины колонок
            dataGridViewRes_PEA.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void buttonOpen_PEA_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            openFileDialog.Title = "Выберите файл с данными";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Сохраняем путь в TextBox или переменную
                textBoxFilePath_PEA.Text = openFileDialog.FileName;
            }
        }

        private void buttonInfo_PEA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнила студентка группы ПКТб-25-1 Поздеева Елизавета Александровна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridViewRes_PEA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void formsPlotRes_PEA_Load(object sender, EventArgs e)
        {

        }
    }
}
