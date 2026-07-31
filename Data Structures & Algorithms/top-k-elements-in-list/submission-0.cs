public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> bucket = new Dictionary<int, int>();

        foreach(int num in nums) {
            if(!bucket.ContainsKey(num)){
                bucket[num] = 0;
            }

            bucket[num]++;
        }

        return bucket.OrderByDescending(x => x.Value)
                     .Take(k)
                     .Select(x => x.Key)
                     .ToArray();
    }
}