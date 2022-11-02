
int[] nums = new int[4] { 1, 1, 1, 1 };
int counter = 0;
for (int i = 0; i < nums.Length; i++)
{
    for (int j = 0; j < nums.Length; j++)
    {
        if (nums[i] == nums[j] && i < j)
        {
            counter++;
        }
    }
}
Console.WriteLine(counter);