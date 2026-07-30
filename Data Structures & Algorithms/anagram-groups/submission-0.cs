public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
       Dictionary<string, List<string>> list = new Dictionary<string, List<string>>();

       foreach(var str in strs){
        char[] chars = str.ToCharArray();
        Array.Sort(chars);
        var key = new string(chars);

        if(!list.ContainsKey(key)) {
            list[key] = new List<string>();
        }
        list[key].Add(str);
       }

        var result = list.Values.ToList();
        return result;
    }
}