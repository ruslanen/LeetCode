namespace LeetCode._1732_Find_the_Highest_Altitude;

public class Solution
{
    public int LargestAltitude(int[] gain)
    {
        var cumulative = 0;
        var max = 0;
        for (int i = 0; i < gain.Length; i++)
        {
            cumulative += gain[i];
            max = Math.Max(max, cumulative);
        }

        return max;
    }
}