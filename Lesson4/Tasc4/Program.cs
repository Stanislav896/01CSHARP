using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите строку: ");
        string input = Console.ReadLine();

        string[] digits = GetDigits(input);

        Console.WriteLine("Массив цифр: " + string.Join(", ", digits));
    }

    static string[] GetDigits(string input)
    {
        string[] digits = new string[0];
        foreach (char c in input)
        {
            if (char.IsDigit(c))
            {
                string[] temp = new string[digits.Length + 1];
                Array.Copy(digits, temp, digits.Length);
                temp[digits.Length] = c.ToString();
                digits = temp;
            }
        }
        return digits;
    }
}


