//  Задайте массив строк.
// Напишите программу, считает кол-во слов в массиве, начинающихся на гласную букву.

int WordsStartingVowel(string[] array)
{
    string[] vowels = { "a", "e", "i", "o", "u", "y" };

    int count = 0;
    for (int i = 0; i < array.Length; i++)
        for(int j = 0; j < vowels.Length; j++)
            {
                if(array[i][0].ToString() == vowels[j]) count++;
            }
    
    return count;

}

string[] words = { "qwe", "wer", "ert", "try", "tyu"};
Console.WriteLine($"Количество слов в массиве, начинающихся на гласную букву: {WordsStartingVowel(words)}");