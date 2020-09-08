using System;

namespace pr1_z1
{
  class Program
  {
    struct Person
    {
      public string firstName;
      public string lastName;
      public int age;

    }
    public string firstName;
    public string lastName;
    public int age;
  }
  public override string ToString()
  {
    return firstName + " " + lastName + ", age " + age;
  }
  // C#
  Person p = new Person("Tony", "Allen", 32); Console.WriteLine(p);

  static void Main(string[] args)
    
  
  }
}
