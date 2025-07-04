using System.Collections;

namespace Task191;

class Program
{
    public int HammingWeight(int n)
    {
        int count = 0;

        foreach (var item in Convert.ToString(n, 2))
        {
            if (item == '1')
                count++;
        }

        return count;
    }
    
    static void Main(string[] args)
    {
        Console.WriteLine(new Program().HammingWeight(2147483645));
    }
}