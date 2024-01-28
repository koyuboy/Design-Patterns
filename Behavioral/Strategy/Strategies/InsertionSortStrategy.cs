namespace Strategy.Strategies;

public class InsertionSortStrategy : ISortStrategy
{
    public List<int> Sort(List<int> numbers)
    {
        for (int i = 1; i < numbers.Count; i++)
        {
            var key = numbers[i];
            var flag = 0;
            for (int j = i - 1; j >= 0 && flag != 1;)
            {
                if (key < numbers[j])
                {
                    numbers[j + 1] = numbers[j];
                    j--;
                    numbers[j + 1] = key;
                }
                else flag = 1;
            }
        }

        Console.WriteLine("Sorted with Insertion Sort Algorithm");

        return numbers;
    }
}
