public class Solution {
    public string solution(string phone_number) {
        int length = phone_number.Length;
        
        string answer = new string('*', length - 4) + phone_number.Substring(length - 4);

        return answer;
    }
}