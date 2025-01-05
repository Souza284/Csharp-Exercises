public class MainProgram
{
    static void Main(string[] args)
    {
        var age01 = Convert.ToInt32(Console.ReadLine());
        Person guy01 = new Person();
        guy01.GreetPerson();
        guy01.SetAge(age01);

        Console.ReadKey();

        var age02 = Convert.ToInt32(Console.ReadLine());
        Student guy02 = new Student();
        guy02.GreetStudent();
        guy02.SetAge(age02);

        Console.ReadKey();

        var age03 = Convert.ToInt32(Console.ReadLine());
        Professor guy03 = new Professor();
        guy03.GreetProfessor();
        guy03.SetAge(age03);

    }
}

public class Person
{
    public void GreetPerson()
    {
        Console.WriteLine("Hello! I'm a person.");
    }

    public void SetAge(int _age01)
    {
        Console.WriteLine("My age is " + _age01 + " years old");
    }

}

public class Student
{
    public void GreetStudent()
    {
        Console.WriteLine("Hello! I'm a student.");
    }
    public void SetAge(int _age02)
    {
        Console.WriteLine("My age is " + _age02 + " years old");
    }
}

public class Professor
{
    public void GreetProfessor()
    {
        Console.WriteLine("Hello! I'm a professor.");
    }

    public void SetAge(int _age03)
    {
        Console.WriteLine("My age is " + _age03 + " years old.");
    }
}
