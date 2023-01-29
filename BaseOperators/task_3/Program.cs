Console.WriteLine("Калькулятор средней арифметической и суммы всех чисел указанного вами диапазона");
Console.WriteLine("Введите первую границу диапазона");
string firstValue = Console.ReadLine();
Console.WriteLine("Введите вторую границу диапазона");
string secondValue = Console.ReadLine();
int resultSum = 0;
int resultArithmeticMean = 0;
int numberCount = 0;
if (int.TryParse(firstValue,out int firstIntValue) && int.TryParse(secondValue, out int secondIntValue))
{
	if (firstIntValue>secondIntValue)
	{
		int temp=firstIntValue;
		firstIntValue=secondIntValue;
		secondIntValue=temp;
    }
	for (int i = firstIntValue; i <= secondIntValue; i++)
	{
		resultSum+= i;
		resultArithmeticMean = (firstIntValue + secondIntValue) / 2; //формула для диапазона последовательных чисел
		numberCount++;
    }

	int resultArithmeticMeanSecondFormula = resultSum / numberCount; // формула при которой значения чисел могут повторяться

    Console.WriteLine($"Сумма чисел выбранного диапазона = {resultSum} \nCреднее арифмитическое = {resultArithmeticMean}");
	Console.WriteLine($"Cреднее арифмитическое по второй формуле = {resultArithmeticMeanSecondFormula}");
}
else
{
    Console.WriteLine("Проверьте корректность данных ");
}