//Task 1
Console.WriteLine("Введите два числа");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB)
{
    Console.Write("max, ");
    Console.Write(numberA);
}
else
{
    if (numberA == numberB)
    {
        Console.WriteLine("Числа равны");
    }
    else
    {
        Console.Write("max, ");
        Console.Write(numberB);
    }
}