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

      }
      public Person()
      {
        name = " ";
        surname = " ";
        data = new DateTime(0, 0, 0);
      }

      // get и set

      public string Name
      {
        get {
          return name;
        }
      }

      public string Surname
      {
        get {
          return surname;
        }
      }

      public DateTime Data
      {
        get {
          return data;
        }
      }

      public int Year_Birth
      {
        get {
          return data.Year;
        }
        set {
          //??????????
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
        get; set;
      }

      Exam(string _subject, int _mark, DateTime _data_ekz)
      {
        subject = _subject;
        mark = _mark;
        data_ekz = _data_ekz;
      }
      Exam()
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
      private List<Exam> ex = new List<Exam>();

      Student(Person p, Education e, int group)
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
        get {
          return InfStudent;
        }
        set {
          InfStudent = value;
        }
      }

      public Education Ed
      {
        get {
          return FormObuch;
        }
        set {
          FormObuch = value;
        }
      }

      public int Group
      {
        get { return group_number; }
        set { group_number = value; }
      }

      public Exam[] exam
      {
        get {
          return ex;
        }
      }

      // индексатор
      //public bool this[Education FormObuch]
      //{
      //  bool res;
      //  if(FormObuch == )
      //  {
  }
  public double AverageMark
  {
    get {
      double aver_mark = 0.0;
      int i = 0;
      foreach (Exam mark in exam)
      {
        aver_mark = aver_mark + mark.mark;
        i++;
      }
      return aver_mark / i;
    }
  }
    void AddExams(params Exam[])
    {

    }
    public override string ToString()
    {
      return 
    }

  }
    
    
    static void Main(string[] args)
    {
      
    }
  }
}
