using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceTask
{
    internal class Guitar:IMusInstruments
    {
        public string Name { get; set; }
        public string Characteristics { get; set; }
        public Guitar()
        {
            Name = "Гитара";
            Console.WriteLine("Укажите форму вашей гитары ");
            string GuitarSize = Console.ReadLine();
            Console.WriteLine("Количесво струн на инструменте");
            string cordsCount = Console.ReadLine();
            Console.WriteLine("Возможный цвет инструмента");
            string GuitarColor = Console.ReadLine();
            Console.WriteLine("Из какого материала сделаны струны");
            string materalCord = Console.ReadLine();
            Characteristics = $"Форма этой модели  {GuitarSize}, количесвто струн у гитары равно {cordsCount}," +
                $"инструмент окрашен в невероятный {GuitarColor} цвет,а материал из которого сделаны струны это {materalCord} ";
        }
        public void Play()
        {
            Console.WriteLine($"Вы сделали пару ловких движений кистью вверх вниз " +
                $"и инструмент издал невероятно мелодичный звук ");
        }
    }
}
