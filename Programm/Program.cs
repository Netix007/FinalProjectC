/* Задача: Написать программу, которая из имеющегося массива строк форирует массив
из строк, длинна которых меньше либо равна 3 символа.
*/
 
void PrintArr (string[] arr)
{
    Console.Write($"[\"{arr[0]}\"");
    for (int i = 1; i < arr.Length; i++)
    {
        Console.Write($", \"{arr[i]}\"");
    }
    Console.Write("]");
}
 
string[] arr = { "hello", "2", "world", ":-)"};
PrintArr (arr);
Console.Write(" -> ");
int maxLength = 3;
int size = arr.Length;
string[] resultArr = new string[size];
int count = 0;
for (int i = 0; i < size; i++)
{
    if (arr[i].Length <= maxLength)
    {
        resultArr[count] = arr[i];
        count++;
    }
}
Array.Resize(ref resultArr, count);
if (count > 0)
{
    PrintArr (resultArr);
}
else
{
    Console.Write("[]");
}
Console.WriteLine();