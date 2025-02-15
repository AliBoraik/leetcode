namespace LeetCode.Tasks;

public class SingleNumberTask
{
    /*
     Given a non-empty array of integers nums, every element appears twice except for one. Find that single one.
       
       You must implement a solution with a linear runtime complexity and use only constant extra space.
     */
    public int SingleNumber(int[] nums)
    {
        int result = nums[0];
        if(nums.Length == 1)
            return nums[0];

        for(int i=1; i<nums.Length; i++){
            result = result^nums[i];
        }
        return result;
    }
}