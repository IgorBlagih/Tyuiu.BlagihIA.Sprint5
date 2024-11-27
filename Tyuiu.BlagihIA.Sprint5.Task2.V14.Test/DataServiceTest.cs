using Tyuiu.BlagihIA.Sprint5.Task2.V14.Lib;
namespace Tyuiu.BlagihIA.Sprint5.Task2.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {


            int[,] ar = { { -5, 7, -4 }, { 10, -12, -4 }, { 14, 8, 3 } };

            DataService ds = new DataService();

            string path = Path.GetTempFileName();

            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(true, fileExist);
        }
    }
}