// Вывод максимального числа среди введенных трех
Console.Write ("Введите первое число: ");
int MaxChislo = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите второе число: ");
int VtoroeChislo = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите третье число: ");
int TretieChislo = Convert.ToInt32(Console.ReadLine());
if (VtoroeChislo>MaxChislo)
{
MaxChislo = VtoroeChislo;
}
if (TretieChislo>MaxChislo)
{
    MaxChislo = TretieChislo;
}
Console.WriteLine("Максимальное число введенное Вами: " + MaxChislo);