int[] array = new int[3] { 1, 2, 1 };
int[] newArray = new int[array.Length * 2];
int j = 0;

for (int i = 0; i <= array.Length; i++)
{
    if (j != array.Length * 2)
    {
        if (i == array.Length )
        {
            i = 0;
        }
        newArray[j] = array[i];
        j++;
    }
}