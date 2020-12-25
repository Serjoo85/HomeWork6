using System;
using System.Collections.Generic;
using ToolsLib;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Task3
{
    /*
    3. Переделать программу «Пример использования коллекций» для решения следующих задач:
    а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
    б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся(частотный массив);
    в) отсортировать список по возрасту студента;
    г) * отсортировать список по курсу и возрасту студента;
    д) разработать единый метод подсчета количества студентов по различным параметрам
    выбора с помощью делегата и методов предикатов.

    Сершей Иванов.
    
     */
    public class Student : IComparable
    {
        public static Delegate[] ArrDel;
        public static List<Student> StList = new List<Student>();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Course { get; set; }
        public int Faculty { get; set; }
        public double AverageGrade { get; set; }

        public Student(string FirstName, string LastName, int Age, int Course,
            int Faculty, double AverageGrade) 
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Age = Age;
            this.Course = Course;
            this.Faculty = Faculty;
            this.AverageGrade = AverageGrade;
        }
        public override string ToString()
        {            
            return String.Format("{0, -10} {6,-1} {1, -10} {6,-1} {2} {6,-1} {3, -3}" +
                " {6,-1} {4} {6,-1} {5,-4} {6,-1}", FirstName, LastName, Age, Faculty, Course, AverageGrade, "|");
        }
        public static void StudentPrint()
        {
            Console.WriteLine(String.Format("{0, -10} {6,-1} {1, -10} {6,-1} {2, -2}" +
                " {6,-1} {3, -3} {6,-1} {4} {6,-1} {5,-4} {6,-1}", "1", "2", "3", "4", "5", "6", "|"));
            Console.WriteLine(String.Format("{0, -10} {6,-1} {1, -10} {6,-1} {2, -2}" +
                " {6,-1} {3, -3} {6,-1} {4} {6,-1} {5,-4} {6,-1}\n", "Фамилия", "Имя", "В", "Ф", "К", "О", "|"));
            foreach (Student st in Student.StList)
            {
                Console.WriteLine(st.ToString());
            }
            Console.WriteLine("_______________________________________________");
            Console.ReadLine();
        }

        public int CompareTo(object obj)
        {
            Student st = obj as Student;
            int z = 0;
            for (int i = 0; i < ArrDel.Length; i++)
            {
                z = (int)ArrDel[i].DynamicInvoke(this, st);
                if (z != 0)
                {
                    return z;
                }
            }
            return 0;
        }
    }

    class Program
    {
        delegate T Del<T, K>(K st1, K st2);
        public static void CreatStudentList(int number)
        {            
            for (int i = 0; i < number; i++)
            {
                Student St = new Student(Tools.NameGenerator(1), Tools.NameGenerator(2),
                    Tools.RandomR.r.Next(18, 45), Tools.RandomR.r.Next(1, 5),
                    (Tools.RandomR.r.Next(1, 5) * 100), (double)(Tools.RandomR.r.Next(200, 500)) / 100);
                Student.StList.Add(St);
            }
        }

        static void Main(string[] args)
        {
            Del<int, Student> del1 = null;
            CreatStudentList(50);
            for(int i = 0; i < 6; i++)
            {
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        del1 += (Student st1, Student st2) => st1.FirstName.CompareTo(st2.FirstName);
                        break;
                    case 2:
                        del1 += (Student st1, Student st2) => st1.LastName.CompareTo(st2.LastName);
                        break;
                    case 3:
                        del1 += (Student st1, Student st2) => st1.Age.CompareTo(st2.Age);
                        break;
                    case 4:
                        del1 += (Student st1, Student st2) => st1.Faculty.CompareTo(st2.Faculty);
                        break;
                    case 5:
                        del1 += (Student st1, Student st2) => st1.Course.CompareTo(st2.Course);
                        break;
                    case 6:
                        del1 += (Student st1, Student st2) => st1.AverageGrade.CompareTo(st2.AverageGrade);
                        break;
                }
                Student.ArrDel = del1.GetInvocationList();
            }
            Student.StudentPrint();
            Student.StList.Sort();
            Student.StudentPrint();
            Console.ReadLine();
        }
    }
}
