// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

// Метод выводит в консоль строковый массив через запятую
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
// Метод считает количество элементов, равных или короче param
int CountElemsLessThen(string[] array, int param)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i].Length <= param)
            counter++;
    return counter;
}
// Метод возвращает массив строк, равных или короче param
string[] SelectLessStr(string[] array, int param)
{
    string[] arrOut = new string[CountElemsLessThen(array, param)];
    int newCounter = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i].Length <= 3)
            arrOut[newCounter++] = array[i];
    return arrOut;
}


string[] arrayIn = { "hello", "2", "world", ":-)" };    // Создаем массив разных строк

PrintArray(arrayIn);                                    // Выводим этот массив

string[] less3str = SelectLessStr(arrayIn, 3);          // В новый массив отбираем строки, равные или короче 3

PrintArray(less3str);                                   // Выводим этот массив
