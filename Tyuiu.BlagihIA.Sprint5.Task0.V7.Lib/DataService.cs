using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.BlagihIA.Sprint5.Task0.V7.Lib
{
    public class DataService : ISprint5Task0V7
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.GetTempFileName();
            x = 4;
            double res = Math.Pow(x,3) + 4 * Math.Pow(x,2) - (3/2 *x);
            res = Math.Round(res);
            File.AppendAllText(path, x.ToString());
            return path;

        }
    }
}
