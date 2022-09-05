// Показывает все четные числа до n.
Console.WriteLine("Введите число");

string num = Console.ReadLine (); // ввод

int n = int.Parse (num); // число
int i = 0;
if (n < i) 
{
        Console.WriteLine("Введите другое число");
}
else
{
    for (i = 0; i <= n; i += 2)
    {
        Console.Write($" {i}");
    }
}