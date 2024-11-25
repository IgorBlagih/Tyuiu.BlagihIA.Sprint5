using Tyuiu.BlagihIA.Sprint5.Task0.V7.Lib;
namespace Tyuiu.BlagihIA.Sprint5.Task0.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Работа в С#                                                       *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Благих Игорь Александрович | ИИПб-24-2                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            Console.WriteLine("* Дано выражение, вычислить его значение при x = 4, результат сохранить   *");
            Console.WriteLine("* в текстовый файл OutPutFileTask0.txt и вывести на консоль. Округлить    *");
            Console.WriteLine("* до трёх знаков после запятой.                                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("* X = 4                                                                   *");
            Console.WriteLine("***************************************************************************");

            int x =4 ; 

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(x);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");

            Console.ReadKey();
        }
    }
}
