// Задача 29: Напишите программу, которая задаёт 
// массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33

int[] GenerateArray(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

string ArrayToString(int[] arr)
{
    string original = String.Join(", ", arr);
    string parentheses = "[" + original + "]";
    return original + " -> " + parentheses;
}
int[] array = GenerateArray(8, 0, 25);

Console.WriteLine(ArrayToString(array));
