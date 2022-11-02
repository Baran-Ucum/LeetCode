int[] nums = new int[6] { 2, 5, 1, 3, 4, 7 };
int[] newArray = new int[nums.Length];
int divideTwo = nums.Length / 2;
int k = 0;
for (int i = 0; i < divideTwo; i++)
{
    if (i < nums.Length / 2)
    {
        nums[k] = nums[i];
        nums[k + 1] = nums[i + divideTwo];
        k += 2;
    }
}
var ks = nums;