using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quest12._1
{
    public class Printer
    {
        public void Print(string value) 
        { 
            Console.WriteLine(value + "\n");
        }
    }

    public class SecondPrinter : Printer
    {
        public void PaintItColor(string color,string value)
        {
            switch (color)
            {
                case "Red": Console.ForegroundColor = ConsoleColor.Red; base.Print(value); break;
                case "Green": Console.ForegroundColor = ConsoleColor.Green; base.Print(value); break;
                case "Blue": Console.ForegroundColor = ConsoleColor.Blue; base.Print(value); break;
                case "DarkGray": Console.ForegroundColor = ConsoleColor.DarkGray; base.Print(value); break;
                case "Gray": Console.ForegroundColor = ConsoleColor.Gray; base.Print(value); break;
                case "Black": 
                    Console.BackgroundColor = ConsoleColor.White; 
                    Console.ForegroundColor = ConsoleColor.Black;
                    base.Print(value);
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
            }
        }
    }
    internal class Program
    {
        static void Main()
        {
            /// Red Green Blue Gray Black
            
            new Printer().Print("Normally цвет консоли");
            new SecondPrinter().PaintItColor
                ("Black", 
                "I see the girls walk by dressed in their summer clothes\n" +
                "I have to turn my head until my darkness goes");
            new SecondPrinter().PaintItColor("Green", "\t\t\t\t\tThe Rolling Stones. Альбом Hot Rocks. Песня Paint It Black");
            new SecondPrinter().PaintItColor("Red", 
                "У каждого из нас своя реализация\n" +
                "Главное - кем быть и можно по всякому называться\n" +
                "Полиморфизм, Человек.СказатьСлово()\n" +
                "Каждый может по-своему и это так клёво!");
            new SecondPrinter().PaintItColor("Gray", "\t\t\t\t\tГруппа Научно-Технический Рэп. Сингл Полиморфизм");
            Console.ReadKey();
        }
    }
}
