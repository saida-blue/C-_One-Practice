 File Lesson

Project Description

This is my C# Windows Forms project. It demonstrates how to work with files using a file named "courses.txt".

Buttons and Their Functions

1. Write Button

The Write button creates the "courses.txt" file and writes three course names into it: Introduction to Computer Science, English Composition, and Calculus I. If the file already contains data, the old data is replaced.

2. Read Button

The Read button reads the file using "File.ReadAllBytes()". It converts the bytes into text and displays each course in the ListBox.

3. Append Button

The Append button adds a new course called Computer Programming to the end of the file. It keeps the previous data without replacing it.

4. Clear Button

The Clear button removes all items from the ListBox. It does not delete or change the data stored in the file.

5. Delete All Items Button

The Delete All Items button removes all the data inside "courses.txt". The file still exists, but it becomes empty.

6. Delete File Button

The Delete File button deletes the entire "courses.txt" file. After deleting it, the file must be created again before it can be used.

What I Learned

In this project, I learned how to create, write, read, append, clear, and delete files using C# Windows Forms.