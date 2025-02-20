using System;

class DataTypes
{
    static void Main()
    {
        // Integer Numeric Types
        byte numByte = 255;      // 0 to 255
        sbyte numSByte = -128;   // -128 to 127
        short numShort = -32768; // -32,768 to 32,767
        ushort numUShort = 65535;// 0 to 65,535
        int numInt = 2147483647; // -2,147,483,648 to 2,147,483,647
        uint numUInt = 4294967295;// 0 to 4,294,967,295
        long numLong = 9223372036854775807; // -9 quintillion to 9 quintillion
        ulong numULong = 18446744073709551615; // 0 to 18 quintillion

        // Floating-Point Numeric Types
        float numFloat = 3.14f;  // 32 bits (single precision)
        double numDouble = 3.14159265359; // 64 bits (double precision)
        decimal numDecimal = 79228162514264337593543950335m; // 128 bits (high precision for monetary values)

        // Char Type
        char letter = 'A'; // Stores a single Unicode character

        // Boolean Type
        bool isTrue = true; // true or false

        // String Type
        string text = "Hello, C#"; // Stores a sequence of characters

        // Object Type (generic type)
        object obj = "This is an object"; // Can store any type

        // Displaying values
        Console.WriteLine($"byte: {numByte}");
        Console.WriteLine($"sbyte: {numSByte}");
        Console.WriteLine($"short: {numShort}");
        Console.WriteLine($"ushort: {numUShort}");
        Console.WriteLine($"int: {numInt}");
        Console.WriteLine($"uint: {numUInt}");
        Console.WriteLine($"long: {numLong}");
        Console.WriteLine($"ulong: {numULong}");
        Console.WriteLine($"float: {numFloat}");
        Console.WriteLine($"double: {numDouble}");
        Console.WriteLine($"decimal: {numDecimal}");
        Console.WriteLine($"char: {letter}");
        Console.WriteLine($"bool: {isTrue}");
        Console.WriteLine($"string: {text}");
        Console.WriteLine($"object: {obj}");
    }
}
