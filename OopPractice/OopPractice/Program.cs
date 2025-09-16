using OopPractice.com.StudentManagment;
using System;
using System.Reflection;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;





//abstract class Account
//{
//    public int AccountNumber;
//    public double Balance; 

//    public abstract void Deposit(double amount);
//    public abstract void Withdraw(double amount);
//    public void ShowBalance()
//    {
//        Console.WriteLine($"Account {AccountNumber} Balance: {Balance}");
//    }
//}
//class SavingAccount : Account
//{
//    public override void Deposit(double amount)
//    {
//        if(amount > 0)
//        {
//            Balance += amount;
//            Console.WriteLine("your deposit is succesful!");
//        }
//        else
//        {
//            Console.WriteLine("invalid amount.");
//        }
//    }
//    public override void Withdraw(double amount)
//    {
//        if(Balance > 0 && Balance - amount >= 1000)
//        {
//            Balance -= amount;
//            Console.WriteLine($"Withdraw: {amount} Succesfull.");
//        }
//        else
//        {
//            Console.WriteLine("Insufficient balance! (Min 1000 required)");
//        }
//    }
//}
//class CurrentAccount : Account
//{
//    public override void Deposit(double amount)
//    {
//        if (amount > 0)
//        {
//            Balance += amount;
//            Console.WriteLine($"Deposited {amount} successfully!");
//        }
//        else
//        {
//            Console.WriteLine("Invalid deposit amount.");
//        }
//    }

//    public override void Withdraw(double amount)
//    {
//        if (amount > 0 && amount <= Balance)
//        {
//            Balance -= amount;
//            Console.WriteLine($"Withdrawn {amount} successfully!");
//        }
//        else
//        {
//            Console.WriteLine("Insufficient balance!");
//        }
//    }
//}
//class Program
//{
//    static void Main(string[] args)
//    {
//        // Savings account
//        SavingAccount sAcc = new SavingAccount();
//        sAcc.AccountNumber = 101;
//        sAcc.Deposit(5000);
//        sAcc.Withdraw(3000);
//        sAcc.ShowBalance();

//        // Current account
//        CurrentAccount cAcc = new CurrentAccount();
//        cAcc.AccountNumber = 202;
//        cAcc.Deposit(8000);
//        cAcc.Withdraw(5000);
//        cAcc.ShowBalance();
//    }
//}


//abstract class Shapes
//{
//    public abstract void area();
//}
//class Circle : Shapes
//{
//    public double radius;
    
//    public override void area()
//    {
//        double circle = 3.14 * radius * radius;
//        Console.WriteLine($"Circle Area: {circle}");
//    }
//}
//class Rectangular : Shapes
//{
//    public double length;
//    public double width;

//    public override void area()
//    {
//        double rectangular = length * width;
//        Console.WriteLine($"Rectangular Area: {rectangular}");
//    }
//}
//class Program{
//    static void Main(string[] args)
//    {
//        Circle c = new Circle();
//        c.radius = 10.5;
//        c.area();

//        Rectangular r = new Rectangular();
//        r.width = 156;
//        r.length = 100;
//        r.area();
        
//    }
//}



//class Application
//{
//    public virtual void turnOn()
//    {
//        Console.WriteLine("Turn on the electronics");
//    }
//}
//class Fan : Application
//{
//    public override void turnOn()
//    {
//        Console.WriteLine("Fan is spinning.");
//    }
//}
//class Light : Application
//{
//    public override void turnOn()
//    {
//        Console.WriteLine("Light is glowing.");
//    }
//}
//class Ac : Application
//{
//    public override void turnOn()
//    {
//        Console.WriteLine("Ac is cooling.");
//    }
//}
//class Problem
//{
//    static void Main(string[] args)
//    {
//        Application fan = new Fan();
//        fan.turnOn();

//        Application light = new Light();
//        light.turnOn();

//        Application Ac = new Ac();
//        Ac.turnOn();
//    }
//}




