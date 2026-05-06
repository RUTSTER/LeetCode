namespace CsProblems.Problems;

internal class SingleNumber_136
{
    public int SingleNumber(int[] nums)
    {
        var buf = 0;
        
        foreach (var n in nums)
        {
            buf ^= n;
        }

        return buf;
    }


    public void Test()
    {
        var res = SingleNumber([4,1,2,1,2]);

        Console.WriteLine(res);
    }
}