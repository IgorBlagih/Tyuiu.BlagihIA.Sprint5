using Tyuiu.BlagihIA.Sprint5.Task0.V7.Lib;
namespace Tyuiu.BlagihIA.Sprint5.Task0.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = Path.Combine(Convert.ToString(Path.GetTempPath()), "OutPutFileTask0.txt");


            FileInfo fileInfo = new FileInfo(path);  
            bool fileExist= fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(true, fileExist);

        } 
    }
}