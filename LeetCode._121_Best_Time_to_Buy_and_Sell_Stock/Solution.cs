namespace LeetCode._121_Best_Time_to_Buy_and_Sell_Stock;

public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int MaxProfitInternal(int[] prices, int from, int to)
        {
            if (to - from <= 1)
            {
                return 0;
            }

            int minIndex = from, maxIndex = from;
            int minPrice = prices[from], maxPrice = prices[from];
            int emptyElementsAfter = -1;
            for (int i = from; i < to; i++)
            {
                if (prices[i] > maxPrice)
                {
                    maxIndex = i;
                    maxPrice = prices[i];
                }

                if (prices[i] < minPrice)
                {
                    minIndex = i;
                    minPrice = prices[i];
                }


                if (prices[i] == 0)
                {
                    if (emptyElementsAfter == -1)
                    {
                        emptyElementsAfter = i;
                    }
                }
                else
                {
                    emptyElementsAfter = -1;
                }
            }

            if (maxIndex > minIndex)
            {
                return maxPrice - minPrice;
            }

            if (emptyElementsAfter != -1)
            {
                to = emptyElementsAfter;
            }

            var left = MaxProfitInternal(prices, from, maxIndex + 1);
            var right = MaxProfitInternal(prices, maxIndex + 1, to);

            return right > left ? right : left;
        }

        var result = MaxProfitInternal(prices, 0, prices.Length);
        return result;
    }
}