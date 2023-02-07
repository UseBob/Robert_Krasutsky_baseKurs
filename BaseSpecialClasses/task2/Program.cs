
using System;
using System.Net.Mail;
using System.Reflection;
Console.WriteLine("Введите количесво людей которые работают в компании");
Company company=new Company();
Person[] person=new Person[Company.personalCount];
string p = "Y";
for (int i = 0; i < person.Length; i++)
{
    Console.WriteLine($"Введите:имя,возраст,номер телефона,зарплату,должность для {i+1} работника .В соответствующем порядке");
    string name = Console.ReadLine();
    int age = int.Parse(Console.ReadLine());
    int number = int.Parse(Console.ReadLine());
    int salary = int.Parse(Console.ReadLine());
    string post = Console.ReadLine();
    person[i]=new Person(name, age, number, salary,post);
    company[i]= person[i];
}
Console.WriteLine("Что вы хотите сделать с работниками");
Console.WriteLine(string.Empty);
while ( p=="Y" || p=="y")
{
    Console.Write("1-Узнать информацию о выбранном работнике \t " +
        "2-Изменить должность выбраного работника \n3-Изменить заработную плату выбраного работника \t"+
        "4-Уволить выбраного работника \n");
    string selection = Console.ReadLine();
    if (selection=="1")
    {
        Console.WriteLine("Укажите индекс работника о котором желаете получить информацию.Индексы начинаются с 0");
        int index = int.Parse(Console.ReadLine());
        company.InfoPerson(index);
    }
    else if (selection=="2") 
    {
        Console.WriteLine("Укажите индекс работника которому желаете изменить должность.Индексы начинаются с 0");
        int index = int.Parse(Console.ReadLine());
        Console.WriteLine($"Текущая должность {company[index].Post}.Желаете изменить на...");
        string post =  Console.ReadLine();
        company.PostChanges(post, index);
        Console.WriteLine("Должность изменена");
    }
    else if (selection == "3")
    {
        Console.WriteLine("Укажите индекс работника которому желаете изменить заработную плату.Индексы начинаются с 0");
        int index = int.Parse(Console.ReadLine());
        Console.WriteLine($"Текущая з.п {company[index].Salary}.Укажите на сколько желаете изменить");
        int deltaSalary = int.Parse(Console.ReadLine());
        company.SalaryChanges(deltaSalary, index);
        Console.WriteLine("З.П изменена");
    }
    else if (selection == "4")
    {
        Console.WriteLine("Список всех работников");
        for (int i = 0; i < person.Length; i++)
        {
            Console.Write(company[i].Name + " ");
        }
        Console.WriteLine(string.Empty);
        Console.WriteLine("Укажите индекс работника которого желаете удалить.Индексы начинаются с 0");
        int index = int.Parse(Console.ReadLine());
        Console.WriteLine("Новый список работников");
        company.FirePerson(index);
        
    }
    else 
    {
        Console.WriteLine("Кажется вы ввели что-то не то");
    }
    Console.WriteLine("Желаете узнать что-то ещё? \n Y-ДА \t  Любая другая клавиша-Нет");
    p = Console.ReadLine();
}
class Person
{
    public static int personCount = 0;
    public string Name { get; }
    public int Age { get; }
    public int Number { get; }
    public int Salary { get; set; }
    public string Post { get; set; }
    public Person(string name, int age, int number, int salary, string post)
    {
        Name = name;
        Age = age;
        Number = number;
        Salary = salary;
        Post = post;
        personCount++;
    }
}
class Company
{
    public static string CompanyName { get; set; }
    public static string Mail { get; set; }
    public static string Vacancy { get; set; }

    public static int personalCount = int.Parse(Console.ReadLine());

    Person[] personal=new Person[personalCount];
    public Person this[int index]
    {
        get => personal[index];
        set => personal[index] = value;
    }
    public void SalaryChanges(int value,int index)
    {
        if (index < personalCount)
        {
            personal[index].Salary += value;
        }
        else { Console.WriteLine("Такого работника нет!"); }
        
    }
    public void PostChanges(string value, int index)
    {
        if (index < personalCount)
        {
            personal[index].Post = value;
        }
        else { Console.WriteLine("Такого работника нет!"); }
       
    }
    public void InfoPerson(int index)
    {
        if (index<personalCount)
        {
            Console.WriteLine($"Имя {personal[index].Name}\nВозраст {personal[index].Age}\n" +
            $"Телефон {personal[index].Number}\nЗаработная плата {personal[index].Salary}\n" +
            $"Должность {personal[index].Post}");
        }
        else { Console.WriteLine("Такого работника нет!"); }
    }
    public void FirePerson(int index)
    {
        if (index < personalCount)
        {
            Person[] newListPerson = new Person[Company.personalCount - 1];
            for (int i = 0; i < index; i++)
            {
                newListPerson[i] = personal[i];
            }
            for (int i = index; i < newListPerson.Length; i++)
            {
                newListPerson[i] = personal[i + 1];
            }
            for (int i = 0; i < newListPerson.Length; i++)
            {
                Console.WriteLine(newListPerson[i].Name + " ");
            }
            Person.personCount--;
        }
        else { Console.WriteLine("Такого работника нет!"); }
        
    }
}
