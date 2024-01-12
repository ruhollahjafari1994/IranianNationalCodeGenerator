// See https://aka.ms/new-console-template for more information


// Example Usage:
using IranianNationalCodeGenerator;

string generatedCode = NationalCode.Generator();
Console.WriteLine($"Generated Code: {generatedCode}");

string roundedCode = NationalCode.RoundGenerator();
Console.WriteLine($"Rounded Generated Code: {roundedCode}");

string validationCode = "1234567890"; // Replace with the code you want to validate
bool isValid = NationalCode.Validator(validationCode);
Console.WriteLine($"Validation Result: {isValid}");