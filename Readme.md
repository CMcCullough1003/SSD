
# Pushing to Git

### Go to the right folder
###### cd C:\Users\cmcc1\Documents\SSD
cd C:\Users\cmcc1\OneDrive\Documents\SSD

### See which files have been changed
git status

### Tell git which files you are interested in saving
git add .

### Tell Git what you have changed 
git commit -m "Updates"

### Push your changes to the Github website
git push origin master


# Adding Unit Tests for Visual Studio

### Create and run unit tests

Go to this [page](https://docs.microsoft.com/en-us/visualstudio/test/getting-started-with-unit-testing?view=vs-2019)

Follow the instruction in the Create Unit Tests and Run Unit Tests sections.

### Test names

Name test method name so that you can understand what the do without even having to look at the code. Use the following pattern:

```
methodName_whatScenarioToTest_expectedResult
sleepsUntilSanta_christmasEve_1
primeNumber_6_false
```

### Test layout

Divide your test into three sections 

	- Assemble
	- Act
	- Assert

Assemble is where you gather all the things you are going to need to run the test; objects, constants, the expected result etc

Act is where you run the method. You will usually have a return value.

Assert is where you compare the expected value to the actual value returned from the method being tested.

### Test tips

	- One assert per test. Each thing you want to test has a different test method.
	- Make sure you see the test fail - if you don't see it fail when you expect to then it may not be working the way you think.
	- Make sure every path through the code in the method is tested.
	
	
# Guidelines

### Rule 1: Keep it simple
If it is complicated you are doing it wrong

### Rule 2: Write as little code as possible
The less code, the less chance of bugs

### Names
- variable names, method names and class names should be desribe what they do.
- it should read like English as much as possible.
- if it isn't named well it will just cause confusion.

### Functions
- functions should only do one thing
- functions that only do one thing will be short...because they only do one thing
- functions should average about 5 lines
- functions should rarely, if ever, be more than 10 lines 
- if it is intended (in an if, switch, loop) then it should be extracted to a method
- nested indents makes code messy - if you have them, get rid of them

### If statements
- complicated if statements should be changed to a function that returns a boolean

### Don't Repeat Yourself
- if have written the same lines of code more than once make it a function
- any string or number you use more than once should be a constant.
- if you have quote marks anywhere that isn't a constant, maybe it should be

### Comments
- if you name your variables, methods and classes correctly you should not need comments

### Nulls
- nulls are the main reason your code will crash - always initialize variables

### Errors
- it's easier to use exceptions instead of error codes
- if there is something wrong throw an exception

### Classes
- classes should only do one thing
- don't worry about creating more classes
- it's better to have three simple classes than one complicated one

### Fonts and Colours
- figure out the font types, colours, sizes, and weights early on
- figure out title, subtitle, body and button styles - will rarely need more
- keep the screens consistent 
- if it appears on many screens keep them in the same place (buttons, headings etc)

### Tests
- automated tests are better than manual tests
- pass all the values in the function needs and check everything it changes
- easier to test if three parameters or less 


