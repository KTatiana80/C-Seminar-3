// Задача 27: Напишите программу, которая принимает
//  на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12


int GetIntNumber()
{    
    Console.WriteLine("Введите целое число: ");

    double numDbl = 0;    
    Double.TryParse(Console.ReadLine(), out numDbl);
    return (numDbl % 1 == 0) ? (int)numDbl : 0;
}

int SumNumbers(int num)
{    
    int result = 0;
    int intPart = 0;
    int rest = 0;    
    while (num > 0)
    {
        intPart = num / 10;
        rest = num % 10;
        result = result + rest;
        num = intPart;
    }
    return result;
}

int num = GetIntNumber();
if (num <= 0)
{
    Console.WriteLine("Некорректный ввод");
    return;
}
int sum = SumNumbers(num);

Console.WriteLine("Сумма цифр числа " + num + " составила " + sum);

// Console.WriteLine($"Сумма цифр числа {num} составила {sum}");