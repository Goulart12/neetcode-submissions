public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> numbers = new HashSet<int>();

        foreach(int num in nums) {
            numbers.Add(num);
        }

        if(numbers.Count < nums.Length){
            return true;
        } else {
            return false;
        }

    }
}