using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.BlagihIA.Sprint5.Task5.V18.Lib
{
    public class DataService : ISprint5Task5V18
    {
        public double LoadFromDataFile(string path)
        {
            double res = 1;
            using(StreamReader reader = new StreamReader(path))
            {
                string line ;
                while ((line= reader.ReadLine()) != null)
                {
                    res = res * Math.Round(Convert.ToDouble(line),3);
                }
            }
            return res;
        }
    }
}
