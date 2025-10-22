public class Solution
{
    public int ClimbStairs(int n)
    {
        if (n == 1) return 1;
        if (n == 2) return 2;

        int distinctWays = 0;
        int divisionRemainder = n / 2;

        for (int i = 1; i < divisionRemainder + 1; i++)
        {
            distinctWays += n - i;
        }

        // Add 1 for the only ones solution
        distinctWays++;

        return distinctWays;
    }

    static void Main(string[] args)
    {
        Solution s = new Solution();
        // int restant = 5/2;
        // Console.WriteLine("Restant de 5/2 = " + restant);
        // int input1 = 1;
        // Console.WriteLine("Input = 1 Answer(2) -> " + s.ClimbStairs(input1));

        // int input2 = 2;
        // Console.WriteLine("Input = 2 Answer(2) -> " + s.ClimbStairs(input2));

        // int input3 = 3;
        // Console.WriteLine("Input = 3 Answer(3) -> " + s.ClimbStairs(input3));

        // int input4 = 4;
        // Console.WriteLine("Input = 4 Answer(5) -> " + s.ClimbStairs(input4));

        int input5 = 5;
        Console.WriteLine("Input = 5 Answer(8) -> " + s.ClimbStairs(input5));

    }
}


/*
4 STAIRS
1+1+1+1
2+2
1+1+2
1+2+1
2+1+1

5 STAIRS
1+1+1+1+1
2+2+1
2+1+2
1+2+2
1+1+1+2
1+1+2+1
1+2+1+1
2+1+1+1


STEPS TO SOLVE THE PROBLEM
1- Count the number with 1 
2- Coutn the number with 2 (and maybe add 1)


Find hom 
*/