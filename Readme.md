
# Pushing to Git

### Go to the right folder
cd C:\Users\cmcc1\Documents\SSD

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

'''
methodName_whatScenarioToTest_expectedResult
sleepsUntilSanta_christmasEve_1
primeNumber_6_false
'''

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
	

