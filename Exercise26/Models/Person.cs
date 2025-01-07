using System.Text.Json;

namespace Exercise26.Models
{
    internal class Person
    {
        public string? Name { get; set; }
        public int Age { get; set; }
        public long Cpf { get; set; }

        public Person(string? name, int age, long cpf)
        {
            Name = name;
            Age = age;
            Cpf = cpf;
        }
        public static void GenerateIndividualJsonFile(Person person)
        {
            string json = JsonSerializer.Serialize(person);
            string fileName = person.Name + "data";

            File.WriteAllText(fileName, json);

            Console.WriteLine(person + " data: " + Path.GetFullPath(fileName));
        }

        public static void GeneratePublicJsonFile(List<Person> people)
        {
            string json = JsonSerializer.Serialize(people);
            string fileName = "People data";

            File.WriteAllText(fileName, json);

            Console.WriteLine("People data: " + Path.GetFullPath(fileName));
        }
    }
}