using System.ComponentModel.DataAnnotations;

public class Code
{

  public static bool ExistsIn(int[,] matrix, int value)
  {
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
        if (matrix[i, j] == value)
        {
          return true;
        }
      }
    }
    return false;
  }

  public static int[,] Transpose(int[,] matrix)
  {
    // TODO: Fix this :-)
    return new int[,] { { } };
  }
}
