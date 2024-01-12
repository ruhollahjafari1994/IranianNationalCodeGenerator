# Iranian National Code Generator

This C# project provides functionality to generate and validate Iranian National Codes (کد ملی). The Iranian National Code is a 10-digit unique identifier with specific rules. This project offers a simple implementation for generating and validating these codes.

## Features

- **Generator:**
  - Easily generate valid Iranian National Codes.
  
- **Rounded Generator:**
  - Generate codes with rounded values.
  - Avoids cases where all digits are equal.

- **Validator:**
  - Validate the correctness of a given National Code.

## Usage

To use the code generation and validation functionalities, integrate the provided methods into your C# application. The `Main` method in the code serves as an example of how to use these functions.

```csharp
// Example Usage:
string generatedCode = Generator();
Console.WriteLine($"Generated Code: {generatedCode}");

string roundedCode = RoundGenerator();
Console.WriteLine($"Rounded Generated Code: {roundedCode}");

string validationCode = "1234567890"; // Replace with the code you want to validate
bool isValid = Validator(validationCode);
Console.WriteLine($"Validation Result: {isValid}");
