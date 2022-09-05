//Определяет четное или нечетное.
Console.WriteLine("Введите число ");

string num = Console.ReadLine (); // ввод

int n = int.Parse (num); // число

if (n == 0) {

    Console.Write($"Ввели число {n}, введите другое число");

}
else {
    if (n % 2 ==0) {

        Console.Write($"Число {n} четное");
    }

    else {
        Console.Write($"Число {n} нечетное");
    }
}