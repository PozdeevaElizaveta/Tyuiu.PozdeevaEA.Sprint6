using Tyuiu.PozdeevaEA.Sprint6.Task1.V14.Lib;
namespace Tyuiu.PozdeevaEA.Sprint6.Task1.V14.Test
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
            valueWait[0] = -2.15;
            valueWait[1] = -2.57;
            valueWait[2] = -3.00;
            valueWait[3] = -3.83;
            valueWait[4] = -11.70;
            valueWait[5] = 3.00;
            valueWait[6] = 2.19;
            valueWait[7] = 3.31;
            valueWait[8] = 2.97;
            valueWait[9] = 1.18;
            valueWait[10] = 0.03;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(res, valueWait);

        }
    }
}
