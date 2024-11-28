using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BlagihIA.Sprint5.Task3.V30.Lib
{
    public class DataService : ISprint5Task3V30
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.GetTempFileName();

            FileInfo fileinfo = new FileInfo(path);
            bool filexists = fileinfo.Exists;
            
            if(filexists)
            {
                File.Delete(path);
            }

            double res = Math.Round(((Math.Pow(Convert.ToDouble(x) ,3) - 1) / (4 * x ^ 2)), 3);

            using(BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
            {
                writer.Write(BitConverter.GetBytes(res));
            }
            return path;
        }
    }
}
