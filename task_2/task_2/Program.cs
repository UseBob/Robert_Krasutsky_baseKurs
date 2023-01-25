 void HypotenuseCalculated()
{
    Console.WriteLine("Введите первый размер катета");
    double firsCathetus=Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите второй катет");
    double secondCathetus = Convert.ToDouble(Console.ReadLine());
    double hypotenuse = Math.Sqrt(Math.Pow(firsCathetus,2)+Math.Pow(secondCathetus,2));
    Console.WriteLine($"Гипотенуза в вашем прямоугольном треугольнике будет равна {hypotenuse}");
}
HypotenuseCalculated();