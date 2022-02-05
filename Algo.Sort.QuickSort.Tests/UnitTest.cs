using Xunit;

namespace Algo.Sort.QuickSort.Tests;

public class UnitTest
{
    [Theory]
    [InlineData(new int[] { 4, 1, 2, 5, 6, 3 })]
    [InlineData(new int[] { 3, 1, -3, 0, 2, -2, -1, 4 })]
    public void AdvancedTest(int[] input)
    {
        input.QuickSort();

        int previousItem = int.MinValue;

        foreach (var item in input)
        {
            Assert.True(item > previousItem);
            previousItem = item;
        }
    }
}
