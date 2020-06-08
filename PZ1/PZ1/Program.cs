using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PZ1
{
    class Program
    {
        /// <summary>
        /// Функция для подсчета различных вариантов размена.
        /// </summary>
        /// <param name="Coins">Массив номиналов монет/купюр</param>
        /// <param name="curCoin">Количество разных номиналов</param>
        /// <param name="Cash">Количество рублей, необходимое для размена</param>
        /// <returns>Рекурсивная зависимость</returns>
        static int getCoinChange(int[] Coins, int curCoin, int Cash)
        {
            

            if (Cash == 0)
                return 1;            

            if (curCoin <= 0 && Cash >= 1)
                return 0;

            return getCoinChange(Coins, curCoin - 1, Cash) + getCoinChange(Coins, curCoin, Cash - Coins[curCoin - 1]);
        }

        /// <summary>
        /// Функция для записи в файл.
        /// </summary>
        /// <param name="FileName">Название файла для записи</param>
        /// <param name="myStr">Строка для записи в файл</param>
        static void writeToFile(string FileName, string myStr)
        {
            File.WriteAllText(FileName, string.Empty);
            using (FileStream fstream = new FileStream(FileName, FileMode.OpenOrCreate))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(myStr);
                fstream.Write(array, 0, array.Length);
            }
        }

        /// <summary>
        /// Функция для проверки на отрицательность
        /// </summary>
        /// <param name="Cash">Количество рублей</param>
        /// <returns>Возвращает true или false в зависимости от допустимости</returns>
        static bool checkNeg(int Cash)
        {
            if (Cash < 0)
                return false;
            else return true;
        }

        /// <summary>
        /// Функция для чтения из файла.
        /// </summary>
        /// <param name="FileName">Название файла для чтения</param>
        /// <returns>Возвращает строку из файла</returns>if (Cash < 0)
                
        static string readFromFile(string FileName)
        {
            using (FileStream fstream = File.OpenRead(FileName))
            {
                byte[] array = new byte[fstream.Length];
                fstream.Read(array, 0, array.Length);
                string textFromFile = System.Text.Encoding.Default.GetString(array);
                return textFromFile;
            }
        }

        public static void Main()
        {
            try
            {
                int[] intCoins = { 1, 5, 10, 50, 100};
            int intCoinsCount = intCoins.Length;

            writeToFile("input.txt", "5000");

            int intCash;
            intCash = int.Parse(readFromFile("input.txt"));
                if (checkNeg(intCash))
                    throw new ArgumentOutOfRangeException("Cash", "Рубли не могут быть меньше нуля");
                else {
                    writeToFile("output.txt", getCoinChange(intCoins, intCoinsCount, intCash) + "");
                    Console.WriteLine("Сдачу в {0} рублей можно выдать {1} различными способами", readFromFile("input.txt"), readFromFile("output.txt"));
                }
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);

            }
            catch (FormatException)
            {
                Console.WriteLine("Неверно указано число рублей");
            }
            catch (Exception e)
            {
                Console.WriteLine("Возникла ошибка " + e.GetType() + ":");
                Console.WriteLine(e.Message);
            }
        }
    }
}
