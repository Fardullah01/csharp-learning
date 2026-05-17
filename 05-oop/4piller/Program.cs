using System;
using System.Diagnostics;
abstract class animal{
    int age;
    public animal( int age)
    {
        this.age=age;
    }
    public abstract void sound();
    public static void show()
    {
        Console.WriteLine("Animal class Details ");
    }
    public virtual void display()
    {
        Console.WriteLine("Animal class ");
    }
}
class dog  : animal
{
    string name;
    public dog(string name,int age):base(age)
    {
        this.name=name;
    }
    public override void sound()
{
    Console.WriteLine("ghew ghew....");
}
public override void display()
    {
        Console.WriteLine("Dog class ");
    }
}
class cat :animal{
  string name;
    public cat(string name,int age):base(age)
    {
        this.name=name;
    }

    public override void sound()
    {
        Console.WriteLine("Meow mwow....");
    }

    public override void display()
    {
        Console.WriteLine("Cat class ");
    }
}
class Program
{
    public static void Main()
    {
        Console.WriteLine("Inheritenece in C#");
        dog myDog = new dog("buddy", 5);
        cat myCat = new cat("bilai", 3);
        myDog.sound();
        myCat.sound();
        myDog.display();
        myCat.display();
        animal.show();
    }
}
