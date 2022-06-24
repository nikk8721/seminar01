Console.WriteLine("Введите число A");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA > numberB)
{
    Console.Write("max = ");
    Console.WriteLine(numberA);
    Console.Write("min = ");
    Console.WriteLine(numberB);
}
else
{
    Console.Write("min = ");
    Console.WriteLine(numberA);
    Console.Write("max = ");
    Console.WriteLine(numberB);
}


