namespace Task7;

class Program
{
    public int Reverse(int x)
    {
        string xStr = x.ToString();
        string reversedStr;

        if (x < 0)
        {
            char[] charrArray = xStr.Substring(1, xStr.Length-1).ToCharArray();
            Array.Reverse(charrArray);
            reversedStr = "-" + new string(charrArray);
        }
        else
        {
            char[] charrArray = xStr.ToCharArray();
            Array.Reverse(charrArray);
            reversedStr = new string(charrArray);
        }
        
        if (!int.TryParse(reversedStr, out _))
        {
            return 0;
        }
        
        return int.Parse(reversedStr);
    }
    
    static void Main(string[] args)
    {
        Console.WriteLine(new Program().Reverse(-2147483648));
    }
    
}