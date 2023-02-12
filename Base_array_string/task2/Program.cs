int[,] myarray = new int[3, 4]
{
    {1,26,5,1 },
    {52,6,1 , 52},
    {24,11,56,25 },
};
int maxVAlue=int.MinValue;
for (int i = 0; i <= myarray.GetUpperBound(0); i++)
{
    for (int j = 0; j <= myarray.GetUpperBound(1); j++)
    {
        if (myarray[i,j]> maxVAlue)
        {
            maxVAlue = myarray[i, j];
        }
    }
    Console.WriteLine(maxVAlue);
    maxVAlue = int.MinValue;
}