sbyte sb = 12;
short sh= 14;
int integer = 342;
long lg = 12341241;
byte bt = 14;
ushort ush = 12341;
uint uinteger = 22334;
ulong ulg = 342;
float f = 43.27F;
double d = -11092.53D;
char ch2 = 'x';
decimal dc = 53005.25M;
Console.WriteLine("Целые числа со знаком \n");
Console.WriteLine("sbyte \t Размер: 08 бит \t Допустимые значения: от -128 до 127");
Console.WriteLine("short \t Размер: 16 бит \t Допустимые значения: от -32768 до 32767");
Console.WriteLine("int \t Размер: 32 бита \t Допустимые значения: от -2^31 до 2^31-1");
Console.WriteLine("long \t Размер: 64 бита \t Допустимые значения: от -2^63 до 2^63-1");
for (int i = 0; i < 25; i++)
{
    Console.Write("---");
}
Console.WriteLine("");
Console.WriteLine("Целые числа без знака \n");
Console.WriteLine("byte \t Размер: 08 бит \t Допустимые значения: от 0 до 255");
Console.WriteLine("ushort \t Размер: 16 бит \t Допустимые значения: от 0 до 65535");
Console.WriteLine("uint \t Размер: 32 бита \t Допустимые значения: от 0 до 2^32-1");
Console.WriteLine("ulong \t Размер: 64 бита \t Допустимые значения: от 0 до 2^64-1");
for (int i = 0; i < 25; i++)
{
    Console.Write("---");
}
Console.WriteLine("");
Console.WriteLine("Числа с плавающей точкой \n");
Console.WriteLine("float \t Размер: 32 бит \t Допустимые значения: от -3.4*10^38 до 3.4*10^38");
Console.WriteLine("double \t Размер: 64 бит \t Допустимые значения: от ±5.0*10^(-324) до ±1.7*10^308");
for (int i = 0; i < 35; i++)
{
    Console.Write("---");
}
Console.WriteLine("");
Console.WriteLine("Символьный тип");
Console.WriteLine("char \t Размер: 16 бит \t Допустимые значения: от U+0000 ('\\u0000') до U+FFFF ('\\uffff') + символы Unicode");
for (int i = 0; i < 35; i++)
{
    Console.Write("---");
}
Console.WriteLine("");
Console.WriteLine("Тип Decimal");
Console.WriteLine("decimal  \t Размер: 128 бит \t Допустимые значения: от ±1.0*10^(-28) до ±7.9228*10^28");
for (int i = 0; i < 35; i++)
{
    Console.Write("---");
}
