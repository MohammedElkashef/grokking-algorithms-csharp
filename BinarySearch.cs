namespace GrokkingAlgorithms;

public static class BinarySearch
{
    /// <summary>
    /// Performs a binary search on a sorted array of integers to find the specified item.
    /// </summary>
    /// <param name="numbers">The sorted array of integers to search.</param>
    /// <param name="item">The item to search for.</param>
    /// <returns>The index of the item if found; otherwise, null.</returns>
    public static int? Search(int[] numbers, int item)
    {
        var lowIndex = 0;
        var highIndex = numbers.Length - 1;
        while (lowIndex <= highIndex)
        {
            var midIndex = (lowIndex + highIndex) / 2;
            var guess = numbers[midIndex];
            if (guess == item)
            {
                return midIndex;
            }

            if (guess > item)
            {
                highIndex = midIndex - 1;
            }
            else
            {
                lowIndex = midIndex + 1;
            }
        }

        return null;
    }
}