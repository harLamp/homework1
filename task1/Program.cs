// Определяет какое число меньшее и большее
Console.WriteLine("Введите число 1");

string frstnum = Console.ReadLine (); // ввод

int a = int.Parse (frstnum); // число

Console.WriteLine ("Введите число 2");

string scndnum = Console.ReadLine (); // ввод

int b = int.Parse (scndnum); // число

if(a < b){
    Console.Write($"min{a} max{b}");
}
else if (a > b){
    Console.Write($"min{b} max{a}");
}
