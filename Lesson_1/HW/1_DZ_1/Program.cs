Console.WriteLine("Первое число");
string a_str = Console.ReadLine()!; 
int a = int.Parse(a_str); 
Console.WriteLine("Второе число");
string b_str = Console.ReadLine()!; 
int b = int.Parse(b_str); 

if (a == b)
{
        Console.WriteLine("числа равны");
}
    else if (a < b)
{
        Console.WriteLine(b);
}
 else if (a > b)
{
        Console.WriteLine(a);
}