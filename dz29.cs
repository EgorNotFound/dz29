/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */
Console.WriteLine();
Console.WriteLine();
int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");

int AckermannFunction (int k, int l)
{
    if (m == 0) return l + 1;
    if (m != 0 && l == 0) return AckermannFunction(m - 1, 1);
    if (m > 0 && l > 0) return AckermannFunction(m - 1, AckermannFunction (m,n - 1));
return AckermannFunction(k, l);
}

Console.WriteLine($"Функция Аккермана для чисел A({m},{n}) = {AckermannFunction(m, n)}");