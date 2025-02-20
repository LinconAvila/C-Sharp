using System;

class OperatorsCSharp
{
    static void Main()
    {
        //Arithmetic Operators
        int a = 10, b = 3;
        Console.WriteLine("Arithmetic:");
        Console.WriteLine($"Addition: {a} + {b} = {a + b}");
        Console.WriteLine($"Subtraction: {a} - {b} = {a - b}");
        Console.WriteLine($"Multiplication: {a} * {b} = {a * b}");
        Console.WriteLine($"Division: {a} / {b} = {a / b}");
        Console.WriteLine($"Modulus: {a} % {b} = {a % b}\n");

        //Assignment Operators
        Console.WriteLine("Assignment:");
        int x = 5;
        Console.WriteLine($"x = {x}");
        x += 3; Console.WriteLine($"x += 3 → {x}");
        x -= 2; Console.WriteLine($"x -= 2 → {x}");
        x *= 4; Console.WriteLine($"x *= 4 → {x}");
        x /= 2; Console.WriteLine($"x /= 2 → {x}");
        x %= 3; Console.WriteLine($"x %= 3 → {x}\n");

        //Comparison Operators
        Console.WriteLine("Comparison:");
        Console.WriteLine($"a == b → {a == b}");
        Console.WriteLine($"a != b → {a != b}");
        Console.WriteLine($"a > b → {a > b}");
        Console.WriteLine($"a < b → {a < b}");
        Console.WriteLine($"a >= b → {a >= b}");
        Console.WriteLine($"a <= b → {a <= b}\n");

        //Logical Operators
        bool v1 = true, v2 = false;
        Console.WriteLine("Logical:");
        Console.WriteLine($"AND: {v1} && {v2} → {v1 && v2}");
        Console.WriteLine($"OR: {v1} || {v2} → {v1 || v2}");
        Console.WriteLine($"NOT: !{v1} → {!v1}\n");

        //Bitwise Operators
        int num1 = 5, num2 = 3;
        Console.WriteLine("Bitwise:");
        Console.WriteLine($"AND: {num1} & {num2} → {num1 & num2}");
        Console.WriteLine($"OR: {num1} | {num2} → {num1 | num2}");
        Console.WriteLine($"XOR: {num1} ^ {num2} → {num1 ^ num2}");
        Console.WriteLine($"NOT: ~{num1} → {~num1}");
        Console.WriteLine($"Left Shift: {num1} << 1 → {num1 << 1}");
        Console.WriteLine($"Right Shift: {num1} >> 1 → {num1 >> 1}\n");

        //Increment/Decrement Operators
        int y = 5;
        Console.WriteLine("Increment/Decrement:");
        Console.WriteLine($"Pre-increment: ++y → {++y}");
        Console.WriteLine($"Post-increment: y++ → {y++} (now y = {y})");
        Console.WriteLine($"Pre-decrement: --y → {--y}");
        Console.WriteLine($"Post-decrement: y-- → {y--} (now y = {y})\n");

        //Ternary Operator
        int age = 18;
        string message = (age >= 18) ? "Adult" : "Minor";
        Console.WriteLine("Ternary Operator:");
        Console.WriteLine($"Age: {age} → {message}\n");

        //Null Coalescing Operator (??) and Null Assignment Operator (??=)
        string name = null;
        Console.WriteLine("Null Coalescing:");
        Console.WriteLine($"name ?? \"Unknown\" → {name ?? "Unknown"}");
        name ??= "Default";
        Console.WriteLine($"After ??= name → {name}\n");

        //Type Casting Operator
        Console.WriteLine("Casting:");
        double d = 9.78;
        int integer = (int)d; // Explicit Casting
        Console.WriteLine($"double {d} → int {integer}\n");
    }
}
