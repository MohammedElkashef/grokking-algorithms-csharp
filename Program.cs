using GrokkingAlgorithms;

// BinarySearch
int[] numbers = [1, 2, 4, 5, 7, 8, 9, 22, 43, 56, 64, 76];
var index = BinarySearch.Search(numbers, 64);
Console.WriteLine(index == null ? "Element not found!" : $"Element exists at index {index}");