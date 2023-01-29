// Задача 25: 
// Напишите цикл, который принимает на вход 
// два числа (A и B) и возводит число A в натуральную 
// степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int myPow(int a, int b)
{
    int result = a;
    for (int i = 1; i < b; i++)
    {
        result = result * a;
    }
    return result;
}

int GetIntNumber()
{
    double numDbl = 0;
    Double.TryParse(Console.ReadLine(), out numDbl);
    return (numDbl % 1 == 0) ? (int)numDbl : 0;
}

Console.WriteLine("Натуральное число: ");
int number1 = GetIntNumber();
if (number1 < 1)
{
    Console.WriteLine("Некорректный ввод");
    return;
}

Console.WriteLine("Возвести в натуральную степень: ");
int number2 = GetIntNumber();
if (number2 < 1)
{
    Console.WriteLine("Некорректный ввод");
    return;
}

int x = myPow(number1, number2);

Console.WriteLine(number1 + " в степени " + number2 + " равно " + x);
