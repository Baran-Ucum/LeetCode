
var d = IsToeplitzMatrix();
var b =d;
bool IsToeplitzMatrix()
{
    int[,] matrix = new int[2, 2] { { 1, 2 },{ 2, 2 } };
    bool val = true;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i != matrix.GetLength(0) - 1 && j != matrix.GetLength(1) - 1)
            {
                if (matrix[i, j] != matrix[i + 1, j + 1])
                {
                    val = false; break;
                }
            }

        }
    }
    return val;
}