using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListTask1
{
    class Program
    {
        static void Main(string[] args)
        {// задача 1
            //Console.WriteLine("Введите количество покупок: ");
            //int N = int.Parse(Console.ReadLine());
            //List<string> listBuy = new List<string>(N);
            //for (int i = 0; i < N; i++)
            //{
            //    listBuy.Add(Console.ReadLine());
            //}
            ////сортировка по алфавиту
            //listBuy.Sort();
            ////вывод списка
            //Console.WriteLine("От А до Я");
            //PrintList(listBuy);
            //listBuy.Reverse();
            //Console.WriteLine("От Я до А");
            //PrintList(listBuy);
            //Console.ReadKey();

            // задача 2
            Console.WriteLine("Введите количество строк: ");
            int K = int.Parse(Console.ReadLine());
            List<string> listSentences = new List<string>(K);
            for (int i = 0; i < K; i++)
            {
                listSentences.Add(Console.ReadLine());
            }
            Console.WriteLine("Введите поисковое слово: ");
            string wordSearch = Console.ReadLine();
            Console.WriteLine("Результаты поиска: ");
            List<string> listFinded = listSentences.FindAll(p => p.Contains(wordSearch));
            if (listFinded.Count > 0)
                PrintList(listFinded);
            else
                Console.WriteLine("По вашему запросу ничего не нашлось");
            Console.ReadKey();
        }

        private static void PrintList(List<string> listBuy)
        {
            foreach (string buy in listBuy)
            {
                Console.WriteLine(buy);
            }
        }
    }
}
