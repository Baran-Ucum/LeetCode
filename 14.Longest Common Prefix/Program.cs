string[] strs = { "dog", "doracecar", "docar" };

string addedLetter = "";
for (int i = 0; i < FindArraySmallLength(strs); i++)
{
    if (!string.IsNullOrEmpty(Varmi(strs, i)))
    {
        addedLetter += Varmi(strs, i);
    }
    else
    {
        i = FindArraySmallLength(strs);
    }
}
Console.WriteLine(addedLetter);
 string Varmi(string[] array, int index)
{
    var letter = array[0][index];
    for (int i = 0; i < array.Length; i++)
    {
        if (letter != array[i][index])
        {
            return "";
        }
    }
    return letter.ToString();
}

 int FindArraySmallLength(string[] array)
{
    int smallLength = array[0].Length;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < smallLength)
        {
            smallLength = array[i].Length;
        }
    }
    return smallLength;
}
