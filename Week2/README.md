# Chapter 2 – Processing Data (C#)

This repository contains my practice work from **Chapter 2: Processing Data** in *Starting Out with Visual C#, Sixth Edition*. The chapter introduces essential programming concepts used in C# Windows Forms applications, including variables, data types, calculations, exception handling, and debugging techniques.

## Topics Covered

- TextBox and the Text property
- Variables and scope
- String variables and concatenation
- Numeric data types
- Type casting and `var`
- Calculations and integer division
- Parsing numeric input
- `ToString()` and formatting
- Exception handling
- Named constants
- Fields
- The `Math` class
- Windows Forms GUI features
- Debugging and breakpoints

---

## Screenshots and Explanations

### 1. The Text Property

Week2/01_text_property.png

**Explanation:**  
The `Text` property is used to store, retrieve, and modify the text contained in a TextBox control. It is one of the most commonly used properties in Windows Forms applications. Text can be removed by assigning an empty string, using `string.Empty`, or calling the `Clear()` method.

---

### 2. Declaring Variables

Week2/02_variables.png

**Explanation:**  
Variables are named storage locations in memory that hold data while a program is running. Each variable must be declared with a data type that determines what type of information it can store.

---

### 3. String Variables

Week2/03_string_variables.png

**Explanation:**  
A string variable stores textual information such as names, descriptions, and messages. String values are enclosed in double quotation marks and can be displayed in controls such as Labels, TextBoxes, and MessageBoxes.

---

### 4. String Concatenation

Week2/04_string_concatenation.png

**Explanation:**  
Concatenation is the process of joining two or more values together. In C#, the `+` operator is used to combine strings with other strings or numeric values.

---

### 5. Declaring Variables Before Using Them

Week2/05_declaring_variables.png

**Explanation:**  
Variables can be declared first and assigned values later. This approach helps improve program organization and readability.

---

### 6. Local Variables and Scope

Week2/06_local_variables_scope.png

**Explanation:**  
A local variable exists only within the method where it is declared. Other methods cannot access that variable directly, which helps maintain proper program structure and prevents unintended modifications.

---

### 7. Initializing Variables

Week2/07_initializing_variables.png

**Explanation:**  
Local variables must be assigned a value before they can be used. Attempting to use an uninitialized variable results in a compiler error because C# cannot determine its value.

---

### 8. Multiple Variables

Week2/08_multiple_variables.png

**Explanation:**  
C# allows several variables of the same data type to be declared in a single statement. This can reduce repetitive code and improve readability.

---

### 9. Numeric Literals

Week2/09_numeric_literals.png

**Explanation:**  
Numeric literals are values written directly in source code. Different data types such as `int`, `double`, and `decimal` are used depending on the nature and precision of the value being stored.

---

### 10. Assignment Compatibility

Week2/10_assignment_compatibility.png

**Explanation:**  
When assigning values to variables, the value must be compatible with the variable's data type. Incompatible assignments result in compiler errors.

---

### 11. Decimal Assignment Compatibility

Week2/11_decimal_compatibility.png

**Explanation:**  
The `decimal` data type is commonly used in financial calculations because it provides higher precision. Integer values can be assigned directly, while some other numeric types require conversion.

---

### 12. Type Casting

Week2/12_type_casting.png

**Explanation:**  
Type casting converts a value from one data type to another. Explicit casting is necessary when there is a possibility of losing information or precision during conversion.

---

### 13. The var Keyword

Week2/13_var_keyword.png

**Explanation:**  
The `var` keyword allows the compiler to determine a variable's data type automatically based on the assigned value while still maintaining strong typing.

---

### 14. Performing Calculations

Week2/14_calculations.png

**Explanation:**  
Arithmetic operators such as `+`, `-`, `*`, `/`, and `%` are used to perform mathematical calculations in C# applications.

---

### 15. Rules for Performing Calculations

Week2/15_calculation_rules.png

