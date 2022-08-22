# My Projects at BCS

This repository is a collection of all the projects I've worked on during my brief time as a Software Engineer at a food distribution company in Queens, NY.

It consists of a combination of C#, of which all were written using the Microsoft Visual Studio (2019) IDE, and establishes a connection with the company's database to run queries in conjunction with SQL Server Management Studio (SSMS).

The repository itself will not hold the entirety of the ERP system that was in use during my time at the company. You will find only code that I have written.

Code that may contain sensitive information to the company will be replaced with my name in the follwing manner, "JINKIM".

Unfortunately, as this repository will only contain a handful of the files that comprises the ERP system, the code itself will not compile.
As such, neither a first-hand experience with the different winforms nor an execution of a stored procedure is possible. I will include as many comments
as I can within the available code to hopefully give you a coherent understanding of what is happening during execution.

In general however, the control flow is quite simple. Physical functions (i.e. A BUTTON) are included within these created Winforms (within file "OBCS"), the code for which will eventually call a function from within a "connections" page (connSalesOrder, connPO, etc. = they help establish a connection with the company's database). These functions within the "connections" page act as the middle-man between the C# and SQL components that comprise the ERP system, sending and receiving data from both ends.

  - Continuing on with the example of a button: Once the button is clicked, relevant data that is being displayed within the winform will be stored within their own variables and sent in as arguments to help structure the query of a specific stored procedure. 
