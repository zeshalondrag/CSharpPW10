namespace Information_system
{
    internal class Program
    {
        static void Main()
        {
            Start("");
        }

        public static void Start(string message)
        {
            Console.Clear();
            if (!(message == "")) Console.WriteLine("   " + message);
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Выберите операцию:\n 1 - Авторизоваться");
            Console.WriteLine("Мне лень было делать меню");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Введите логин: ");
                string login = Console.ReadLine();

                Console.Write("Введите пароль: ");
                string password = "";

                while (true)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);

                    if (key.Key == ConsoleKey.Enter) break;

                    Console.Write("*");

                    password += key.KeyChar;
                }

                Authorization.Start(login, password);
            }
            else
            {
                Start("Неправильно введено значение операции!");
            }
        }
    }
}