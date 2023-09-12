/*Написать программу, которая из имеющегося массива строк
формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
["Hello", "2", "world", ":-)"] ? ["2", ":-)"]
["1234", "1567", "-2", "computer science"] ? ["-2"]
["Russia", "Denmark", "Kazan"] ? []
*/

using System.Text;

void FillArray(string [] array) // заполнение массива 
{
    Console.WriteLine("Введите элементы массива с новой строки: ");
    for (int i = 0; i < array.Length; i++) // цикл для заполнения массива
    {
        array[i] = Console.ReadLine() ?? ""; // заполнение массива      
    }
}

void PrintArray(string [] array) // вывод массива
{
    Console.WriteLine();
    Console.WriteLine("Вывод элементов массива, длина которых меньше, либо равна 3 символам: ");
    for (int i = 0; i < array.Length; i++) // цикл для вывода
    {
        if (array[i].Length <= 3) // проверка длины строк 
        {
            Console.WriteLine(array[i]); // вывод
        }
    }
}

string [] array = new string [4];
FillArray(array); // заполнение массива
PrintArray(array); // вывод массива


//string [] array = {"Hello", "2", "world", ":-)"}; // массив строк 
//string [] array1 = new string [array.Length];
// int count = 0; 
// for (int i = 0; i < array.Length; i++) // цикл для склеивания строк 
// {
//     if (array[i].Length <= 3) // проверка длины строк 
//     {
//         array1[count] = array[i]; // запись в новый массив
//         count++; // увеличение счетчика
//     }
// }
// for (int i = 0; i < array1.Length; i++) // цикл для вывода
// {
//     Console.WriteLine(array1[i]); // вывод
// }