int[,] accounts = new[,] { { 1,2,3 }, {3,2,1 } ,};

int[] kiyaslanacakDegerler = new int[accounts.GetLength(0)];
for (int i = 0; i < accounts.GetLength(0); i++)
{
    var sum = 0;
    for (int j = 0; j < accounts.GetLength(1); j++)
    {
        sum = sum + accounts[i, j];

    }
    kiyaslanacakDegerler[i] = sum;

}
var kiyasla = kiyaslanacakDegerler[0];
for (int i = 0; i < kiyaslanacakDegerler.Length; i++)
{
    if (kiyasla < kiyaslanacakDegerler[i])
    {
        kiyasla = kiyaslanacakDegerler[i];
    }
}
Console.WriteLine(kiyasla);