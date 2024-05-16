namespace Ver9Preview;

internal class NewLanguageFeatures
{
    internal void EscapeSequenceForESC()
    {
        var text1 = $"\e";
        var text2 = "\u001b";
        Console.WriteLine("\\e equals \\u001b: {0}", text1 == text2); // True
        Console.WriteLine("Value of \\e: {0}", (int)text1[0]); // 27
    }
}
