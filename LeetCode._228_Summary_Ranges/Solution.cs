namespace LeetCode._228_Summary_Ranges;

public class Solution
{
    public IList<string> SummaryRanges(int[] nums)
    {
        if (!nums.Any())
            return new List<string>();
        
        var rangeStart = nums[0];
        var ranges = new Dictionary<int, int> { { rangeStart, rangeStart } };
        for (int i = 0; i < nums.Length - 1; i++)
        {
            var num = nums[i];
            var nextNum = nums[i + 1];
            if (num + 1 != nextNum)
            {
                rangeStart = nextNum;
            } 
            
            ranges[rangeStart] = nextNum;
        }


        return ranges.Select(x => x.Key == x.Value ? $"{x.Key}" : $"{x.Key}->{x.Value}").ToList();
    }
}