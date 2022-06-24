Console.WriteLine("Введите число ");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberR = 0; 
if (numberA % 2 == 1)
{
    numberA = numberA - 1;
}
while (numberA > 0)
{
    numberR = numberR + 2;
    Console.Write(numberR);
    Console.Write(",");
    numberA = numberA - 2;
}

