// Итоговая задача: Написать программу, которая из имеющегося массива из строк 
// формирует массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры либо задать на старте выполнения алгоритма.  
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами. 


string[] array = new string[5] { "hello", "dog", "array", "3", ";)" };
string[] newArray = new string[array.Length];

void CreateNewArray(string[] array, string[] newArray)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[count] = array[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    
    Console.WriteLine();
}

Console.WriteLine("Первоначальный массив: ");
PrintArray(array);
CreateNewArray(array, newArray);
Console.WriteLine("Массив из строк, длина которых меньше либо равна 3 символа: ");
PrintArray(newArray);

