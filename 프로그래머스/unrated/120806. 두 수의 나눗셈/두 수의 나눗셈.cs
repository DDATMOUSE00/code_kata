using System;

public class Solution {
    public int solution(double num1, double num2) {
        double sum = 0;
        int answer = 0;
        if (num1 > 0 && num1 <= 100 && num2 > 0 && num2 <= 100)
        {
            sum = (num1 / num2) * 1000;
            answer = (int)sum;
            return answer;
        }
        return answer;
    }
}