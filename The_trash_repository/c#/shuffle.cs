using System;

public static class HelloWorld
{
    public static void Main(string[] args)
    {
        string str = "trytosolvemebitch";
        Console.WriteLine(str);
        Console.WriteLine(str.Shuffle());
    }
    
    public static string Shuffle(this string a)
    {
        Random rng = new Random();
        string tsr = "";
        int k = 0;
        while (a.Length > 0)
        {
            k = rng.Next(0,a.Length);
            tsr+=a[k].ToString();
            a = a.Remove(k,1);
        }
        return tsr;
    }
    
}
