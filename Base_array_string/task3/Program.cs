using System.Text;
using System.Text.RegularExpressions;
Console.WriteLine( "Введите слово или фрагмент который вы желаете найти.\nЕсли фрагментов в тексте несколько, вам будет выдан первый из них.");
string searchWord=Console.ReadLine();
Console.WriteLine("Вставьте текст в котором желаете произвести поиск");
string text=Console.ReadLine();
int symbolCount = searchWord.Length;
int mySearchIndex = text.IndexOf(searchWord);
if (text.Contains(searchWord))
{
    string fragmentText = text.Substring(mySearchIndex, symbolCount);
    Console.WriteLine(fragmentText);
}
else
{
    Console.WriteLine("В тексте не обнаружено такого фрагмента");
}
//string link = "c:\\WebServers\\home\\testsite\\www\\myfile.txt";
//string test = "myfile";
//Console.WriteLine(symbolCount);
//int myfile=link.LastIndexOf("myfile");
//string file=link.Substring(myfile, symbolCount);
//Console.WriteLine(file);