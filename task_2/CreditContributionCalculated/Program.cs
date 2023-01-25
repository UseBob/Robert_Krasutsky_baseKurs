void ContributionCalculated()
{
    Console.WriteLine("Введите сумму вклада");
    decimal contributionSumm = Convert.ToDecimal(Console.ReadLine());
    Console.WriteLine("Введите расчётное кол-во месяцев по вкладу");
    int monthCount = Convert.ToInt32(Console.ReadLine());
    if (contributionSumm > 0 && monthCount > 0)
    {
        for (int i = 0; i < monthCount; i++)
        {
            contributionSumm *= 1.07M;
        }
    }
    else
    {
        Console.WriteLine("Проверьте введенные вами данные");
    }
    Console.WriteLine($"Расчитаная сумма по вкладу за период {monthCount} месяцев равна {contributionSumm}");
}
ContributionCalculated();