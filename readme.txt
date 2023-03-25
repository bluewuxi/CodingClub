Website: https://codingclub.macleans.repl.co/problems

This repo is created as a homework portal solution for coding club homework.

The structure:

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
