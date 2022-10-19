// Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


string[] arrayStringInit = { "Hello", "2", "world", ":-)" };
string[] arrayStringResult = new string[GetNumStringsLessOrEqual3(arrayStringInit)];
FillArrayStringsLessOrEqual3(arrayStringInit, arrayStringResult);
System.Console.WriteLine("'{0}'", string.Join("', '", arrayStringResult));

int GetNumStringsLessOrEqual3(string[] arrayString)
{
    int nResultMassLength = 0;
    for (int i = 0; i < arrayString.Length; i++)
        if (arrayString[i].Length <= 3) nResultMassLength++;
    return nResultMassLength;
}

void FillArrayStringsLessOrEqual3(string[] arrayStringInit, string[] arrayStringResult)
{
    int j = 0;

    for (int i = 0; i < arrayStringInit.Length; i++)
    {
        if (arrayStringInit[i].Length <= 3)
        {
            arrayStringResult[j] = arrayStringInit[i];
            j++;
        }
    }
}
