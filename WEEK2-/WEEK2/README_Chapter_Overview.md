# WEEK2 — Chapter Overview

**Course material:** *Starting Out with Visual C#, Sixth Edition* — Chapter 2, “Processing Data”.

## Chapter purpose

This chapter explains how a Visual C# Windows Forms application reads data from controls, stores data in variables, performs calculations, converts values, and displays results. It also introduces exception handling and useful Windows Forms and Visual Studio features.

## Topics covered

### 1. Reading input with TextBox controls
The chapter begins with the `Text` property of a TextBox. It demonstrates reading or assigning text and clearing a TextBox.

### 2. A first look at variables
It introduces variables as named storage locations. It covers string variables, assigning and displaying values, joining strings with the `+` operator, declaring variables before use, local-variable scope, initialization, and declaring multiple variables.

### 3. Numeric data types and variables
The chapter introduces numeric types such as `int`, `double`, and `decimal`. It explains numeric literals, assignment compatibility, explicit conversion using cast operators, and type inference with the `var` keyword.

### 4. Performing calculations
It explains arithmetic expressions and operators, the order of operations, parentheses, calculations involving different numeric types, and integer division.

### 5. Inputting and outputting numeric values
TextBox input is read as text, so the chapter demonstrates converting input strings to numeric values with `Parse` methods. It also explains converting numeric values to strings for display.

### 6. Formatting numbers with the ToString method
The chapter demonstrates formatting numeric output with format strings, including number (`N`), fixed-point (`F`), exponential (`E`), currency (`C`), and percent (`P`) formats.

### 7. Simple exception handling
It introduces runtime errors and the `try` and `catch` structure. Examples show catching exceptions and displaying the exception message through `ex.Message`.

### 8. Using named constants
It explains how to declare a named constant with the `const` keyword for a value that should not change while the program runs.

### 9. Declaring variables as fields
It distinguishes class-level fields from local variables and demonstrates accessing a field from more than one method in a class.

### 10. Using the Math class
The chapter introduces methods and constants from the .NET `Math` class, including `Sqrt`, `Pow`, `Max`, `Min`, `Round`, `PI`, and `E`.

### 11. More GUI details
The presentation also covers Windows Forms interface details such as tab order, focus, keyboard access keys, control colors, form background images, and grouping controls with GroupBox and Panel.

### 12. Using the debugger to locate logic errors
The final section introduces debugging tools and techniques in Visual Studio, including breakpoints, Break mode, Locals and Watch windows, and stepping through code to find logic errors.

## Learning outcomes

After studying this chapter, a student should be able to:

- Read and clear text in TextBox controls.
- Declare, initialize, and use string and numeric variables.
- Understand local-variable scope and class-level fields.
- Perform arithmetic calculations and recognize integer division.
- Convert TextBox input into numeric values and display numeric results.
- Format numbers with `ToString()` format strings.
- Handle exceptions with `try` and `catch`.
- Declare and use named constants.
- Use common members of the `Math` class.
- Apply basic Windows Forms interface features.
- Use the Visual Studio debugger to investigate logic errors.

## Screenshot collection

The `Code_Screenshots` folder contains the captured slides that include code examples, code fragments, or code-based application examples. For a slide-by-slide explanation and direct image links, open [README_Screenshots.md](README_Screenshots.md).

## Source note

This overview follows the topics and terminology presented in the supplied PowerPoint. The screenshot files are captures of the original slides; they are not rewritten or re-created code samples.
