    using System;
class MYString
{  
     public static void run()
    {
        string s = "  hello world  ";
        string s2 = "CSharp Programming";

        Console.WriteLine("Original String: '" + s + "'\n");

        // 1. Length
        Console.WriteLine("Length: " + s.Length);

        // 2. Trim
        Console.WriteLine("Trim: '" + s.Trim() + "'");
        Console.WriteLine("TrimStart: '" + s.TrimStart() + "'");
        Console.WriteLine("TrimEnd: '" + s.TrimEnd() + "'");

        // 3. ToUpper / ToLower
        Console.WriteLine("Upper: " + s.Trim().ToUpper());
        Console.WriteLine("Lower: " + s.Trim().ToLower());

        // 4. Contains
        Console.WriteLine("Contains 'hello': " + s.Contains("hello"));

        // 5. StartsWith / EndsWith
        Console.WriteLine("StartsWith '  he': " + s.StartsWith("  he"));
        Console.WriteLine("EndsWith 'ld  ': " + s.EndsWith("ld  "));

        // 6. IndexOf / LastIndexOf
        Console.WriteLine("IndexOf 'o': " + s.IndexOf('o'));
        Console.WriteLine("LastIndexOf 'o': " + s.LastIndexOf('o'));

        // 7. Substring
        Console.WriteLine("Substring(2,5): " + s.Substring(2, 5));

        // 8. Replace
        Console.WriteLine("Replace 'l' with 'x': " + s.Replace("l", "x"));

        // 9. Split
        string[] arr = s2.Split(' ');
        Console.WriteLine("Split result:");
        foreach (string item in arr)
        {
            Console.WriteLine(item);
        }

        // 10. Join
        Console.WriteLine("Join: " + string.Join("-", arr));

        // 11. Insert
        Console.WriteLine("Insert: " + "HelloWorld".Insert(5, " "));

        // 12. Remove
        Console.WriteLine("Remove: " + "HelloWorld".Remove(5, 5));

        // 13. Equals
        Console.WriteLine("Equals: " + s2.Equals("CSharp Programming"));

        // 14. Compare
        Console.WriteLine("Compare: " + string.Compare("A", "B"));

        // 15. PadLeft / PadRight
        Console.WriteLine("PadLeft: " + "5".PadLeft(3, '0'));
        Console.WriteLine("PadRight: " + "5".PadRight(3, '*'));

        // 16. ToCharArray
        char[] chars = "ABC".ToCharArray();
        Console.WriteLine("Char Array:");
        foreach (char c in chars)
        {
            Console.WriteLine(c);
        }

        // 17. IsNullOrEmpty / IsNullOrWhiteSpace
        string empty = "   ";
        Console.WriteLine("IsNullOrEmpty: " + string.IsNullOrEmpty(empty));
        Console.WriteLine("IsNullOrWhiteSpace: " + string.IsNullOrWhiteSpace(empty));

        // 18. Format / Interpolation
        string name = "Rahim";
        Console.WriteLine(string.Format("Hello {0}", name));
        Console.WriteLine($"Hello {name}");
    }
}