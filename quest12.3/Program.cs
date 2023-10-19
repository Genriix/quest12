using System;

class Vehicle
{
    protected string type;
    protected double x;
    protected double y;
    protected double price;
    protected double speed;
    protected int year;

    /// Пользовательский конструктор

    public Vehicle(string type,double x, double y, double price, double speed, int year)
    {
        this.type = type;
        this.x = x;
        this.y = y;
        this.price = price;
        this.speed = speed;
        this.year = year;
    }

    /// Вывод информации

    public virtual void ShowInfo()
    {
        Console.WriteLine($"Тип/Тип, имя: {type}");
        Console.WriteLine($"Координаты: ({x} по Х, {y} по У)");
        Console.WriteLine($"Цена: {price}");
        Console.WriteLine($"Скорость: {speed}");
        Console.WriteLine($"Год выпуска: {year}");
    }
}

class Plane : Vehicle
{
    /// Пользовательский конструктор

    private double altitude; // Высота
    private int passengerCount; // Кол-во пассажиров

    public Plane(string type, double x, double y, double price, double speed, int year, double altitude, int passengerCount)
        : base(type, x, y, price, speed, year) // Наследование от Vehicle
    {
        this.altitude = altitude;
        this.passengerCount = passengerCount;
    }

    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Высота: {altitude}");
        Console.WriteLine($"Количество пассажиров: {passengerCount}");
    }
}

class Car : Vehicle
{
    /// Пользовательский конструктор

    public Car(string type, double x, double y, double price, double speed, int year)
        : base(type, x, y, price, speed, year) { } // Тут ничего не меняется, так что конструктор пустой
}

class Ship : Vehicle
{
    private int passengerCount;  // Кол-во пассажиров
    private string homePort; // Место стоянки

    /// Пользовательский конструктор

    public Ship(string type, double x, double y, double price, double speed, int year, int passengerCount, string homePort)
        : base(type, x, y, price, speed, year)
    {
        this.passengerCount = passengerCount;
        this.homePort = homePort;
    }

    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Количество пассажиров: {passengerCount}");
        Console.WriteLine($"Место стоянки: {homePort}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Vehicle[] vehicles = new Vehicle[3];

        vehicles[0] = new Plane("Самолёт",66, 51, 15279000, 500, 2010, 10000, 200);
        vehicles[1] = new Car("Машина", 57, 36, 50000, 83, 2015);
        vehicles[2] = new Ship("Корабль <<Wicked Wich>>", 345, 2, 2000000, 13, 2005, 500, "Tartooga");

        foreach (Vehicle vehicle in vehicles)
        {
            vehicle.ShowInfo();
            Console.WriteLine();
        }

        Console.ReadKey();
    }
}