Console.WriteLine("Введите число A");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число С");
int numberC = Convert.ToInt32(Console.ReadLine());
int maxCh = numberA;
if (numberA > maxCh)
{
    maxCh = numberA;
}
if (numberB > maxCh)
{
    maxCh = numberB;
}
if (numberC > maxCh)
{
    maxCh = numberC;
}
Console.Write("Максимальное число = ");
Console.WriteLine(maxCh);

