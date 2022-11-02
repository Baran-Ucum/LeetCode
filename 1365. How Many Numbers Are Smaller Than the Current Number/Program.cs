 int[] SmallerNumbersThanCurrent(int[] nums)
{
    int[] newNums = new int[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        newNums[i] = smaller(nums, i);

    }
    return newNums;

    int smaller(int[] nums, int index)
    {
        int count = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (i != index && nums[i] < nums[index])
            {
                count++;
            }
        }
        return count;
    }
}