int max=0;
Console.WriteLine("Первое число");
string a_str = Console.ReadLine()!; 
int a = int.Parse(a_str); 
Console.WriteLine("Второе число");
string b_str = Console.ReadLine()!; 
int b = int.Parse(b_str); 
Console.WriteLine("Третье число");
string c_str = Console.ReadLine()!; 
int c = int.Parse(c_str); 
if (a >= b)
{
       max = a;
}
    else
{
max = b;
}
    
    
    if (max >= c)
{
        Console.WriteLine("максимальное число");
        Console.WriteLine(max);
}
 else 
{
        max = c;
        Console.WriteLine("максимальное число");
        Console.WriteLine(max);
}