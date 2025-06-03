namespace LeetCode.algorithmicProblems.challange1;

public class TwoSum {
    
    public int[] TwoSumSolver(int[] nums, int target) {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                int actual = nums[i];
                int prox = nums[j];
                
                if (actual + prox == target)
                {
                    return new int[] {i, j};
                }
            }
        }
        return new int[0];
    }
}