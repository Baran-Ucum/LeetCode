string[] sentences = { "alice and bob love leetcode", "i think so too", "this is great thanks very much" };
var maximumNumberSentence = 0;
for (int i = 0; i < sentences.Length; i++)
{
    var count = 0;
    for (int j = 0; j < sentences[i].Length; j++)
    {
        if (sentences[i][j].ToString() == " ")
        {
            count++;
        }
    }
    if (count > maximumNumberSentence)
    {
        maximumNumberSentence = count;
    }
    
}
Console.WriteLine(maximumNumberSentence);