using System.ComponentModel.DataAnnotations;

public class Code
{

  // Returns true if value exists in matric,
  // false otherwise
  public static bool ExistsIn(int[,] matrix, int value)
  {
    // TODO: Implement this :-)
    return false;
  }

  // Returns the transposed matrix
  public static int[,] Transpose(int[,] matrix)
  {
    // TODO: Implement this :-)
    return new int[,] { { } };
  }

  // Returns the product of the matrices
  public static int[,] Product(int[,] a, int[,] b)
  {
    // TODO: Implement this :-)
    return new int[,] { { } };
  }

  // Returns whether this is a magic square
  // (sum of columns = sum of rows = sum of diagonals)
  public static bool IsMagicSquare(int[,] a)
  {
    // TODO: Implement this :-)
    return false;
  }

  // Returns a bubble sorted array. From wikipedia:
  // tri_à_bulles(Tableau T)
  //  pour i allant de (taille de T)-1 à 1
  //      pour j allant de 0 à i-1
  //          si T[j+1] < T[j]
  //              (T[j+1], T[j]) ← (T[j], T[j+1])
  public static int[] BubbleSort(int[] a)
  {
    // TODO: Implement this :-)
    return Array.Empty<int>();
  }
}
