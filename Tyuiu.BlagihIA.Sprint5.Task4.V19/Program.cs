using System.IO;
using Tyuiu.BlagihIA.Sprint5.Task4.V19.Lib;
namespace Tyuiu.BlagihIA.Sprint5.Task4.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Работа в С#                                                       *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнил: Благих Игорь Александрович | ИИПб-24-2                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл С:DataSprint5InPutDataFileTask4V0.txt (файл взять из архива*");
            Console.WriteLine("* согласно вашему варианту. Создать папку в ручную С:DataSprint5 и    *");
            Console.WriteLine("* скопировать в неё файл) в котором есть вещественное значение. Прочитать *");
            Console.WriteLine("* значение из файла и подставить вместо Х в формуле Вычислить значение по *");
            Console.WriteLine("* формуле и вернуть полученный результат на консоль.                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

           string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask4V19.txt");


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine("Ответ " + res);



            Console.ReadKey();
        }
    }
}
