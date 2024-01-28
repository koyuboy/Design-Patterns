namespace Strategy.Strategies;

public class BubbleSortStrategy : ISortStrategy
{
    public List<int> Sort(List<int> numbers)
    {
        var n = numbers.Count;
        for (int i = 0; i < n - 1; i++)
            for (int j = 0; j < n - i - 1; j++)
                if (numbers[j] > numbers[j + 1])
                {
                    var tempVar = numbers[j];
                    numbers[j] = numbers[j + 1];
                    numbers[j + 1] = tempVar;
                }

        Console.WriteLine("Sorted with Bubble Sort Algorithm");

        return numbers;
    }
}
