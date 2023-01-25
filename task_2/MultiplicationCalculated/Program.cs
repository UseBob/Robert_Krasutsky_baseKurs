void MultiplicationCalculated()
{
    while (true) 
    {
        Console.WriteLine("Введите первое число которое лежит в диапазоне от 0 до 10 включительно");
        double firsValue = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите второе число которое лежит в диапазоне от 0 до 10 включительно");
        double secondValue = Convert.ToDouble(Console.ReadLine());
        if (firsValue >= 0 && firsValue <= 10 && secondValue >= 0 && secondValue <= 10)
        {
            Console.WriteLine($"Произведение ваших чисел = {firsValue * secondValue}");
            return;
        }
        else
        {
            Console.WriteLine($"Введеные числа не соответствуют запросу.Прочтите условие ввода внимательнее и попытайтесь ещё раз :)");
        }
    }
}
MultiplicationCalculated();