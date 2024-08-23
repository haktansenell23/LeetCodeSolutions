
int[] TwoSum(int[] nums, int target)
{
    for (int i = 0; i < nums.Length; i++)
    {

        for (int j = i + 1; j<nums.Length; j++)
        {
            if (nums[i] + nums[j] == target)
            {

                return new int[] {i,j};
            }
        }

    }

    return new int[] {};
}




int[] nums = new int[4] { 2, 7, 11, 15 };


Console.WriteLine($"{TwoSum(nums, 9)[0]},{TwoSum(nums, 9)[1]}"); // [0, 1]   






