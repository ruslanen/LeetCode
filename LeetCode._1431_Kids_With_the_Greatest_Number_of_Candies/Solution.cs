namespace LeetCode._1431_Kids_With_the_Greatest_Number_of_Candies;

public class Solution
{
    // O(N)
    // Сначала находим максимальное количество конфет, которое может быть у какого-то ребенка
    // Затем проходим по всем детям и находим количество конфет каждого + дополнительные конфеты
    // Если сумма конфет больше или равна максимальному количеству конфет, то, очевидно, что у этого ребенка больше всех конфет
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        var max = candies.Max();
        var result = new List<bool>();
        foreach (var c in candies)
            result.Add(c + extraCandies >= max);

        return result;
    }
    
    // O(N^2)
    // public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    // {
    //     var result = new List<bool>();
    //     for (int i = 0; i < candies.Length; i++)
    //     {
    //         var childCandies = candies[i] + extraCandies;
    //         var greater = true;
    //         for (int j = 0; j < candies.Length; j++)
    //         {
    //             if (i != j)
    //             {
    //                 if (childCandies < candies[j])
    //                 {
    //                     greater = false;
    //                 }
    //             }
    //         }
    //         
    //         result.Add(greater);
    //     }
    //
    //     return result;
    // }
}