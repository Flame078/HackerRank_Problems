/* A string is said to be a child of a another string if it can be formed by deleting 0 or more characters from the other string. 
Letters cannot be rearranged. Given two strings of equal length, what's the longest string that can be constructed such that it is a child of both?

Example
s1="ABCD"
s2="ABDC"

These strings have two children with maximum length 3, ABC and ABD. They can be formed by eliminating either the D or C from both strings. Return: 3. 

Problem: https://www.hackerrank.com/challenges/common-child/problem?isFullScreen=true&h_r=next-challenge&h_v=zen */

public static int MAX(int a, int b) {
        if (a >= b)
            return a;
        else return b;
    }
   
    public static int commonChild(string s1, string s2)
    {
        int s1_length = s1.Length, s2_length = s2.Length;
        int[,] matrix = new int[s1_length + 1, s2_length + 1];

        for (int i = 1; i<=s2_length; i++)
        {
            for(int j = 1; j<=s1_length; j++)
            {
                if(s1[j-1] == s2[i-1]) {
                    matrix[i, j] = matrix[i - 1, j-1] +1;
                } else {
                    matrix[i, j] = MAX(matrix[i - 1, j], matrix[i, j - 1]);
                }
            }
        }
        
        return  matrix[s1_length, s2_length];
    }
