 void CookingSushiApp()
{
    Console.WriteLine("Добрро пожаловать в 'Cooking sushi app' ");
    Console.WriteLine("Укажите предпочитаемый вид суши");
    Console.WriteLine("вегетарианские суши нажмите 1, классика 2");
    int selectionTyps = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Для расчёта ингридиентов укажите желаемое кол-во порций(Максимум 10)");
    int servingCount = Convert.ToInt32(Console.ReadLine());
    int nori=0;
    if (selectionTyps == 1 && servingCount<11)
    {
        if (servingCount<6)
        {
            Console.WriteLine("Ингридиенты: \n рис-200гр \n вода 1 стакан \n нори 3 шт. \n огурец 1 шт. \n тофу 150гр. ");
             nori = 3;
        }
        else if (servingCount>5)
        {
            Console.WriteLine("Ингридиенты: \n рис-400гр \n вода 2 стакана \n нори 6 шт. \n огурец 2 шт. \n тофу 300гр. ");
             nori = 6;
        }
    }
    else if (selectionTyps == 2 && servingCount<11)
    {
        if (servingCount < 6)
        {
            Console.WriteLine("Ингридиенты: \n форель 1 шт. \n рис-200гр \n вода 1 стакан \n нори 3 шт. \n огурец 1 шт. \n тофу 150гр. ");
             nori = 3;

        }
        else if (servingCount > 5)
        {
            Console.WriteLine("Ингридиенты: \n форель 2 шт. \n рис-400гр \n вода 2 стакана \n нори 6 шт. \n огурец 2 шт. \n тофу 300гр. ");
             nori = 6;
        }
    }
    else return;
    Console.WriteLine("Рецепт : отварить рис ,нарезать отсальные ингридиенты, выложить на листы нори");
    Console.WriteLine("Всё готово");
    Console.WriteLine("Начать скручивать роллы? Укажите Да или Нет");
    string roll = Console.ReadLine();
    while (roll == "нет" || roll == "Нет" )
    {
        Console.WriteLine("А теперь?");
        roll= Console.ReadLine();
    }
    if (roll == "Да" || roll == "да")
    {
        for (int i = 0; i < nori; i++)
        {
            Console.WriteLine($"Скручиваем {i + 1}-ый ролл");
        }
        Console.WriteLine("Ролы скрученны!");
    }
    else return;
    Console.WriteLine("Теперь их можно нарезать. Укажите на сколько частей вы желаете нарезать ролл 2,4,6 " +
        "либо нажмите q для выхода ");
    string kut = Console.ReadLine();
    if (kut != "2" && kut != "4" && kut != "6" && kut == "Q" && kut == "q") return;
    else if (kut=="2")
    {
        Console.WriteLine($"Ваш сет из {nori*2} суши готов!") ;
    }
    else if (kut == "4")
    {
        Console.WriteLine($"Ваш сет из {nori * 4} суши готов!");
    }
    else if (kut == "6")
    {
        Console.WriteLine($"Ваш сет из {nori * 6} суши готов!");
    }
}
CookingSushiApp();
for (int i = 0; i < 40; i++)
{
    Console.Write("##");
}
Console.WriteLine("");
Console.WriteLine("Желаете проверить дополнительное задание?");
string addTask = Console.ReadLine();
if (addTask=="Да" || addTask == "да")
{
    CalculatedLenghts();
}
void CalculatedLenghts()
{
    Console.WriteLine("Введите длину в сантиметрах");
    int cmLenghts=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Длина в полных метрах будет равна {cmLenghts/100}"); 
}
