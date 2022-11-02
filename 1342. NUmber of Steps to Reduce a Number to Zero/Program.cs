
int stepCount = 0;
var d = NumberOfSteps(14);
var b = stepCount;
int NumberOfSteps(int num)
{
    while (num != 0)
    {
        stepCount++;
        if (num % 2 == 0)
        {
            num = num / 2;
        }
        else
        {
            num = num - 1;
        }
    }
    return num;
}