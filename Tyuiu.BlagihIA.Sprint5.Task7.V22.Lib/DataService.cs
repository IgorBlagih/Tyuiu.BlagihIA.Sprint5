using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.BlagihIA.Sprint5.Task7.V22.Lib
{
    public class DataService : ISprint5Task7V22
    {
        public string LoadDataAndSave(string path)
        {
            string strx = File.ReadAllText(path);
            char item = '#';
            foreach(char c in strx) 

            {
                
                if (c == '!' || c == ',' || c == '.' || c == '?' || c == '-')
                {
                    strx =strx.Replace(c, item);
                }
            }

            return strx;
        }
    }
}

