using System.Diagnostics;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
internal class Program
{
    private static void Main(string[] args)
    {
        int n = 10000;
        int i = 1;

        while (i <= n)
        {
            //Console.WriteLine(i);
            Console.Write(i);
             Console.Write(' ');
            i = i + 1;
        }
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}