// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
//длина которых меньше либо равна 3 символа.

//метод выводит на печать массив
void printArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
        Console.WriteLine();
}
// метод считает количество элементов для нового массива
int countElements(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
            count++;
    }
    return count;
}
// метод формирует массив из строк, 
//длина которых меньше либо равна 3 символа
string[] array3OrLessCharacters(string[] array)
{
    string[] newArray = new string[countElements(array)];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[count] = array[i];
            count++;
        }
    }
    return newArray;
}

string[] array = { "hello", "2", "world", ":-)", "123", "1234", "-2", "computer science", "мир", "труд", "май"  };
string[] resultArray = array3OrLessCharacters(array);
printArray(resultArray);