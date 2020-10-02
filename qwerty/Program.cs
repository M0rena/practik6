using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication2
{
  class Person
  {
    
    private string name;
    private string secondname;
    private DateTime BDate;

    
    public Person(string studentname, string studentsecondname, System.DateTime studentBDate)
    {
      this.name = studentname;
      this.secondname = studentsecondname;
      this.BDate = studentBDate;
    }

    
    public Person()
    { }

    
    private string stdname;
    public string Name
    {
      get {
        return name;
      }


    }
    private string stdtsecondname;
    public string Secondname
    {
      get {
        return secondname;
      }

    }
    DateTime stdBDate
    {
      get {
        return BDate;
      }
    }

    int inststdBDate
    {
      get {
        return Convert.ToInt32(BDate);
      }

      set {
        BDate = Convert.ToDateTime(value);
      }
    }

    
    public override string ToString()
    {
      return string.Format("{0} {1}\nDate of birth: {2}", name, secondname, BDate);
    }

    
    public string ToShortString()
    {
      return "\n" + "Имя: " + name + "\n" + "Фамилия: " + secondname;
    }
    
  }
 
  enum Frequency { Weekly, Monthly, Yearly }

 
  class Article
  {
    public

    Person AboutAuthor
    { get; set; }
    string Title { get; set; }
    double Top { get; set; }

    
    public Article(Person writtername, string header, double rang)
    {
      this.AboutAuthor = writtername;
      this.Title = header;
      this.Top = rang;
    }

    
    public Article()
    {
      this.AboutAuthor = new Person();
      this.Title = "Header";
      this.Top = 1;
    }

    
    public override string ToString()
    {
      return string.Format("{0} {1}\nDate of birth: {2}", AboutAuthor, Title, Top);
    }
  }

  
  class Magazine
  {
    private string title; 
    private Frequency periodicity;
    private DateTime RDate; 
    private int circulation; 
    private Article[] list; 

   

    private Magazine(string header, Frequency rhythm, DateTime publicationdate, int quantity)
    {
      this.title = header;
      this.periodicity = rhythm;
      this.RDate = publicationdate;
      this.circulation = quantity;
    }

    
    private Magazine()
        : this("Leonardo da Vinci", new Frequency(), new DateTime(), 10000)
    { }

    
    private string header;

    public string GetName()
    {
      return title;
    }
    private Frequency rhythm;
    public Frequency Periodicity
    {
      get {
        return periodicity;
      }

    }
    DateTime publicationdate
    {
      get {
        return RDate;
      }
    }

    int quantity
    {
      get {
        return circulation;
      }
    }

    
    public Article[] Name => list;

    
  }
  static class extention
  {
    static public double Average<Article>([Article]

                    this IEnumerable<Article[]> rang,
                    Func<Article[], long> selector,
                    double Top)
    {

      {
        return Top;
      }
    }

  }
  class ArticleAttribute : Attribute
  {
  }
  class Program
  {
    static void Main()
    {

    }
  }
}