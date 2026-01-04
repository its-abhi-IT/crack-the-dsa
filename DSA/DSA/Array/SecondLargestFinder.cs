namespace DSA.Array;

public class SecondLargestFinder
{
    int[] arr = [1, 2, 4, 5, 10, 21, 3, 50];
    private int _input;
    public SecondLargestFinder()
    {
        Console.WriteLine("");
        Select();
        _input = int.MinValue;
    }
    public void Select()
    {
        Console.WriteLine("Please select program");
        Console.WriteLine(@"
            1. SecondLarge
            2. ZeroAtlast
            3. Reverse");
        string userInput = Console.ReadLine();
        if (int.TryParse(userInput, out int result))
        {
            _input = result;
        }
        else
        {
            Console.WriteLine("Oops input is not number");
            Environment.Exit(0);
        }
        switch (_input)
        {
            case 1:
                SecondLarge();
                break;
            case 2:
                ZeroAtlast();
                break;
            case 3:
                Reverse();
                break;
        }
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
        // basic approach take more space
        //[Naive Approach] Using Temporary Array - O(n) Time and O(n) Space
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
        Console.WriteLine();
        //advance
        //[Better Approach] Two Traversals
        Console.WriteLine("[Better Approach] Two Traversals");
        j = 0;
        for(int i = 0; i < n; i++)
        {
            if(arr[i] != 0)
                arr[j++] = arr[i];
        }
        while (j < n)
            arr[j++] = 0;
        foreach (int num in arr)
            Console.Write(num + " ");
        Console.WriteLine();
        // advance
        //[Expected Approach] One Traversal
        //Auxiliary Space: O(1) //constanst
        Console.WriteLine("[Expected Approach] One Traversal");
        int c = 0;

        for(int i = 0; i < n; i++)
        {
            if (arr[i] != 0)
            {
                int temp = arr[i];
                arr[i] = arr[c];
                arr[c] = temp;
                c++;
            }
        }
        foreach (int num in arr)
            Console.Write(num + " ");
    }


    public void Reverse()
    {
        //first approach
        int n = arr.Length;
        for(int i = 0; i < n / 2; i++)
        {
            int temp = arr[i];
            arr[i] = arr[n - i - 1];
            arr[n - i - 1] = temp;
        }
        foreach (int num in arr)
            Console.Write(num + " ");
        Console.WriteLine();
    }
}
