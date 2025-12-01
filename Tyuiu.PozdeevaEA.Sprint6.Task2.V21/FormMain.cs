using ScottPlot;
using System.Windows.Forms.VisualStyles;
using Tyuiu.PozdeevaEA.Sprint6.Task2.V21.Lib;
namespace Tyuiu.PozdeevaEA.Sprint6.Task2.V21
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void buttonDone_PEA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxValuestart_PEA.Text);
                int stopStep = Convert.ToInt32(textBoxValuestop_PEA.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                dataGridView_PEA.Rows.Clear(); // Очищаем старые данные

                for (int i = 0; i < len; i++)
                {
                    int currentX = startStep + i;
                    dataGridView_PEA.Rows.Add(
                        Convert.ToString(currentX),
                        Convert.ToString(valueArray[i])
                    );
                }

                // 4. Строим график в formsPlot_PEA (ScottPlot)
                PlotGraph(startStep, stopStep, valueArray);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Метод для построения графика
        private void PlotGraph(int startValue, int stopValue, double[] yValues)
        {
            formsPlot_PEA.Plot.Clear();

            int len = yValues.Length;

            // Создаем массив X значений
            double[] xValues = new double[len];
            for (int i = 0; i < len; i++)
            {
                xValues[i] = startValue + i;
            }

            // Добавляем график
            var scatter = formsPlot_PEA.Plot.AddScatter(xValues, yValues);
            scatter.LineWidth = 2;
            scatter.MarkerSize = 5;
            scatter.Color = System.Drawing.Color.Blue;

            // Настройки графика
            formsPlot_PEA.Plot.Title("График функции f(x)");
            formsPlot_PEA.Plot.XLabel("X");
            formsPlot_PEA.Plot.YLabel("F(x)");
            formsPlot_PEA.Plot.Grid(enable: true);

            // Автомасштабирование
            formsPlot_PEA.Plot.AxisAuto();

            // Обновляем отображение
            formsPlot_PEA.Refresh();
        }

        private void formsPlot_PEA_Load(object sender, EventArgs e)
        {

        }

        private void buttonHelp_PEA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнила студентка группы ПКТб-25-1 Поздеева Елизавета Александровна", "Сообщение",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBoxTask_PEA_TextChanged(object sender, EventArgs e) { }
        private void pictureBoxFormula_PEA_Click(object sender, EventArgs e) { }
        private void groupBoxValue_PEA_Enter(object sender, EventArgs e) { }
        private void groupBoxTask_PEA_Enter(object sender, EventArgs e) { }
        private void FormMain_Load(object sender, EventArgs e) { }
        private void textBoxResult_PEA_TextChanged(object sender, EventArgs e) { }
        private void textBoxValuestop_PEA_TextChanged(object sender, EventArgs e) { }

        private void dataGridView_PEA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

