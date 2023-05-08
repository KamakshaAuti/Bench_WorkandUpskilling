using System;
 
public class Example
{
    public static void Main()
    {
        string str = "Techie Delight";
        char ch = 'e';
 
        int freq = 0;
        foreach (char c in str)
        {
            if (c == ch) {
                freq++;
            }
        }
 
        Console.WriteLine(freq);
    }
}