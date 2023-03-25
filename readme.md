# Coding Club Homework Portal Solution

This repository contains the solution for the Coding Club homework portal, which can be accessed at https://codingclub.macleans.repl.co/problems. 

## Prerequisites

Before getting started, make sure you have the following installed on your system:

- Git
- .NET Core 3.1 framework (required to match the website's ability)
- IDE: either Visual Studio Code with extensions for C#, .NET Core Test Explorer, and GitLens, or Visual Studio 2022 Community Edition

## Structure

- CodingClub -

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

        - Program.cs  // Main function entry. You put the tested script into the main function, do a final test, then copy the whole text to the Code Club web to submit.
        - TestableConsole.cs // The toolkit classes are defined here to support testing and debugging
        - Exercises.csproj  // The main project file
    
    - .gitignore // git settings, to ingnore the build output files when sync to cloud
    - CodingClub.sln // Solution file


The repository has the following structure:In the `CodingClubTests` directory, you can find the test classes for each homework exercise. You can create your own test classes as needed.

The `Exercises` directory contains subdirectories for each homework exercise. Each subdirectory has a `Readme.txt` file with the exercise requirements, and an `ApproachTestable.cs` file where you should implement your code.

`Program.cs` is the main function entry where you can debug your script, and `TestableConsole.cs` contains the toolkit classes for testing and debugging.

`.gitignore` is a file that contains Git settings to ignore the build output files when syncing to the cloud.

`CodingClub.sln` is the solution file for the project.

## An example
For a task called GHOSTBUSTERS on Coding Club website
- Create a new folder GhostBusters under folder Exercises
- Copy file Exercises/ComputerProblem.cs to the new folder then rename it to GhostBusters.cs
- Rename the class name to ComputerProblem in the file
- Create a readme file and paste the problem description
>The ghost busters have encountered N ghosts, and all of them are very cool.
>No, they don't need help catching them, they are Ghostbusters! Their trouble is what ghost to catch.
>All ghosts have a size value of s and a cool value of c. But the ghost busters' ghost storage box has only a maximum capacity of S! 😢 They can't catch all N ghosts > 
>due to some of them have bigger size than others. They want to get the maximum cool value C by catching the ghosts.
> ...

- Duplicate file CodingClubTests/ComputerProblemTest.cs in the same folder and rename it to GhostbustersTest.cs
- Rename the test class ComputerProblemTest to GhostbustersTest
- According the problem description, you replace the Datasets for the new test class GhostbustersTest
- Build the test project and run ComputerProblemTest via Test Explorer (Extension .NET Core Test Explorer), and they should fail which adhere Test-driven development (TDD) https://en.wikipedia.org/wiki/Test-driven_development
 
- Write your codes into Exercises/GhostBusters.cs file, DoJob method.
- Set breakpoint and debug GhostBustersTest.cs, if fails then modify your code in GhostBusters.cs until it is succeeded.
- Copy script of DoJob method to replace main function body of Program.cs
- Final run Exercises.csproj to make sure everything works.
- Copy content of file program.cs and paste it to https://codingclub.macleans.repl.co/problems, GhostBusters page and submit.
- Congraulation if you pass! Otherwise, go back to check your logic, you may miss some edge situation. You can add more dataset to your test class to test.