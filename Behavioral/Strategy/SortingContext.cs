using Strategy.Strategies;

namespace Strategy;

public class SortingContext
{
    private ISortStrategy sortingStrategy;

    public SortingContext()
    {
        sortingStrategy = new DefaultSortStrategy();
        Console.WriteLine($"Set to {nameof(DefaultSortStrategy)} Algorithm.");
    }

    public void SetSortingStrategy(ISortStrategy sortingStrategy)
    {
        this.sortingStrategy = sortingStrategy;
        Console.WriteLine($"Set to {sortingStrategy.GetType().Name} Algorithm.");
    }

    public List<int> SortNumbers(List<int> numbers)
    {
        return sortingStrategy.Sort(numbers);
    }

}
