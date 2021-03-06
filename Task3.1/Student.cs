﻿using System;
using System.Collections.Generic;
using ToolsLib;

namespace Task3._1
{
    public class Student : IComparable
    {
        // Массив для проброса делегатов
        // обеспечивающих логику сортировки.
        private static Delegate[] arrDel;
        public static List<Student> StList = new List<Student>();
        internal string FirstName { get; set; }
        internal string LastName { get; set; }
        internal int Age { get; set; }
        internal int Course { get; set; }
        internal int Faculty { get; set; }
        internal double AverageGrade { get; set; }

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

        // Генерируем лист из студентов.
        public static void GenerateStudentList(int number)
        {
            StList.Clear();
            for (int i = 0; i < number; i++)
            {
                Student St = new Student(Tools.NameGenerator(1), Tools.NameGenerator(2),
                    Tools.RandomR.r.Next(18, 45), Tools.RandomR.r.Next(1, 5),
                    (Tools.RandomR.r.Next(1, 5) * 100), (double)(Tools.RandomR.r.Next(200, 500)) / 100);
                StList.Add(St);
            }
        }

        // Метод реализации интерфейса IComparable
        // соритрует наш лист применяя
        // заложенную списком делегатов очередность.
        public int CompareTo(object obj)
        {            
            Student st = obj as Student;
            int z = 0;
            for (int i = 0; i < arrDel.Length; i++)
            {
                z = (int)arrDel[i].DynamicInvoke(this, st);
                if (z != 0)
                {
                    return z;
                }
            }
            return 0;
        }
        
        // Метод комплексной сортировки.
        public static void ComplexSort(Func<Student, Student, int> f)
        {
            arrDel = f.GetInvocationList();
            StList.Sort();
        }
    }
}
