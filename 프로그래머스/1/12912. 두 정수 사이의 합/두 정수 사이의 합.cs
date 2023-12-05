using System;
public class Solution {
    public long solution(int a, int b) {
        if (a > -10000000 && a < 10000000 && b > -10000000 && b < 10000000)
        {
        long answer = 0;
        
        int start = Math.Min(a, b);
        int end = Math.Max(a, b);
        
        for (int i = start; i <= end; i++)
        {
            answer += i;
        }
        
        //같은 수
        if (a == b)
        {
            return a;
        }
        
        return answer;
        
        }
        return 0;
    }
}