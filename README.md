


Encapsulation in C# – Student Management Example
Overview

This project demonstrates the concept of Encapsulation in Object-Oriented Programming (OOP) using C# Windows Forms.

A Student class is created with private data members and public properties to control access to the data.
The application displays student information on a Windows Form when a button is clicked.

Concepts Used
Encapsulation
Classes and Objects
Properties (get and set)
Access Modifiers (private, public)
Windows Forms
Methods
Project Structure
1. Student Class

The Student class contains:

Private Fields
private string name;
private int age;
private string rollNum;
private string Class;
private string id;

These variables are hidden from outside access.

Public Properties

Properties are used to safely access private fields.

Example:

public string Name
{
    get { return name; }
    set { name = value; }
}
get → returns value
set → assigns value
Auto-Implemented Properties
public string RollNum { get => rollNum; set => rollNum = value; }

Short form of properties.

Read-Only Property
public string Id { get => id; }
Only get
Value cannot be changed directly from outside the class
Introduce Method
public string introduce()
{
    return $"My name is {Name}. \nI am {Age} years old. \nmy roll number is {RollNum}. \nI am in class {Class1}.\nMy id is "+(Class1+RollNum);
}

This method returns all student information in string format.

Form1 Class

When the button is clicked:

private void Student_Click(object sender, EventArgs e)

A Student object is created.

Object Creation
Student student = new Student();
Assigning Values
student.Name = "Muhammad Ali";
student.Age = 20;
student.RollNum = "014";
student.Class1 = "FA25-BSE";
Displaying Output
label1.Text = student.introduce();

The returned text from introduce() method is shown on the label.

Example Output
My name is Muhammad Ali.
I am 20 years old.
my roll number is 014.
I am in class FA25-BSE.
My id is FA25-BSE014
What is Encapsulation?

Encapsulation means:

“Binding data and methods into a single unit and restricting direct access to data.”

In this project:

Fields are private
Access is controlled using properties

This protects data from unauthorized access.

Advantages of Encapsulation
Data Security
Better Control on Variables
Easy Maintenance
Improves Code Reusability
Prevents Invalid Data Access
Possible Improvements

You can improve the project by:

Adding age validation
Automatically generating ID
Using constructors
Adding multiple students
Saving data in database

Example validation:

set
{
    if(value > 0)
        age = value;
}
