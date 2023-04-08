namespace LeetCode._42_Trapping_Rain_Water;

public class Solution
{
    // 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1
    // 
    // 1, 0, 2          - (1 в длину, 1 в высоту, 2 занятых = (1 * 3) - 2 = 1)
    // 2, 1, 0, 1, 3    - (3 в длину, 2 в высоту, 2 занятых = (2 * 3) - (1 + 1) = 4)
    // 3, 2, 1, 2       - (3 в длину, 2 в высоту, 5 занятых = (1 * 2) - (
    
    // Out of memory
    public int Trap(int[] height)
    {
        var n = height.Max();
        var m = height.Length;

        var array = new int[n, m];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                array[i, j] = height[j] > i ? 1 : 0;
            }
        }
        
        var traps = 0;
        for (int i = 0; i < n; i++)
        {
            var firstPoint = 0;
            var lastPoint = 0;
            for (int j = 0; j < m; j++)
            {
                if (array[i,j] == 1)
                {
                    firstPoint = j;
                    break;
                }
            }
            for (int j = m - 1; j >= 0; j--)
            {
                if (array[i,j] == 1)
                {
                    lastPoint = j;
                    break;
                }
            }
            
            for (int j = firstPoint; j < lastPoint; j++)
            {
                if (array[i, j] == 0)
                {
                    traps++;
                }
            }
        }
        
        return traps;
    }
    
    // Time Limit Exceeded
    public int TrapV2(int[] height)
    {
        var n = height.Max();
        var m = height.Length;
        
        var traps = 0;
        for (int i = 0; i < n; i++) // columns
        {
            var firstOne = -1;
            var lastOne = -1;
            var rowCount = 0;
            for (int j = 0; j < m; j++) // rows
            {
                var currentCell = height[j] > i ? 1 : 0;
                if (currentCell == 1)
                {
                    if (lastOne != -1)
                    {
                        lastOne = j;
                    }
                    
                    if (lastOne > firstOne)
                    {
                        traps += rowCount;
                        rowCount = 0;
                    }
                    
                    firstOne = j;
                }

                if (currentCell == 1)
                {
                    lastOne = j;
                }

                if (currentCell == 0 && firstOne != -1)
                {
                    rowCount++;
                }
            }

            Console.WriteLine($"For column: {i} firstRow: {firstOne}, lastRow: {lastOne}");
        }

        return traps;
    }

    // public int TrapV3(int[] height)
    // {
    //     var traps = 0;
    //     var max1 = 0;
    //     var max2 = 0;
    //     var max1Index = 0;
    //     var max2Index = 0;
    //     var newChunk = false;
    //     for (int i = 1; i < height.Length; i++)
    //     {
    //         var current = height[i];
    //         if (current > max1)
    //         {
    //             max2 = max1;
    //             max2Index = max1Index;
    //             max1 = current;
    //             max1Index = i;
    //         }
    //         
    //         if (Math.Abs(max1Index - max2Index) > 1)
    //         {
    //             Console.WriteLine($"Max: {max1}, min: {max2}");
    //             newChunk = true;
    //
    //             max2 = max1;
    //             max2Index = max1Index;
    //         }
    //
    //         if (current < max2)
    //         {
    //             
    //         }
    //
    //
    //
    //         
    //         
    //     }
    //
    //     return 1;
    // }
}

// найти min, найти max, подсчитать число между ними

// Рассмотрим: 2 1 0 1 3
// 1 0 1 = 3 - элемента между 2 и 3
// 2 и 3 = 2 - минимальный элемент
// 1+0+1 = 2 - элемента заполнены
// 2 * 3 = 6 - длина * ширина
// 6 - 2 = 4 - занято 

// 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1
// 
// 1, 0, 2        
// 2, 1, 0, 1, 3  
// 3, 2, 1, 2     