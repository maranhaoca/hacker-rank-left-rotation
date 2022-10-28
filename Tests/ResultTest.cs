using System.Collections.Generic;
using Xunit;
using Src;

namespace Tests;

public class ResultTest
{
    [Fact]
    public void Test1()
    {
        int d = 2;
        var arr = new List<int> { 1, 2, 3, 4, 5 };

        List<int> expected = new List<int> { 3, 4, 5, 1, 2 };
        List<int> actual = Result.rotateLeft(d, arr);

        Assert.Equal(expected, actual);
    }
}