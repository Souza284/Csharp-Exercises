Generic(10);
Generic("Hello, World!");
Generic(false);

void Generic<T>(T parameter)
{
    Console.WriteLine(parameter);
}