**Explanation:**  
C# follows the standard order of operations. Parentheses can be used to control the order in which calculations are performed.

---

### 16. Integer Division

Week2/16_integer_division.png

**Explanation:**  
When two integer values are divided, the fractional portion of the result is discarded. Casting one operand to `double` allows a decimal result to be produced.

---

### 17. Parsing Numeric Input

Week2/17_parse_numeric_input.png

**Explanation:**  
User input from a TextBox is stored as a string. Methods such as `int.Parse()` and `double.Parse()` convert the text into numeric values that can be used in calculations.

---

### 18. Displaying Numeric Values

Week2/18_numeric_output_tostring.png

**Explanation:**  
The `ToString()` method converts a numeric value into text so that it can be displayed in controls such as Labels, TextBoxes, and MessageBoxes.

---

### 19. String Conversion

Week2/19_string_conversion.png

**Explanation:**  
When a string is combined with a numeric value using the `+` operator, C# automatically converts the number into text.

---

### 20. Formatting Numbers

Week2/20_tostring_formatting.png

**Explanation:**  
Format specifiers such as `C`, `P`, `N`, and `F` control how numbers are displayed and allow values to appear as currency, percentages, or decimal numbers.

---

### 21. Try-Catch

Week2/21_try_catch.png

**Explanation:**  
The `try-catch` statement is used to handle exceptions. Code that might cause an error is placed inside the `try` block, while the `catch` block handles any exceptions that occur.

---

### 22. Exception Handling Example

Week2/22_throwing_exception.png

**Explanation:**  
Exceptions can occur when users enter invalid data or when unexpected conditions arise. Proper exception handling prevents the application from crashing.

---

### 23. Displaying an Exception Message

Week2/23_exception_message.png

**Explanation:**  
The `Exception.Message` property contains information describing the error that occurred, helping both users and developers understand the issue.

---

### 24. Named Constants

Week2/24_named_constants.png

**Explanation:**  
Constants store values that do not change while a program is running. They improve code readability and make maintenance easier.

---

### 25. Fields

Week2/25_fields.png

**Explanation:**  
Fields are variables declared at the class level rather than inside methods. They are accessible throughout the class and can maintain values between method calls.

---

### 26. Field Demo Application

Week2/26_field_demo_application.png

**Explanation:**  
This example demonstrates how a field can be accessed and modified by multiple methods within the same class.

---

### 27. The Math Class

Week2/27_math_class.png

**Explanation:**  
The `Math` class provides methods and constants used for mathematical operations including square roots, powers, rounding, and mathematical constants such as `PI` and `E`.

---

### 28. Changing Focus

Week2/28_focus_method.png

**Explanation:**  
The `Focus()` method sets keyboard focus to a specific control, allowing the user to interact with that control immediately.

---

### 29. Keyboard Access Keys

Week2/29_access_key.png

**Explanation:**  
Access keys provide keyboard shortcuts that allow users to activate controls quickly by pressing the `Alt` key together with a designated character.

---

### 30. Setting Colors

Week2/30_colors.png

**Explanation:**  
The `BackColor` and `ForeColor` properties are used to customize the appearance of controls by changing background and text colors.

---

### 31. GroupBoxes and Panels

Week2/31_groupbox_panel.png

**Explanation:**  
GroupBoxes and Panels are container controls used to organize related controls on a form. A GroupBox can display a title, while a Panel cannot.

---

### 32. Breakpoints

Week2/32_breakpoints.png

**Explanation:**  
Breakpoints pause program execution at a selected line of code, allowing developers to inspect variables and program behavior during debugging.

---

### 33. Locals and Watch Windows

Week2/33_locals_watch.png

**Explanation:**  
The Locals window displays variables available in the current procedure, while the Watch window allows developers to monitor selected variables and expressions.

---

### 34. Single-Stepping

Week2/34_single_stepping.png

**Explanation:**  
Single-stepping executes one line of code at a time during debugging. This technique helps developers trace program execution and identify errors more efficiently.
