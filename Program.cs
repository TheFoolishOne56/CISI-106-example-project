using Microsoft.VisualBasic;

public class Person
{
    public string Name;
    public int Age;
}
public class Dog
{
    public List<string>PeopleMet;

    public void Encounter(Person person)
    {
        var isChild = person.Age <= 18;
        var isKnown = PeopleMet.Contains(person.Name);
       if (isChild||isKnown)
       {
            Console.WriteLine("person is either Child or is known, so I am friendly.");    
       }
       else
       {
            Console.WriteLine("This is an adult that i do not know");
       } 
    }
    
}