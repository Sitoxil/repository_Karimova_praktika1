// 1 вариант
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktika6
{
    class Program
    {
        class Person
        {
            private string name;
            private string surname;
            private System.DateTime data;
            public Person(string _name, string _surname, DateTime _data)
            {
                name = _name;
                surname = _surname;
                data = _data;
            }
            public Person()
            {
                name = " ";
                surname = " ";
                data = new DateTime(0, 0, 0);
            }

          
            public string Name
            {
                get
                {
                    return name;
                }
            }

            public string Surname
            {
                get
                {
                    return surname;
                }
            }

            public DateTime Data
            {
                get
                {
                    return data;
                }
            }

            public int Year_Birth
            {
                get
                {
                    return (Int32) data.Year;
                }
                set
                {
                    data = Convert.ToDateTime(value);
                }
            }

            public override string ToString()
            {
                return surname + " " + name + " was born on " + data.ToShortDateString();
            }

            public virtual string ToShortString()
            {
                return surname + " " + name;
            }


        }
        public enum Education : int { Specialist, Вachelor, SecondEducation };

        class Exam
        {
            public string subject
            {
                get;
                set;
            }
            public int mark
            {
                get;
                set;
            }
            public System.DateTime data_ekz
            {
                get;
                set;
            }

            public Exam(string _subject, int _mark, DateTime _data_ekz)
            {
                subject = _subject;
                mark = _mark;
                data_ekz = _data_ekz;
            }
            public Exam()
            {
                subject = " ";
                mark = 0;
                data_ekz = new DateTime(0, 0, 0);
            }

            public override string ToString()
            {
                return subject + " " + "mark: " + mark + "data of exam: " + data_ekz;
            }
        }
        class Student
        {
            private Person InfStudent;
            private Education FormObuch;
            private int group_number;
            private List<Exam> exameny = new List<Exam>();

            public Student(Person p, Education e, int group)
            {
                InfStudent = p;
                FormObuch = e;
                group_number = group;
            }

            public Student()
            {
                InfStudent = new Person();
                FormObuch = new Education();
                group_number = 0;
            }

            public Person Inf
            {
                get
                {
                    return InfStudent;
                }
                set
                {
                    InfStudent = value;
                }
            }

            public Education Ed
            {
                get
                {
                    return FormObuch;
                }
                set
                {
                    FormObuch = value;
                }
            }

            public int Group
            {
                get
                { 
                        return group_number;
                }
                set
                {
                       group_number = value;
                }
            }

            public List <Exam> exam
            {
                get
                {
                    return exameny;
                }
            }
            public double AverageMark
            {
                get
                {
                    double aver_mark = 0.0;
                    int i = 0;
                    foreach (Exam mark in exameny)
                    {
                        aver_mark = aver_mark + mark.mark;
                        i++;
                    }
                    return aver_mark / i;
                }
            }

            public bool this [Education form]
            {
                get
                {
                    return form == FormObuch;
                }
            }
            public void AddExams(params Exam[] e)
            {
                exameny = e.ToList();
            }

            public override string ToString()
            {
                string ex = " ";
                for(int i = 0; i < exameny.Count; i++)
                {
                    ex += "\n" + exameny.ToString();
                }
                return "Inf: "+ InfStudent + "Forma Obucheniya: " + FormObuch + "Group: " + group_number + "Exams: " + ex;
            }

            public virtual string ToShortString()
            {
                return "Inf: " + InfStudent + "Forma Obucheniya: " + FormObuch + "Group: " + group_number + "Average: " + AverageMark;
            }
        }

        static void Main(string[] args)
        {
            Student student = new Student(new Person("Иванов", "Иван", new DateTime (2000, 1, 1)), Education.Вachelor, 20);
            Console.WriteLine(student.ToShortString());
            Console.WriteLine("");

            foreach (Education element in Enum.GetValues(typeof(Education)))
            {
                Console.WriteLine($"{element} = {student[element]}");
            }

            student.AddExams(new Exam("Math", 4, new DateTime(2019, 3, 2)),new Exam("Informatics", 5, new DateTime(2019, 6, 10)),new Exam("Information Security", 5, new DateTime(2018, 1, 18)), new Exam("History", 3, new DateTime(2019, 6, 20)), new Exam("English language", 5, new DateTime(2018, 5, 31)));
            Console.WriteLine("");
            Console.WriteLine(student.ToShortString());
        }
    }
}
