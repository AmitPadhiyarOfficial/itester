using System.Globalization;

namespace itester;

/// <summary>
/// Entry point for the four-operation calculator console application.
/// </summary>
public static class Program
{
    /// <summary>
    /// Runs the calculator loop and accepts user input until the user exits.
    /// </summary>
    public static void Main()
    {
        Console.WriteLine("Four-Operation Calculator");
        Console.WriteLine("Enter an expression such as 12 + 3.5, or type 'q' to quit.");

        while (true)
        {
            Console.Write("> ");
            var input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input) || input.Trim().Equals("q", StringComparison.OrdinalIgnoreCase))
            {
                break;
            }

            var result = Calculator.Calculate(input);
            if (result is null)
            {
                Console.WriteLine("Invalid input. Enter two numbers and an operator, for example: 12 + 3.5");
                continue;
            }

            Console.WriteLine(result.Value.ToString(CultureInfo.InvariantCulture));
        }
    }
}

/// <summary>
/// Provides basic arithmetic operations for addition, subtraction, multiplication, and division.
/// </summary>
public static class Calculator
{
    /// <summary>
    /// Attempts to evaluate a simple arithmetic expression formatted as "number operator number".
    /// </summary>
    /// <param name="expression">The expression to evaluate. Example: "12 + 3.5".</param>
    /// <returns>
    /// The computed numeric result, or <see langword="null"/> if the expression is invalid or cannot be evaluated.
    /// </returns>
    public static double? Calculate(string expression)
    {
        if (string.IsNullOrWhiteSpace(expression))
        {
            return null;
        }

        var parts = expression.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        if (parts.Length != 3)
        {
            return null;
        }

        if (!double.TryParse(parts[0], NumberStyles.Float, CultureInfo.InvariantCulture, out var left) ||
            !double.TryParse(parts[2], NumberStyles.Float, CultureInfo.InvariantCulture, out var right))
        {
            return null;
        }

        return parts[1] switch
        {
            "+" => Add(left, right),
            "-" => Subtract(left, right),
            "*" => Multiply(left, right),
            "/" => Divide(left, right),
            _ => null
        };
    }

    /// <summary>
    /// Adds two numbers.
    /// </summary>
    /// <param name="left">The left operand.</param>
    /// <param name="right">The right operand.</param>
    /// <returns>The sum of the operands.</returns>
    public static double Add(double left, double right) => left + right;

    /// <summary>
    /// Subtracts one number from another.
    /// </summary>
    /// <param name="left">The value to subtract from.</param>
    /// <param name="right">The value to subtract.</param>
    /// <returns>The difference between the operands.</returns>
    public static double Subtract(double left, double right) => left - right;

    /// <summary>
    /// Multiplies two numbers.
    /// </summary>
    /// <param name="left">The first operand.</param>
    /// <param name="right">The second operand.</param>
    /// <returns>The product of the operands.</returns>
    public static double Multiply(double left, double right) => left * right;

    /// <summary>
    /// Divides one number by another.
    /// </summary>
    /// <param name="left">The dividend.</param>
    /// <param name="right">The divisor.</param>
    /// <returns>The quotient of the operands.</returns>
    /// <exception cref="DivideByZeroException">Thrown when the divisor is zero.</exception>
    public static double Divide(double left, double right)
    {
        if (right == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }

        return left / right;
    }
}
