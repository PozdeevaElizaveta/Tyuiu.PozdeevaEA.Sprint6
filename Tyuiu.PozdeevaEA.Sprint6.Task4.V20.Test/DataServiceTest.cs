using Tyuiu.PozdeevaEA.Sprint6.Task4.V20.Lib;
namespace Tyuiu.PozdeevaEA.Sprint6.Task4.V20.Test
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
            valueWait[0] = 17.27;
            valueWait[1] = 14.08;
            valueWait[2] = 10.27;
            valueWait[3] = 6.65;
            valueWait[4] = 3.87;
            valueWait[5] = 2.00;
            valueWait[6] = -0.74;
            valueWait[7] = -3.71;
            valueWait[8] = -7.59;
            valueWait[9] = -11.55;
            valueWait[10] = -14.74;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(res, valueWait);
        }
    }
}
