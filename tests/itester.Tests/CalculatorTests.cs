using Microsoft.VisualStudio.TestTools.UnitTesting;
using itester;

namespace itester.Tests;

[TestClass]
public class CalculatorTests
{
    [DataTestMethod]
    [DataRow("12 + 3.5", 15.5)]
    [DataRow("12 - 3.5", 8.5)]
    [DataRow("2 * 4", 8.0)]
    [DataRow("8 / 2", 4.0)]
    public void Calculate_ValidExpression_ReturnsExpectedResult(string expression, double expected)
    {
        var result = Calculator.Calculate(expression);

        Assert.IsNotNull(result);
        Assert.AreEqual(expected, result.Value, 0.000001);
    }

    [DataTestMethod]
    [DataRow("")]
    [DataRow("   ")]
    [DataRow("1 +")]
    [DataRow("one + 2")]
    [DataRow("1 ^ 2")]
    [DataRow("1 + 2 extra")]
    public void Calculate_InvalidExpression_ReturnsNull(string expression)
    {
        Assert.IsNull(Calculator.Calculate(expression));
    }

    [TestMethod]
    public void Calculate_DivisionByZero_ThrowsDivideByZeroException()
    {
        Assert.ThrowsException<DivideByZeroException>(() => Calculator.Calculate("8 / 0"));
    }
}
