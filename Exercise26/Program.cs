using Exercise26.Models;

Person person1 = new("Pedro", 18, 09944190667);
Person person2 = new("Lorena", 17, 10868341992);
Person person3 = new("Janine", 48, 26691234812);

List<Person> people = [person1, person2, person3];

Person.GenerateIndividualJsonFile(person1);
Person.GeneratePublicJsonFile(people);
