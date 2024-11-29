using System.IO;

namespace Tyuiu.BlagihIA.Sprint5.Task4.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = Path.Combine("C:","app","data","AssesmentData","C#","Sprint5Task4", "InPutDataFileTask4V19.txt");

            FileInfo inf = new FileInfo(path);
            bool ex = inf.Exists;
            bool wait = true;

            Assert.AreEqual(wait, ex);

        }
    }
}