//class Vehical
//{
//    public virtual void drive()
//    {
//        Console.WriteLine("vehical is ready to drive.");
//    }
//}
//class Car : Vehical
//{
//    public override void drive()
//    {
//        Console.WriteLine("Car is driven.");
//    }
//}
//class Bike : Vehical
//{
//    public override void drive()
//    {
//        Console.WriteLine("Bike is driven.");
//    }
//}
//class Problem
//{
//    static void Main(string[] args)
//    {
//        Vehical v1 = new Vehical();
//        v1.drive();

//        Vehical v2 = new Car();
//        v2.drive();

//        Vehical v3 = new Bike();
//        v3.drive();
//    }
//}









//class Printer
//{
//    public void print(string x)
//    {
//        Console.WriteLine(x);
//    }
//    public void print(int y) {
//        Console.WriteLine(y); 
//    }
//    public void print(string x, int y)
//    {
//        Console.WriteLine(x + y);
//    }
//}
//class Program
//{
//    static void Main(string[] args)
//    {
//        Printer p = new Printer();
//        p.print("umair");
//        p.print(45);
//        p.print("ali", 55);
//    }
//}


//class Calculater
//{
//    public int add(int x, int y)
//    {
//        return x + y;
//    }
//    public double add(double x, double y)
//    {
//        return x + y;
//    }
//    public int add(int a,int b,int c)
//    {
//        return a + b + c;
//    }
//}
//class Program
//{
//    static void Main(string[] args)
//    {
//        Calculater cal = new Calculater();


//        Console.WriteLine("Add 2 integers: " + cal.add(5, 10));
//        Console.WriteLine("Add 2 doubles: " + cal.add(2.5, 3.5));
//        Console.WriteLine("Add 3 integers: " + cal.add(1, 2, 3));
//    }
//}








//class Person
//{
//    protected int id = 154;
//    public string name ;
//    internal int age ;
//}
//class Student : Person
//{
//    public string department;
//    private double gpa;

//    public void ShowStudentInfo()
//    {
//        Console.WriteLine("Name: "+name);
//        Console.WriteLine("Age: "+ age);
//        Console.WriteLine("Department: "+ department);
        
//    }
//}
//class Teacher : Person
//{
//    public string Subject;
//    protected int salary;

//    public void ShowTeacherInfo()
//    {
//        Console.WriteLine("Name: " + name);
//        Console.WriteLine("Age: " + age);
//        Console.WriteLine("Subject: "+Subject);
//        Console.WriteLine("Salary: "+ salary);
//    }
//}
//class Program
//{
//    static void Main(string[] args)
//    {
//       Student s1 = new Student();
//        Console.WriteLine("Enter student name");
//        s1.name = Console.ReadLine();
//        Console.WriteLine("enter student age");
//        s1.age = int.Parse(Console.ReadLine());
//        Console.WriteLine("Enter student department");
//        s1.department = Console.ReadLine();

//        s1.ShowStudentInfo();

//        Teacher t1 = new Teacher();
//        Console.WriteLine("Enter teacher subject");
//        t1.Subject = Console.ReadLine();
//        Console.WriteLine("Enter teacher name");
//        t1.name = Console.ReadLine();
//        Console.WriteLine("Enter teacher age");
//        t1.age = int.Parse(Console.ReadLine());
        
//        t1.ShowTeacherInfo();

//    }
//}



//class Vehical
//{
//    public string brand;
//}
//class Car : Vehical
//{
//    public int model;
//}
//class ElectricCar : Car
//{
 //{1} Battery Capacity: {2}", brand,model,battery_Capacity);
//    }
//}
//class Program
//{
//    static void Main(string[] args)
//    {
//        ElectricCar e = new ElectricCar();
//        e.brand = "BYD";
//        e.model = 2025;
//        e.battery_Capacity = "200 kwh";
//        e.show();
//    }
//}



//class Person
//{
//    public string name;
//    public int age;
//}
//class Employee : Person
//{
//    public int salary;

//    public void show()
//    {
//        Console.WriteLine("Name: {0} Age: {1} Salary: {2}", name, age, salary);
//    }
//}
//class Program
//{ 
//    static void Main(string[] args)
//    {
//        Employee emp = new Employee();
//        emp.name = "Umair";
//        emp.salary = 1000000;
//        emp.age = 18;

//        emp.show();
//    }
//}
