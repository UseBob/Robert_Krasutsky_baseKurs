using System.Text;
using System.Text.RegularExpressions;

string link = "c:\\WebServers\\home\\testsite\\www\\myfile.txt";
int myfile=link.LastIndexOf("myfile");
//Console.WriteLine(myfile);
string file=link.Substring(32,6);
Console.WriteLine(file);