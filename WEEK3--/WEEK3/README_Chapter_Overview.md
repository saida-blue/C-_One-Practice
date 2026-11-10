# WEEK3 — Chapter Overview

**Textbook:** *Starting Out with Visual C#, Sixth Edition*  
**Chapter:** Chapter 3 — “Making Decisions”  
**Presentation section numbers:** 4.1–4.11

## Chapter purpose

This chapter explains how a C# program makes decisions. A decision structure controls which statements execute based on whether a condition is true or false. The chapter introduces Boolean expressions, relational and logical operators, alternative decision paths, input conversion and validation, selection controls, the `switch` statement, and ListBox operations.

## Topics covered

### 1. Decision Structures and the if Statement
A control structure determines the order in which program statements execute. A sequence structure runs statements in the order they appear. A decision structure executes statements only under certain circumstances. The `if` statement uses a Boolean expression that evaluates to `true` or `false`.

### 2. The if-else Statement
An `if-else` statement provides two alternative paths. The `if` block executes when its Boolean expression is true; otherwise, the `else` block executes.

### 3. Nested Decision Structures
A nested decision structure places one decision inside another. It allows a program to test an additional condition within a path selected by an earlier condition. The chapter also explains the `if-else-if` structure for checking multiple conditions in sequence.

### 4. Logical Operators
- `&&` (AND): both Boolean expressions must be true.
- `||` (OR): at least one Boolean expression must be true.
- `!` (NOT): reverses the truth value of a Boolean expression.

### 5. bool Variables and Flags
A `bool` variable stores `true` or `false`. A flag is a Boolean variable used to signal whether a condition exists in a program.

### 6. Comparing Strings
The presentation demonstrates the `==` and `!=` operators and the `String.Compare` method for comparing string values.

### 7. Preventing Data Conversion Exceptions with TryParse
The chapter introduces `int.TryParse`, `double.TryParse`, and `decimal.TryParse`. The general syntax uses the `out` keyword to receive the converted value: `dataType.TryParse(string input, out targetVariable)`.

### 8. Input Validation
Input validation checks whether entered data is acceptable before it is used. `TryParse` checks whether text can be converted, but it does not check whether the resulting number is within an acceptable range. Examples include hours worked from greater than zero through 168 and test scores from 0 through 100.

### 9. Radio Buttons and Check Boxes
Radio buttons allow one choice from a group; choosing one automatically deselects the others in that group. Check boxes allow multiple options to be selected. The chapter covers the `Text` and `Checked` properties and the `CheckedChanged` event.

### 10. The switch Statement
The `switch` statement is a multiple-alternative decision structure. It compares a test expression with `case` values. `break` ends a case, and the optional `default` section handles values that do not match a case.

### 11. Introduction to List Boxes
A ListBox displays items and allows the user to select one. The presentation covers `Text`, `Items`, `Items.Count`, `SelectedItem`, and `SelectedIndex`. It demonstrates `Items.Add`, `Items.Remove`, `Items.RemoveAt`, and `Items.Clear`. It also explains that `SelectedIndex` is `-1` when no item is selected and warns against accessing `SelectedItem` without a selection.

## Learning outcomes

After studying this chapter, a student should be able to:
- Explain sequence and decision structures.
- Write `if`, `if-else`, nested `if`, and `if-else-if` statements.
- Use relational and logical operators in Boolean expressions.
- Declare and use Boolean variables as flags.
- Compare strings with operators and `String.Compare`.
- Use `TryParse` to check numeric conversion.
- Validate input ranges.
- Check RadioButton and CheckBox selections and respond to `CheckedChanged`.
- Use `switch`, `case`, `break`, and `default`.
- Add, select, remove, and clear ListBox items.

## Screenshot collection

The `Code_Screenshots` folder contains 21 original full-slide PNG screenshots of the code-bearing slides. The detailed slide-by-slide explanations and embedded images are in [README_Screenshots.md](README_Screenshots.md).

## Source note

This overview follows the topics and terminology in the supplied PowerPoint. The screenshots preserve the original slides; they are not rewritten source-code files.
