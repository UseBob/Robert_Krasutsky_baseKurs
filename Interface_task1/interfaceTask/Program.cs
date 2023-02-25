using interfaceTask;
using System.Collections.Concurrent;
using System.Diagnostics.Tracing;

List<IMusInstruments> instruments = new List<IMusInstruments>();
string selection;
do
{
    Console.WriteLine("Какой инстурмент вы желаете добавить в библиотеку.\n 1 - Гитара 2 - Барабаны 3 - Пианино");
    selection=Console.ReadLine();
    if (selection =="1")
    {
        instruments.Add(new Guitar());
    }
    else if (selection == "2")
    {
        instruments.Add(new Drums());
    
    }
    else if (selection == "3")
    {
        instruments.Add(new Piano());
    }
    else
    {
        Console.WriteLine("Такого выбора не предусмотрена в программе");
    }
    Console.WriteLine("Желаете добавить ещё инструмент в библиотеку?\n+ если да, что угодно другое - нет");
    selection = Console.ReadLine();
}
while (selection == "+");
Console.WriteLine("Библиотека успешна инициализирована желаете посмотреть список инструментов?\n 1 - Да 2 - нет");
selection = Console.ReadLine();
if (selection == "1")
{
    foreach (var item in instruments)
    {
        Console.WriteLine(item.Name);
    }
}
do
{
    Console.WriteLine("Укажите индекс инструмента, на котором желаете сыграть");
    int.TryParse(Console.ReadLine(), out int index);
    if (index < instruments.Count)
    {
        instruments[index].Play();
    }
    else
    {
        Console.WriteLine("Такого инструмента нет.");
    }
    Console.WriteLine("Желаете сыграть ещё на каком нибудь?\n+ если да, что угодно другое - нет");
    selection=Console.ReadLine();
}
while (selection=="+");


//foreach (var item in instruments)
//{
//    Console.Write(item.Characteristics);
//    Console.WriteLine();
//    item.Play();
//    Console.WriteLine();
//}