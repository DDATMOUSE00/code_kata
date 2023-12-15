using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        if (n <= 100000000 && n > 0)
        {
        string numString = n.ToString();
        
        foreach(char numsum in numString)
        {
            answer += (numsum - '0');
        }
        return answer;
        }
        return answer;
    }
}