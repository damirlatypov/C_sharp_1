Console.WriteLine("Введите номер дня в неделе");
string a_str = Console.ReadLine()!; 
int a = int.Parse(a_str); 

if (a == 1)
{
        Console.WriteLine("Понедельник");
}
    else if (a == 2)
{
        Console.WriteLine("Вторник");
}
    else if (a == 3)
{
        Console.WriteLine("Среда, маленькая пятница");
}
    else if (a == 4)
{
        Console.WriteLine("Четверг");
}
    else if (a == 5)
{
        Console.WriteLine("Питница");
}
    else if (a == 6)
{
        Console.WriteLine("Суббота");
}
    else if (a == 7)
{
        Console.WriteLine("Воскресенье");
}
    else
{
        Console.WriteLine("Ну ты фантазер!!!");
}
