namespace DSA.Array;

public class SecondLargestFinder
{
    int[] arr = [1, 2, 4, 5, 10, 21, 3, 50];

    public SecondLargestFinder()
    {
        Console.WriteLine("");
        Large();
    }
    public void Large()
    {
        int number = int.MinValue, largeNumebr = int.MinValue;
        for (int i = 0;i<arr.Length;i++)
        {
            if(arr[i] > number)
            {
                largeNumebr = number;
                number = arr[i];
            }
            else if(arr[i] > largeNumebr && arr[i] != number)
            {
                largeNumebr = number;
            }
        }
        Console.WriteLine(largeNumebr);
    }
}
