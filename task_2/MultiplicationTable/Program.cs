void MultiplicationTable()
{
    Console.WriteLine(" Таблица умножения целых чисел");
    Console.WriteLine("Введите число до которого неоходимо строить таблицу умножения");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    for (int i = 1; i <= maxValue; i++)
    {
        for (int j = 1; j <= maxValue; j++)
        {
            Console.Write($"{i * j} \t");
        }
        Console.WriteLine(string.Empty + "\n");
    }
}
MultiplicationTable();
