using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.PozdeevaEA.Sprint6.Task5.V3.Lib
{
    public class DataService : ISprint6Task5V3
    {
        public double[] LoadFromDataFile(string path)
        {
            List<double> values = new List<double>();

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (string.IsNullOrWhiteSpace(line))
                        continue;

                    string[] numbers = line.Split(new char[] { ' ', '\t', ',', ';' },
                                                 StringSplitOptions.RemoveEmptyEntries);

                    foreach (string numberStr in numbers)
                    {
                        // Проверяем, является ли число вещественным (содержит точку или запятую)
                        bool isRealNumber = numberStr.Contains('.') || numberStr.Contains(',');

                        if (double.TryParse(numberStr.Replace(',', '.'),
                                           NumberStyles.Any,
                                           CultureInfo.InvariantCulture,
                                           out double number))
                        {
                            // Если нужно ТОЛЬКО вещественные числа
                            if (isRealNumber)
                            {
                                // Округляем до 3 знаков после запятой
                                values.Add(Math.Round(number, 3));
                            }
                           
                        }
                    }
                }
            }
            return values.ToArray();
        }
    }
}
