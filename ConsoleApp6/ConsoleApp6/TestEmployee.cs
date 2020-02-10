using System;
public class Employee
{
     public Employee()
     {
         Console.WriteLine("Constructor Invoked");
     }
    ~Employee()
    {
        Console.WriteLine("Destructor Invoked");


    }
    public void method1()
    {
        Console.WriteLine("hi good morning");
    }
   
    
    public static void Main(string[] args)
    {
        Employee e1 = new Employee();
        Employee e2 = new Employee();
        e1.method1();
        Console.ReadKey();
    }
} 
