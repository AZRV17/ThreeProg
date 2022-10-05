namespace PracticalWork2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int action;

            do
            {
                Console.WriteLine("Выберите программу:\n" +
                    "1. Угадать число\n" + "2. Таблица умножения\n" +
                    "3. Найти делители числа\n" + "4. Выйти\n");
                action = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                switch (action)
                {
                    case 1:
                        Randomiser();
                        break;
                    case 2:
                        MultiplicationTable();
                        break;
                    case 3:
                        AllSeparators();
                        break;
                }
            }while (action != 4);

        }

        static void Randomiser()
        {
            Random rand = new Random();
            int randomNum = rand.Next(0, 100);
            Console.WriteLine("Угадайте число от 0 до 100");
            int num; 

            do
            {
                Console.WriteLine("Введите число\n");
                num = Convert.ToInt32(Console.ReadLine());
                if (num > randomNum)
                {
                    Console.WriteLine("Введите меньшее число\n");
                }
                else if (num < randomNum)
                {
                    Console.WriteLine("Введите большее число\n");
                }
            } while (randomNum != num);
            Console.WriteLine("Поздравляем!\n");
        }

        static void MultiplicationTable()
        {
            int[,] multiplication = new int[10, 10];

            for (int i = 1; i < multiplication.GetLength(0); i++)
            {
                for (int j = 1; j < multiplication.GetLength(1); j++)
                {
                    multiplication[i, j] = i * j;
                    Console.Write($"{multiplication[i, j]}\t|\t");
                }
                Console.WriteLine();
            }
        }

        static void AllSeparators()
        {
            int quit = 0;
            int num;

            do
            {
                Console.WriteLine("Введите число, делители которого хотите найти\n");
                Console.WriteLine("Введите 0, чтобы выйти\n");
                num = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        Console.Write($"{i}\t|\t");
                    }
                }
                Console.WriteLine(num);
            }while (num != quit);
        }
    }
}