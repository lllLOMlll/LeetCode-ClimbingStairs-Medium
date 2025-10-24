public class Solution
{
    public int ClimbStairs(int n)
    {
        int tempDistinctWays = 0;
        int distinctWays = 2;
        int twoBefore = 1;
      
        if (n == 1) return 1;
        if (n == 2) return 2;

        for (int i = 3; i <= n; i++)
        {
            tempDistinctWays = distinctWays + twoBefore;
            twoBefore = distinctWays;
            distinctWays = tempDistinctWays;
        }

        return distinctWays;
    }

    static void Main(string[] args)
    {
        Solution s = new Solution();

        int input1 = 1;
        Console.WriteLine("Input = 1 Answer(1) -> " + s.ClimbStairs(input1));

        int input2 = 2;
        Console.WriteLine("Input = 2 Answer(2) -> " + s.ClimbStairs(input2));

        int input3 = 3;
        Console.WriteLine("Input = 3 Answer(3) -> " + s.ClimbStairs(input3));

        int input4 = 4;
        Console.WriteLine("Input = 4 Answer(5) -> " + s.ClimbStairs(input4));

        int input5 = 5;
        Console.WriteLine("Input = 5 Answer(8) -> " + s.ClimbStairs(input5));


        int input6 = 6;
        Console.WriteLine("Input = 6 Answer(13) -> " + s.ClimbStairs(input6));

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

6 STAIRS
1+1+1+1+1+1
2+2+2

1+1+1+1+2
1+1+1+2+1
1+1+2+1+1
1+2+1+1+1
2+1+1+1+1

1+1+2+2
1+2+1+2
2+1+1+2
1+2+2+1  -> j'avais oublié
2+1+2+1  -> j'avais oublié
2+2+1+1

STEPS TO SOLVE THE PROBLEM
1- Count the number with 1 
2- Coutn the number with 2 (and maybe add 1)


Find hom 
*/