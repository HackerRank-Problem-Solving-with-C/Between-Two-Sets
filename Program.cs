class Result
{
    /*
     * Complete the 'getTotalX' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY a
     *  2. INTEGER_ARRAY b
     */

    public static int getTotalX(List<int> a, List<int> b)
    {
        int first = a.Last();
        int last = b.First();
        int count = 0;

        for (int i = first; i <= last; i++)
        {
            if (IsFactorOfAll(i, a) && IsFactorForAll(i, b))
            {
                count++;
            }
        }

        return count;
    }

    private static bool IsFactorOfAll(int number, List<int> list)
    {
        foreach (var value in list)
        {
            if (number % value != 0)
            {
                return false;
            }
        }
        return true;
    }

    private static bool IsFactorForAll(int number, List<int> list)
    {
        foreach (var value in list)
        {
            if (value % number != 0)
            {
                return false;
            }
        }
        return true;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int m = Convert.ToInt32(firstMultipleInput[1]);

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        List<int> brr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(brrTemp => Convert.ToInt32(brrTemp)).ToList();

        int total = Result.getTotalX(arr, brr);

        Console.WriteLine(total);
    }
}