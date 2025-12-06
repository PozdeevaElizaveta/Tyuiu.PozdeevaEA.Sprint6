using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.PozdeevaEA.Sprint6.Task4.V20.Lib
{
    public class DataService : ISprint6Task4V20
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
                if (3*x - 1 == 0)
                {
                    value[count] = 0.0;
                    count++;
                }
                else
                {
                    y = Math.Round(((Math.Sin(x)-2 * x)/(3 * x - 1) + Math.Sin(x) - 3 * x + 2), 2);
                    value[count] = y;
                    count++;
                }

            }
            return value;
        }
    }
}
