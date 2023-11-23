using System;

public class Solution {
    public int solution(int age) {
        if (age > 0 && age <= 120)
        {
            age = (2022-age+1);
        }
        return age;
    }
}