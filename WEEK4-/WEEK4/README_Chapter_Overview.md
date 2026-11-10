# Chapter Overview – Chapter 4: Loops, Files, and Random Numbers

## Chapter title

**Chapter 4: Loops, Files, and Random Numbers**

Source: *Starting Out With Visual C#*, Sixth Edition, Global Edition.

## Introduction

This chapter explains how C# programs repeat instructions with loops, work with text files, display standard file dialog boxes, generate random values, and respond when a Windows Form loads. The examples use Windows Forms features such as `MessageBox`, `ListBox`, and event handlers. The file examples in this chapter focus on text files.

## Topics

### 5.1 The while Loop

A `while` loop repeats a statement or group of statements as long as its Boolean expression is true. The condition is checked before the loop body runs, so it is a **pretest loop**. The counter or other values used by the condition must be initialized and updated appropriately. If the condition is false at the beginning, the body does not run; if the condition never becomes false, the loop can be infinite.

### 5.2 The ++ and -- Operators

The increment operator `++` increases a variable by one, and the decrement operator `--` decreases it by one. The chapter compares **postfix** and **prefix** forms. In postfix mode, the old value is used before the variable changes; in prefix mode, the variable changes before its value is used.

### 5.3 The for Loop

A `for` loop is designed for repetitions controlled by a counter variable. Its header contains an initialization expression, a Boolean test expression, and an update expression. The test is checked before each iteration, so `for` is also a pretest loop. The update can increment, decrement, or change the counter by another amount.

### 5.4 The do-while Loop

A `do-while` loop executes its body before testing its Boolean expression. It is a **posttest loop**, which means its body executes at least once. The condition appears after the closing brace of the loop body.

### 5.5 Using Files for Data Storage

A program can store data in a file for later use. File processing has three basic steps: open the file, process it by reading or writing data, and close it. The chapter distinguishes text files from binary files and focuses on text files. It introduces `StreamWriter` for writing and `StreamReader` for reading. It also covers `Write`, `WriteLine`, `Read`, `ReadLine`, `ReadToEnd`, `File.ReadAllText`, and `EndOfStream`.

### 5.6 The OpenFileDialog and SaveFileDialog Controls

These invisible Windows Forms controls display standard Open and Save As dialog boxes. `ShowDialog()` displays a dialog and returns a `DialogResult`, such as `DialogResult.OK` or `DialogResult.Cancel`. The examples use the selected filename to open or create a text file and show how to set `InitialDirectory`.

### 5.7 Random Numbers

The .NET `Random` class generates random values. The chapter introduces `Next()` for integer values and `NextDouble()` for floating-point values from 0.0 to 1.0. It also shows how to use `Next(max + 1)` to generate an integer from zero through a chosen maximum.

### 5.8 The Load Event

The form's `Load` event occurs when the form is loaded into memory as the application starts. A `Form1_Load` event handler contains code that runs when the form is launched. The chapter demonstrates displaying a message box from this event.

> **Numbering note:** The topic list on the presentation’s “Topics” slide labels the last item as **5.8 The Load Event**. The individual Load Event slides display **5.9 The Load Event**. Both labels are preserved here as they appear in the presentation.

## Important definitions

- **Boolean expression:** An expression tested for a true or false value.
- **while clause:** The first line of a `while` loop, containing the condition.
- **Loop body:** The statement or statements inside the loop's curly braces.
- **Iteration:** One execution of a loop body.
- **Counter variable:** A variable used to track how many times a loop runs.
- **Pretest loop:** A loop that tests its condition before performing an iteration.
- **Infinite loop:** A loop that continues until the program is interrupted; one cause is a condition that never becomes false.
- **Posttest loop:** A loop that performs an iteration before testing its condition.
- **Text file:** A file containing data encoded as text, using a scheme such as Unicode.
- **Binary file:** A file containing data that has not been converted to text and cannot be viewed as ordinary text in a text editor.
- **File object:** An object associated with a specific file that gives a program a way to work with that file.
- **`StreamWriter`:** The .NET class used in the chapter to write data to a text file.
- **`StreamReader`:** The .NET class used in the chapter to read data from a text file.
- **`EndOfStream`:** A Boolean property indicating whether the end of a stream has been reached.
- **`DialogResult`:** The value returned by `ShowDialog()` to indicate how the user dismissed a dialog.
- **`InitialDirectory`:** The property used to specify the directory initially displayed by a file dialog.
- **`Random`:** The .NET class used to generate random numbers.
- **Load event:** The form event that occurs when the form is loaded into memory.

