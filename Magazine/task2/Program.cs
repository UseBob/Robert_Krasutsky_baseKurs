using task2;
int arrayLength = 3;
IPrintable[] printable=new IPrintable[arrayLength];
printable[0] = new Book();
printable[1] = new Magazine();
printable[2] = new Book();
for (int i = 0; i < printable.Length; i++)
{
    printable[i].Print();
}    