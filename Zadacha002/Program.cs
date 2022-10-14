// Сравнение двух чисел и вывод большего и меньшего
Console.Write ("Введите первое число: ");
int PervoeChislo = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите второе число: ");
int VtoroeChislo = Convert.ToInt32(Console.ReadLine());
if (PervoeChislo > VtoroeChislo) 
{
    Console.WriteLine(PervoeChislo + " > " + VtoroeChislo);
}
else 
{
    Console.WriteLine(PervoeChislo + " < " + VtoroeChislo);
}
