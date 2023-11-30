using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        if (n > 0 && n <= 1000)
        {
            if (n % 2 != 0)
            {
                n--;
            }
            if (n % 2 == 0)
            {
                for (int i = 2; i <= n; i += 2)
                {
                    answer += i;
                }
                return answer;
            }
        }
        return answer;
    }
}