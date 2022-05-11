// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
//длина которых меньше либо равна 3 символа.

string[] array = { "hello", "2", "world", ":-)", "123", "1234", "-2", "computer science", "мир", "труд", "май"  };
//метод выводит на печать массив
void printArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
        Console.WriteLine();
}