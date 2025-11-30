using Tyuiu.PozdeevaEA.Sprint6.Task1.V14.Lib;
namespace Tyuiu.PozdeevaEA.Sprint6.Task1.V14
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
                // Проверка и преобразование введенных данных
                int startValue = int.Parse(textBoxValuestart_PEA.Text);
                int stopValue = int.Parse(textBoxValuestop_PEA.Text);

                string strLine;

                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] valueArray = new double[len];

                valueArray = ds.GetMassFunction(startValue, stopValue);

                textBoxResult_PEA.Text = "";
                textBoxResult_PEA.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult_PEA.AppendText("|    X     |   f(x)   |" + Environment.NewLine);
                textBoxResult_PEA.AppendText("+----------+----------+" + Environment.NewLine);

                for (int i = 0; i < len; i++)
                {
                    strLine = String.Format("|{0,6:d}    |  {1, 6:f2}  | ", startValue, valueArray[i]);
                    textBoxResult_PEA.AppendText(strLine + Environment.NewLine);
                    startValue++;
                }
                textBoxResult_PEA.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка ввода",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonHelp_PEA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнила студентка группы ПКТб-25-1 Поздеева Елизавета Александровна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBoxTask_PEA_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxFormula_PEA_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxValue_PEA_Enter(object sender, EventArgs e)
        {

        }
    }
}
