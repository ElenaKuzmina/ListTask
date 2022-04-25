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
            //Console.WriteLine("Введите количество строк: ");
            //int K = int.Parse(Console.ReadLine());
            //List<string> listSentences = new List<string>(K);
            //for (int i = 0; i < K; i++)
            //{
            //    listSentences.Add(Console.ReadLine());
            //}
            //Console.WriteLine("Введите поисковое слово: ");
            //string wordSearch = Console.ReadLine();
            //Console.WriteLine("Результаты поиска: ");
            //List<string> listFinded = listSentences.FindAll(p => p.Contains(wordSearch));
            //if (listFinded.Count > 0)
            //    PrintList(listFinded);
            //else
            //    Console.WriteLine("По вашему запросу ничего не нашлось");
            //Console.ReadKey();
            //задача 3
            //Console.WriteLine("Введите количество строк: ");
            //int M = int.Parse(Console.ReadLine());
            //List<string> listStrings = new List<string>(M);
            //for (int i = 0; i < M; i++)
            //{
            //    listStrings.Add(Console.ReadLine());
            //}
            //Console.WriteLine("Введите номер символа: ");
            //int numberSimbol = int.Parse(Console.ReadLine());
            //string abbreviature = "";
            //foreach(string line in listStrings)
            //{
            //    if (line.Length >= numberSimbol)
            //        abbreviature += line[numberSimbol - 1];
            //    else
            //        abbreviature += '_';
            //}
            //Console.WriteLine($"Полученное слово: {abbreviature}");
            //Console.ReadKey();
            //задача 5
            Console.WriteLine("Введите количество клиентов банка: ");
            int N = int.Parse(Console.ReadLine());
            List<int> listClients = new List<int>(N);
            for (int i = 0; i < N; i++)
            {
                listClients.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("Исходные вложения");
            PrintList(listClients);
            Console.WriteLine(listClients.Sum()); //сумма
            Console.WriteLine(listClients.Average()); //среднее ариф
            Console.WriteLine(listClients.Min()); // минимум
            Console.WriteLine(listClients.Max()); //максимум
            Console.WriteLine("Накопления через год");
            foreach(int client in listClients)
            {
                Console.WriteLine(client * 3);
            }
            Console.ReadKey();
        }

        private static void PrintList(List<string> list)
        {
            foreach (string buy in list)
            {
                Console.WriteLine(buy);
            }
        }
        private static void PrintList(List<int> list)
        {
            foreach (int buy in list)
            {
                Console.WriteLine(buy);
            }
        }
    }
}
