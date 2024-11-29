using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.BlagihIA.Sprint5.Task5.V18.Lib
{
    public class DataService : ISprint5Task5V18
    {
        public double LoadFromDataFile(string path)
        {
            double res = 1;
            string strx = File.ReadAllText(path);
            strx = strx.Replace(".", ",");
            string[] lines = strx.Split(" ");
            foreach (string str in lines)
            {
                double x = Math.Round(Convert.ToDouble(str), 3);

                res = res * x;
            }
            


            return res;


        }
    }
}
