using Tyuiu.PozdeevaEA.Sprint6.Task6.V22.Lib;
namespace Tyuiu.PozdeevaEA.Sprint6.Task6.V22
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        string openFilePath;
        DataService ds = new DataService();

        private void buttonOpenFile_PEA_Click(object sender, EventArgs e)
        {
            // Открываем диалог выбора файла
            if (openFileDialogTask_PEA.ShowDialog() == DialogResult.OK)
            {
                openFilePath = openFileDialogTask_PEA.FileName;

                // Считываем содержимое файла и отображаем в textBoxInput_PEA
                textBoxInput_PEA.Text = File.ReadAllText(openFilePath);

                // Очищаем textBoxResult_PEA
                textBoxResult_PEA.Clear();
            }
        }

        private void buttonDone_PEA_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(openFilePath) && File.Exists(openFilePath))
            {
                // Получаем результат из CollectTextFromFile
                string result = ds.CollectTextFromFile(openFilePath);

                // Выводим первые слова в textBoxResult_PEA
                textBoxResult_PEA.Text = result;
            }
            else
            {
                MessageBox.Show("Файл не выбран или путь недействителен.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_PEA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 6 выполнила студентка группы ПКТб-25-1 Поздеева Елизавета Александровна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
