# Tutorial

This tutorial explains how to build, run, and use the four-operation calculator.

## 1. Prerequisites

Install the .NET 8 SDK from Microsoft.

## 2. Restore and run

From the project root:

```bash
dotnet restore
dotnet run
```

## 3. Example usage

The app accepts a simple expression in the format:

```text
<number> <operator> <number>
```

Examples:

```text
12 + 3.5
8 - 2
9 * 7
20 / 4
```

## 4. Supported operations

- Addition: `+`
- Subtraction: `-`
- Multiplication: `*`
- Division: `/`

## 5. Notes

- Use a period for decimal values, such as `3.5`.
- The calculator exits when you type `q`.
- Division by zero is not allowed.

## 6. Example session

```text
Four-Operation Calculator
Enter an expression such as 12 + 3.5, or type 'q' to quit.
> 12 + 3.5
15.5
> 8 / 2
4
> q
```
