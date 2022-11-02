int[] array = { 2, 5, 5, 11 };
int target = 10;

TwoSumClass twoSumClass = new TwoSumClass();
int[] result = twoSumClass.TwoSum(array, target);

Console.WriteLine(result[0] + " " + result[1]);

public class TwoSumClass
{
    public int[] TwoSum(int[] array, int target)
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 1; j < array.Length; j++)
            {

                if (i != j && target == array[i] + array[j])
                {
                    return new int[] { i, j };
                }
            }
        }
        return null;
    }

}