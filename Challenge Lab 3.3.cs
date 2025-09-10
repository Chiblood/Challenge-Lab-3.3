/* Challenge Lab 3.3
3. Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

Input: nums = [2,7,11,15], target = 9

Output: [0,1]

Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].

 lets try a brute force solution first
 then find a more efficient solution using a hash map?
*/

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        // Brute force solution
        for (int i = 0; i < nums.Length; i++) {
            for (int j = i + 1; j < nums.Length; j++) {
                if (nums[i] + nums[j] == target) {
                    return new int[] { i, j };
                }
            }
        }
        throw new ArgumentException("No two sum solution");
    }

    // More efficient solution using a hash map
    public int[] TwoSumHashMap(int[] nums, int target) {
        Dictionary<int, int> numDict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++) {
            int complement = target - nums[i];
            if (numDict.ContainsKey(complement)) {
                return new int[] { numDict[complement], i };
            }
            numDict[nums[i]] = i;
        }
        throw new ArgumentException("No two sum solution");
    }
}