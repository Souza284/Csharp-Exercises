var ToDoList = new List<string>();
var condition = true;

Console.WriteLine("Welcome to the To Do List program");

while(condition)
{
    Console.WriteLine("\nWhat would you like to do? ");
    Console.WriteLine("Enter 1 to add a task to the list.\nEnter 2 to remove a task from the list.\nEnter 3 to view the list.\nEnter e to exit the program.");

    var option = Console.ReadLine();

    switch (option)
    {
        case "1":
        {
            Console.WriteLine("Please enter the name of the task to add to the list.");
            var task = Console.ReadLine()!;
            ToDoList.Add(task);
            Console.WriteLine("Task added to the list.  ");
            continue;
        }
        case "2":
        {
            Console.WriteLine("Please enter the number of the task that you want to remove: ");
            var numberTask = Convert.ToInt32(Console.ReadLine());

            ToDoList.RemoveAt(numberTask);

            continue;
        }
        case "3":
        {
            Console.WriteLine("Current tasks in the list: ");
            
            for (var i = 0; i < ToDoList.Count; i++)
            {
                Console.WriteLine($"{i}: {ToDoList[i]}");
            }
            continue;
        }
        case "e":
        {
            Console.Clear();
            Console.WriteLine("Thanks for using the program.");
            condition = false;
            break;
        }
    }
}