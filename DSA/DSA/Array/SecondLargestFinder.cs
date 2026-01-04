namespace DSA.Array;

public class SecondLargestFinder
{
    int[] arr = [1, 2, 4, 5, 10, 21, 3, 50];

    public SecondLargestFinder()
    {
        Console.WriteLine("");
        Select();
    }
    public void Select()
    {
        Console.WriteLine("Please select program");
        Console.WriteLine(@"
            1. SecondLarge
            2. ZeroAtlast
");
        ZeroAtlast();
    }
    public void SecondLarge()
    {
        int number = int.MinValue, largeNumebr = int.MinValue;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > number)
            {
                largeNumebr = number;
                number = arr[i];
            }
            else if (arr[i] > largeNumebr && arr[i] != number)
            {
                largeNumebr = number;
            }
        }
        Console.WriteLine(largeNumebr);
    }
    public void ZeroAtlast()
    {
        int[] arr = [1, 3, 4, 2, 0, 2, 0, 3, 23, 22, 20, 0, 230, 0];
        int n = arr.Length;
        int j = 0;
        int[] tempArr = new int[n];
        for (int i = 0; i < n; i++)
        {
            if (arr[i] != 0)
            {
                tempArr[j++] = arr[i];
            }
        }
        while (j < n)
        {
            tempArr[j++] = 0;
        }
        for (int i = 0; i < n; i++)
        {
            arr[i] = tempArr[i];
        }


        foreach (int num in arr)
            Console.Write(num + " ");
    }
}
