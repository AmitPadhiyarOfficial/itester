# API Reference

## Namespace

`itester`

## Classes

### Calculator

The `Calculator` class contains static methods for performing basic arithmetic operations.

#### Methods

##### `Calculate(string expression)`

Parses and evaluates a simple arithmetic string in the format `number operator number`.

Example:

```csharp
var result = Calculator.Calculate("12 + 3.5");
```

Returns:
- `double` value on success
- `null` if the expression is invalid

##### `Add(double left, double right)`

Returns the sum of `left` and `right`.

##### `Subtract(double left, double right)`

Returns the difference of `left` and `right`.

##### `Multiply(double left, double right)`

Returns the product of `left` and `right`.

##### `Divide(double left, double right)`

Returns the quotient of `left` divided by `right`.

Throws:
- `DivideByZeroException` when `right` is zero.

## Program

The `Program` class starts the interactive console loop and reads user input.

```csharp
public static void Main()
```
