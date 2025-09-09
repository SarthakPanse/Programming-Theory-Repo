using UnityEngine;

// INHERITANCE
public class Animal : MonoBehaviour
{
    // ENCAPSULATION: private field with getter/setter
    private string animalName;

    public string AnimalName
    {
        get { return animalName; }
        set { animalName = value.Length <= 10 ? value : value.Substring(0, 10); }
    }

    // ABSTRACTION: high-level method
    public void Introduce()
    {
        Debug.Log("I am an animal named " + AnimalName);
    }

    // POLYMORPHISM: virtual method to be overridden
    public virtual void Speak()
    {
        Debug.Log("Some generic animal sound");
    }
}
