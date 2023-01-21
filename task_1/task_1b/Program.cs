int randomInt = 23;
long randomLong = 2342;
sbyte randomSByte = 11;
byte randomByte = 100;
uint randomUInt = 1123;
float randomFloat = 14.34F;
double randomDouble = 123.234D;

randomLong= randomInt;
randomInt = randomSByte;
Console.WriteLine($"Long-{randomLong};Int-{randomInt};");
randomDouble = randomFloat;
randomLong = randomUInt;
randomInt = randomByte;
Console.WriteLine($"Long-{randomLong};Int-{randomInt};Double-{randomDouble};");

randomInt = (int)randomFloat;
Console.WriteLine($"Int-{randomInt}");
randomLong = (long)randomDouble;
randomInt = (int)randomLong;
randomSByte=(sbyte)randomInt;
Console.WriteLine($"Int-{randomInt};SByte-{randomSByte}");
randomFloat=(float)randomDouble;
Console.WriteLine($"Float-{randomFloat};");


