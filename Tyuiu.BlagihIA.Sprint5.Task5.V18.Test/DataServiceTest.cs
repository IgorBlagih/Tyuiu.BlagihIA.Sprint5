using Tyuiu.BlagihIA.Sprint5.Task5.V18.Lib;
namespace Tyuiu.BlagihIA.Sprint5.Task5.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask5V18.txt");

            FileInfo inf = new FileInfo(path);
            bool ex = inf.Exists;
            bool wait = true;

            Assert.AreEqual(wait, ex);
        }
    }
}