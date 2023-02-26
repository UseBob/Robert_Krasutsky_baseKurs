using task2;
Console.WriteLine("Укажите какое количество литературы у вас имеется");
int.TryParse(Console.ReadLine(), out int arrayLength);
IPrintable[] printable=new IPrintable[arrayLength];
if ( printable.Length!=0)
{
    Console.WriteLine("Сколько из них книг?");
    int.TryParse(Console.ReadLine(), out int bookCount);
    for (int i = 0; i < bookCount; i++)
    {
        Console.WriteLine("Укажите название книги " + (i + 1));
        string title = Console.ReadLine();
        Console.WriteLine("теперь краткое описание");
        string discription = Console.ReadLine();
        printable[i] = new Book(title, discription);
    }

    for (int i = bookCount; i < printable.Length; i++)
    {
        Console.WriteLine("Укажите название журнала " + (i + 1));
        string title = Console.ReadLine();
        Console.WriteLine("теперь краткое описание");
        string discription = Console.ReadLine();
        printable[i] = new Magazine(discription, title);
    }
    for (int i = 0; i < printable.Length; i++)
    {
        printable[i].Print();
    }
    Console.WriteLine(new string('*',50));
    Console.WriteLine("Количесвто книг:"+Book.bookCount);
    Book.PrintBook(printable);
    Console.WriteLine(new string('*', 50));
    Console.WriteLine("Количесвто журналов:"+Magazine.magazineCount);
    Magazine.PrintMagazine(printable);

}