using UnityEngine;

// INHERITANCE: Cat inherits from Animal
public class Cat : Animal
{
    // POLYMORPHISM: override Speak() method
    public override void Speak()
    {
        Debug.Log(AnimalName + " says: Meow!");
    }
}
