namespace LeetCode._120_Valid_Parentheses;

public class Solution
{
    public bool IsValid(string s)
    {
        var dictionary = new Dictionary<char, char>()
        {
            {')', '('},
            {']', '['},
            {'}', '{'},
        };

        var stack = new Stack<char>();
        for (int i = 0; i < s.Length; i++)
        {
            var c = s[i];
            if (!dictionary.ContainsKey(c))
            {
                stack.Push(c);
            }
            else
            {
                var top = stack.Count != 0 ? stack.Pop() : '\0';
                if (top != dictionary[c])
                {
                    return false;
                }
            }
        }

        return stack.Count == 0;
    }
}