// Задайте массив строк. 
// Напишите программу, которая генерирует новый массив, объединяя элементы исходного массива попарно.

string[] PairwiseUnion(string[] array)
{
    string[] union = new string[array.Length];

    for (int i = 0; i < array.Length - 1; i = i + 2)
        union[i] = array[i] + array[i + 1];

    return union;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

string[] words = { "qwe", "wer", "ert", "rty", "tyu", "yui"};
string[] resultWords = PairwiseUnion(words);
PrintArray(resultWords);