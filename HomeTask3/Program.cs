// 1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.


bool Palindrom (int N)
{
    // Для решения можно взять число N как масссив, перевернуть и вернуть массив в новое число NRev, затем сравнить N и NRev.
    // При равенстве это палиндром. А вот как это корректно записать - воспроооос... Но суть написания и вызова метода bool я уловила
    // Если это рабочий вариант, подскажите, пожалуйста, как записать?

    int N = Convert.ToBase64CharArray(NA);
    char NR = Array.Reverse(NA);
    int NRev = Convert.ToInt3(char NR);
    
    if (N == NRev)
        Console.Write("Yes!");
    else 
        Console.Write("No!");
}

Console.WriteLine("Input a number: ");
int N = Convert.ToInt32(Console.ReadLine());

Palindrom (N);



// 2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

/*
double DistanceAB (double xA, double yA, double zA, double xB, double yB, double zB)
{
    double dist = Math.Sqrt(Math.Pow(xA-xB, 2) + Math.Pow(yA - yB, 2) + Math.Pow(zA-zB, 2));
    return dist;
}

Console.WriteLine("Input xA: ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input xB: ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input yA: ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input yB: ");
double yB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input zA: ");
double zA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input zB: ");
double zB = Convert.ToDouble(Console.ReadLine());

double dist = Math.Round(DistanceAB(xA, yA, zA, xB, yB, zB), 3);
Console.WriteLine($"A distance is: {dist}");
*/




// 3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

/*
void Cube (int N)
{
    int result = 1;
    while (result <= N)
    {
        Console.Write(Math.Pow(result, 3) + " ");
        result ++;
    }
}

Console.WriteLine("Input a number:  ");
int N = Convert.ToInt32(Console.ReadLine());
Cube(N);
*/