# Coding Club Homework Portal Solution

This repository contains the solution for the Coding Club homework portal, which can be accessed at https://codingclub.macleans.repl.co/problems. 

## Prerequisites

Before getting started, make sure you have the following installed on your system:

- Git
- .NET Core 3.1 framework (required to match the website's ability)
- IDE: either Visual Studio Code with extensions for C#, .NET Core Test Explorer, and GitLens, or Visual Studio 2022 Community Edition

## Structure

CodingClub -

    - CodingClubTests // Test project home directory
        - CodingClubTests.csproj    // Test project file
        - FizzBuzzTest.cs           // The test class, naming rule: [problem name]Test.cs
        - ComputerProblemTest.cs    // Another the test class
        - XxxxTest.cs               // Create yours test class and add them ...

    - Exercises // Homework project home directory
        - FizzBuzz      // Create a folder for every homework exercise
            - Readme.txt    // Copy the exercise requirement in this readme file
            - ApproachTestable.cs  // Your actual work is in DoJob method of this class, recommend name "ApproachTestable" though you can use anyother names
        - ComputerProblem   // Another homework exercise
            - Readme.txt    // Copy the exercise requirement in this readme file
            - ApproachTestable.cs  // Your actual work is in DoJob method of this class

        Program.cs  // Main function entry. You may also debug your script here
        TestableConsole.cs // The toolkit classes are defined here to support testing and debugging
    
    - .gitignore // git settings, to ingnore the build output files when sync to cloud
    - CodingClub.sln // Solution file


The repository has the following structure:In the `CodingClubTests` directory, you can find the test classes for each homework exercise. You can create your own test classes as needed.

The `Exercises` directory contains subdirectories for each homework exercise. Each subdirectory has a `Readme.txt` file with the exercise requirements, and an `ApproachTestable.cs` file where you should implement your code.

`Program.cs` is the main function entry where you can debug your script, and `TestableConsole.cs` contains the toolkit classes for testing and debugging.

`.gitignore` is a file that contains Git settings to ignore the build output files when syncing to the cloud.

`CodingClub.sln` is the solution file for the project.
