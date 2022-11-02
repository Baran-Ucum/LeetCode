string address = "1.1.1.1";
//. yı[.] ile değiştir
char[] charArray = address.ToCharArray();
string newAddress = "";
for (int i = 0; i < charArray.Length; i++)
{
	if (charArray[i]=='.')
	{
		newAddress += "[.]";
	}
	else
	{
        newAddress += charArray[i].ToString();
    }
}
Console.WriteLine(newAddress);
