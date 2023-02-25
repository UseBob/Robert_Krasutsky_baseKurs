using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceTask
{
    internal class Piano : IMusInstruments
    {
        public string Name { get; set; }
        public string Characteristics { get; set; }
        public Piano() 
        {
            Name = "Пианино";
            Console.WriteLine("Укажите габариты вашего пианино ");
            string PianoSize=Console.ReadLine();
            Console.WriteLine("Количесво клавиш на инструменте");
            string keysCount = Console.ReadLine();
            Console.WriteLine("Возможный цвет инструмента");
            string PianoColor = Console.ReadLine();
            Console.WriteLine("Продолжительность звука после нажатия");
            string timeSound = Console.ReadLine();
            Characteristics = $"Размер этой модели {PianoSize}, количесвто клавиш на инструменте {keysCount}," +
                $"инструмент окрашен в невероятный {PianoColor} цвет,а продолжительность звука от 1го нажатия равна {timeSound} ";
        }
        public void Play() 
        {
            Console.WriteLine($"Не рассчитав силу нажатия  вы резко вдавливаете клавишу " +
                $"и пианино издаёт громкий и долгий звук  ");
        }
    }
}
