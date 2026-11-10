# Code Screenshots – Chapter 4: Loops, Files, and Random Numbers

This guide lists every slide in the presentation that contains C# code, code syntax, a code structure, or a code fragment embedded in a slide image. Each image is a full-slide screenshot so that the code and its surrounding explanation or activity context remain together.

**Source:** *Starting Out With Visual C#*, Sixth Edition, Global Edition, Chapter 4.

## Slide 04 – Structure of a while Loop

This slide presents the general C# while-loop structure: a Boolean condition followed by a braced statement body. It identifies the while clause, the loop body, iteration, and counter variables, so the screenshot shows both the syntax and the vocabulary used to describe it.

![Slide 04 – Structure of a while Loop](Code_Screenshots/Slide_04.png)

## Slide 05 – The while Loop is a Pretest Loop

The example initializes count to 0 and repeats a MessageBox.Show call while count is less than 5. The count update inside the loop makes the condition eventually false, so the loop displays the message five times. The slide also explains why a pretest loop needs a suitable initial value to run at least once.

![Slide 05 – The while Loop is a Pretest Loop](Code_Screenshots/Slide_05.png)

## Slide 06 – The while Loop is a Pretest Loop

This example starts count at 5 and tests count < 5 before entering the loop. Because that condition is false immediately, the body is skipped and no message box appears. It demonstrates the pretest behavior of while.

![Slide 06 – The while Loop is a Pretest Loop](Code_Screenshots/Slide_06.png)

## Slide 07 – Infinite Loops

The code initializes count to 0 and repeatedly displays a message while count < 5, but it never changes count. The condition therefore stays true and the loop does not end normally. This illustrates how omitting an update that can make the condition false creates an infinite loop.

![Slide 07 – Infinite Loops](Code_Screenshots/Slide_07.png)

## Slide 08 – Lap Practice – The Ending Balance form

This lab-practice slide shows the Ending Balance form and the C# fragments used in its monthly-interest calculation. The code declares a monthly interest-rate constant and adds the current month’s interest to the balance. The form labels identify the input fields, result label, and Calculate, Clear, and Exit buttons.

![Slide 08 – Lap Practice – The Ending Balance form](Code_Screenshots/Slide_08.png)

## Slide 09 – Lap Practice – The modified Ending Balance form

This slide shows the modified Ending Balance form and its displayed results for a starting balance of 1000 over eight months. The visible C# fragments add monthly interest to the balance and append a formatted monthly ending-balance message to detailListBox. The screenshot preserves the form, output, and code together.

![Slide 09 – Lap Practice – The modified Ending Balance form](Code_Screenshots/Slide_09.png)

## Slide 10 – The increment and decrement Operators

The slide compares ways to increase and decrease a variable by one, including count++, count += 1, and count = count + 1, as well as their decrement equivalents. These are alternative C# expressions for changing a counter value and are commonly used in loops.

![Slide 10 – The increment and decrement Operators](Code_Screenshots/Slide_10.png)

## Slide 11 – Postfix Mode versus Prefix Mode

This slide contrasts postfix and prefix placement of the increment and decrement operators. It shows count++ and --count and explains that postfix uses the old value before changing it, while prefix changes the value before it is used.

![Slide 11 – Postfix Mode versus Prefix Mode](Code_Screenshots/Slide_11.png)

## Slide 12 – Example of postfix and prefix mode

The slide contains two C# examples that compare postfix and prefix increment behavior. Each example initializes count and x, displays their values, applies an increment to x, and displays the values again. The message-box calls make the difference in evaluation order observable.

![Slide 12 – Example of postfix and prefix mode](Code_Screenshots/Slide_12.png)

## Slide 13 – Test Inside Class

This in-class exercise contains short C# code samples using number++, number--, and a while loop with count++. It asks learners to determine the displayed values and how many times the loop iterates. The screenshot includes the complete questions and code.

![Slide 13 – Test Inside Class](Code_Screenshots/Slide_13.png)

## Slide 14 – The for Loop

This slide gives the general for-loop structure and names its three expressions: initialization, test, and update. The loop tests its Boolean condition before each iteration, and the update expression changes the counter after the body runs.

