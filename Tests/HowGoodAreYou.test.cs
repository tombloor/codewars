using NUnit.Framework;
using Solutions.HowGoodAreYou;

namespace Tests.HowGoodAreYou;

public class Tests
{
    [Test]
    [TestCase(new int[]{2,3}, 5, ExpectedResult=true)]
    [TestCase(new int[]{100, 40, 34, 57, 29, 72, 57, 88}, 75, ExpectedResult=true)]
    [TestCase(new int[]{12,23,34,45,56,67,78,89,90}, 69, ExpectedResult=true)]
    public static bool HowGoodAreYou(int[] arr, int num)
    {
        return Kata.BetterThanAverage(arr, num);
    }

    [Test]
    [TestCase(new int[]{2,3}, 5, ExpectedResult=true)]
    [TestCase(new int[]{100, 40, 34, 57, 29, 72, 57, 88}, 75, ExpectedResult=true)]
    [TestCase(new int[]{12,23,34,45,56,67,78,89,90}, 69, ExpectedResult=true)]
    public static bool HowGoodAreYouLinq(int[] arr, int num)
    {
        return Kata.BetterThanAverageLinq(arr, num);
    }
}