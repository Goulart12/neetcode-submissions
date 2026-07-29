public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;
        char[] sCharacters = s.ToCharArray();
        char[] tCharacters = t.ToCharArray();

        Array.Sort(sCharacters);
        Array.Sort(tCharacters);

        for(int i = 0; i < sCharacters.Length; i++) {
            if(sCharacters[i] != tCharacters[i]){
                return false;
            }
        }
        return true;
    }
}