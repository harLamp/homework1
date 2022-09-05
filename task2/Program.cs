//Максимальное из трех чисел
Console.WriteLine("Введите число 1");

string frstnum = Console.ReadLine (); // ввод

int a = int.Parse (frstnum); // число

Console.WriteLine ("Введите число 2");

string scndnum = Console.ReadLine (); // ввод

int b = int.Parse (scndnum); // число

Console.WriteLine("Введите число 3");

string trdnum = Console.ReadLine (); // ввод

int c = int.Parse (trdnum); // число

if (a > b) {

    if (a > c) {

        Console.Write($"Число {a} самое большое");
    }
    else {

        Console.Write($"Число {c} самое большое");
    }
}
else {
    if (b > c){

       Console.Write($"Число {b} самое большое"); 

    }
    else {
        
        Console.Write($"Число {c} самое большое");
    }
}