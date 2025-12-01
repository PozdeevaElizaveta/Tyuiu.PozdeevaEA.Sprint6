using Tyuiu.PozdeevaEA.Sprint6.Task3.V19.Lib;
namespace Tyuiu.PozdeevaEA.Sprint6.Task3.V19
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        int[,] matrix = new int[5, 5]{ {4,32,-20,27,21},
                                   {17,15,-1,-2,-1},
                                   {-3,18,12,-10,29},
                                   {7,-15,2,-8,12},
                                   {-10,25,5,27,21} };

        private void FormMain_Load(object sender, EventArgs e)
        {
            // Показываем исходную матрицу
            DisplayMatrix(dataGridViewTask_PEA, matrix);
        }

        private void buttonRes_PEA_Click(object sender, EventArgs e)
        {
            // Показываем отсортированную матрицу
            int[,] sortedMatrix = ds.Calculate((int[,])matrix.Clone());
            DisplayMatrix(dataGridViewRes_PEA, sortedMatrix);
        }

        private void DisplayMatrix(DataGridView dgv, int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            dgv.ColumnCount = columns;
            dgv.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dgv.Columns[i].Width = 50;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dgv.Rows[i].Cells[j].Value = matrix[i, j].ToString();
                }
            }
        }

        private void buttonHelp_PEA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнила студентка ПКТб-25-1 Поздеева Елизавета Александровна", "Сообщение",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Остальные методы
        private void dataGridView_PEA_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void textBox_PEA_TextChanged(object sender, EventArgs e) { }
        private void dataGridViewRes_PEA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
