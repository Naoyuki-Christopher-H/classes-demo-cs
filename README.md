# Classes Demo (C#)

This is a simple C# console application that demonstrates basic concepts of **classes** and **methods** in object-oriented programming.

## Overview

The project showcases how to:

* Define a class in C#
* Instantiate an object from a class
* Call methods from an object
* Handle exceptions using `try-catch`

The program prints a sequence of messages to the console using a class called `Messages`.

## Project Structure

```
classes-demo-cs/
├── Program.cs
├── classes_demo_cs.csproj
└── README.md
```

## Code Description

### `Program.cs`

Contains the `Main` method, which is the entry point of the application. It does the following:

1. Creates an instance of the `Messages` class
2. Calls three methods from the `Messages` class:

   * `DisplayMessage()`
   * `Waiting()`
   * `Goodbye()`
3. Wraps the method calls in a `try-catch` block to handle any unexpected exceptions.

### `Messages` Class

A simple class with three public methods:

* `DisplayMessage()` – Prints "Hello, World!"
* `Waiting()` – Prints "I am waiting for something."
* `Goodbye()` – Prints "Goodbye, World!"

## Requirements

* .NET Framework or .NET Core SDK
* C# compiler (e.g., Visual Studio, Visual Studio Code with C# extension)

## How to Run

1. Clone the repository:

   ```
   git clone https://github.com/Naoyuki-Christopher-H/classes-demo-cs.git
   ```

2. Navigate to the project directory:

   ```
   cd classes-demo-cs
   ```

3. Build and run the project:

   ```
   dotnet run
   ```

## Output

When run, the console will display:

```
Hello, World!
I am waiting for something.
Goodbye, World!
```

## DISCLAIMER  

UNDER NO CIRCUMSTANCES SHOULD IMAGES OR EMOJIS BE INCLUDED DIRECTLY IN 
THE README FILE. ALL VISUAL MEDIA, INCLUDING SCREENSHOTS AND IMAGES OF 
THE APPLICATION, MUST BE STORED IN A DEDICATED FOLDER WITHIN THE PROJECT 
DIRECTORY. THIS FOLDER SHOULD BE CLEARLY STRUCTURED AND NAMED ACCORDINGLY 
TO INDICATE THAT IT CONTAINS ALL VISUAL CONTENT RELATED TO THE APPLICATION 
(FOR EXAMPLE, A FOLDER NAMED IMAGES, SCREENSHOTS, OR MEDIA).

I AM NOT LIABLE OR RESPONSIBLE FOR ANY MALFUNCTIONS, DEFECTS, OR ISSUES THAT 
MAY OCCUR AS A RESULT OF COPYING, MODIFYING, OR USING THIS SOFTWARE. IF YOU 
ENCOUNTER ANY PROBLEMS OR ERRORS, PLEASE DO NOT ATTEMPT TO FIX THEM SILENTLY 
OR OUTSIDE THE PROJECT. INSTEAD, KINDLY SUBMIT A PULL REQUEST OR OPEN AN ISSUE 
ON THE CORRESPONDING GITHUB REPOSITORY, SO THAT IT CAN BE ADDRESSED APPROPRIATELY 
BY THE MAINTAINERS OR CONTRIBUTORS.

---
