// Определение четности числа
Console.Write ("Введите число для проверки: ");
int Chislo = Convert.ToInt32(Console.ReadLine());
if (Chislo %2 == 0)
{
    Console.Write ("Число " + Chislo + " является четным");
}
else
{
    Console.Write ("Число " + Chislo + " является нечетным");
}