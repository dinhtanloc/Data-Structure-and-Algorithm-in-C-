using System;
using System.Net.NetworkInformation;

class Bai1
{
    // Hàm kiểm tra xem có hai phần tử nào trong mảng có tổng bằng target không
    static bool Ham1(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length - 1;

        while (left < right)
        {
            int curr = nums[left] + nums[right];
            if (curr == target)
            {
                return true;
            }
            if (curr > target)
            {
                right--;
            }
            else
            {
                left++;
            }
        }

        return false;
    }

    static bool Ham2(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length - 1;

        while (left < right)
        {
            int curr = nums[left] + nums[right];
            if (curr == target)
            {
                return true;
            }
            if (curr > target)
            {
                right--;
            }
            else
            {
                left++;
            }
        }

        return false;
    }

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        int[] nums = { 1, 2, 3, 4, 5 };
        int target = 8;

        bool result = Ham1(nums, target);
        bool result1 = Ham2(nums, target);
        Console.WriteLine($"Có hai phần tử có tổng bằng {target}: {result}");
    }
    

}
