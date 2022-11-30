// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

void PrintArray(string[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1) Console.Write(", ");
    }
    Console.WriteLine(" ]");
}

string[] arrayIn = { "hello", "2", "world", ":-)" };

PrintArray(arrayIn);

int counter = 0;
for (int i = 0; i < arrayIn.Length; i++)
    if(arrayIn[i].Length <=3)
        counter++;
    
string[] arrOut = new string[counter];

int newCounter = 0;
for (int i = 0; i < arrayIn.Length; i++)
    if(arrayIn[i].Length <=3)
        arrOut[newCounter++] = arrayIn[i];

PrintArray(arrOut);


