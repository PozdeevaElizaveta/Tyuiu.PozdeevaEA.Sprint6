using ScottPlot;
using Tyuiu.PozdeevaEA.Sprint6.Task4.V20.Lib;
namespace Tyuiu.PozdeevaEA.Sprint6.Task4.V20
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void PlotGraph(int startValue, int stopValue, double[] yValues)
        {
            formsPlotRes_PEA.Plot.Clear();

            int len = yValues.Length;

            // Создаем массив X значений
            double[] xValues = new double[len];
            for (int i = 0; i < len; i++)
            {
                xValues[i] = startValue + i;
            }

            // Добавляем график
            var scatter = formsPlotRes_PEA.Plot.AddScatter(xValues, yValues);
            scatter.LineWidth = 2;
            scatter.MarkerSize = 5;
            scatter.Color = System.Drawing.Color.Blue;

            // Настройки графика
            formsPlotRes_PEA.Plot.Title("График функции f(x)");
            formsPlotRes_PEA.Plot.XLabel("X");
            formsPlotRes_PEA.Plot.YLabel("F(x)");
            formsPlotRes_PEA.Plot.Grid(enable: true);

            // Автомасштабирование
            formsPlotRes_PEA.Plot.AxisAuto();

            // Обновляем отображение
            formsPlotRes_PEA.Refresh();
        }

        private void formsPlotRes_PEA_Load(object sender, EventArgs e)
        {

        }

        private void buttonInfo_PEA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнила студентка группы ПКТб-25-1 Поздеева Елизавета Александровна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBoxValueStart_PEA_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDo_PEA_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxValueStart_PEA.Text);
                int stopValue = Convert.ToInt32(textBoxValueStop_PEA.Text);

                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] value = new double[len];

                value = ds.GetMassFunction(startValue, stopValue);

                textBoxRes_PEA.Clear();
                for (int i = 0; i < len; i++)
                {
                    textBoxRes_PEA.AppendText($"{value[i]}" + Environment.NewLine);
                }
                PlotGraph(startValue, stopValue, value);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonSave_PEA_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Path.GetTempFileName();
                File.WriteAllText(path, textBoxRes_PEA.Text);
                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранен успешно!\nОткрыть его?","Сохранение",
                MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch 
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
