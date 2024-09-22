using System.Collections.Generic;

namespace DartPracticeApp
{
    public static class ProblemList
    {
        private static int GetScoreValue(string difficultyLevel)
        {
            switch (difficultyLevel.ToLower())
            {
                case "easy":
                    return 1;
                case "medium":
                    return 3;
                case "hard":
                    return 5;
                default:
                    return 0; // or throw an exception for invalid levels
            }
        }
        public static List<Problem> GetProblems()
        {
            return new List<Problem>
            {
                new Problem
                {
                    GetProblem = "Print Hello World",
                    GetDescription = "",
                    GetExpectedOutput = "Hello, World!",
                    GetCode = "void main() { print('Hello, World!'); }",
                    DifficultyLevel = "Easy",
                    ScoreValue = GetScoreValue("Easy")
                },

                new Problem
                {
                    GetProblem = "Add two numbers (3 + 7)",
                    GetDescription = "Add two given numbers and print the result.",
                    GetExpectedOutput = "10",
                    GetCode = "void main() { int a = 3; int b = 7; print(a + b); }",
                    DifficultyLevel = "Easy",
                    ScoreValue = GetScoreValue("Easy")
                },

                new Problem
                {
                    GetProblem = "Check if a number is even or odd",
                    GetDescription = "Check whether a given number is even or odd.",
                    GetExpectedOutput = "Even",
                    GetCode = "void main() { int num = 10; if (num % 2 == 0) { print('Even'); } else { print('Odd'); } }",
                    DifficultyLevel = "Easy",
                    ScoreValue = GetScoreValue("Easy")                
                },

                new Problem
                {
                    GetProblem = "Find the largest number",
                    GetDescription = "Find the largest of three numbers (12, 5, 20).",
                    GetExpectedOutput = "20",
                    GetCode = "void main() { int a = 12; int b = 5; int c = 20; print([a, b, c].reduce((curr, next) => curr > next ? curr : next)); }",
                    DifficultyLevel = "Medium",
                    ScoreValue = GetScoreValue("Medium")
                },

                new Problem
                {
                    GetProblem = "Reverse a string",
                    GetDescription = "Reverse the string 'Dart'.",
                    GetExpectedOutput = "traD",
                    GetCode = "void main() { String str = 'Dart'; print(str.split('').reversed.join()); }",
                    DifficultyLevel = "Medium",
                    ScoreValue = GetScoreValue("Medium")
                },

                new Problem
                {
                    GetProblem = "Factorial of a number",
                    GetDescription = "Find the factorial of the number 5.",
                    GetExpectedOutput = "120",
                    GetCode = "int factorial(int n) => n <= 1 ? 1 : n * factorial(n - 1); void main() { print(factorial(5)); }",
                    DifficultyLevel = "Medium",
                    ScoreValue = GetScoreValue("Medium")
                },

                new Problem
                {
                    GetProblem = "Fibonacci sequence up to 7 terms",
                    GetDescription = "Print the first 7 numbers of the Fibonacci sequence.",
                    GetExpectedOutput = "0 1 1 2 3 5 8",
                    GetCode = "void main() { int a = 0, b = 1; print('$a $b'); for (int i = 2; i < 7; i++) { int next = a + b; print(next); a = b; b = next; } }",
                    DifficultyLevel = "Medium",
                    ScoreValue = GetScoreValue("Medium")
                },

                new Problem
                {
                    GetProblem = "Sum of digits of a number",
                    GetDescription = "Find the sum of digits of the number 1234.",
                    GetExpectedOutput = "10",
                    GetCode = "void main() { int num = 1234; int sum = num.toString().split('').map(int.parse).reduce((a, b) => a + b); print(sum); }",
                    DifficultyLevel = "Medium",
                    ScoreValue = GetScoreValue("Medium")
                },

                new Problem
                {
                    GetProblem = "Palindrome check",
                    GetDescription = "Check if the string 'racecar' is a palindrome.",
                    GetExpectedOutput = "true",
                    GetCode = "void main() { String str = 'racecar'; print(str == str.split('').reversed.join()); }",
                    DifficultyLevel = "Hard",
                    ScoreValue = GetScoreValue("Hard")
                },

                new Problem
                {
                    GetProblem = "Find prime numbers up to 20",
                    GetDescription = "Print all prime numbers between 1 and 20.",
                    GetExpectedOutput = "2 3 5 7 11 13 17 19",
                    GetCode = "bool isPrime(int num) { if (num <= 1) return false; for (int i = 2; i <= num ~/ 2; i++) { if (num % i == 0) return false; } return true; } void main() { for (int i = 1; i <= 20; i++) { if (isPrime(i)) print(i); } }",
                    DifficultyLevel = "Hard",
                    ScoreValue = GetScoreValue("Hard")
                },

                new Problem
                {
                    GetProblem = "Convert Celsius to Fahrenheit",
                    GetDescription = "Convert a temperature of 25°C to Fahrenheit.",
                    GetExpectedOutput = "77",
                    GetCode = "void main() { double celsius = 25; double fahrenheit = (celsius * 9/5) + 32; print(fahrenheit); }",
                    DifficultyLevel = "Easy",
                    ScoreValue = GetScoreValue("Easy")
                },

                new Problem
                {
                    GetProblem = "Check if a number is positive or negative",
                    GetDescription = "Check if the number -5 is positive, negative, or zero.",
                    GetExpectedOutput = "Negative",
                    GetCode = "void main() { int num = -5; if (num > 0) { print('Positive'); } else if (num < 0) { print('Negative'); } else { print('Zero'); } }",
                    DifficultyLevel = "Easy",
                   ScoreValue = GetScoreValue("Easy")
                },

                new Problem
                {
                    GetProblem = "Find the area of a circle",
                    GetDescription = "Calculate the area of a circle with a radius of 7.",
                    GetExpectedOutput = "153.93804002589985",
                    GetCode = "import 'dart:math'; void main() { double radius = 7; double area = pi * radius * radius; print(area); }",
                    DifficultyLevel = "Easy",
                    ScoreValue = GetScoreValue("Easy")
                },

                new Problem
                {
                    GetProblem = "Count the number of vowels in a string",
                    GetDescription = "Count how many vowels are in the string 'education'.",
                    GetExpectedOutput = "5",
                    GetCode = "void main() { String str = 'education'; int count = str.split('').where((char) => 'aeiou'.contains(char)).length; print(count); }",
                    DifficultyLevel = "Medium",
                    ScoreValue = GetScoreValue("Medium")
                },

                new Problem
                {
                    GetProblem = "Check if a number is prime",
                    GetDescription = "Check if the number 29 is a prime number.",
                    GetExpectedOutput = "true",
                    GetCode = "bool isPrime(int num) { if (num <= 1) return false; for (int i = 2; i <= num ~/ 2; i++) { if (num % i == 0) return false; } return true; } void main() { print(isPrime(29)); }",
                    DifficultyLevel = "Medium",
                    ScoreValue = GetScoreValue("Medium")
                },

                new Problem
                {
                    GetProblem = "Sum of first N natural numbers",
                    GetDescription = "Find the sum of the first 10 natural numbers.",
                    GetExpectedOutput = "55",
                    GetCode = "void main() { int sum = 0; for (int i = 1; i <= 10; i++) { sum += i; } print(sum); }",
                    DifficultyLevel = "Easy",
                    ScoreValue = GetScoreValue("Easy")
                },

                new Problem
                {
                    GetProblem = "Find the greatest common divisor (GCD)",
                    GetDescription = "Find the GCD of 48 and 18.",
                    GetExpectedOutput = "6",
                    GetCode = "int gcd(int a, int b) { return b == 0 ? a : gcd(b, a % b); } void main() { print(gcd(48, 18)); }",
                    DifficultyLevel = "Medium",
                    ScoreValue = GetScoreValue("Medium")
                },

                new Problem
                {
                    GetProblem = "Check if a number is Armstrong",
                    GetDescription = "Check if 153 is an Armstrong number.",
                    GetExpectedOutput = "true",
                    GetCode = "void main() { int num = 153; int sum = 0; String numStr = num.toString(); for (int i = 0; i < numStr.length; i++) { sum += int.parse(numStr[i]) * int.parse(numStr[i]) * int.parse(numStr[i]); } print(sum == num); }",
                    DifficultyLevel = "Medium",
                    ScoreValue = GetScoreValue("Medium")
                },

                new Problem
                {
                    GetProblem = "Print multiplication table of 5",
                    GetDescription = "Print the multiplication table of 5 up to 10 terms.",
                    GetExpectedOutput = "5\n 10\n 15\n 20\n 25\n 30\n 35\n 40\n 45\n 50",
                    GetCode = "void main() { int num = 5; for (int i = 1; i <= 10; i++) { print(num * i); } }",
                    DifficultyLevel = "Easy",
                    ScoreValue = GetScoreValue("Easy")
                },

                new Problem
                {
                    GetProblem = "Swap two variables",
                    GetDescription = "Swap the values of two variables, a = 5 and b = 10.",
                    GetExpectedOutput = "a = 10, b = 5",
                    GetCode = @"void main() { int a = 5, b = 10; int temp = a; a = b; b = temp; print('a = \$a, b = \$b'); }",
                    DifficultyLevel = "Easy",
                    ScoreValue = GetScoreValue("Easy")
                },

                new Problem
                {
                    GetProblem = "Sum of even numbers between 1 and 10",
                    GetDescription = "Calculate the sum of all even numbers between 1 and 10.",
                    GetExpectedOutput = "30",
                    GetCode = "void main() { int sum = 0; for (int i = 1; i <= 10; i++) { if (i % 2 == 0) { sum += i; } } print(sum); }",
                    DifficultyLevel = "Easy",
                    ScoreValue = GetScoreValue("Easy")
                },

                new Problem
                {
                    GetProblem = "Find the length of a string",
                    GetDescription = "Find the length of the string 'Flutter'.",
                    GetExpectedOutput = "7",
                    GetCode = "void main() { String str = 'Flutter'; print(str.length); }",
                    DifficultyLevel = "Easy",
                    ScoreValue = GetScoreValue("Easy")
                },

                new Problem
                {
                    GetProblem = "Sum of squares of first 5 natural numbers",
                    GetDescription = "Find the sum of squares of the first 5 natural numbers.",
                    GetExpectedOutput = "55",
                    GetCode = "void main() { int sum = 0; for (int i = 1; i <= 5; i++) { sum += i * i; } print(sum); }",
                    DifficultyLevel = "Medium",
                    ScoreValue = GetScoreValue("Medium")
                },

                new Problem
                {
                    GetProblem = "Convert lowercase to uppercase",
                    GetDescription = "Convert the string 'hello' to uppercase.",
                    GetExpectedOutput = "HELLO",
                    GetCode = "void main() { String str = 'hello'; print(str.toUpperCase()); }",
                    DifficultyLevel = "Easy",
                    ScoreValue = GetScoreValue("Easy")
                },

                new Problem
                {
                    GetProblem = "Find the largest element in a list",
                    GetDescription = "Find the largest element in the list [3, 7, 1, 9, 2].",
                    GetExpectedOutput = "9",
                    GetCode = "void main() { List<int> nums = [3, 7, 1, 9, 2]; print(nums.reduce((curr, next) => curr > next ? curr : next)); }",
                    DifficultyLevel = "Medium",
                    ScoreValue = GetScoreValue("Medium")
                },

                new Problem
                {
                    GetProblem = "Calculate power of a number",
                    GetDescription = "Calculate 2 raised to the power of 5.",
                    GetExpectedOutput = "32",
                    GetCode = "void main() { int base = 2; int exponent = 5; int result = 1; for (int i = 0; i < exponent; i++) { result *= base; } print(result); }",
                    DifficultyLevel = "Medium",
                    ScoreValue = GetScoreValue("Medium")
                },

                new Problem
                {
                    GetProblem = "Find the sum of a list of numbers",
                    GetDescription = "Find the sum of the list [3, 7, 1, 9, 2].",
                    GetExpectedOutput = "22",
                    GetCode = "void main() { List<int> nums = [3, 7, 1, 9, 2]; int sum = nums.reduce((a, b) => a + b); print(sum); }",
                    DifficultyLevel = "Easy",
                    ScoreValue = GetScoreValue("Easy")
                },

                new Problem
                {
                    GetProblem = "Find the average of a list of numbers",
                    GetDescription = "Find the average of the list [3, 7, 1, 9, 2].",
                    GetExpectedOutput = "4.4",
                    GetCode = "void main() { List<int> nums = [3, 7, 1, 9, 2]; double average = nums.reduce((a, b) => a + b) / nums.length; print(average); }",
                    DifficultyLevel = "Medium",
                    ScoreValue = GetScoreValue("Medium")
                },

                new Problem
                {
                    GetProblem = "Convert a number to binary",
                    GetDescription = "Convert the number 10 to binary.",
                    GetExpectedOutput = "1010",
                    GetCode = "void main() { int num = 10; print(num.toRadixString(2)); }",
                    DifficultyLevel = "Medium",
                    ScoreValue = GetScoreValue("Medium")
                },

                new Problem
                {
                    GetProblem = "Calculate compound interest",
                    GetDescription = "Calculate compound interest for principal=1000, rate=5%, time=2 years.",
                    GetExpectedOutput = "1102.5",
                    GetCode = "void main() { double principal = 1000; double rate = 5; int time = 2; double amount = principal * (1 + rate / 100).pow(time); print(amount); }",
                    DifficultyLevel = "Hard",
                    ScoreValue = GetScoreValue("Hard")
                },

                new Problem
                {
                    GetProblem = "Find the smallest number in a list",
                    GetDescription = "Find the smallest element in the list [10, 5, 30, 3, 12].",
                    GetExpectedOutput = "3",
                    GetCode = "void main() { List<int> nums = [10, 5, 30, 3, 12]; print(nums.reduce((curr, next) => curr < next ? curr : next)); }",
                    DifficultyLevel = "Medium",
                    ScoreValue = GetScoreValue("Medium")
                },

                new Problem
                {
                    GetProblem = "Check if a year is a leap year",
                    GetDescription = "Check if 2024 is a leap year.",
                    GetExpectedOutput = "true",
                    GetCode = "void main() { int year = 2024; bool leap = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0); print(leap); }",
                    DifficultyLevel = "Medium",
                    ScoreValue = GetScoreValue("Medium")
                },

                new Problem
                {
                    GetProblem = "Print the first 10 odd numbers",
                    GetDescription = "Print the first 10 odd numbers starting from 1.",
                    GetExpectedOutput = "1 3 5 7 9 11 13 15 17 19",
                    GetCode = "void main() { for (int i = 1, count = 0; count < 10; i += 2, count++) { print(i); } }",
                    DifficultyLevel = "Easy",
                    ScoreValue = GetScoreValue("Easy")
                },

                new Problem
                {
                    GetProblem = "Find the product of a list of numbers",
                    GetDescription = "Find the product of the numbers in the list [2, 4, 6].",
                    GetExpectedOutput = "48",
                    GetCode = "void main() { List<int> nums = [2, 4, 6]; int product = nums.reduce((a, b) => a * b); print(product); }",
                    DifficultyLevel = "Easy",
                    ScoreValue = GetScoreValue("Easy")
                },

                new Problem
                {
                    GetProblem = "Convert binary to decimal",
                    GetDescription = "Convert the binary number 1101 to decimal.",
                    GetExpectedOutput = "13",
                    GetCode = "void main() { String binary = '1101'; print(int.parse(binary, radix: 2)); }",
                    DifficultyLevel = "Medium",
                    ScoreValue = GetScoreValue("Medium")
                },

                new Problem
                {
                    GetProblem = "Find the sum of prime numbers up to 20",
                    GetDescription = "Find the sum of all prime numbers up to 20.",
                    GetExpectedOutput = "77",
                    GetCode = "bool isPrime(int num) { if (num <= 1) return false; for (int i = 2; i <= num ~/ 2; i++) { if (num % i == 0) return false; } return true; } void main() { int sum = 0; for (int i = 1; i <= 20; i++) { if (isPrime(i)) sum += i; } print(sum); }",
                    DifficultyLevel = "Medium",
                    ScoreValue = GetScoreValue("Medium")
                },

                new Problem
                {
                    GetProblem = "Check if two strings are anagrams",
                    GetDescription = "Check if 'listen' and 'silent' are anagrams.",
                    GetExpectedOutput = "true",
                    GetCode = "void main() { String str1 = 'listen'; String str2 = 'silent'; print(str1.split('').toList()..sort() == str2.split('').toList()..sort()); }",
                    DifficultyLevel = "Medium",
                    ScoreValue = GetScoreValue("Medium")
                },

                new Problem
                {
                    GetProblem = "Find the sum of squares of even numbers up to 10",
                    GetDescription = "Find the sum of the squares of all even numbers from 1 to 10.",
                    GetExpectedOutput = "220",
                    GetCode = "void main() { int sum = 0; for (int i = 1; i <= 10; i++) { if (i % 2 == 0) { sum += i * i; } } print(sum); }",
                    DifficultyLevel = "Medium",
                    ScoreValue = GetScoreValue("Medium")
                },

                new Problem
                {
                    GetProblem = "Remove duplicates from a list",
                    GetDescription = "Remove duplicate elements from the list [1, 2, 2, 3, 4, 4, 5].",
                    GetExpectedOutput = "[1, 2, 3, 4, 5]",
                    GetCode = "void main() { List<int> nums = [1, 2, 2, 3, 4, 4, 5]; List<int> uniqueNums = nums.toSet().toList(); print(uniqueNums); }",
                    DifficultyLevel = "Easy",
                    ScoreValue = GetScoreValue("Easy")
                },

                new Problem
                {
                    GetProblem = "Print all even numbers in a list",
                    GetDescription = "Print all even numbers from the list [10, 21, 32, 43, 54].",
                    GetExpectedOutput = "10 32 54",
                    GetCode = "void main() { List<int> nums = [10, 21, 32, 43, 54]; nums.where((num) => num % 2 == 0).forEach(print); }",
                    DifficultyLevel = "Easy",
                    ScoreValue = GetScoreValue("Easy")
                },

                new Problem
                {
                    GetProblem = "Find the square root of a number",
                    GetDescription = "Find the square root of 81.",
                    GetExpectedOutput = "9.0",
                    GetCode = "import 'dart:math'; void main() { print(sqrt(81)); }",
                    DifficultyLevel = "Easy",
                    ScoreValue = GetScoreValue("Easy")
                },

                new Problem
                {
                    GetProblem = "Check if a string is a palindrome",
                    GetDescription = "Check if the string 'madam' is a palindrome.",
                    GetExpectedOutput = "true",
                    GetCode = "void main() { String str = 'madam'; print(str == str.split('').reversed.join()); }",
                    DifficultyLevel = "Medium",
                    ScoreValue = GetScoreValue("Medium")
                },

                new Problem
                {
                    GetProblem = "Find the LCM of two numbers",
                    GetDescription = "Find the least common multiple (LCM) of 12 and 18.",
                    GetExpectedOutput = "36",
                    GetCode = "int gcd(int a, int b) => b == 0 ? a : gcd(b, a % b); int lcm(int a, int b) => (a * b) ~/ gcd(a, b); void main() { print(lcm(12, 18)); }",
                    DifficultyLevel = "Medium",
                    ScoreValue = GetScoreValue("Medium")
                },

                new Problem
                {
                    GetProblem = "Calculate the sum of digits of a string",
                    GetDescription = "Calculate the sum of the digits in the string 'a1b2c3'.",
                    GetExpectedOutput = "6",
                    GetCode = "void main() { String str = 'a1b2c3'; int sum = str.split('').where((char) => int.tryParse(char) != null).map(int.parse).reduce((a, b) => a + b); print(sum); }",
                    DifficultyLevel = "Medium",
                    ScoreValue = GetScoreValue("Medium")
                },

                new Problem
                {
                    GetProblem = "Count the number of consonants in a string",
                    GetDescription = "Count the number of consonants in the string 'hello'.",
                    GetExpectedOutput = "3",
                    GetCode = "void main() { String str = 'hello'; int count = str.split('').where((char) => !'aeiou'.contains(char) && char != ' ').length; print(count); }",
                    DifficultyLevel = "Medium",
                    ScoreValue = GetScoreValue("Medium")
                },

                new Problem
                {
                    GetProblem = "Find the second largest number in a list",
                    GetDescription = "Find the second largest number in the list [12, 35, 1, 10, 34].",
                    GetExpectedOutput = "34",
                    GetCode = "void main() { List<int> nums = [12, 35, 1, 10, 34]; nums.sort(); print(nums[nums.length - 2]); }",
                    DifficultyLevel = "Medium",
                    ScoreValue = GetScoreValue("Medium")
                },

                new Problem
                {
                    GetProblem = "Generate a list of squares",
                    GetDescription = "Generate a list of squares from 1 to 5.",
                    GetExpectedOutput = "[1, 4, 9, 16, 25]",
                    GetCode = "void main() { List<int> squares = [for (int i = 1; i <= 5; i++) i * i]; print(squares); }",
                    DifficultyLevel = "Easy",
                    ScoreValue = GetScoreValue("Easy")
                },

                new Problem
                {
                    GetProblem = "Convert a list of integers to a string",
                    GetDescription = "Convert the list [1, 2, 3] to a string.",
                    GetExpectedOutput = "123",
                    GetCode = "void main() { List<int> nums = [1, 2, 3]; print(nums.join()); }",
                    DifficultyLevel = "Easy",
                    ScoreValue = GetScoreValue("Easy")
                },
                new Problem
                {
                    GetProblem = "Write a program to print your name in Dart.",
                    GetDescription = "",
                    GetExpectedOutput = "Your Name",
                    GetCode = "void main() { print('Your Name'); }",
                    DifficultyLevel = "Easy",
                    ScoreValue = GetScoreValue("Easy")
                },

                new Problem
                {
                    GetProblem = "Write a program to print Hello I am “John Doe” and Hello I’am “John Doe” with single and double quotes.",
                    GetDescription = "",
                    GetExpectedOutput = "Hello I am “John Doe”\nHello I’am “John Doe”",
                    GetCode = "void main() { print('Hello I am \"John Doe\"'); print(\"Hello I'am 'John Doe'\"); }",
                    DifficultyLevel = "Easy",
                    ScoreValue = GetScoreValue("Easy")
                },

                new Problem
                {
                    GetProblem = "Declare constant type of int set value 7.",
                    GetDescription = "",
                    GetExpectedOutput = "7",
                    GetCode = "void main() { const int value = 7; print(value); }",
                    DifficultyLevel = "Easy",
                    ScoreValue = GetScoreValue("Easy")
                },

                new Problem
                {
                    GetProblem = "Write a program in Dart that finds simple interest. Formula= (p * t * r) / 100",
                    GetDescription = "",
                    GetExpectedOutput = "Simple Interest: [calculated value]",
                    GetCode = @"void main() { double p = 1000, t = 3, r = 5; double si = (p * t * r) / 100; print('Simple Interest: \$si'); }",
                    DifficultyLevel = "Medium",
                    ScoreValue = GetScoreValue("Medium")
                },

                new Problem
                {
                    GetProblem = "Write a program to print a square of a number using user input.",
                    GetDescription = "",
                    GetExpectedOutput = "Square: [calculated value]",
                    GetCode = @"import 'dart:io'; void main() { print('Enter a number:'); int num = int.parse(stdin.readLineSync()!); print('Square: \${num * num}'); }",
                    DifficultyLevel = "Medium",
                    ScoreValue = GetScoreValue("Medium")
                },

                new Problem
                {
                    GetProblem = "Write a program to print full name from first name and last name using user input.",
                    GetDescription = "",
                    GetExpectedOutput = "Full Name: [first name] [last name]",
                    GetCode = @"import 'dart:io'; void main() { print('Enter your first name:'); String firstName = stdin.readLineSync()!; print('Enter your last name:'); String lastName = stdin.readLineSync()!; print('Full Name: \$firstName \$lastName'); }",
                    DifficultyLevel = "Easy",
                    ScoreValue = GetScoreValue("Easy")
                },

                new Problem
                {
                    GetProblem = "Write a program to find quotient and remainder of two integers.",
                    GetDescription = "",
                    GetExpectedOutput = "Quotient: [calculated value]\nRemainder: [calculated value]",
                    GetCode = @"void main() { int a = 15, b = 4; print('Quotient: \${a ~/ b}'); print('Remainder: \${a % b}'); }",
                    DifficultyLevel = "Medium",
                    ScoreValue = GetScoreValue("Medium")
                },

                new Problem
                {
                    GetProblem = "Write a program to swap two numbers.",
                    GetDescription = "",
                    GetExpectedOutput = "Swapped Numbers: [new value1], [new value2]",
                    GetCode = @"void main() { int a = 5, b = 10; print('Before Swap: a=\$a, b=\$b'); int temp = a; a = b; b = temp; print('After Swap: a=\$a, b=\$b'); }",
                    DifficultyLevel = "Medium",
                    ScoreValue = GetScoreValue("Medium")
                },

                new Problem
                {
                    GetProblem = "Write a program in Dart to remove all whitespaces from a string.",
                    GetDescription = "",
                    GetExpectedOutput = "[string without whitespaces]",
                    GetCode = "void main() { String str = 'Hello World'; String result = str.replaceAll(' ', ''); print(result); }",
                    DifficultyLevel = "Easy",
                    ScoreValue = GetScoreValue("Easy")
                },

                new Problem
                {
                    GetProblem = "Write a Dart program to convert string to int.",
                    GetDescription = "",
                    GetExpectedOutput = "[converted integer]",
                    GetCode = "void main() { String str = '123'; int value = int.parse(str); print(value); }",
                    DifficultyLevel = "Easy",
                    ScoreValue = GetScoreValue("Easy")
                },

                new Problem
                {
                    GetProblem = "Write a program to calculate the split amount of a bill. Formula= (total bill amount) / number of people",
                    GetDescription = "",
                    GetExpectedOutput = "Split Amount: [calculated value]",
                    GetCode = @"void main() { double totalBill = 200, people = 4; double splitAmount = totalBill / people; print('Split Amount: \$splitAmount'); }",
                    DifficultyLevel = "Medium",
                    ScoreValue = GetScoreValue("Medium")
                },

                new Problem
                {
                    GetProblem = "Write a program to calculate time taken to reach office in minutes. Formula= (distance) / (speed)",
                    GetDescription = "",
                    GetExpectedOutput = "Time Taken: [calculated value] minutes",
                    GetCode = @"void main() { double distance = 25, speed = 40; double time = (distance / speed) * 60; print('Time Taken: \$time minutes'); }",
                    DifficultyLevel = "Medium",
                    ScoreValue = GetScoreValue("Medium")
                },
                new Problem
                {
                    GetProblem = "Write a program to implement a simple version of the Merge Sort algorithm.",
                    GetDescription = "Merge Sort is a divide-and-conquer algorithm that splits an array into smaller sub-arrays, sorts them, and then merges them back together.",
                    GetExpectedOutput = "[3, 9, 10, 27, 38, 43, 82]",
                    GetCode = @"
                    void mergeSort(List<int> arr) {
                      if (arr.length <= 1) return;
                      int mid = arr.length ~/ 2;
                      List<int> left = arr.sublist(0, mid);
                      List<int> right = arr.sublist(mid);
                      mergeSort(left);
                      mergeSort(right);
                      merge(arr, left, right);
                    }
    
                    void merge(List<int> arr, List<int> left, List<int> right) {
                      int i = 0, j = 0, k = 0;
                      while (i < left.length && j < right.length) {
                        if (left[i] <= right[j]) {
                          arr[k++] = left[i++];
                        } else {
                          arr[k++] = right[j++];
                        }
                      }
                      while (i < left.length) arr[k++] = left[i++];
                      while (j < right.length) arr[k++] = right[j++];
                    }
    
                    void main() {
                      List<int> arr = [38, 27, 43, 3, 9, 82, 10];
                      mergeSort(arr);
                      print(arr); // Output: [3, 9, 10, 27, 38, 43, 82]
                    }
                    ",
                    DifficultyLevel = "Hard",
                    ScoreValue = GetScoreValue("Hard")
                },

                new Problem
                {
                    GetProblem = "Write a program to find the nth Fibonacci number using dynamic programming.",
                    GetDescription = "The Fibonacci sequence is a series where each number is the sum of the two preceding ones, usually starting with 0 and 1.",
                    GetExpectedOutput = "Nth Fibonacci number: 55",
                    GetCode = @"
                    int fibonacci(int n) {
                      List<int> fib = List<int>.filled(n + 1, 0);
                      fib[1] = 1;
                      for (int i = 2; i <= n; i++) {
                        fib[i] = fib[i - 1] + fib[i - 2];
                      }
                      return fib[n];
                    }
    
                    void main() {
                      int n = 10; // Example
                      print('Nth Fibonacci number: \${fibonacci(n)}'); // Output: Nth Fibonacci number: 55
                    }
                    ",
                    DifficultyLevel = "Hard",
                    ScoreValue = GetScoreValue("Hard")
                },

                new Problem
                {
                    GetProblem = "Write a program to solve the Tower of Hanoi problem using recursion.",
                    GetDescription = "The Tower of Hanoi is a mathematical puzzle where you have three rods and multiple disks of different sizes, and you must move all disks from one rod to another, following specific rules.",
                    GetExpectedOutput = "[Moves for all disks from A to C]",
                    GetCode = @"
                    void hanoi(int n, String from, String to, String aux) {
                      if (n == 1) {
                        print('Move disk 1 from \$from to \$to');
                        return;
                      }
                      hanoi(n - 1, from, aux, to);
                      print('Move disk \$n from \$from to \$to');
                      hanoi(n - 1, aux, to, from);
                    }
    
                    void main() {
                      int n = 3; // Number of disks
                      hanoi(n, 'A', 'C', 'B'); // A, B, C are the names of the rods
                    }
                    ",
                    DifficultyLevel = "Hard",
                    ScoreValue = GetScoreValue("Hard")
                },

                new Problem
                {
                    GetProblem = "Write a Dart program to implement a binary search on a sorted array.",
                    GetDescription = "Binary search is a search algorithm that finds the position of a target value within a sorted array by dividing the search interval in half.",
                    GetExpectedOutput = "Element found at index 3",
                    GetCode = @"
                    int binarySearch(List<int> arr, int target) {
                      int low = 0, high = arr.length - 1;
                      while (low <= high) {
                        int mid = (low + high) ~/ 2;
                        if (arr[mid] == target) {
                          return mid;
                        } else if (arr[mid] < target) {
                          low = mid + 1;
                        } else {
                          high = mid - 1;
                        }
                      }
                      return -1;
                    }
    
                    void main() {
                      List<int> arr = [2, 3, 4, 10, 40];
                      int target = 10;
                      int result = binarySearch(arr, target);
                      if (result != -1) {
                        print('Element found at index \$result'); // Output: Element found at index 3
                      } else {
                        print('Element not found');
                      }
                    }
                    ",
                    DifficultyLevel = "Hard",
                    ScoreValue = GetScoreValue("Hard")
                },

                new Problem
                {
                    GetProblem = "Write a program to check whether a given number is a prime number using a more efficient method.",
                    GetDescription = "A prime number is a natural number greater than 1 that has no positive divisors other than 1 and itself.",
                    GetExpectedOutput = "29 is Prime",
                    GetCode = @"
                    bool isPrime(int n) {
                      if (n <= 1) return false;
                      if (n <= 3) return true;
                      if (n % 2 == 0 || n % 3 == 0) return false;
                      for (int i = 5; i * i <= n; i += 6) {
                        if (n % i == 0 || n % (i + 2) == 0) return false;
                      }
                      return true;
                    }
    
                    void main() {
                      int n = 29; // Example
                      if (isPrime(n)) {
                        print('\$n is Prime'); // Output: 29 is Prime
                      } else {
                        print('\$n is Not Prime');
                      }
                    }
                    ",
                    DifficultyLevel = "Hard",
                    ScoreValue = GetScoreValue("Hard")
                },

                new Problem
                {
                    GetProblem = "Write a program to find the shortest path in a graph using Dijkstra's algorithm.",
                    GetDescription = "Dijkstra's algorithm finds the shortest paths between nodes in a graph, which may represent, for example, road networks.",
                    GetExpectedOutput = "[Shortest paths from source node]",
                    GetCode = @"
                    import 'dart:collection';

                    class Graph {
                      Map<int, List<List<int>>> adjList = {};

                      void addEdge(int u, int v, int weight) {
                        adjList.putIfAbsent(u, () => []);
                        adjList[u]!.add([v, weight]);
                      }

                      void dijkstra(int src, int n) {
                        List<int> dist = List.filled(n, double.infinity.toInt());
                        dist[src] = 0;
                        var pq = PriorityQueue<List<int>>((a, b) => a[1].compareTo(b[1]));
                        pq.add([src, 0]);

                        while (pq.isNotEmpty) {
                          var u = pq.removeFirst();
                          int node = u[0], d = u[1];
                          if (d > dist[node]) continue;

                          for (var neighbor in adjList[node] ?? []) {
                            int v = neighbor[0], weight = neighbor[1];
                            if (dist[node] + weight < dist[v]) {
                              dist[v] = dist[node] + weight;
                              pq.add([v, dist[v]]);
                            }
                          }
                        }
                        print(dist); // Output: Shortest paths
                      }
                    }

                    void main() {
                      var g = Graph();
                      g.addEdge(0, 1, 9);
                      g.addEdge(0, 2, 6);
                      g.addEdge(0, 3, 5);
                      g.addEdge(0, 4, 3);
                      g.addEdge(2, 1, 2);
                      g.addEdge(2, 3, 4);
                      g.dijkstra(0, 5);
                    }
                    ",
                    DifficultyLevel = "Hard",
                    ScoreValue = GetScoreValue("Hard")
                },

                new Problem
                {
                    GetProblem = "Write a program to implement a depth-first search (DFS) traversal in a graph.",
                    GetDescription = "Depth-First Search (DFS) is an algorithm for traversing or searching tree or graph data structures.",
                    GetExpectedOutput = "[Nodes in DFS order]",
                    GetCode = @"
                    class Graph {
                      Map<int, List<int>> adjList = {};

                      void addEdge(int u, int v) {
                        adjList.putIfAbsent(u, () => []);
                        adjList[u]!.add(v);
                      }

                      void dfs(int start, Set<int> visited) {
                        if (!visited.contains(start)) {
                          print(start);
                          visited.add(start);
                          for (var neighbor in adjList[start] ?? []) {
                            dfs(neighbor, visited);
                          }
                        }
                      }
                    }

                    void main() {
                      var g = Graph();
                      g.addEdge(0, 1);
                      g.addEdge(0, 2);
                      g.addEdge(1, 2);
                      g.addEdge(2, 0);
                      g.addEdge(2, 3);
                      g.addEdge(3, 3);
                      var visited = <int>{};
                      g.dfs(2, visited); // Output: Nodes in DFS order
                    }
                    ",
                    DifficultyLevel = "Hard",
                    ScoreValue = GetScoreValue("Hard")
                },

                new Problem
                {
                    GetProblem = "Write a Dart program to find all the permutations of a given string.",
                    GetDescription = "A permutation of a string is a rearrangement of its letters.",
                    GetExpectedOutput = "ABC\r\nACB\r\nBAC\r\nBCA\r\nCBA\r\nCAB",
                    GetCode = @"
                    void permute(String str, int l, int r) {
                      if (l == r) {
                        print(str); // Outputs all permutations
                      } else {
                        for (int i = l; i <= r; i++) {
                          str = swap(str, l, i);
                          permute(str, l + 1, r);
                          str = swap(str, l, i);
                        }
                      }
                    }

                    String swap(String str, int i, int j) {
                      var charArray = str.split('');
                      String temp = charArray[i];
                      charArray[i] = charArray[j];
                      charArray[j] = temp;
                      return charArray.join();
                    }

                    void main() {
                      String str = 'ABC';
                      int n = str.length;
                      permute(str, 0, n - 1); // Outputs all permutations
                    }
                    ",
                    DifficultyLevel = "Hard",
                    ScoreValue = GetScoreValue("Hard")
                },

                new Problem
                {
                    GetProblem = "Write a program to implement the Knapsack problem using dynamic programming.",
                    GetDescription = "The knapsack problem is a combinatorial optimization problem.",
                    GetExpectedOutput = "Maximum value in knapsack: 220",
                    GetCode = @"
                    int knapSack(int W, List<int> wt, List<int> val, int n) {
                      List<List<int>> dp = List.generate(n + 1, (_) => List.filled(W + 1, 0));
                      for (int i = 0; i <= n; i++) {
                        for (int w = 0; w <= W; w++) {
                          if (i == 0 || w == 0) {
                            dp[i][w] = 0;
                          } else if (wt[i - 1] <= w) {
                            dp[i][w] = max(val[i - 1] + dp[i - 1][w - wt[i - 1]], dp[i - 1][w]);
                          } else {
                            dp[i][w] = dp[i - 1][w];
                          }
                        }
                      }
                      return dp[n][W];
                    }

                    int max(int a, int b) => (a > b) ? a : b;

                    void main() {
                      List<int> val = [60, 100, 120];
                      List<int> wt = [10, 20, 30];
                      int W = 50;
                      int n = val.length;
                      print('Maximum value in knapsack: \${knapSack(W, wt, val, n)}'); // Output: 220
                    }
                    ",
                    DifficultyLevel = "Hard",
                    ScoreValue = GetScoreValue("Hard")
                },

                new Problem
                {
                    GetProblem = "Write a program to calculate the determinant of a matrix using recursion.",
                    GetDescription = "The determinant of a matrix is a special number that can be calculated from a square matrix.",
                    GetExpectedOutput = "Determinant: 1",
                    GetCode = @"
                    int determinant(List<List<int>> matrix, int n) {
                      if (n == 1) return matrix[0][0];
                      int det = 0;
                      for (int x = 0; x < n; x++) {
                        List<List<int>> subMatrix = List.generate(n - 1, (_) => List.filled(n - 1, 0));
                        for (int i = 1; i < n; i++) {
                          int subCol = 0;
                          for (int j = 0; j < n; j++) {
                            if (j == x) continue;
                            subMatrix[i - 1][subCol++] = matrix[i][j];
                          }
                        }
                        det += ((x % 2 == 0) ? 1 : -1) * matrix[0][x] * determinant(subMatrix, n - 1);
                      }
                      return det;
                    }

                    void main() {
                      List<List<int>> matrix = [
                        [1, 2, 3],
                        [0, 1, 4],
                        [5, 6, 0]
                      ];
                      int n = matrix.length;
                      print('Determinant: \${determinant(matrix, n)}'); // Output: 1
                    }
                    ",
                    DifficultyLevel = "Hard",
                    ScoreValue = GetScoreValue("Hard")
                }

            };
        }
    }
}
