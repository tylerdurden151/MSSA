//Assignment 2.2.1
/* Dsign a class hierarch of your choice. Need only class files) 
 * Pet ->
 * Dog -> 
 * Hound -> Beagle
 * Terrier -> Welsh Terrier
  Working -> Boxer */

Pet pet = new Pet("Sparky", 5);
pet.Speak();

Dog dog = new Dog("Buddy", 3);
dog.Speak();

Boxer boxer = new Boxer("Max", 4);
boxer.Speak();


class Pet
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Pet(string name, int age)
    {
        Name = name;
        Age = age;
    }
    public virtual void Speak()
    {
        Console.WriteLine("Pet makes a sound.");
    }
}
class Dog : Pet
{
    public Dog(string name, int age) : base(name, age) { }
    public override void Speak()
    {
        Console.WriteLine("Dog barks.");
    }
}
class Hound : Dog
{
    public Hound(string name, int age) : base(name, age) { }
    public override void Speak()
    {
        Console.WriteLine("Hound howls.");
    }
}
class Beagle : Hound
{
    public Beagle(string name, int age) : base(name, age) { }
    public override void Speak()
    {
        Console.WriteLine("Beagle baying.");
    }
} 
class Terrier : Dog
{
    public Terrier(string name, int age) : base(name, age) { }
    public override void Speak()
    {
        Console.WriteLine("Terrier yaps.");
    }
}
class WelshTerrier : Terrier
{
    public WelshTerrier(string name, int age) : base(name, age) { }
    public override void Speak()
    {
        Console.WriteLine("Welsh Terrier yaps loudly.");
    }
}
class Working : Dog
{
    public Working(string name, int age) : base(name, age) { }
    public override void Speak()
    {
        Console.WriteLine("Working dog barks.");
    }
}

class Boxer : Working
{
    public Boxer(string name, int age) : base(name, age) { }
    public override void Speak()
    {
        Console.WriteLine("Boxer barks loudly.");
    }
}