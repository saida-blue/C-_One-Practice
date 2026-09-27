# Chapter 2 – Processing Data | C# Practice

This repository contains my practice for **Chapter 2 – Processing Data** from *Starting Out with Visual C#, Sixth Edition*.

I practiced the code examples and concepts from the chapter and saved screenshots in the **Week2** folder.

---

## 1. Text Property

![Text Property](Week2/01_text_property.png)

The `Text` property is used to display or change the text inside a control.

    textBox1.Text = "Hello";

    textBox1.Text = string.Empty;

    textBox1.Clear();

    textBox1.Text = "";

---

## 2. Variables

![Variables](Week2/02_variables.png)

A variable is used to store data.

    DataType VariableName;

Example:

    int age;

---

## 3. String Variables

![String Variables](Week2/03_string_variables.png)

A `string` variable stores text.

    string lastName, firstName, middleName;

---

## 4. String Concatenation

![String Concatenation](Week2/04_string_concatenation.png)

String concatenation joins strings and other values together.

Example:

    string output = "Your ID number is " + idNumber;

---

## 5. Declaring Variables

![Declaring Variables](Week2/05_declaring_variables.png)

Variables are declared by specifying the data type and variable name.

    int studentId;
    string name;

---

## 6. Local Variables and Scope

![Local Variables and Scope](Week2/06_local_variables_scope.png)

A local variable can only be used inside the block or method where it is declared.

---

## 7. Initializing Variables

![Initializing Variables](Week2/07_initializing_variables.png)

A variable can be initialized when it is declared.

    int hoursWorked = 40;

---

## 8. Multiple Variables

![Multiple Variables](Week2/08_multiple_variables.png)

Multiple variables of the same type can be declared in one statement.

    string lastName = "Khalaf", firstName = "Mohamed", middleName = "Abdullahi";

---

## 9. Numeric Literals

![Numeric Literals](Week2/09_numeric_literals.png)

Numeric values can be stored using different numeric data types.

    int hoursWorked = 40;
    double temperature = 87.6;
    decimal payRate = 28.75m;

---

## 10. Assignment Compatibility

![Assignment Compatibility](Week2/10_assignment_compatibility.png)

The value assigned to a variable must be compatible with its data type.

Example:

    int hoursWorked = 40;

An incompatible value can cause a compilation error.

---

## 11. Decimal Compatibility

![Decimal Compatibility](Week2/11_decimal_compatibility.png)

Decimal values use the `m` suffix when necessary.

    decimal balance = 9280.73m;
    decimal price = 50;

---

## 12. Type Casting

![Type Casting](Week2/12_type_casting.png)

Type casting converts a value from one data type to another.

    int wholeNumber;
    decimal moneyNumber = 4500m;

    wholeNumber = (int)moneyNumber;

---

## 13. var Keyword

![var Keyword](Week2/13_var_keyword.png)

The `var` keyword allows C# to determine the data type from the value assigned to the variable.

    var interestRate = 12.0;
    var stockCode = "D465U";
    var accountBalance = 1000.0m;

---

## 14. Calculations

![Calculations](Week2/14_calculations.png)

C# can perform mathematical calculations using arithmetic operators.

    int x = 5, y = 4;

    MessageBox.Show((x + y).ToString());

---

## 15. Calculation Rules

![Calculation Rules](Week2/15_calculation_rules.png)

C# follows mathematical rules when performing calculations.

Example:

    result = (a + b) / 4;

Parentheses can be used to control the order of calculation.

---

## 16. Integer Division

![Integer Division](Week2/16_integer_division.png)

When two integers are divided, the fractional part is removed.

    int x = 7, y = 3;

    MessageBox.Show((x / y).ToString());

To keep the fractional part, use a floating-point value.

    MessageBox.Show(((double)x / y).ToString());

---

## 17. Parse Numeric Input

![Parse Numeric Input](Week2/17_parse_numeric_input.png)

`Parse` converts text entered into a TextBox into a numeric value.

    int hoursWorked = int.Parse(hoursWorkedTextBox.Text);

    double temperature = double.Parse(temperatureTextBox.Text);

