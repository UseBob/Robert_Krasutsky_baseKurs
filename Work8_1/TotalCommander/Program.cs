using dz8_namespace;
using System.Reflection;
using TotalCommander;

TotalCommand totalCommander = new TotalCommand("Bob");

//totalcommander.copydirectory("c:\\temp\\newdir2");
//totalcommander.movefile("c:\\temp\\t6.txt", "c:\\temp\\newdir2\\t6.txt");
//totalcommander.copyfile("c:\\temp\\newdir2\\t6.txt");

Assembly asseblies = Assembly.LoadFrom("C:\\Users\\Мария\\source\\repos\\Work8_1\\dz8.dll");
Console.WriteLine(asseblies.FullName);
Type[] types = asseblies.GetTypes();
foreach (Type t in types)
{
    Console.WriteLine(t.Name);
}
//Сборка содержит несколько атрибутов, и класс "Class_dz8",так же узнали имя сборки,версию и т.д
Console.WriteLine(new string('*', 50));
Type myType = typeof(Class_dz8);
foreach (MemberInfo member in myType.GetMembers())
{
    Console.WriteLine($"{member.DeclaringType} {member.MemberType} {member.Name}");
}
// тут мы узнали краткую информацию о сборке: 2 конструктора,
// 2 св-ва один из которых содержит только метод гет,1 метод,1 поле
Console.WriteLine(new string('-', 50));
foreach (MemberInfo member in myType.GetMembers(BindingFlags.DeclaredOnly
                        | BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public))
{
    Console.WriteLine($"{member.DeclaringType} {member.MemberType} {member.Name}");
}
//Здесь мы находим спрятанные эл-ты: метод ShowSecretPassword,поле secret_password,
//поле  типа  <Email> и ещё одно поле типа <Checksum>

var NewObj = Activator.CreateInstance(myType);
//Cоздали экземляр объекта и присвоили его в NewObj