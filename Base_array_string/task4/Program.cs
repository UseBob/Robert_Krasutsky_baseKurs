using System.Text;
string text = Console.ReadLine();

string[] dif = { " ", ",",".","!","?","-",":",";"};
string[] strlist= text.Split(dif, StringSplitOptions.RemoveEmptyEntries);

Console.WriteLine($"Количество слов = {strlist.Length}");
for (int i = 0; i < strlist.Length; i++)
{
    Console.WriteLine(strlist[i]);
}
