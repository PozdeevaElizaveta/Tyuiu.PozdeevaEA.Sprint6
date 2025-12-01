using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.PozdeevaEA.Sprint6.Task2.V21.Lib
{
    public class DataService : ISprint6Task2V21
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;

            double[] value;
            value = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x + 2 == 0)
                {
                    value[count] = 0.0;
                    count++;
                }
                else
                {
                    y = Math.Round((Math.Cos(x) + (Math.Cos(x) / (x + 2)) - 3 * x), 2);
                    value[count] = y;
                    count++;
                }
                   
            }
            return value;
        }
    }
}
