//int[] array=new int[7];
//int[] array2=new int[7];

//Random Random = new Random();

#region Diziyi tersten yazma
//for (int i = 0; i < array.Length; i++)
//{
//    array[i]=Random.Next(9);
//    array2[(array2.Length - 1) - i] = array[i];
//}
//for (int i = 0; i < array.Length; i++)
//{
//    Console.Write(array[i]);
//    Console.Write(array2[i]);
//}
#endregion

#region sayiyi diziye çevirme

int sayi = 121;

#endregion

Palindrome Palindrome = new Palindrome();
bool palindromeResult = Palindrome.IsPalindrome(121);

Console.WriteLine(palindromeResult);

public class Palindrome
{
    public bool IsPalindrome(int x)
    {
        x = 1000021;
        int[] dizi = x.ToString().Select(o => Convert.ToInt32(o) - 48).ToArray();

        for (int i = 0; i < dizi.Length; i++)
        {
            if (dizi[i] != dizi[(dizi.Length - 1) - i])
            {
                return false;
            }
        }
        return true;
    }
}


