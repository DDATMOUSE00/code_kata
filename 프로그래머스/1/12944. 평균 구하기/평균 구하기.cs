public class Solution {
    public double solution(int[] arr) {
        double answer = 0, sum = 0;
        foreach(int num in arr)
        {
            sum += num;
        }
        answer = sum / arr.Length;
        return answer;
    }
}