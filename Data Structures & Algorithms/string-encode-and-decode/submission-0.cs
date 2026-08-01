public class Solution {

    public string Encode(IList<string> strs) {
        string encoded = "";

        foreach(string str in strs){
            encoded += str.Length;
            encoded += '#';
            encoded += str;
        }

        return encoded;
    }

    public List<string> Decode(string s) {
        List<string> result = new List<string>();
        int i = 0;
        int n = s.Length;

        while (i < n){
            int len = 0;

            while(s[i] != '#') {
                len = len * 10 + (s[i] - '0');
                i++;
            }

            i++;

            string temp = s.Substring(i, len);
            result.Add(temp);

            i += len;
        }

        return result;
   }
}
