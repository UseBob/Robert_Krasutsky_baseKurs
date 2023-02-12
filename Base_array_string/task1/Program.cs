int[] myarray = new int[6];
string fronter = new string('-', 30);
for (int i = 0;i<myarray.Length;i++)
{
    Console.WriteLine($"Введите число для индекса {i}");
    int.TryParse(Console.ReadLine(), out int arraynumber);
    myarray[i] = arraynumber;
}
Array.Sort(myarray);
Array.Reverse(myarray);
Console.WriteLine(fronter);
for (int i = 0; i < myarray.Length; i++)
{
    Console.WriteLine(myarray[i]);
}
Console.WriteLine(fronter);
foreach (var item in myarray)
{
    Console.WriteLine(item);
}
Console.WriteLine(fronter);
for (int i = myarray.Length-1; myarray.Length-3 <= i; i--)
{
    Console.WriteLine(myarray[i]);
}
Console.WriteLine(fronter);
for (int i = 0; i < myarray.Length; i++)
{
    if (myarray[i] % 2 == 0 && myarray[i] > 5)
    {
        Console.WriteLine(myarray[i]);
    }
}
