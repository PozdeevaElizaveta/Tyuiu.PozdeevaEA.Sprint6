using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.PozdeevaEA.Sprint6.Task3.V19.Lib
{
    public class DataService : ISprint6Task3V19
    {
        public int[,] Calculate(int[,] matrix)
        {
            // Копируем исходный массив
            int[,] result = (int[,])matrix.Clone();

            // Создаем массив значений 5-го столбца
            int[] fifthColumn = new int[5];
            for (int i = 0; i < 5; i++)
            {
                fifthColumn[i] = matrix[i, 4];
            }

            // Сортируем значения 5-го столбца
            Array.Sort(fifthColumn);

            // Заменяем только 5-й столбец отсортированными значениями
            for (int i = 0; i < 5; i++)
            {
                result[i, 4] = fifthColumn[i];
            }

            return result;
        }
    }
}
