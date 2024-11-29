using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BlagihIA.Sprint5.Task4.V19.Lib
{
    public class DataService : ISprint5Task4V19
    {
        public double LoadFromDataFile(string path)
        {
            path = Path.Combine("C:", "app", "data", "AssesmentData", "C#", "Sprint5Task4", "InPutDataFileTask4V19.txt");

            string strx = File.ReadAllText(path);
            
            double x = Convert.ToDouble(strx);

            double res =Math.Round(Math.Pow( x/Math.Cos(x) , 2) , 3);   
            return res;
                
        }
    }
}
