Console.WriteLine("Введите значение а ");
string a_str = Console.ReadLine()!; 
int a = int.Parse(a_str); 
Console.WriteLine("Введите значение b ");
string b_str = Console.ReadLine()!; 
int b = int.Parse(b_str); 
if (a == b*b)
{
        Console.WriteLine("да");
}
    else
{
        Console.WriteLine("нет");
}
