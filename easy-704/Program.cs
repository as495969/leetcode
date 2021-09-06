// See https://aka.ms/new-console-template for more information
int[] nums = { };
var target = 0;

Console.WriteLine(Solution.Search(nums, target));

public class Solution
{
    public static int Search(int[] nums, int target)
    {
        var position = nums.ToList().BinarySearch(target);

        return position > 0 ? position : -1;
    }
}



