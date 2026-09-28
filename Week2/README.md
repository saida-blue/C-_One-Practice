# Chapter 2 – Processing Data (C#)

This repository contains my practice from **Chapter 2: Processing Data** in *Starting Out with Visual C#, Sixth Edition*.

## Contents

- TextBox and the `Text` property
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

![Text Property](./01_text_property.png)

The `Text` property stores the text inside a TextBox. Use `Clear()` or an empty string to remove it.

```csharp
textBox1.Text = "Hello";
textBox1.Text = string.Empty;
textBox1.Clear();
textBox1.Text = "";
```

---

## 2. Declaring Variables

![Variables](./02_variables.png)

A variable is a storage location in memory. Its data type tells C# what kind of value it can store.

```csharp
DataType variableName;
```

---

## 3. String Variables

![String Variables](./03_string_variables.png)

A `string` stores text. String values are written inside double quotation marks.

```csharp
productDescription = "Jamhuuriya University";
productLabel = productDescription;
MessageBox.Show(productDescription);
```

---

## 4. String Concatenation

![String Concatenation](./04_string_concatenation.png)

Concatenation joins strings and other values with the `+` operator.

```csharp
"12" + " apples";
"Total is " + 25.75;
```

---

## 5. Declaring Variables Before Using Them

![Declaring Variables](./05_declaring_variables.png)

A variable can be declared first and assigned a value later.

```csharp
string fullName;
fullName = firstNameTextBox.Text + " " + lastNameTextBox.Text;
fullNameLabel.Text = fullName;
```

---

## 6. Local Variables and Scope

![Local Variables and Scope](./06_local_variables_scope.png)

A local variable belongs to the method where it is declared. Other methods cannot directly access it.

```csharp
private void firstButton_Click(object sender, EventArgs e)
{
    string myName = nameTextBox.Text;
}
```

---

## 7. Initializing Variables

![Initializing Variables](./07_numeric_literals.png)

A local variable must be assigned a value before it is used. Otherwise, the compiler reports an error.

```csharp
string productDescription;
// MessageBox.Show(productDescription); // Error: variable is not initialized
```

---

## 8. Multiple Variables

![Multiple Variables](./08_int_compatibility.png)

Multiple variables of the same type can be declared in one statement.

```csharp
string lastName, firstName, middleName;

string last = "Khalaf",
       first = "Mohamed",
       middle = "Abdullahi";
```

---

## 9. Numeric Literals

![Numeric Literals](./09_decimal_compatibility.png)

Numeric literals are numbers written directly in the program. The `m` suffix identifies a `decimal` literal.

```csharp
int hoursWorked = 40;
double temperature = 87.6;
decimal payRate = 28.75m;
```

---

## 10. Assignment Compatibility

![Assignment Compatibility](./10_type_casting.png)

Values assigned to variables must match the variable's data type or be converted appropriately.

```csharp
int hoursWorked = 40;       // Valid
// int unitsSold = 650m;     // Error: decimal cannot be assigned to int
// int score = -25.5;        // Error: double cannot be assigned to int
```

---

## 11. Decimal Assignment Compatibility

![Decimal Compatibility](./11_var_keyword.png)

A `decimal` can accept integer values and decimal literals, but not a `double` value directly.

```csharp
decimal balance = 9280.73m;
decimal price = 50;
// decimal sales = 6500.0; // Error: this is a double literal
```

---

## 12. Type Casting

![Type Casting](./12_calculations.png)

Type casting explicitly converts a value from one data type to another.

```csharp
decimal moneyNumber = 4500m;
int wholeNumber = (int)moneyNumber;

decimal anotherMoneyNumber = 625.70m;
double realNumber = (double)anotherMoneyNumber;
```

---

## 13. The `var` Keyword

![The var Keyword](./13_calculation_rules.png)

The `var` keyword lets the compiler determine a variable's type from its assigned value.

```csharp
var interestRate = 12.0;
var stockCode = "D465U";
var accountBalance = 1000.0m;
```

---

## 14. Performing Calculations

![Calculations](./14_integer_division.png)

C# uses arithmetic operators such as `+`, `-`, `*`, `/`, and `%`.

```csharp
int x = 5;
int y = 4;

int sum = x + y;
int difference = x - y;
int product = x * y;
int quotient = x / y;
int remainder = x % y;
```

---

## 15. Rules for Performing Calculations

![Calculation Rules](./15_parse_numeric_input.png)

C# follows the normal order of operations. Parentheses control which calculation happens first.

```csharp
int x = 5, y = 4;
MessageBox.Show((x + y).ToString());

int result = (10 + 6) / 4;
```

---

## 16. Integer Division

![Integer Division](./16_numeric_output_tostring.png)

Dividing two integers produces an integer result. Casting one value to `double` allows a fractional result.

```csharp
int x = 7, y = 3;
MessageBox.Show((x / y).ToString());
MessageBox.Show(((double)x / y).ToString());
```

