// Программа вывода всех четных чисел от 1 до N
Console.Write ("Введите число: ");
int MaxChislo = Convert.ToInt32(Console.ReadLine());
int Schet = 1;
if (MaxChislo >= 0)
{
Console.Write ("Положительные четные числа до " + MaxChislo + " это: ");
while (Schet <= MaxChislo)
    {
    if (Schet %2 == 0)
    {
        Console.Write (Schet + " ");
    }
    Schet +=1;
    }
}
else
{
    Console.Write ("Отрицательные четные числа до " + MaxChislo + " это: ");    
    Schet = -1;
  while (Schet >= MaxChislo)
    {
    if (Schet %2 == 0)
    {
        Console.Write (Schet + " ");
    }
    Schet -=1;  
    }
}