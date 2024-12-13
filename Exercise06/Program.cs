public class MainProgram
{
    static void Main(string[] args)
    {
        var people = new string[3];

        for (var i = 0; i < 3; i++)
        {
            people[i] = Console.ReadLine()!;
        }

        foreach (var person in people)
        {
            Person name = new(person);
            name.MyName();
        }


    }
}

public class Person
{
    public string Name {set; get;}
    
    public Person(string _name)
    {
        Name = _name;
    }

    public void MyName()
    {
     Console.WriteLine("Hello! My name is " + Name);
    }
}