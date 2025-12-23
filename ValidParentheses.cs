public class Solution {
    public bool IsValid(string s) {

    while (true) {
            if (s.Contains("()")) {
                s = s.Replace("()", "");
            } else if (s.Contains("{}")) {
                s = s.Replace("{}", "");
            } else if (s.Contains("[]")) {
                s = s.Replace("[]", "");
            } else {
                return string.IsNullOrEmpty(s);
            }
        }
    }
}