## Important syntax and code structures

The following structures are transcribed from the presentation. They are included as reference syntax; the slide screenshots retain the complete original examples and surrounding explanations.

### while loop

```csharp
while (BooleanExpression)
{
    statements
}
```

### Increment and decrement

```csharp
count++;
count += 1;
count = count + 1;

count--;
count -= 1;
count = count - 1;
```

### Prefix and postfix forms

```csharp
count++;
--count;
```

Postfix uses the old value and then changes it. Prefix changes the value first and then uses it.

### for loop

```csharp
for (InitializationExpression; TestExpression; UpdateExpression)
{
}
```

The presentation also shows these update patterns:

```csharp
for (int count = 0; count <= 100; count += 10)
{
    MessageBox.Show(count.ToString());
}

for (int count = 10; count >= 0; count--)
{
    MessageBox.Show(count.ToString());
}
```

### do-while loop

```csharp
do
{
    statements…
} while (BooleanExpression);
```

### Writing to a text file

```csharp
StreamWriter outputFile;
outputFile = File.CreateText("courses.txt");
outputFile.WriteLine("Introduction to Computer Science");
outputFile.WriteLine("English Composition");
outputFile.WriteLine("Calculus I");
outputFile.Close();
```

The presentation also demonstrates `File.AppendText(...)`, `Write(...)`, and `WriteLine(...)`.

### Reading from a text file

```csharp
StreamReader inputFile;
inputFile = File.OpenText("students.txt");
```

The presentation also demonstrates `Read()`, `ReadLine()`, `ReadToEnd()`, and `File.ReadAllText(...)`.

### Reading until the end of a file

```csharp
while (inputFile.EndOfStream == false)
{
}

while (!inputFile.EndOfStream)
{
}
```

### Open dialog and selection result

```csharp
private void openButton_Click(object sender, EventArgs e)
{
    openFileDialog.ShowDialog();
}

DialogResult result = openFileDialog.ShowDialog();
if (result == DialogResult.OK)
{
}
else if (result == DialogResult.Cancel)
{
}
```

### Random numbers

```csharp
Random rand = new Random();
int number1 = rand.Next();
double number2 = rand.NextDouble();

int number = rand.Next(100);
```

The slide gives the general form `RandomObject.Next(max + 1)`.

### Load event handler

```csharp
private void Form1_Load(object sender, EventArgs e)
{
}
```

The example on the following slide places a `MessageBox.Show(...)` call inside this handler.

## Learning outcomes

After studying the material in this chapter, a learner should be able to:

1. Explain how a `while` loop works and identify its condition and body.
2. Distinguish pretest loops from posttest loops.
3. Trace a loop and determine whether it runs zero, one, or multiple times.
4. Recognize how a missing counter update can cause an infinite loop.
5. Use `++` and `--` and explain the difference between prefix and postfix forms.
6. Construct and trace a `for` loop using initialization, test, and update expressions.
7. Explain when a `do-while` loop is useful and why its body runs at least once.
8. Describe the open, process, and close steps of file handling.
9. Distinguish text files from binary files.
10. Use the chapter's `StreamWriter` and `StreamReader` patterns to write and read text data.
11. Explain the difference between creating a file and appending to an existing file.
12. Read file content line by line and use `EndOfStream` as the loop condition.
13. Display Open and Save As dialogs and check `DialogResult` values.
14. Use a selected filename and the `InitialDirectory` property in file-dialog examples.
15. Create a `Random` object and use `Next` and `NextDouble`.
16. Recognize a Windows Form `Load` event handler and explain when its code executes.

## Lab practice and in-class activities shown in the slides

The presentation includes a **Lap Practice** using an Ending Balance form and a modified Ending Balance form. The visible code fragments calculate monthly interest and add monthly ending-balance information to a list box. It also includes a **Squares** lab-practice slide with application screenshots, plus in-class checkpoints about increment/decrement expressions, loop iteration counts, and the behavior of `do-while` compared with `while`.
