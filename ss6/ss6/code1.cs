using System;
    class Animal
{
    public void Eat() {
        Console.WriteLine("Evaery animal eats something");
    }
}

class Mamnal : Animal
{
    public void Feature()
    {
        Console.WriteLine("Mammals give birth to young ones ");
    }
}

class Dog : Mamnal
{
    public void Noise()
    {
        Console.WriteLine("dogBarks");
    }
    static void Main(string[] args)
    {
        Dog objDog = new Dog();
        objDog.Eat();
        objDog.Feature();
        objDog.Noise();
    }
}
