Console.WriteLine("Гид по эксплотации бытовой техники,укажите какой машиной вы сейчас будете пользвоаться");
Console.WriteLine("1-стиральная 2-посудомоечная ");
string selectionMachin=Console.ReadLine();
if(selectionMachin!="1" && selectionMachin!="2")
{
    Console.WriteLine("Кажется вы жмякнули не туда");
}
else if (selectionMachin == "1")
{
    Console.WriteLine("Для начала нам требуется узнать кое какие параметры вашей стиральной машины");
    WashingMachine washingMachine=new WashingMachine();
    Console.WriteLine("Укажите навзвание вашей стиральной машины ");
    string machineName= Console.ReadLine();
    washingMachine.MachineName = machineName;
    Console.WriteLine("Теперь модель ");
    washingMachine.MachineVersion = Console.ReadLine();
    Console.WriteLine("Ну что же,осталось всего 2 характеристики.Укажите максимальную загрузку, " +
        "а затем и потребляемую мощность");
    washingMachine.MaxMachineVolume=int.Parse(Console.ReadLine());
    washingMachine.PowerConsumption =int.Parse(Console.ReadLine());
    washingMachine.PutItem();
    washingMachine.SelectionMod();
    washingMachine.Start();
}
else if (selectionMachin == "2")
{
    Console.WriteLine("Для начала нам требуется узнать кое какие параметры вашей посудомоечной машины");
    Dishwasher dishwasher = new Dishwasher();
    Console.WriteLine("Укажите навзвание вашей  машины ");
    dishwasher.MachineName = Console.ReadLine();
    Console.WriteLine("Теперь модель ");
    dishwasher.MachineVersion = Console.ReadLine();
    Console.WriteLine("Ну что же,осталось всего 2 характеристики.Укажите максимальную загрузку, " +
        "а затем и потребляемую мощность");
    dishwasher.MaxMachineVolume = int.Parse(Console.ReadLine());
    dishwasher.PowerConsumption = int.Parse(Console.ReadLine());
    dishwasher.PutItem();
    dishwasher.SelectionMod();
    dishwasher.Start();
}

abstract class Appliances
{
    public string machineName;
    public string machineVersion;
    public int powerConsumption;
    public int maxMachineVolume;

    public abstract int MaxMachineVolume { get; set; }
    public abstract string MachineName { get; set; }
    public abstract int PowerConsumption { get; set; }
    public abstract string MachineVersion { get; set; }


    public abstract void PutItem();

    public abstract void SelectionMod();

    public void Start()
    {
        Console.WriteLine("Запустите  машину");
    }
}
class WashingMachine:Appliances
{

    public override int PowerConsumption { get => powerConsumption; set => powerConsumption = value; }
    public override int MaxMachineVolume { get => maxMachineVolume; set =>  maxMachineVolume=value; }
    public override string MachineName { get => "Тип машины "+machineName; set => machineName=value; }
    public override string MachineVersion { get => "Модель указанной машины"+machineVersion; set => machineVersion=value; }
    public override void PutItem()
    {

        if (MaxMachineVolume<20 || PowerConsumption>50)
        {
            Console.WriteLine("Вы можете полностью загрузить машину");
        }
        else if(MaxMachineVolume>20 || PowerConsumption< 100)
        {
            Console.WriteLine("Вам нежелательно загружать всю машину ");
        }
    }
    public override void SelectionMod()
    {
        Console.WriteLine("Выберете режим стирки и затем выставьте температуру ниже 60 градусов");
    }
}
class Dishwasher:Appliances
{

    public override int PowerConsumption { get => powerConsumption; set => powerConsumption = value; }
    public override int MaxMachineVolume { get =>  maxMachineVolume; set => maxMachineVolume = value; }
    public override string MachineName { get => "Тип машины " + machineName; set => machineName = value; }
    public override string MachineVersion { get => "Модель указанной машины" + machineVersion; set => machineVersion = value; }
    public override void PutItem()
    {
        Console.WriteLine("Загрузите все посадочные места для посуды ");
    }
    public override void SelectionMod()
    {
        Console.WriteLine("Закиньте таблетку и запустите машину нажав комбинацию клавиш '+' и 'Пуск");
    }
}