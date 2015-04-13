SpecFlow Experiment
===================

Purpose
-------


To experiment with the SpecFlow tool in Visual Studio 2013.  SpecFlow is the C# implementation of the Cucumber BDD system.

How to run the example
----------------------

1. Clone the git repo into a new solution in Visual Studio 2013
2. Install the "SpecFlow for Visual Studio 2013" Visual Studio extension
3. Open solution explorer
4. Right click the "Specflow Tutorial" project and choose "Run SpecFlow Scenarios"
5. A test should run and pass

Code orgranisation
------------------

There are only two files of any interest:

1. "Tutorial.feature" -- The specification file describing the test scenario to run
2. "OrderingAnswersSteps.cs" -- The source code that both defines the bindings from the specification file to the code *and* defines the QuestionModel class which is the class under test.  Obviously in a real world example the class under test would be in a different file.





Last updated: dave@goopot.co.uk, 13 April 2015