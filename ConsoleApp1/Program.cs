using System;

namespace ConsoleApp1
{

    public class Student
    {

        public string FullName;
        public int Grade1;
        public int Grade2;


        public void ShowData()
        {
            Console.WriteLine($"Студент: {FullName}");
            Console.WriteLine($"Оценка 1: {Grade1}");
            Console.WriteLine($"Оценка 2: {Grade2}");
        }

        public float SredOcenka()
        {
            return (Grade1 + Grade2) / 2.0f;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();

            student1.FullName = "Иванов";
            student1.Grade1 = 3;
            student1.Grade2 = 5;


            student1.ShowData();


            float avg1 = student1.SredOcenka();
            Console.WriteLine($"Средняя оценка студента {student1.FullName}: {avg1}");

            Console.ReadKey();
        }
    }
}
