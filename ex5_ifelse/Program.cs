Console.WriteLine("Input YOUR name!");
string username = Console.ReadLine();
if (username.ToLower() == "nikita")
{
    Console.WriteLine("Hello, Nikita!");
    Console.WriteLine("Glad to see you again!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}