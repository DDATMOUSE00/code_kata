using System;

public class Solution {
    public int solution(int n) {
        if (n >= 3 && n <= 1000000)
        {
            for (int x = 1; x <= n; x++) {
                if (n % x == 1) {
                    return x;
                }
            }
            return -1;
        }
        else
        {
            return -1;
        }
    }
}