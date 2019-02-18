# Response_Generator_Boilerplate
A solution for generating random strings as responses or quotes for C# and the .NET Framework. Complete with WinForms example application and the ResponseGenerator class that would fulfill this said purpose.
Can be useful for many forms (the WinForms implementation with the class, just the class used for another project, etc), however giving me credit when used in practice is preferred.

# What are some prerequisites to build this application?
* Visual Studio 2017 (untested with 2015 and older versions)
* .NET Framework 4.0 or later

# What is this class library/project for?
This is one way to tackle the concept of iterating through a string collection/array randomly, including boolean arrays to determine what item has been used or not.

# How do I get started?
If you wish to use the ResponseGenerator class for another project of yours, skip over to "Using the ResponseGenerator class in another project".

## I want to use the Windows Forms implementation, complete with the ResponseGenerator class
Awesome. Most changes you should do will remain in the realm of how things are designed in the form. Most of the groundwork is done in the project, all buttons are mapped to their appropriate methods for you to change later. One important thing to know is how to modify the string collection that this response generation is dependent on. Modify StringCollection Properties.Settings.Default.Responses by going to the Solution Explorer > Properties > Settings > Responses (the StringCollection with Application scope).

## Using the ResponseGenerator class in another project
The ResponseGenerator class has the following fields and methods:
```
private static StringCollection _responses; // string collection by default, but this is the collection of resources.
private bool[] _isResponseUsed;
private Random _rnd = new Random();
public bool AllResponsesUsed (bool[] ResponsesTaken); 
public string GenerateResponse();
```
The constructor uses a StringCollection as a parameter. Since StringCollection objects can be indexed, it makes migrating to, for instance, a primitive string array an easy task. The name of the game for the ResponseGenerator class is to get the reference of the string collection or other indexed string array/collection type of your choice, and to return a randomized response. When implementing it into another project, please keep using the same instance of ResponseGenerator to ensure random response generation every single time. It is the same principle behind using the Random class, **always use the same instance**.

## Do I have to give you credit for using this with a project of my own or simply modifying this program?
You do not have to give me credit, due to its simplistic nature (it's recommended, though). Have fun.
