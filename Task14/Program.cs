namespace Task14;

class Program
{
    
    static void Main(string[] args)
    {
        string[] strs = { "ab", "a" };

        string currentPrefix = "";
        string minPrefix = string.Empty;
        
        if (strs.Length == 1)
            Console.WriteLine(strs[0]);
        
        for (int i = 0; i < strs.Length; i++)
        {
            for (int j = 0; j < strs.Length; j++)
            {
                if (i == j)
                    continue;

                for (int charIdx = 0; charIdx < Math.Min(strs[i].Length, strs[j].Length); charIdx++)
                {
                    if (strs[i][charIdx] == strs[j][charIdx])
                    {
                        currentPrefix += strs[i][charIdx];
                    }
                    else
                    {
                        if (currentPrefix.Length < minPrefix.Length || minPrefix == string.Empty)
                            minPrefix = currentPrefix;
                        
                        currentPrefix = "";
                        break;
                    }
                }
            }
        }
        
        Console.WriteLine(minPrefix);
    }
    
    
}
