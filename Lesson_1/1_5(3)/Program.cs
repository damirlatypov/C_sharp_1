Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine()!);
int count = -a;
    Console.WriteLine("Результ:");
    Console.WriteLine(count);
while (count!=a){
    if (a>0)
    count++;
    else
    count--;
    Console.WriteLine(count);
}
