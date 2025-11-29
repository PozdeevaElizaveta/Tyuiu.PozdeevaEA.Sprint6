using Tyuiu.PozdeevaEA.Sprint6.Task0.V21.Lib;
namespace Tyuiu.PozdeevaEA.Sprint6.Task0.V21
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDone_PEA_Click(object sender, EventArgs e)
        {
            try
            {
                // Проверка и преобразование введенного x
                int x = int.Parse(textBoxValueX_PEA.Text);

                DataService ds = new DataService();
                double result = ds.Calculate(x);

                textBoxResult_PEA.Text = result.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка! Введите число в поле X.", "Ошибка ввода",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_PEA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнила студентка группы ИСПб-23-1 Поздеева Екатерина Александровна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBoxTask_PEA_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxFormula_PEA_Click(object sender, EventArgs e)
        {

        }
    }
}
