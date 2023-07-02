Console.Write("Введите число: ");
string a_str = Console.ReadLine()!; 
int a = int.Parse(a_str); 
int a_abs = Math.Abs(a);
if (a_abs % 2==1)
{
Console.WriteLine("Число нечетное");
}
else
{
Console.WriteLine("Число четное");
}
 
