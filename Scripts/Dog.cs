using UnityEngine;

// INHERITANCE: Dog inherits from Animal
public class Dog : Animal
{
    // POLYMORPHISM: override Speak() method
    public override void Speak()
    {
        Debug.Log(AnimalName + " says: Woof!");
    }
}
