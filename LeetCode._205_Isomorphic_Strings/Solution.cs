namespace LeetCode._205_Isomorphic_Strings;

public class Solution
{
    public bool IsIsomorphic(string s, string t) {
        if (s.Length != t.Length)
        {
            return false;
        }

        int GetIndexOf(char[] array, char value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    return i;
                }
            }

            return -1;
        }

        var sMap = new char[s.Length];
        var tMap = new char[t.Length];
        for (int i = 0; i < s.Length; i++)
        {
            var sIndex = GetIndexOf(sMap, s[i]);
            var tIndex = GetIndexOf(tMap, t[i]);
            if (sIndex == -1 && tIndex == -1)
            {
                sMap[i] = s[i];
                tMap[i] = t[i];
            }
            else if (sIndex != tIndex)
            {
                return false;
            }
        }

        return true;
    }
}