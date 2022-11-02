string[] operations = { "++X", "X++", "X++" };
int x = 0;
for (int i = 0; i < operations.Length; i++)
{

    x += getStringValue(operations[i]);
}
return x;
int getStringValue(string str)
{
    switch (str)
    {
        case "++X":
            return 1;
        case "X++":
            return 1;
        case "--X":
            return -1;
        case "X--":
            return -1;
        default:
            return 0;
    }
}
