# Kalkylator_grupp - Console-Based Calculator

### Overview

This project is a simple console-based calculator that provides users with the ability to perform basic arithmetic operations such as addition, subtraction, multiplication, division, and exponentiation (power). The program runs in a loop, allowing the user to perform multiple operations until they choose to exit.

### Features

- **Addition**: Adds two integers.
- **Subtraction**: Subtracts the second integer from the first.
- **Multiplication**: Multiplies two integers.
- **Division**: Divides the first number by the second (handles division by zero).
- **Power**: Raises the first number to the power of the second.
- **Exit Option**: Allows the user to exit the program when desired.

### How to Use

1. Run the program in a console environment.
2. The program will display a list of available options:
   - Option 1: Addition
   - Option 2: Subtraction
   - Option 3: Multiplication
   - Option 4: Division
   - Option 5: Power
   - Option 6: Exit
3. Enter the number corresponding to the operation you want to perform.
4. For the selected operation, input two numbers when prompted.
5. The program will display the result and return to the menu for another operation.
6. Choose Option 6 to exit the program.

### Code Structure

- **Main Program (`Main`)**:
  - The main logic runs in a loop, showing the menu and processing user input based on the selected option.
  - If an invalid input is provided, the program will notify the user and prompt them to try again.

- **Helper Methods**:
  - `GetFirstNum()`: Prompts and returns the first number input from the user.
  - `GetSecNum()`: Prompts and returns the second number input from the user.

- **Operations**:
  - `Addition(int value1, int value2)`: Returns the sum of two integers.
  - `Subtraction(int firstInt, int secondInt)`: Returns the difference between two integers.
  - `Multiplikation(int firstInt, int secondInt)`: Returns the product of two integers.
  - `Division(double a, double b)`: Returns the result of dividing two numbers, handling division by zero.
  - `Power(double a, double exponent)`: Returns the result of raising the first number to the power of the second.

### Error Handling

- **Division by Zero**: 
  - If the user attempts to divide by zero, the program will catch the `DivideByZeroException` and display an error message, returning `0` as the result.

### Future Enhancements

- **Input Validation**: Currently, the program assumes valid input from the user (integers and valid menu options). Adding validation for non-integer inputs would make the program more robust.
- **Floating Point Support**: Extend operations to accept floating point numbers for more precise calculations.
- **Advanced Operations**: Adding features like square root, logarithms, or trigonometric functions could make the calculator more versatile.

### Requirements

- **.NET SDK**: The program is built in C# and requires the .NET SDK to compile and run.
  
### Running the Program

1. Clone or download the repository.
2. Open the project in an IDE that supports C# (like Visual Studio).
3. Build and run the project to start the calculator. Follow the on-screen instructions to perform various calculations.
