string[,] strArrays = new string[8, 2];
string s = "codeleet";
int[] indices = new int[8] { 4, 5, 6, 7, 0, 2, 1, 3 };
Dictionary<int, char> list = new Dictionary<int, char>();

string str = "";
for (int i = 0; i < indices.Length; i++)
{
    list.Add(indices[i], s[i]);
}
for (int i = 0; i < list.Count; i++)
{
    str += list[i];
}
Console.WriteLine(str);