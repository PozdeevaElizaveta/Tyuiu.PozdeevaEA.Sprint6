using Tyuiu.PozdeevaEA.Sprint6.Task3.V19.Lib;
namespace Tyuiu.PozdeevaEA.Sprint6.Task3.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[5, 5]{ {4,32,-20,27,21},
                                        {17,15,-1,-2,-1},
                                        {-3,18,12,-10,29}, 
                                        {7,-15,2,-8,12}, 
                                        {-10,25,5,27,21}, };
            int[,] res = ds.Calculate(matrix);
            int[,] wait = new int[5, 5]{ {17,15,-1,-2,-1},
                                        {7,-15,2,-8,12},
                                        {4,32,-20,27,21},
                                        {- 10,25,5,27,21},
                                        {-3,18,12,-10,29}, };
            CollectionAssert.AreEqual(res, wait);
        }
    }
}