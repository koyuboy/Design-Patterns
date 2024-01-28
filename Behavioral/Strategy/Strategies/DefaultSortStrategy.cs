namespace Strategy.Strategies;

public class DefaultSortStrategy : ISortStrategy
{
    public List<int> Sort(List<int> numbers)
    {
        numbers.Sort();

        Console.WriteLine("Sorted with Default Sorting Algorithm");

        return numbers;
    }
}
