using System;

namespace PZ5
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                Hamburger[] Burgers = new Hamburger[5];
                int size, topping;
                ConsoleKeyInfo cki;
                for (int i = 0; i < Burgers.Length; i++)
                {
                    Console.WriteLine("Выберите размер бургера \n1 - Маленький (100 р.) \n2 - Большой (200 р.)");
                    size = int.Parse(Console.ReadLine());
                    switch (size)
                    {
                        case 1:
                            Burgers[i] = new SmallHamburger();
                            break;

                        case 2:
                            Burgers[i] = new BigHamburger();
                            break;

                        default:
                            throw new ArgumentException("Ошибка! Такого бургера не существует");
                    }
                    Console.WriteLine("Выберите добавку бургера \n0 - Пусто \n1 - Сыр (25 р.) \n2 - Лук (53 р.)");
                    topping = int.Parse(Console.ReadLine());

                    switch (topping)
                    {
                        case 0:
                            break;

                        case 1:
                            Burgers[i] = new CheeseHamburger(Burgers[i]);
                            break;

                        case 2:
                            Burgers[i] = new OnionHamburger(Burgers[i]);
                            break;

                        default:
                            throw new ArgumentException("Ошибка! Такого топинга не существует");
                    }
                    Console.WriteLine("Добавить новый бургер? [Y/N]");
                    cki = Console.ReadKey(true);
                    if (cki.Key != ConsoleKey.Y)
                    {
                        break;
                    }
                }
                foreach (Hamburger Burger in Burgers)
                {
                    if (Burger != null)
                    {
                        Console.WriteLine(Burger.Name);
                        Console.WriteLine(Burger.GetPrice());
                        Console.WriteLine("___________________________");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}