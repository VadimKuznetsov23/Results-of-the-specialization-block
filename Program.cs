/* Задача: написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
Примеры:
["hello", "2", "world", ":-)"] -> ["2", ":-)"] 
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> [] */

string[] arr = {"вк", "Russia", "три", "world", ":-)", "4521", "-2", "Kazan", "33"};
void PrintEnteredArray(string[] newArr)
{
    Console.Write("Заданный массив: [");
    for (int i =0; i < newArr.Length; i++)
    {
        if (i < newArr.Length-1) Console.Write($"{newArr[i]}, ");
        else Console.Write($"{newArr[i]}");
    }
    Console.Write("]");
    Console.WriteLine();
}
void PrintFinalArray(string[] newArr)
{
    Console.Write("Строки заданного массива, длина которых меньше либо равна 3 символам: [");
    for (int i =0; i < newArr.Length; i++)
    {
        if (newArr[i].Length <= 3)
        {
            if (i < newArr.Length-1) Console.Write($"{newArr[i]}, ");
            else Console.Write($"{newArr[i]}");
        }
    }
    Console.Write("]");
    Console.WriteLine();
}
Console.WriteLine("*****************");
PrintEnteredArray(arr);
PrintFinalArray(arr);
Console.WriteLine("*****************"); 
