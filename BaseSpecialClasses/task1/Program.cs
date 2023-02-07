using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
Console.WriteLine("Укажите какое количесво точек вы желаете создать");
string poinCountStr=Console.ReadLine();
string selectionQuit;
if(int.TryParse(poinCountStr,out int poinCount))
{
    Point[] points= new Point[poinCount];
    for (int i = 0; i < poinCount; i++)
    {
        Console.WriteLine($"Введите координаты для {i+1} точки,при некорректных данных координаты её значение будет равно 0");
        int.TryParse(Console.ReadLine(), out int pointX);
        int.TryParse(Console.ReadLine(), out int pointY);
        Console.WriteLine($"X: {pointX}"); 
        Console.WriteLine($"Y: {pointY}");
        points[i]=new Point(pointX,pointY);
    }
    do
    {
        Console.WriteLine("Теперь выберете между какими точками вы хотите узнать расстояние,если индексы будут выбраны неправильно берётся точка под индексом 0");
        for (int i = 0; i < points.Length; i++)
        {
            Console.WriteLine($"{i}: X:{points[i].X} Y:{points[i].Y} ");
        }
        int.TryParse(Console.ReadLine(), out int selectionPoint1);
        int.TryParse(Console.ReadLine(), out int selectionPoint2);
        if (selectionPoint1 < poinCount && selectionPoint2 < poinCount)
        {
            Console.WriteLine("Расстояние между точками: "+ Point.LengthPoints(points[selectionPoint1], points[selectionPoint2])); 
        }
        else
        {
            Console.WriteLine("Точек под таким индексом не существует");
        }
        Console.WriteLine("Желаете ещё узнать расстояние между парами точек? Y-да, любая другая клавиша- выход");
        selectionQuit = Console.ReadLine();
    } while (selectionQuit=="Y" || selectionQuit=="y");
   
}
else
{
    Console.WriteLine("Попробуйте ввести число ещё раз");
}

class Point
{
    int x;
    int y;
    public int X { get=>x;}
    public int Y { get => y; }
    public static int pointCount = 0;
    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
        pointCount++;
    }
    public static double LengthPoints(Point point1,Point point2)
    {
        int deltaX=Math.Abs(point1.x - point2.x);
        int deltaY= Math.Abs(point1.y - point2.y);
        double length = Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY,2)); 
        return length;
    }

}


