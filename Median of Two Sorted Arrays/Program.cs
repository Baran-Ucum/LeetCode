int[] nums1 = new int[2] { 1, 3 };
int[] nums2 = new int[1] { 2 };

int[] sortedArray = new int[nums1.Length + nums2.Length];
int[] sortedList = new int[nums1.Length + nums2.Length];

int temp = 0;
sendArray(nums1);
sendArray(nums2);

void sendArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        sortedArray[temp] = array[i];
        temp++;
    }
}
var k = sortedArray;
