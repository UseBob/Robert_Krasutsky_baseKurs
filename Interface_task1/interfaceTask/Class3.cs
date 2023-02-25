using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceTask
{
    internal class Drums:IMusInstruments
    {
        public string Name { get; set; }
        public string Characteristics { get; set; }
        public Drums()
        {
            Name = "Барабаны";
            Console.WriteLine("Укажите тип вашего барабана ");
            string drumsType = Console.ReadLine();
            Console.WriteLine("Количесво барабанных установок");
            string drumsCount = Console.ReadLine();
            Console.WriteLine("Материал из которого изготовлены палочки");
            string stickMaterial = Console.ReadLine();
            Console.WriteLine("Материал из которого изготовлен корпус самого барабана");
            string drumsMaterial = Console.ReadLine();
            Characteristics = $"Тип этих барабанов  {drumsType}, в составе идёт  {drumsCount} барабанных установок," +
                $"палочки сделаны под заказ из {stickMaterial} ,а материал самого корпуса это {drumsMaterial}";
        }
        public void Play()
        {
            Console.WriteLine($"Пару раз стукнув по барабану палочка отскачила и ударила вам по лбу." +
                $"Кажется барабаны это не ваше)");
        }
    }
}
