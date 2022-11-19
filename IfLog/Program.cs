int a;
int b = 2;
string c = "Mayor";
Console.WriteLine("Pleaser, enter a value");
string d = Console.ReadLine();

if (c == d)
{
    Console.WriteLine("Is the same");
}
else
{
    Console.WriteLine("Is not the same");
}

Console.WriteLine("Pleaser, enter a number");

a = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine("Is greater");
}
else
{
    Console.WriteLine("Is less");
}