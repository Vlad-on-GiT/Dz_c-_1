// Напишите функцию, которая принимает на вход число и выдает
// сумму цифр в числе.
// А что если попробовать преобразовать в массив строку...
// Юху!!! 4 часа на это убил, пойду поделюсь с ребятами!

System.Console.WriteLine("Введите число: ");
string chislo = Console.ReadLine()!;
int length = chislo.Length;
int[] array = new int[length];
int sum = 0;

for (int i = 0; i < length; i++)
{
    array[i] = (int)char.GetNumericValue(chislo[i]);
    sum += array[i];
}
System.Console.WriteLine(sum);
