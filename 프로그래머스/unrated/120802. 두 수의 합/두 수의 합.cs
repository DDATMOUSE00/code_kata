using System;

public class Solution {
    public int solution(int num1, int num2) {
        int sum = 0;
        if (num1 >= -50000 && num1 <= 50000 && num2 >= -50000 && num2 <= 50000)
        {
            sum = num1 + num2;
        }
        return sum;
    }
}