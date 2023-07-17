# PortaOne-BAD-task

This repository contains a solution for the given task that involves developing an algorithm to perform the following operations:

## Task Description

- The program accepts an arbitrary text input.
- It finds the first character in each word of the text that is no longer repeated within that word.
- From the obtained set of characters, the program selects the first unique character, which is the character that no longer appears in the set.
- The program returns the selected unique character.

## Solution Description

The solution is implemented as a WinForms application in C#. It consists of a form with a textbox for entering the text, a start button to initiate the algorithm, and a label to display the result.

The algorithm is implemented in the `UniqueChars` class. It accepts the input text as a parameter and performs the following steps:

1. It checks if the input text is empty or null and displays an appropriate message if it is.
2. It splits the text into individual words using regular expressions and stores them in a list.
3. For each word, it finds the first unique character by iterating through the characters and checking if they are unique.
4. It appends the first unique character of each word to a result string.
5. Finally, it finds the first unique character in the result string and assigns it to the `result` variable.

The WinForms application uses an instance of the `UniqueChars` class to process the input text. When the start button is clicked, the program displays the first unique character in the result label.

The solution ensures that the application handles empty or null inputs appropriately and provides the expected result as per the given task.

## Usage

To use the application, follow these steps:

1. Clone or download the repository to your local machine.
2. Navigate to the location where the application is located.
3. Open the executable file `BAD task.exe` located in `D:\.net\BAD\BAD task\bin\Debug\net6.0-windows\`.
4. The application window will open.
5. Enter the text into the textbox.
6. Click the start button to initiate the algorithm.
7. The result label will display the first unique character found in the input text.
8. To reset the application, click the reset button.

Note: The solution assumes that the .NET runtime is installed on your machine to run the application. The executable file `BAD task.exe` is located in the specified directory: `...\BAD task\bin\Debug\net6.0-windows\BAD task.exe`.
