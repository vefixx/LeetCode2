namespace Task27;

class Program
{
    public int RemoveElement(int[] nums, int val)
    {
        int countToAdd = 0;
        int k = 0;
        int[] resNums = { };

        foreach (var num in nums)
        {
            if (num == val)
            {
                countToAdd++;
            }
            else
            {
                Array.Resize(ref resNums, resNums.Length+1);
                resNums[^1] = val;
                k++;
            }
        }
        
        // Замена удаленных элементов на "_"
        // for (int i = 0; i < countToAdd; i++)
        // {
        //     Array.Resize(ref resNums, resNums.Length+1);
        //     resNums[^1] = val;
        // }
        
        return k;
    }
    
    static void Main(string[] args)
    {
        // https://leetcode.com/problems/remove-element/
        Console.WriteLine(new Program().RemoveElement([0,1,2,2,3,0,4,2], 2));
    }
}