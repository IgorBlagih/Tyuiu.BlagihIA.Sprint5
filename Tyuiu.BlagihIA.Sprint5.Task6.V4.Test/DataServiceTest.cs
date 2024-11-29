using Tyuiu.BlagihIA.Sprint5.Task6.V4.Lib;
using System.IO;
namespace Tyuiu.BlagihIA.Sprint5.Task6.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask6V4.txt");
            DataService ds = new DataService();
            
            int wait = 0;
            int res = ds.LoadFromDataFile(path);

            Assert.AreEqual(wait, res);
        }
        
        
        
        
        [TestMethod]
        public void TestMethod2()
        {
            string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask4V19.txt");

            FileInfo inf = new FileInfo(path);
            bool ex = inf.Exists;
            bool wait = true;

            Assert.AreEqual(wait, ex);
        }
    }
}