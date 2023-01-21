int a_1 = 545;
long b_1 = 1111;
string hello = "Hello world";

object hello_1 = hello; //boxing
object a_2 = a_1; //boxing
object b_2 = b_1; //boxing
a_1=(int)a_2; //unboxing
b_1=(long)b_2; //unboxing
hello=(string)hello_1; //unboxing

var randomObject = 342;
Console.WriteLine(randomObject);
Console.WriteLine(randomObject.GetType());
randomObject = 234;
Console.WriteLine(randomObject);
randomObject = "fsds";
// среда разработки выделяет здесь ошибку,т.к полю randomObjekt был присвоен тип переменной int 
// и мы не может неявно преобразовать тип string в int.




