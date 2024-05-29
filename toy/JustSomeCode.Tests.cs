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

  [Fact]
  public void IsMagicSquareTrue()
  {
    int[,] a = new int[,] {
      {16, 2, 3, 13},
      {5, 11, 10, 8},
      {9, 7, 6, 12},
      {4, 14, 15, 1}};
    int[,] b = new int[,] {
      {8, 1, 6},
      {3, 5, 7},
      {4, 9, 2}
    };
    Assert.True(Code.IsMagicSquare(a));
    Assert.True(Code.IsMagicSquare(b));
  }

  [Fact]
  public void IsMagicSquareFalse()
  {
    int[,] a = new int[,] {
      {16, 2, 3, 13},
      {5, 11, 10, 8},
      {9, 7, 6, 12},
      {4, 14, 15, 0}};
    int[,] b = new int[,] {
      {8, 1, 6},
      {3, 5, 7},
      {4, 9, 1}
    };
    Assert.False(Code.IsMagicSquare(a));
    Assert.False(Code.IsMagicSquare(b));
  }

  [Fact]
  public void IsBubbleSorted()
  {
    int Min = 0;
    int Max = 200;
    int Elements = 6;
    Random randNum = new Random();
    int[] a = Enumerable
        .Repeat(0, Elements)
        .Select(i => randNum.Next(Min, Max))
        .ToArray();
    int[] sortedA = (int[])a.Clone();
    Array.Sort(sortedA);
    Assert.Equal(sortedA, Code.BubbleSorted(a));
  }
}
