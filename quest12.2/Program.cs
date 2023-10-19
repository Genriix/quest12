using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quest12._2
{
    class ClassRoom
    {
        Pupil[] arrPupil; // Поле-массив

        /// Реализация ввода не полного класса

        public ClassRoom(Pupil p1, Pupil p2, Pupil p3, Pupil p4)
        {
            arrPupil = new Pupil[] { p1, p2, p3, p4 };
        }
        public ClassRoom(Pupil p1, Pupil p2, Pupil p3)
        {
            arrPupil = new Pupil[] { p1, p2, p3 };
        }
        public ClassRoom(Pupil p1, Pupil p2)
        {
            arrPupil = new Pupil[] { p1, p2 };
        }

        /// Вывод информации

        public void PrintInfoStudy()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nОбучение: ");
            foreach (Pupil item in arrPupil)
                item.Study();
        }
        public void PrintInfoRead()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nЧтение: ");
            foreach (Pupil item in arrPupil)
                item.Read();
        }
        public void PrintInfoWrite()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nПисьмо: ");
            foreach (Pupil item in arrPupil)
                item.Write();
        }
        public void PrintInfoRelax()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nПоведение: ");
            foreach (Pupil item in arrPupil)
                item.Relax();
        }
        public void ShowAllInfo()
        {
            PrintInfoStudy();
            PrintInfoRead();
            PrintInfoWrite();
            PrintInfoRelax();
        }
    }

    class Pupil 
    {        
        public virtual void Study() { }
        public virtual void Read() { }
        public virtual void Write() { }
        public virtual void Relax() { }
    }
    class ExcelentPupil : Pupil 
    {
        public override void Study() { 
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Отличник: Обучение - отлично"); }
        public override void Read() {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Отличник: Чтение - отлично"); }
        public override void Write() {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Отличник: Письмо - отлично"); }
        public override void Relax() {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Отличник: Поведение - отлично"); }
    }
    class GoodPupil : Pupil 
    {
        public override void Study() { 
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Хорошист: Обучение - хорошо"); }
        public override void Read() {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Хорошист: Чтение - хорошо"); }
        public override void Write() {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Хорошист: Письмо - хорошо"); }
        public override void Relax() {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Хорошист: Поведение - хорошо"); }
    }
    class BadPupil : Pupil
    {
        public override void Study() { 
            Console.ForegroundColor= ConsoleColor.Red;
            Console.WriteLine("Троечник: Обучение - удовлетворительно"); }
        public override void Read() {
            Console.ForegroundColor = ConsoleColor.Red; 
            Console.WriteLine("Троечник: Чтение - удовлетворительно"); }
        public override void Write() {
            Console.ForegroundColor = ConsoleColor.Red; 
            Console.WriteLine("Троечник: Письмо - удовлетворительно"); }
        public override void Relax() {
            Console.ForegroundColor = ConsoleColor.Red; 
            Console.WriteLine("Троечник: Поведение - удовлетворительно"); }
    }

    internal class Program
    {
        static void Main()
        {
            ClassRoom cRoom = new ClassRoom(new ExcelentPupil(), new GoodPupil(), new BadPupil(), new GoodPupil());
            cRoom.ShowAllInfo();
            Console.ReadKey();
        }
    }
}
