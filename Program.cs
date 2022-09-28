Console.WriteLine("Выберите программу, которую вы хотите запустить: \r\n1.Угадай число\r\n2.Таблица умножения\r\n3.Выйти из программы");
int a = Convert.ToInt32(Console.ReadLine());
while (a != 3)
{
    switch (a)
    {
        case 1:
            GuessNumber();
            break;


        case 2:
            MultiplicationTable();
            break;
    }
    Console.WriteLine("Выберите программу, которую вы хотите запустить: \r\n1.Угадай число\r\n2.Таблица умножения\r\n3.Выйти из программы");
    a = Convert.ToInt32(Console.ReadLine());
}


static void GuessNumber()
{
    Console.WriteLine("Угадай число от 0 до 100");
    int b = 1;
    Random rand = new Random();
    int chislo = rand.Next(100);
    int GuessNumber = Convert.ToInt32(Console.ReadLine());
    while (GuessNumber != chislo)
    {
        if (GuessNumber < chislo)
        {
            Console.WriteLine("Надо больше");
        }
        else
        {
            Console.WriteLine("Надо меньше");
        }

        {
            b++;
            Console.WriteLine("Нет, это не число " + GuessNumber + "! Попытка № " + b + ":");
            GuessNumber = Convert.ToInt32(Console.ReadLine());
        }
    }

    if (GuessNumber == chislo)
    {
        Console.WriteLine("Угадал, красаучик!");

    }
    Console.WriteLine();
}
static void MultiplicationTable()
{
    int x = 2;
    Console.WriteLine();


    int i;
    int Multiplication;
    for (i = 1; i <= 9; i++)
    {
        Console.WriteLine("\t");
        for (Multiplication = 1; Multiplication <= 9; Multiplication++)
        {
            Console.Write("\t" + i * Multiplication);
        }
    }
    Console.WriteLine();
}
