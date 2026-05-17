using System;
class Animal
{
    int age;
    public Animal( )
    {
    
    }
    public Animal( int age)
    {
        this.age = age;
    }
    public void display()
    {
        Console.WriteLine("Age: " + age);
    }
}
class Dog: Animal
{
    string name;
    public Dog( ):base ()
    {
       
    }
    public Dog(int age, string name):base (age)
    {
        this.name=name;
    }
    public void display()
    {
        base.display();
        Console.WriteLine("Name: " + name);
    }
}
class Cat: Animal
{
    string name;
    public Cat( ):base ()
    {
       
    }
    public Cat(int age, string color):base (age)
    {
        this.name=name;
    }
    public void display()
    {
        base.display();
        Console.WriteLine("name : " + name);
    }
}

class Program
{
    static void Main()
    {
        Animal A1=new Animal (5);
        A1.display();
        Dog d1=new Dog(3,"kutta");
        d1.display();
        Cat c1=new Cat(2,"billi");
        c1.display();
        
    }
}