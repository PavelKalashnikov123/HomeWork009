//Задача 68: Напишите программу вычисления функции Аккермана 
//с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.WriteLine("Введите два положительных числа: M и N.");
int n = InputInt("Введите N: ");
int m = InputInt("Введите M: ");
Console.WriteLine($"A({n}, {m}) = {Akkerman(n, m)}");

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine()!);
}

int Akkerman(int n, int m)
{
    if (n == 0)
        return m + 1;
    if (n > 0 && m == 0)
        return Akkerman(n - 1, 1);
    else
        return Akkerman(n - 1, Akkerman(n, m - 1));
}