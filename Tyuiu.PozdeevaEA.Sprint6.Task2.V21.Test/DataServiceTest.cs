using Tyuiu.PozdeevaEA.Sprint6.Task2.V21.Lib;
namespace Tyuiu.PozdeevaEA.Sprint6.Task2.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            int len = stopValue - startValue + 1;

            double[] valueWait;
            valueWait = new double[len];
            valueWait[0] = 15.19;
            valueWait[1] = 11.67;
            valueWait[2] = 9.00;
            valueWait[3] = 0.00;
            valueWait[4] = 4.08;
            valueWait[5] = 1.50;
            valueWait[6] = -2.28;
            valueWait[7] = -6.52;
            valueWait[8] = -10.19;
            valueWait[9] = -12.76;
            valueWait[10] = -14.68;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(res, valueWait);
        }
    }
}
