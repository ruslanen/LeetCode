namespace LeetCode._733_Flood_Fill;

public class Solution
{
    /// <summary>
    ///
    ///
    /// Например, требуется выполнить заливку по координатам '1, 1' с новым цветом '2'.
    /// Исходный массив    Результат
    /// +---+---+---+      +---+---+---+
    /// | 1 | 1 | 1 |      | 2 | 2 | 2 |
    /// +---+---+---+      +---+---+---+
    /// | 1 | 1 | 0 |  =>  | 2 | 2 | 0 |  
    /// +---+---+---+      +---+---+---+
    /// | 1 | 0 | 1 |      | 2 | 0 | 1 |
    /// +---+---+---+      +---+---+---+
    /// </summary>
    /// <param name="image">Двумерный массив пикселей, в котором координаты x, y ведут к цвету</param>
    /// <param name="sr">Номер строки для заливки</param>
    /// <param name="sc">Номер колонки для заливки</param>
    /// <param name="color">Цвет для заливки</param>
    /// <returns>Двумерный массив пикселей, в котором выполнена заливка</returns>
    public int[][] FloodFill(int[][] image, int sr, int sc, int color)
    {
        var value = image[sr][sc];
        var visitedMap = new Dictionary<(int, int), bool>();
        FloodFillRecursive(image, sr, sc, value, color, visitedMap);
        return image;
    }
    
    void FloodFillRecursive(int[][] image, int x, int y, int sourceColor, int newColor, Dictionary<(int, int), bool> visitedMap)
    {
        image[x][y] = newColor;
        visitedMap[(x, y)] = true;
        
        // Вниз по строкам
        if (x - 1 >= 0)
        {
            if (image[x - 1][y] == sourceColor && !visitedMap.ContainsKey((x - 1, y)))
            {
                FloodFillRecursive(image, x - 1, y, sourceColor, newColor, visitedMap);
            }
        }
            
        // Вверх по строкам
        if (x + 1 < image.Length && !visitedMap.ContainsKey((x + 1, y)))
        {
            if (image[x + 1][y] == sourceColor)
            {
                FloodFillRecursive(image, x + 1, y, sourceColor, newColor, visitedMap);
            }
        }
            
        // Влево по колонкам
        if (y - 1 >= 0)
        {
            if (image[x][y - 1] == sourceColor && !visitedMap.ContainsKey((x, y - 1)))
            {
                FloodFillRecursive(image, x, y - 1, sourceColor, newColor, visitedMap);
            }
        }
            
        // Вправо по колонкам
        if (y + 1 < image[x].Length && !visitedMap.ContainsKey((x, y + 1)))
        {
            if (image[x][y + 1] == sourceColor)
            {
                FloodFillRecursive(image, x, y + 1, sourceColor, newColor, visitedMap);
            }
        }
    }
}