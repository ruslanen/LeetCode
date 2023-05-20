namespace LeetCode._42_Trapping_Rain_Water;

public class Solution
{
    public int Trap(int[] height)
    {
        var maxLeft = new int[height.Length];
        var maxRight = new int[height.Length];

        var lm = 0;
        for (int i = 0; i < height.Length; i++)
        {
            if (height[i] > lm)
                lm = height[i];

            maxLeft[i] = lm;
        }
        
        var rm = 0;
        for (int i = height.Length - 1; i >= 0; i--)
        {
            if (height[i] > rm)
                rm = height[i];

            maxRight[i] = rm;
        }

        var sum = 0;
        for (int i = 0; i < height.Length; i++)
        {
            var diff = Math.Min(maxLeft[i], maxRight[i]) - height[i];
            if (diff > 0)
            {
                sum += diff;
            }
        }

        return sum;
    }
    
    // Out of memory
    public int TrapV1(int[] height)
    {
        // Находим максимальный элемент (это будет размерность одного измерения матрицы)
        var n = height.Max();
        // Находим число элементов в массиве (это будет размерность второго измерения матрицы)
        var m = height.Length;

        var array = new int[n, m];
        // Заполняем матрицу значением 1 или 0
        // 1 - есть точка
        // 0 - пустота
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                array[i, j] = height[j] > i ? 1 : 0;
            }
        }
        
        var traps = 0;
        // Обходим матрицу по первому измерению
        for (int i = 0; i < n; i++)
        {
            var firstPoint = 0;
            var lastPoint = 0;
            // Находим первую заполненную точку с начала
            for (int j = 0; j < m; j++)
            {
                if (array[i,j] == 1)
                {
                    firstPoint = j;
                    break;
                }
            }
            // Находим первую заполненную точку с конца
            for (int j = m - 1; j >= 0; j--)
            {
                if (array[i,j] == 1)
                {
                    lastPoint = j;
                    break;
                }
            }
            // Просто считаем количество 1 на основе первой точки с начала и конца
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