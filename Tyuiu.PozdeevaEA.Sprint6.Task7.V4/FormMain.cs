using Tyuiu.PozdeevaEA.Sprint6.Task7.V4.Lib;
namespace Tyuiu.PozdeevaEA.Sprint6.Task7.V4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        static string openFilePath;
        static int rows;
        static int columns;
        private int[,] modifiedMatrix;

        DataService dataService = new DataService();

        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);

            fileData = fileData.Replace("\n", "\r");
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }

        private void buttonDone_PEA_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = dataService.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOutMatrix_PEA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            buttonSave_PEA.Enabled = true;
        }

        private void buttonHelp_PEA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 7 выполнила студентка группы ПКТб-25-1 Поздеева Елизавета Александровна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonOpenFile_PEA_Click(object sender, EventArgs e)
        {
            if (openFileDialogTask_PEA.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialogTask_PEA.FileName;

                modifiedMatrix = dataService.GetMatrix(filePath);

                int rows = modifiedMatrix.GetLength(0);
                int columns = modifiedMatrix.GetLength(1);

                dataGridViewInMatrix_PEA.ColumnCount = columns;
                dataGridViewInMatrix_PEA.RowCount = rows;
                dataGridViewOutMatrix_PEA.ColumnCount = columns;
                dataGridViewOutMatrix_PEA.RowCount = rows;

                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < columns; c++)
                    {
                        dataGridViewInMatrix_PEA.Rows[r].Cells[c].Value = modifiedMatrix[r, c];
                        dataGridViewOutMatrix_PEA.Rows[r].Cells[c].Value = modifiedMatrix[r, c];
                    }
                }

                buttonSave_PEA.Enabled = true;
            }
        }

        private void buttonSave_PEA_Click(object sender, EventArgs e)
        {
            if (saveFileDialogMatrix.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialogMatrix.FileName;

                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    int rows = modifiedMatrix.GetLength(0);
                    int columns = modifiedMatrix.GetLength(1);

                    for (int r = 0; r < rows; r++)
                    {
                        for (int c = 0; c < columns; c++)
                        {
                            writer.Write(modifiedMatrix[r, c]);
                            if (c < columns - 1)
                            {
                                writer.Write(";");
                            }
                        }
                        writer.WriteLine();
                    }
                }
            }
        }

        private void buttonOpenFile_PEA_MouseEnter(object sender, EventArgs e)
        {
            toolTip_PEA.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_PEA_MouseEnter(object sender, EventArgs e)
        {
            toolTip_PEA.ToolTipTitle = "Выполнить";
        }

        private void buttonSave_PEA_MouseEnter(object sender, EventArgs e)
        {
            toolTip_PEA.ToolTipTitle = "Сохранить в файл";
        }

        private void buttonHelp_PEA_MouseEnter(object sender, EventArgs e)
        {
            toolTip_PEA.ToolTipTitle = "Справка";
        }

        private void textBoxTask_PEA_TextChanged(object sender, EventArgs e)
        {
            // Пустой обработчик
        }
    }
}
