using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Task3._1
{
    class BusinessLogic
    {
        public static ListViewItem[] GetLvi()
        {
            return Student.StList.Select(x => new[] { x.FirstName, x.LastName,
                x.Age.ToString(), x.Faculty.ToString(), x.Course.ToString(), x.AverageGrade.ToString() })
                .Select(x => new ListViewItem(x))
                .ToArray();
        }

        public static List<Func<Student, Student, int>> GetDelList()
        {
            Func<Student, Student, int> f1 = (Student st1, Student st2) => st1.FirstName.CompareTo(st2.FirstName);
            List<Func<Student, Student, int>> list = new List<Func<Student, Student, int>>();
            list.AddRange(new Func<Student, Student, int>[] { 
                f1,
                (Student st1, Student st2) => st1.LastName.CompareTo(st2.LastName),
                (Student st1, Student st2) => st1.Age.CompareTo(st2.Age),
                (Student st1, Student st2) => st1.Faculty.CompareTo(st2.Faculty),
                (Student st1, Student st2) => st1.Course.CompareTo(st2.Course),
                (Student st1, Student st2) => st1.AverageGrade.CompareTo(st2.AverageGrade)                
            });
            return list;
        }
    }
}
