int[] array = new int[4] { 1, 1, 1, 1 };
int[] array2 = new int[4];
int endValue = 0;
for (int i = 0; i < array.Length; i++)
{
    endValue = array[i] + endValue;
    array[i] = endValue;
}