---

## 18. Numeric Output with ToString

![Numeric Output ToString](Week2/18_numeric_output_tostring.png)

The `ToString()` method converts a numeric value into text.

    decimal grossPay = 1550.0m;

    grossPayLabel.Text = grossPay.ToString();

Example:

    int myNumber = 123;

    MessageBox.Show(myNumber.ToString());

---

## 19. String Conversion

![String Conversion](Week2/19_string_conversion.png)

A numeric value can be combined with a string.

    int idNumber = 1044;

    string output = "Your ID number is " + idNumber;

---

## 20. ToString Formatting

![ToString Formatting](Week2/20_tostring_formatting.png)

The `ToString()` method can format numeric values.

Examples:

    ToString("n3")
    ToString("f2")
    ToString("e3")
    ToString("C")
    ToString("P")

These format values as numbers, fixed-point, scientific notation, currency, or percentages.

---

## 21. try-catch

![try-catch](Week2/21_try_catch.png)

A `try-catch` statement is used to handle exceptions that may occur while the program is running.

    try
    {
        statement;
        statement;
    }
    catch
    {
        statement;
        statement;
    }

---

## 22. Throwing an Exception

![Throwing Exception](Week2/22_throwing_exception.png)

An exception can occur when the program receives invalid data or performs an invalid operation.

The `catch` block handles the exception.

---

## 23. Exception Message

![Exception Message](Week2/23_exception_message.png)

The exception object can be used to display information about an error.

    catch (Exception ex)
    {
        MessageBox.Show(ex.Message);
    }

---

## 24. Named Constants

![Named Constants](Week2/24_named_constants.png)

A constant is a value that cannot be changed while the program is running.

Example:

    const double INTEREST_RATE = 0.129;

---

## 25. Fields

![Fields](Week2/25_fields.png)

A field is a variable declared inside a class.

Example:

    private string name = "Charles";

The field can be used by methods in the class.

---

## 26. Field Demo Application

![Field Demo Application](Week2/26_field_demo_application.png)

The Field Demo application demonstrates how a field can be changed and displayed.

Example:

    name = "Darius";

or:

    name = "Carmen";

The value can then be displayed by another method.

---

## 27. Math Class

![Math Class](Week2/27_math_class.png)

The `Math` class provides methods and constants for mathematical operations.

Examples:

    Math.Sqrt(x);
    Math.Pow(x, y);
    Math.Max(x, y);
    Math.Min(x, y);
    Math.Round(x);
    Math.PI;
    Math.E;

---

## 28. Focus Method

![Focus Method](Week2/28_focus_method.png)

The `Focus()` method places the keyboard cursor inside a control.

Example:

    nameTextBox.Focus();

---

## 29. Access Key

![Access Key](Week2/29_access_key.png)

An access key allows the user to activate a control using the keyboard.

Example:

    Alt + X

---

## 30. Colors

![Colors](Week2/30_colors.png)

The `BackColor` and `ForeColor` properties can be used to change the colors of controls.

Example:

    messageLabel.BackColor = Color.Black;
    messageLabel.ForeColor = Color.Yellow;

---

## 31. GroupBox and Panel

![GroupBox and Panel](Week2/31_groupbox_panel.png)

A `GroupBox` can display a title using its `Text` property.

A `Panel` does not have a title, but it can use a border through its `BorderStyle` property.

Both controls can be used to organize other controls.

---

## 32. Breakpoints

![Breakpoints](Week2/32_breakpoints.png)

A breakpoint pauses the program while debugging.

It allows the programmer to stop at a specific line and examine what is happening in the program.

---

## 33. Locals and Watch

![Locals and Watch](Week2/33_locals_watch.png)

The Locals and Watch windows help the programmer inspect variable values while debugging.

They are useful for finding errors in the program.

---

## 34. Single Stepping

![Single Stepping](Week2/34_single_stepping.png)

Single stepping allows the programmer to execute the program one line at a time while debugging.

The `F11` key can be used for single stepping.



