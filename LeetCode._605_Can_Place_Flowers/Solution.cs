using System.Collections;

namespace LeetCode._605_Can_Place_Flowers;

public class Solution
{
    // public bool CanPlaceFlowers(int[] flowerbed, int n)
    // {
    //     if (flowerbed.Length == 1 && flowerbed[0] == 0)
    //         return --n <= 0;
    //
    //     if (flowerbed.Length == 1 && flowerbed[0] == 1)
    //         return n <= 0;
    //     
    //     for (int i = 0; i < flowerbed.Length; i++)
    //     {
    //         if (flowerbed[i] == 1)
    //             continue;
    //         
    //         if (i == 0 && flowerbed[i + 1] == 0)
    //         {
    //             n--;
    //             flowerbed[i] = 1;
    //         }
    //         else if (i == flowerbed.Length - 1 && flowerbed[i-1] == 0)
    //         {
    //             n--;
    //             flowerbed[i] = 1;
    //         }
    //         else if (i != 0 && flowerbed[i-1] == 0 && flowerbed[i+1] == 0)
    //         {
    //             n--;
    //             flowerbed[i] = 1;
    //         }
    //         
    //     }
    //
    //     return n <= 0;
    // }

    public bool CanPlaceFlowers(int[] flowerbed, int n)
    {
        for (int i = 0; i < flowerbed.Length; i++)
        {
            if (flowerbed[i] == 0
                && (i == 0 || flowerbed[i - 1] == 0)
                && (i == flowerbed.Length - 1 || flowerbed[i + 1] == 0))
            {
                n--;
                i += 2;
            }
            else
            {
                i++;
            }
        }

        return n <= 0;
    }
}