namespace LeetCode._49_Group_Anagrams;

public class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        var dictionary = new Dictionary<string, List<string>>(); 
        foreach (var str in strs)
        {
            var sorted = string.Concat(str.OrderBy(c => c));
            if (dictionary.TryGetValue(sorted, out var value))
            {
                value.Add(str);
            }
            else
            {
                dictionary[sorted] = new List<string>() {str};
            }
        }

        return dictionary.Values.ToList<IList<string>>();
    }
}