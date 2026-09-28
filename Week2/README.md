Chapter 2 – Processing Data (C#)

This repository contains my practice from Chapter 2: Processing Data in Starting Out with Visual C#, Sixth Edition.

Contents

- TextBox and the Text property
- Variables and scope
- String variables and concatenation
- Numeric data types
- Type casting and "var"
- Calculations and integer division
- Parsing numeric input
- "ToString()" and formatting
- Exception handling
- Named constants
- Fields
- The "Math" class
- Windows Forms GUI details
- Debugging and breakpoints

---

1. The Text Property

"Text Property" (Week2/01_text_property.png)

textBox1.Text = "Hello";

textBox1.Text = string.Empty;

textBox1.Clear();

textBox1.Text = "";

Explanation:
The "Text" property stores the text inside a TextBox. "Clear()" or an empty string can be used to remove the text.

---

2. Declaring Variables

"Variables" (Week2/02_variables.png)

DataType VariableName;

Explanation:
A variable is a storage location in memory. The data type tells C# what kind of value the variable can store.

---

3. String Variables

"String Variables" (Week2/03_string_variables.png)

productDescription = "Jamhuuriya University";

productLabel = productDescription;

MessageBox.Show(productDescription);

Explanation:
A "string" stores characters and text. The value is written inside double quotation marks.

---

4. String Concatenation

"String Concatenation" (Week2/04_string_concatenation.png)

12 + " apples";

"Total is " + 25.75;

Explanation:
Concatenation means joining values together. The "+" operator is used to join strings with other values.

---

5. Declaring Variables Before Using Them

"Declaring Variables" (Week2/05_declaring_variables.png)

string fullName;

fullName = firstNameTextBox.Text + " " + lastNameTextBox.Text;

fullNameLabel.Text = fullName;

Explanation:
A variable can be declared first and assigned a value later.

---

6. Local Variables and Scope

"Local Variables and Scope" (Week2/06_local_variables_scope.png)

private void firstButton_Click(object sender, EventArgs e)
{
    string myName;
    myName = nameTextBox.Text;
}

Explanation:
A local variable belongs to the method where it is declared. Other methods cannot directly access that local variable.

---

7. Initializing Variables

"Initializing Variables" (Week2/07_initializing_variables.png)

string productDescription;

MessageBox.Show(productDescription);

Explanation:
A local variable must be assigned a value before it is used. Otherwise, the C# compiler reports an error.

---

8. Multiple Variables

"Multiple Variables" (Week2/08_multiple_variables.png)

string lastName, firstName, middleName;

Another example:

string lastName = "Khalaf",
       firstName = "Mohamed",
       middleName = "Abdullahi";

Explanation:
Multiple variables of the same data type can be declared in one statement.

---

9. Numeric Literals

"Numeric Literals" (Week2/09_numeric_literals.png)

int hoursWorked = 40;

double temperature = 87.6;

decimal payRate = 28.75m;

Explanation:
Numeric literals are numbers written directly in the program. The "m" suffix identifies a decimal literal.

---

10. Assignment Compatibility

"Assignment Compatibility" (Week2/10_assignment_compatibility.png)

int hoursWorked = 40;       // This works
int unitsSold = 650m;       // ERROR!
int score = -25.5;          // ERROR!

Explanation:
An "int" variable can store integer values. A "double" or "decimal" value cannot be assigned directly to an "int".

---

11. Decimal Assignment Compatibility

"Decimal Compatibility" (Week2/11_decimal_compatibility.png)

decimal balance = 9280.73m;  // This works

decimal price = 50;          // This works

decimal sales = 6500.0;      // ERROR!

Explanation:
A "decimal" variable can accept decimal and integer values, but not a "double" value directly.

---

12. Type Casting

"Type Casting" (Week2/12_type_casting.png)

int wholeNumber;

decimal moneyNumber = 4500m;

wholeNumber = (int)moneyNumber;

Another example:

double realNumber;

decimal moneyNumber = 625.70m;

realNumber = (double)moneyNumber;

Explanation:
Type casting explicitly converts a value from one data type to another.

---

13. The "var" Keyword

"var Keyword" (Week2/13_var_keyword.png)

var interestRate = 12.0;

var stockCode = "D465U";

var accountBalance = 1000.0m;

Explanation:
"var" allows the compiler to determine the variable's type from the value assigned to it.

---

14. Performing Calculations

"Calculations" (Week2/14_calculations.png)

int x = 5;
int y = 4;

Explanation:
C# uses arithmetic operators such as "+", "-", "*", "/", and "%" to perform calculations.

---

15. Rules for Performing Calculations

"Calculation Rules" (Week2/15_calculation_rules.png)

int x = 5, y = 4;

MessageBox.Show((x + y).ToString());

Another example:

result = (a + b) / 4;

Explanation:
C# follows the normal order of operations. Parentheses can be used to control which calculation happens first.

---

16. Integer Division

"Integer Division" (Week2/16_integer_division.png)

int x = 7, y = 3;

MessageBox.Show((x / y).ToString());

The result is:

2

To get a fractional result:

int x = 7, y = 3;

MessageBox.Show(((double)x / y).ToString());

Explanation:
Dividing two integers produces an integer result. Casting one value to "double" allows a fractional result.

---

17. Parsing Numeric Input

"Parse Numeric Input" (Week2/17_parse_numeric_input.png)

int hoursWorked = int.Parse(hoursWorkedTextBox.Text);

double temperature = double.Parse(temperatureTextBox.Text);

Explanation:
TextBox input is treated as a string. "Parse()" converts the string into a numeric value.

---

18. Displaying Numeric Values

"ToString" (Week2/18_numeric_output_tostring.png)

decimal grossPay = 1550.0m;

grossPayLabel.Text = grossPay.ToString();

int myNumber = 123;

MessageBox.Show(myNumber.ToString());

Explanation:
"ToString()" converts a numeric value into text so it can be displayed in a Label, TextBox, or MessageBox.

---

19. String Conversion with "+"

"String Conversion" (Week2/19_string_conversion.png)

int idNumber = 1044;

string output = "Your ID number is " + idNumber;

Explanation:
The "+" operator can also combine a string and a numeric value.

---

20. Formatting Numbers

"ToString Formatting" (Week2/20_tostring_formatting.png)

Examples from the chapter:

ToString("n3")
ToString("f2")
ToString("e3")
ToString("C")
ToString("P")

Explanation:
Format strings control how numbers are displayed, such as number, fixed-point, currency, and percentage formats.

---

21. "try-catch"

"Try Catch" (Week2/21_try_catch.png)

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

Explanation:
The "try" block contains code that may cause an exception. The "catch" block handles the error.

---

22. Throwing an Exception

"Throwing Exception" (Week2/22_throwing_exception.png)

try
{
    double miles;
    double gallons;
    double mpg;

    miles = double.Parse(milesTextBox.Text);
    gallons = double.Parse(gallonsTextBox.Text);

    mpg = miles / gallons;

    mpgLabel.Text = mpg.ToString();
}
catch
{
    MessageBox.Show("Invalid data was entered.");
}

Explanation:
If invalid numeric data is entered, an exception can occur. The program then moves to the "catch" block.

---

23. Displaying an Exception Message

"Exception Message" (Week2/23_exception_message.png)

try
{
    statement;
}
catch (Exception ex)
{
    MessageBox.Show(ex.Message);
}

Explanation:
The "Message" property contains a description of the exception.

---

24. Named Constants

"Named Constants" (Week2/24_named_constants.png)

const double INTEREST_RATE = 0.129;

Explanation:
A constant represents a value that cannot be changed during program execution.

---

25. Fields

"Fields" (Week2/25_fields.png)

private string name = "Charles";

Explanation:
A field is declared inside the class but outside a method. Its scope is the entire class.

---

26. Field Demo Application

"Field Demo Application" (Week2/26_field_demo_application.png)

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

Explanation:
The "name" field can be accessed by different methods in the "Form1" class.

---

27. The "Math" Class

"Math Class" (Week2/27_math_class.png)

Math.Sqrt(x);

Math.Pow(x, y);

Math.Max(x, y);

Math.Min(x, y);

Math.Round(x);

Math.PI;

Math.E;

Explanation:
The "Math" class provides methods and constants for mathematical calculations.

---

28. Changing Focus

"Focus Method" (Week2/28_focus_method.png)

ControlName.Focus();

Example:

private void clearButton_Click(object sender, EventArgs e)
{
    nameTextBox.Focus();
}

Explanation:
"Focus()" gives keyboard focus to a control.

---

29. Keyboard Access Keys

"Access Keys" (Week2/29_access_key.png)

Alt + X

Explanation:
An access key allows the user to access a control using "Alt" plus a designated letter.

---

30. Setting Colors

"Colors" (Week2/30_colors.png)

messageLabel.BackColor = Color.Black;

messageLabel.ForeColor = Color.Yellow;

Explanation:
"BackColor" changes the background color. "ForeColor" changes the text color.

---

31. GroupBoxes and Panels

"GroupBox and Panel" (Week2/31_groupbox_panel.png)

GroupBox
Panel

Explanation:
Both controls can contain other controls. A GroupBox can display a title, while a Panel does not have a "Text" property.

---

32. Breakpoints

"Breakpoints" (Week2/32_breakpoints.png)

Breakpoint → Program pauses → Examine variables

Explanation:
A breakpoint pauses the program at a selected line so you can examine values while debugging.

---

33. Locals and Watch Windows

"Locals and Watch" (Week2/33_locals_watch.png)

Locals Window → variables in the current procedure

Watch Window → variables selected by the programmer

Explanation:
The Locals window shows variables in the current procedure. The Watch window lets you monitor selected variables.

---

34. Single-Stepping

"Single-Stepping" (Week2/34_single_stepping.png)

F11

Explanation:
Single-stepping executes the program one statement at a time. "F11" can be used to step into the code.
