using Xunit;
using System;

public class MathUtilTests
{
  [Fact]
  public void ExistsIn_Returns_True_When_Element_Exists()
  {
    int[,] myArray = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
    Assert.True(Code.ExistsIn(myArray, 3));
  }

  [Fact]
  public void ExistsIn_Returns_False_When_Element_Does_Not_Exist()
  {
    int[,] myArray = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
    Assert.False(Code.ExistsIn(myArray, 42));
  }

  [Fact]
  public void Transpose_Actually_Transposes()
  {
    int[,] myArray = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
    int[,] transposedArray = new int[,] { { 1, 4, 7 }, { 2, 5, 8 }, { 3, 5, 9 } };
    Assert.Equal(transposedArray, Code.Transpose(myArray));
  }

  [Fact]
  public void Product_One_By_One()
  {
    int[,] a = new int[,] { { 4 } };
    int[,] b = new int[,] { { 2 } };
    int[,] ab = new int[,] { { 8 } };
    Assert.Equal(ab, Code.Product(a, b));
  }

  [Fact]
  public void Product_Two_By_Two()
  {
    int[,] a = new int[,] { { 4, 5 }, { 6, 7 } };
    int[,] b = new int[,] { { 8, 9 }, { 10, 11 } };
    int[,] ab = new int[,] { { 82, 91 }, { 118, 131 } };
    Assert.Equal(ab, Code.Product(a, b));
  }
}
