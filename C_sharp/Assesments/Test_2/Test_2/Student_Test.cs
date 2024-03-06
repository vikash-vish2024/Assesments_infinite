using System;

abstract class Student
{
    public string Student_Name { get; set; }
    public int Student_Id { get; set; }
    public double Grade { get; set; }

    // Abstract method 
    public abstract bool IsPassed(double grade);
}

class Undergraduate : Student
{
    //Parametrized constructor
    public Undergraduate(string Student_Name, int Student_Id, double Grade)
    {
        this.Student_Name = Student_Name;
        this.Student_Id = Student_Id;
        this.Grade = Grade;
    }

    public override bool IsPassed(double Grade)
    {
        return Grade > 70.0;
    }
}

class Graduate : Student
{
  
    public Graduate(string Student_Name, int Student_Id, double Grade)
    {
        this.Student_Name = Student_Name;
        this.Student_Id = Student_Id;
        this.Grade = Grade;
    }


    public override bool IsPassed(double Grade)
    {
        return Grade > 80.0;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Undergraduate class
        Undergraduate undergraduate = new Undergraduate("Vikash Vishwkarma", 101, 71 );
        Console.WriteLine($"{undergraduate.Student_Name} Passed: {undergraduate.IsPassed(undergraduate.Grade)}");

        // Graduate class
        Graduate graduate = new Graduate("Vikash vishwakarma", 102, 87);
        Console.WriteLine($"{graduate.Student_Name} Passed: {graduate.IsPassed(graduate.Grade)}");
    }
}