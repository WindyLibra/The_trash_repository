using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
    string[] words = {"hah","ao","za warudo","Yo"," ","dojyaaan","eh"};
    string[] neededwords = new string[words.Length];    
        foreach(string i in words) Console.Write($"{i}, ");
        Console.WriteLine("\n");
        for(int i = 0;i<words.Length;i++)
        {
            if (words[i].Length>=3){
                neededwords[i] = words[i];
            }
        }
        foreach(string i in neededwords) {
        if (i==null)
            continue;
        Console.Write($"{i}, ");
        }
        GC.Collect();
        
        
}
    
}
