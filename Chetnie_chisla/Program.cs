Console.WriteLine("Введите число ");
int numberA = Convert.ToInt32(Console.ReadLine());
if (numberA % 2 == 1)
{
    numberA = numberA - 1;
}
while (numberA > 2)
{
    numberA = numberA - 2;
    Console.WriteLine(numberA);
}

