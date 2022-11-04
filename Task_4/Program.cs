Console.WriteLine("Введите число");
//Введенное число будет границей исчислений.

int a = Convert.ToInt32(Console.ReadLine());


for (int i = 1; i <= a; i ++)
{
    if  (i % 2 ==0)
    Console.WriteLine(Convert.ToInt32(i));
}