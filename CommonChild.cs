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