![Slide 14 – The for Loop](Code_Screenshots/Slide_14.png)

## Slide 15 – Sample Code (2 of 4)

The slide shows two equivalent ways to write a for loop that displays Hello five times: declaring count in the initialization expression or declaring it before the loop. The accompanying explanation describes initialization, condition testing, updating, and restarting the loop.

![Slide 15 – Sample Code (2 of 4)](Code_Screenshots/Slide_15.png)

## Slide 16 – Other Forms of Update Expression

These examples show that a for-loop update expression does not have to add one. One loop counts upward by ten from 0 through 100, and another counts backward from 10 to 0. Both display the current counter value in a message box.

![Slide 16 – Other Forms of Update Expression](Code_Screenshots/Slide_16.png)

## Slide 18 – The do-while Loop

This slide introduces the do-while loop as a posttest loop. Its general C# structure executes the braced statements first and tests the Boolean expression afterward, so the body is always executed at least once.

![Slide 18 – The do-while Loop](Code_Screenshots/Slide_18.png)

## Slide 19 – Sample Code

The two examples compare a do-while loop and a while loop when number starts at 1 and the condition number < 0 is false. The do-while version still displays the number once because it tests afterward; the while version skips its body because it tests first.

![Slide 19 – Sample Code](Code_Screenshots/Slide_19.png)

## Slide 20 – Test In Class

This checkpoint slide includes a do-while code sample and asks learners to identify a posttest loop, compare while with do-while, and count loop iterations. The screenshot preserves the exercise questions and the complete loop fragment.

![Slide 20 – Test In Class](Code_Screenshots/Slide_20.png)

## Slide 22 – File Accessing

This slide introduces the file-related .NET classes StreamWriter and StreamReader. StreamWriter is used to write text to a file, while StreamReader is used to read text from a file. These class names are the core code identifiers for the file examples that follow.

![Slide 22 – File Accessing](Code_Screenshots/Slide_22.png)

## Slide 23 – Writing Data to a File

This slide outlines the steps for writing to a text file: create a StreamWriter, open the file with File.CreateText or File.AppendText, write data with Write or WriteLine, and close the connection. The screenshot includes the key C# declarations and method names.

![Slide 23 – Writing Data to a File](Code_Screenshots/Slide_23.png)

## Slide 24 – Sample Code (4 of 4)

The code creates courses.txt with File.CreateText, writes three course names using WriteLine, and closes the StreamWriter. The slide explains that WriteLine ends each written item with a newline, whereas Write writes without adding a newline.

![Slide 24 – Sample Code (4 of 4)](Code_Screenshots/Slide_24.png)

## Slide 25 – CreateText versus AppendText

This slide demonstrates File.AppendText by writing three names to Names.txt and then closing the output file. It explains that CreateText creates a file or erases an existing file’s contents, while AppendText preserves existing content and adds new data.

![Slide 25 – CreateText versus AppendText](Code_Screenshots/Slide_25.png)

## Slide 26 – Specifying the Location of an Output File

The examples show how to specify a file location as well as a filename. One uses a verbatim string path prefixed with @, and another shows escaped backslashes in a path. The code illustrates path formatting for File.AppendText and File.CreateText.

![Slide 26 – Specifying the Location of an Output File](Code_Screenshots/Slide_26.png)

## Slide 27 – Reading Data from a File

This slide introduces reading text files with StreamReader and File.OpenText. It shows the inputFile declaration and opening students.txt, and describes Read, ReadLine, ReadToEnd, and File.ReadAllText as reading options before the connection is closed.

![Slide 27 – Reading Data from a File](Code_Screenshots/Slide_27.png)

## Slide 28 – Example of read file

This slide compares several file-reading patterns: reading one line with ReadLine, reading characters with Read, reading the remaining content with ReadToEnd, and reading the whole file with File.ReadAllText. The examples add retrieved text to listBox1 where shown and close the reader after stream-based reading.

![Slide 28 – Example of read file](Code_Screenshots/Slide_28.png)

## Slide 29 – Reading a File with a Loop

