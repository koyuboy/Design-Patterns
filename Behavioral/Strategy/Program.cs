using Strategy;
using Strategy.Strategies;

internal class Program
{
    private static void Main(string[] args)
    {
        var numbers = GenerateNumbers();

        var sortingContext = new SortingContext();

        var defaultSortResult = sortingContext.SortNumbers(numbers);
        Console.WriteLine($"Sorted numbers: {String.Join(", ", defaultSortResult)} \n");

        //Set to bubble sort
        sortingContext.SetSortingStrategy(new BubbleSortStrategy());
        var bubbleSortResult = sortingContext.SortNumbers(numbers);
        Console.WriteLine($"Sorted numbers: {String.Join(", ", bubbleSortResult)} \n");

        //Set to insertion sort
        sortingContext.SetSortingStrategy(new InsertionSortStrategy());
        var insertionSortResult = sortingContext.SortNumbers(numbers);
        Console.WriteLine($"Sorted numbers: {String.Join(", ", insertionSortResult)} \n");
    }

    private static List<int> GenerateNumbers()
    {
        var numbers = new List<int>();
        var random = new Random();
        for (int i = 0; i < 50; i++) { numbers.Add(random.Next(1, 999)); }
        Console.WriteLine($"Numbers to sort: {String.Join(", ", numbers)} \n");
        return numbers;
    }
}