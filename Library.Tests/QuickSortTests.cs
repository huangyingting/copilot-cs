using Xunit;
using CopilotCsharp.Library;
namespace CopilotCsharp.Library.Tests;


public class QuickSortTests
{
    [Fact]
    public void QuickSort_UnsortedArray()
    {
        // Arrange
        var array = new int[] { 5, 2, 1, 8, 4 };
        var expected = new int[] { 1, 2, 4, 5, 8 };

        // Act
        Sort.QuickSort(array);

        // Assert
        Assert.Equal(expected, array);
    }

    [Fact]
    public void QuickSort_ArrayWithDuplicates()
    {
        // Arrange
        var array = new int[] { 5, 2, 1, 2, 4 };
        var expected = new int[] { 1, 2, 2, 4, 5 };

        // Act
        Sort.QuickSort(array);

        // Assert
        Assert.Equal(expected, array);
    }

    [Fact]
    public void QuickSort_EmptyArray()
    {
        // Arrange
        var array = new int[] { };
        var expected = new int[] { };

        // Act
        Sort.QuickSort(array);

        // Assert
        Assert.Equal(expected, array);
    }

    [Fact]
    public void QuickSort_SingleElementArray()
    {
        // Arrange
        var array = new int[] { 1 };
        var expected = new int[] { 1 };

        // Act
        Sort.QuickSort(array);

        // Assert
        Assert.Equal(expected, array);
    }
}