The slide shows two equivalent loop conditions for reading until the end of a file: inputFile.EndOfStream == false and !inputFile.EndOfStream. EndOfStream indicates whether the reader has reached the end, allowing a loop to process file content without assuming a fixed number of lines.

![Slide 29 – Reading a File with a Loop](Code_Screenshots/Slide_29.png)

## Slide 30 – Example of read-line method

This example declares a StreamReader, opens a text file, and loops while EndOfStream is false. Inside the loop it reads each line with ReadLine and adds it to listBox1; the reader is closed after the reading operation, and an exception handler displays an error message.

![Slide 30 – Example of read-line method](Code_Screenshots/Slide_30.png)

## Slide 32 – Displaying an Open Box

This slide shows the openFileButton_Click event handler and calls openFileDialog.ShowDialog() to display the standard Open dialog. It also explains that an OpenFileDialog component is placed in the Designer’s component tray rather than appearing on the form at runtime.

![Slide 32 – Displaying an Open Box](Code_Screenshots/Slide_32.png)

## Slide 33 – Detecting the User’s Selection

The code stores the result of openFileDialog.ShowDialog() in a DialogResult variable. It checks for DialogResult.OK and DialogResult.Cancel so the application can respond differently depending on whether the user opens a file or cancels the dialog.

![Slide 33 – Detecting the User’s Selection](Code_Screenshots/Slide_33.png)

## Slide 34 – Example of Dialog results ok or cancel

This example checks the result of the Open dialog. If the user selects OK, the program opens the selected path with File.OpenText, reads a line, adds it to listBox1, and closes the reader; if the user cancels, it displays a cancellation message.

![Slide 34 – Example of Dialog results ok or cancel](Code_Screenshots/Slide_34.png)

## Slide 35 – The Filename and InitialDirectory Property

The slide demonstrates opening the selected file when ShowDialog returns DialogResult.OK and using openFileDialog.Filename as the file path. It also sets InitialDirectory to a specified folder so the Open dialog initially displays that location.

![Slide 35 – The Filename and InitialDirectory Property](Code_Screenshots/Slide_35.png)

## Slide 36 – Examples of filename

This example opens a file through openFileDialog1, creates a StreamReader from its FileName, and reads lines until EndOfStream is reached. Each line is added to listBox1, and the reader is closed at the end.

![Slide 36 – Examples of filename](Code_Screenshots/Slide_36.png)

## Slide 37 – Displaying a Save As Dialog Box

This slide shows the main steps for a Save As dialog: call saveFileDialog.ShowDialog(), test for DialogResult.OK, and create the output file. The code uses File.CreateText to open the selected destination, illustrating how a user chooses where output is saved.

![Slide 37 – Displaying a Save As Dialog Box](Code_Screenshots/Slide_37.png)

## Slide 38 – Save Diaglog

This example uses saveFileDialog1.ShowDialog() and checks whether the result is DialogResult.OK. If the user confirms, it creates a text file at the selected FileName, writes a name with WriteLine, and closes the writer; if the user cancels, it displays a cancellation message.

![Slide 38 – Save Diaglog](Code_Screenshots/Slide_38.png)

## Slide 39 – Random Numbers

The slide introduces the Random class and creates a Random object named rand. It demonstrates Next for generating an integer and NextDouble for generating a floating-point value between 0.0 and 1.0.

![Slide 39 – Random Numbers](Code_Screenshots/Slide_39.png)

## Slide 40 – Syntax of the Random.Next Method

This slide gives the Random.Next(max + 1) syntax and explains the range of values returned. The example rand.Next(100) generates an integer from 0 through 99, because the upper bound supplied to Next is exclusive.

![Slide 40 – Syntax of the Random.Next Method](Code_Screenshots/Slide_40.png)

## Slide 41 – The Load Event

This slide explains that the form’s Load event occurs as the application form is loaded into memory. It shows the empty Form1_Load event-handler structure with the standard object sender and EventArgs e parameters.

![Slide 41 – The Load Event](Code_Screenshots/Slide_41.png)

## Slide 42 – The Load Event

This example places MessageBox.Show inside Form1_Load. The message is displayed when the form is launched because code in the Load event handler runs as the form loads.

![Slide 42 – The Load Event](Code_Screenshots/Slide_42.png)
