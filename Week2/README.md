# Chapter 2 – Processing Data (C#)

This repository contains my practice work from **Chapter 2: Processing Data** in *Starting Out with Visual C#, Sixth Edition*.

This chapter focuses on working with data in C#, including variables, calculations, user input, exception handling, Windows Forms controls, and debugging techniques.

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
- Windows Forms GUI details
- Debugging and breakpoints

---

## 1. The Text Property

![Text Property](Week2/01_text_property.png)

**Explanation:**  
The `Text` property is used to store, retrieve, and modify text inside a TextBox control. It is commonly used when working with user input in Windows Forms applications.

---

## 2. Declaring Variables

![Declaring Variables](Week2/02_variables.png)

**Explanation:**  
Variables are named memory locations used to store data while a program is running. Each variable must be declared with a specific data type.

---

## 3. String Variables

![String Variables](Week2/03_string_variables.png)

**Explanation:**  
A string variable stores text values such as names, descriptions, and messages. String values are enclosed within double quotation marks.

---

## 4. String Concatenation

![String Concatenation](Week2/04_string_concatenation.png)

**Explanation:**  
Concatenation combines text and other values into one string using the `+` operator.

---

## 5. Declaring Variables Before Using Them

![Declaring Variables](Week2/05_declaring_variables.png)

**Explanation:**  
Variables can be declared first and assigned values later. This improves code organization and readability.

---

## 6. Local Variables and Scope

![Local Variables and Scope](Week2/06_local_variables_scope.png)

**Explanation:**  
A local variable is only accessible within the method where it is declared. Other methods cannot directly use it.

---

## 7. Initializing Variables

![Initializing Variables](Week2/07_initializing_variables.png)

**Explanation:**  
A local variable must be assigned a value before it can be used. Otherwise, the compiler generates an error.

---

## 8. Multiple Variables

![Multiple Variables](Week2/08_multiple_variables.png)

**Explanation:**  
Multiple variables of the same data type can be declared in a single statement to reduce repetitive code.

---

## 9. Numeric Literals

![Numeric Literals](Week2/09_numeric_literals.png)

**Explanation:**  
Numeric literals are numbers written directly in code. Common types include `int`, `double`, and `decimal`.

---

## 10. Assignment Compatibility

![Assignment Compatibility](Week2/10_assignment_compatibility.png)

**Explanation:**  
Values assigned to variables must match the variable's data type or be converted appropriately.

---

## 11. Decimal Assignment Compatibility

![Decimal Assignment Compatibility](Week2/11_decimal_compatibility.png)

**Explanation:**  
The `decimal` type is commonly used for financial calculations because it provides high precision.

---

## 12. Type Casting

![Type Casting](Week2/12_type_casting.png)

**Explanation:**  
Type casting converts a value from one data type to another. Explicit casting is required when automatic conversion is not possible.

---

## 13. The var Keyword

![The var Keyword](Week2/13_var_keyword.png)

**Explanation:**  
The `var` keyword allows the compiler to determine the variable's data type from the assigned value.

---

## 14. Performing Calculations

![Performing Calculations](Week2/14_calculations.png)

**Explanation:**  
Arithmetic operators such as `+`, `-`, `*`, `/`, and `%` are used to perform mathematical calculations.

---

## 15. Rules for Performing Calculations

![Calculation Rules](Week2/15_calculation_rules.png)

**Explanation:**  
C# follows the order of operations when performing calculations. Parentheses can be used to control which calculations occur first.

---

## 16. Integer Division

![Integer Division](Week2/16_integer_division.png)

**Explanation:**  
Dividing two integers produces an integer result. To obtain a decimal result, one value should be converted to a floating-point type.

---

## 17. Parsing Numeric Input

![Parsing Numeric Input](Week2/17_parsing_numeric_input.png)

**Explanation:**  
Methods such as `int.Parse()` and `double.Parse()` convert user-entered text into numeric values.

---

## 18. Displaying Numeric Values

![Displaying Numeric Values](Week2/18_numeric_output_tostring.png)

**Explanation:**  
The `ToString()` method converts values into strings so they can be displayed in labels, text boxes, and message boxes.

---

## 19. String Conversion

![String Conversion](Week2/19_string_conversion.png)

**Explanation:**  
When a string is combined with a number using the `+` operator, C# automatically converts the number into text.

---

## 20. Formatting Numbers

![Formatting Numbers](Week2/20_tostring_formatting.png)

**Explanation:**  
Format specifiers allow values to be displayed as currency, percentages, scientific notation, and fixed-point numbers.

---

## 21. Try-Catch

![Try Catch](Week2/21_try_catch.png)

**Explanation:**  
The `try-catch` statement handles exceptions and prevents applications from crashing when errors occur.

---

## 22. Throwing an Exception

![Throwing an Exception](Week2/22_throwing_exception.png)

**Explanation:**  
This example demonstrates handling invalid user input by catching exceptions generated during program execution.

---

## 23. Displaying an Exception Message

![Exception Message](Week2/23_exception_message.png)

**Explanation:**  
The `Message` property provides details about an exception, helping developers identify problems more easily.

---

## 24. Named Constants

![Named Constants](Week2/24_named_constants.png)

**Explanation:**  
Constants store fixed values that cannot be changed during program execution.

---

## 25. Fields

![Fields](Week2/25_fields.png)

**Explanation:**  
Fields are class-level variables that can be accessed throughout the class and retain their values between method calls.

---

## 26. Field Demo Application

![Field Demo Application](Week2/26_field_demo_application.png)

**Explanation:**  
This example demonstrates how fields can be shared and modified by multiple methods within a class.

---

## 27. The Math Class

![The Math Class](Week2/27_math_class.png)

**Explanation:**  
The `Math` class contains methods and constants that perform common mathematical operations.

---

## 28. Changing Focus

![Changing Focus](Week2/28_focus_method.png)

**Explanation:**  
The `Focus()` method sets keyboard focus to a specific control so the user can interact with it immediately.

---

## 29. Keyboard Access Keys

![Keyboard Access Keys](Week2/29_access_key.png)

**Explanation:**  
Access keys enable users to activate controls using keyboard shortcuts such as `Alt + Key`.

---

## 30. Setting Colors

![Setting Colors](Week2/30_colors.png)

**Explanation:**  
The `BackColor` and `ForeColor` properties customize the appearance of controls by modifying their colors.

---

## 31. GroupBoxes and Panels

![GroupBoxes and Panels](Week2/31_groupbox_panel.png)

**Explanation:**  
GroupBoxes and Panels are container controls that help organize related controls on a Windows Form.

---

## 32. Breakpoints

![Breakpoints](Week2/32_breakpoints.png)

**Explanation:**  
Breakpoints pause program execution at specific lines of code, making debugging easier.

---

## 33. Locals and Watch Windows

![Locals and Watch Windows](Week2/33_locals_watch.png)

**Explanation:**  
The Locals window displays variables in the current procedure, while the Watch window allows selected variables and expressions to be monitored.

---

## 34. Single-Stepping

![Single-Stepping](Week2/34_single_stepping.png)

**Explanation:**  
Single-stepping executes one statement at a time, allowing developers to trace program execution and identify errors.
