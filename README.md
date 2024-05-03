# Grade Calculator
## Description:
This C# console application, **GradeCalculator**, is designed to calculate and manage student grades over a semester. 
Users enter student IDs and their marks for four courses. The program then calculates the average grade, determines the final grade, and outputs whether the student has passed or failed the semester.

## Installation:
To run this program, you need:
1. A C# compatible IDE or a runtime environment that can compile and execute C# code (e.g., Visual Studio, .NET Core).
2. Open the program in a C# IDE or navigate to the directory containing the `program.cs` file in your command line.
3. Compile the program using the C# compiler.
4. Execute the compiled file.

## How It Works:
The application prompts the user to enter a student ID and their marks for four different courses. If a user enters '0' for the student ID, the program will stop requesting further inputs and will provide a summary report that includes:
- The highest average grade among the entered students.
- The number of students passing.
- The number of students failing.

The grades are assigned based on the following criteria:

- A: Average 70% and above
- B: Average 60% to 69%
- D: Average 40% to 59%
- F: Below 40%

## Key Features:
- Inputs for multiple students.
- Calculation of average marks and final grade.
- Summary report of all entries upon completion.   
