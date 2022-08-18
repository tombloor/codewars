namespace Solutions.HowGoodAreYou;

public class Kata
{
    public static bool BetterThanAverageLinq(int[] ClassPoints, int YourPoints)
    {
        int sum = ClassPoints.Sum() + YourPoints;
        return sum / (ClassPoints.Length + 1) <= YourPoints;
    }

    public static bool BetterThanAverage(int[] ClassPoints, int YourPoints)
    {
        int sum = YourPoints;

        for(int i = 0; i < ClassPoints.Length; i++) 
        {
            sum += ClassPoints[i];
        }

        return sum / (ClassPoints.Length + 1) <= YourPoints;
    }
}
