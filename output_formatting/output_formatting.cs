using System;
using System.Globalization;

class OutputFormatting
{
    static void Main()
    {
        // 🔹 Variables used in the examples
        int age = 25;
        double salary = 4523.75;
        float height = 1.75f;
        string name = "Mestre";
        DateTime today = DateTime.Now;

        // 1. Simple Concatenation
        Console.WriteLine("Simple Concatenation:");
        Console.WriteLine("Name: " + name + ", Age: " + age + ", Height: " + height + "m\n");

        // 2. String Interpolation ($)
        Console.WriteLine("String Interpolation:");
        Console.WriteLine($"Name: {name}, Age: {age}, Height: {height}m\n");

        // 3. String.Format
        Console.WriteLine("String.Format:");
        Console.WriteLine(string.Format("Name: {0}, Age: {1}, Height: {2}m\n", name, age, height));

        // 4. Numeric Formatting
        Console.WriteLine("Numeric Formatting:");
        Console.WriteLine($"Standard number: {salary}");
        Console.WriteLine($"Two decimal places: {salary:F2}");
        Console.WriteLine($"Currency format (BRL): {salary:C}"); // Depends on culture
        Console.WriteLine($"Currency format (US): {salary.ToString("C", CultureInfo.GetCultureInfo("en-US"))}");
        Console.WriteLine($"Percentage format: {0.857:P}\n");

        // 5. Date Formatting
        Console.WriteLine("Date Formatting:");
        Console.WriteLine($"Full date: {today}");
        Console.WriteLine($"Short date: {today:dd/MM/yyyy}");
        Console.WriteLine($"Short time: {today:HH:mm}");
        Console.WriteLine($"Custom date: {today:dddd, dd 'of' MMMM 'of' yyyy}\n");

        // 6. Text Alignment
        Console.WriteLine("Text Alignment:");
        Console.WriteLine($"|{"Name",-10}|{"Age",5}|{"Height",7}|");
        Console.WriteLine($"|{name,-10}|{age,5}|{height,7:F2}|\n");

        // 7. Displaying Numbers in Different Bases
        Console.WriteLine("Different Number Representations:");
        int value = 255;
        Console.WriteLine($"Decimal: {value}");
        Console.WriteLine($"Binary: {Convert.ToString(value, 2)}");
        Console.WriteLine($"Hexadecimal: {value:X}");
        Console.WriteLine($"Octal: {Convert.ToString(value, 8)}\n");
    }
}
