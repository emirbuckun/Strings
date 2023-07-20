using System.Text;

namespace StringExample
{
  internal class Program
  {
    private static void Main()
    {
      // Diff Declarations of String
      string text = "Hello World ";
      System.String text2 = "C#";

      // String Constructor
      Console.WriteLine("--- String Constructor");
      char[] letters = { 'A', 'B', 'C' };
      string alphabet = new(letters);
      Console.WriteLine(alphabet);
      Console.WriteLine();

      // String Builder
      Console.WriteLine("--- String Builder");
      StringBuilder stringBuilder = new(text);
      stringBuilder.AppendLine(text2);
      Console.WriteLine(text);
      Console.WriteLine(text2);
      Console.WriteLine($"String Builder result: {stringBuilder}");

      // Formating String
      Console.WriteLine("--- Formating String");
      int a = 5, b = 10;
      Console.WriteLine("Hello, {0} ! World {1} {2}", a, text2, b); // Composition format
      Console.WriteLine($"Hello, {text} ! World {a} {b}", a, text2, b); // Interpolation format
      Console.WriteLine();

      // Length Function
      Console.WriteLine("--- Length Function");
      string lengthTest = "C# Programming";
      int length = lengthTest.Length;
      Console.WriteLine($"String length: {length}");
      Console.WriteLine();

      // Concat Function
      Console.WriteLine("--- Concat Function");
      string s1 = "C# ";
      string s2 = "Programming";
      string joined = string.Concat(s1, s2);
      Console.WriteLine($"Joined string: {joined}");
      Console.WriteLine();

      // CompareTo Function
      Console.WriteLine("--- CompareTo Function");
      // s1 == s2 return 0
      // s1 > s2 return 1
      // s1 < s2 return -1
      string str1 = "hello";
      string str2 = "hello";
      string str3 = "csharp";
      string str4 = "mello";
      Console.WriteLine($"Compare(str1,str2) result: {string.Compare(str1, str2)}");
      Console.WriteLine($"Compare(str1,str2) result: {string.Compare(str2, str3)}");
      Console.WriteLine($"Compare(str1,str2) result: {string.Compare(str3, str4)}");
      Console.WriteLine();

      // Contains Function
      Console.WriteLine("--- Contains Function");
      string str5 = "Summer";
      string str6 = "er";
      string str7 = "al";
      Console.WriteLine($"str5.Contains(str6) result: {str5.Contains(str6)}");
      Console.WriteLine($"str5.Contains(str7) result: {str5.Contains(str7)}");
      Console.WriteLine();

      // Equals Function
      Console.WriteLine("--- Equals Function");
      string str8 = "Hello";
      string str9 = "Hello";
      string str10 = "By";
      Console.WriteLine($"str8.Equals(str9) result: {str8.Equals(str9)}");
      Console.WriteLine($"str8.Equals(str10) result: {str8.Equals(str10)}");
      Console.WriteLine();

      // IndexOf Function
      Console.WriteLine("--- IndexOf Function");
      string str11 = "Hello C#";
      int index = str11.IndexOf('C');
      Console.WriteLine($"str11.IndexOf('C') result: {index}");
      Console.WriteLine();

      // ToUpper - ToLower Functions
      Console.WriteLine("--- ToUpper - ToLower Functions");
      string password = "PassWord123";
      Console.WriteLine($"toUpper(): {password.ToUpper()}");
      Console.WriteLine($"ToLower(): {password.ToLower()}");
      Console.WriteLine();

      // Remove Function
      Console.WriteLine("--- Remove Function");
      string str12 = "Hello World";
      string remaining = str12.Remove(1);
      string remaining2 = str12.Remove(1, 3);
      Console.WriteLine($"String: {str12}");
      Console.WriteLine($"Remaining: {remaining}");
      Console.WriteLine($"Remaining2: {remaining2}");
      Console.WriteLine();

      // Split Function
      Console.WriteLine("--- Split Function");
      string str13 = "Hello World";
      string[] strArray = str13.Split(' ');
      Console.WriteLine($"String: {str13}");
      Console.WriteLine("Split Result str13.Split(' ')");
      foreach (var item in strArray)
        Console.WriteLine(item);
      Console.WriteLine();

      // StartsWith Function
      Console.WriteLine("--- StartsWith Function");
      string str14 = "Hello World";
      Console.WriteLine($"String: {str14}");
      bool result = str14.StartsWith("H");
      bool result2 = str14.StartsWith("W");
      Console.WriteLine($"str14.StartsWith('H'): {result}");
      Console.WriteLine($"str14.StartsWith('W'): {result2}");
      Console.WriteLine();

      // Substring Function
      Console.WriteLine("--- Substring Function");
      string str15 = "Hello World";
      int index2 = str15.IndexOf("W");
      string srt16 = str15[index2..];
      string srt17 = str15.Substring(index2, 4);
      Console.WriteLine($"String: {str15}");
      Console.WriteLine($"str15[index2..]: {srt16}");
      Console.WriteLine($"str15.Substring(index2,4): {srt17}");
      Console.WriteLine();

      // Trim Function
      Console.WriteLine("--- Trim Function");
      string str18 = "\v\tHello World\r\n";
      Console.WriteLine($"String: {str18}");
      Console.WriteLine($"Trim Result: {str18.Trim()}");

      // ToCharArray Function
      Console.WriteLine("--- ToCharArray Function");
      string str19 = "Hello World";
      char[] chars = str19.ToCharArray();
      Console.WriteLine($"String: {str19}");
      Console.WriteLine("Char Array Result");
      foreach (var item in chars)
        Console.WriteLine(item);

      // Format Function
      Console.WriteLine("--- Format Function");
      string str20 = string.Format("{0:M}", DateTime.Now);
      Console.WriteLine($"string.Format('{{0:M}}', DateTime.Now) Result: {str20}");
    }
  }
}