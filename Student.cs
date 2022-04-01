using System;
namespace GenericHM
{
    public class Student 
    {
        private static int _id;

        public int ID { get; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public double Point { get; set; }

        public Student(string name, string surname, double point)
        {
            Name = name;
            Surname = surname;
            Point = point;
        }

        public Student()
        {
            _id++;
            ID = _id;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Student ID : {ID}\n" +
                $"Name : {Name}\n" +
                $"Surname : {Surname}\n" +
                $"Age : {Age}\n" +
                $"Point : {Point}");
        }

        public static bool operator >(Student p , Student p1)
        {
            return p.Point > p1.Point;
        }
        public static bool operator <(Student p , Student p1)
        {
            return p.Point < p1.Point;
        }

    }


   

}