---

## 17. Parsing Numeric Input

![Parsing Numeric Input](./17_tostring_formatting.png)

TextBox input is a string. `Parse()` converts it into a numeric value.

```csharp
int hoursWorked = int.Parse(hoursWorkedTextBox.Text);
double temperature = double.Parse(temperatureTextBox.Text);
```

---

## 18. Displaying Numeric Values

![Displaying Numeric Values](./18_try_catch.png)

`ToString()` converts a numeric value into text so it can be displayed.

```csharp
decimal grossPay = 1550.0m;
grossPayLabel.Text = grossPay.ToString();

int myNumber = 123;
MessageBox.Show(myNumber.ToString());
```

---

## 19. String Conversion

![String Conversion](./19_throwing_exception.png)

The `+` operator can combine a string and a numeric value.

```csharp
int idNumber = 1044;
string output = "Your ID number is " + idNumber;
```

---

## 20. Formatting Numbers

![Formatting Numbers](./20_exception_message.png)

Format strings control how numbers are displayed.

```csharp
value.ToString("n3"); // Number with three decimal places
value.ToString("f2"); // Fixed-point with two decimal places
value.ToString("e3"); // Scientific notation
value.ToString("C");  // Currency
value.ToString("P");  // Percentage
```

---

## 21. Try-Catch

![Try-Catch](./21_solution_code.png)

The `try` block contains code that may cause an exception. The `catch` block handles the error.

```csharp
try
{
    // Code that might cause an exception
}
catch
{
    // Handle the error
}
```

---

## 22. Throwing an Exception

![Throwing an Exception](./22_named_constants.png)

Invalid numeric input can cause an exception. A `catch` block can display an error message.

```csharp
try
{
    double miles = double.Parse(milesTextBox.Text);
    double gallons = double.Parse(gallonsTextBox.Text);
    double mpg = miles / gallons;

    mpgLabel.Text = mpg.ToString();
}
catch
{
    MessageBox.Show("Invalid data was entered.");
}
```

---

## 23. Displaying an Exception Message

![Exception Message](./23_fields.png)

The exception's `Message` property contains a description of the error.

```csharp
try
{
    // Code that might fail
}
catch (Exception ex)
{
    MessageBox.Show(ex.Message);
}
```

---

## 24. Named Constants

![Named Constants](./24_field_demo_application.png)

A constant represents a value that cannot be changed during program execution.

```csharp
const double INTEREST_RATE = 0.129;
```

---

## 25. Fields

![Fields](./25_math_class.png)

A field is declared inside a class and outside a method. It can be accessed by methods in that class.

```csharp
private string name = "Charles";
```

---

## 26. Field Demo Application

![Field Demo Application](./26_focus_method.png)

A field can be accessed and changed by different methods in the same class.

```csharp
private string name = "Charles";

private void showNameButton_Click(object sender, EventArgs e)
{
    MessageBox.Show(name);
}

private void dariusButton_Click(object sender, EventArgs e)
{
    name = "Darius";
}

private void carmenButton_Click(object sender, EventArgs e)
{
    name = "Carmen";
}
```

---

## 27. The `Math` Class

![Math Class](./27_access_key.png)

The `Math` class provides methods and constants for mathematical calculations.

```csharp
Math.Sqrt(x);
Math.Pow(x, y);
Math.Max(x, y);
Math.Min(x, y);
Math.Round(x);
Math.PI;
Math.E;
```

---

## 28. Changing Focus

![Focus Method](./28_colors.png)

`Focus()` gives keyboard focus to a control.

```csharp
private void clearButton_Click(object sender, EventArgs e)
{
    nameTextBox.Focus();
}
```

---

## 29. Keyboard Access Keys

![Access Keys](./29_groupbox_panel.png)

An access key lets the user activate a control with **Alt** and a designated letter, such as **Alt + X**.

---

## 30. Setting Colors

![Colors](./30_breakpoints.png)

`BackColor` changes a control's background color. `ForeColor` changes its text color.

```csharp
messageLabel.BackColor = Color.Black;
messageLabel.ForeColor = Color.Yellow;
```

---

## 31. GroupBoxes and Panels

![GroupBoxes and Panels](./29_groupbox_panel.png)

Both controls can contain other controls. A `GroupBox` can display a title; a `Panel` does not have a `Text` property.

---

## 32. Breakpoints

![Breakpoints](./31_breakpoints.png)
![Break Mode](./32_break_mode.png)

A breakpoint pauses the program at a selected line so you can examine variables while debugging.

---

## 33. Locals and Watch Windows

![Locals Window](./33_locals_window.png)

The Locals window shows variables in the current procedure. The Watch window lets you monitor selected variables.

---

## 34. Single-Stepping

![Single-Stepping](./34_single_stepping.png)

Single-stepping executes the program one statement at a time. In Visual Studio, **F11** steps into a method call while debugging.

