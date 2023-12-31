# _Pierre's Treats_

#### By _Jake Elsberry_

#### _A C# / ASP.NET Core MVC application using Entity Framework Core and MySQL._

## Technologies Used

* C#
* .NET 6
* ASP.NET Core MVC
* ASP.NET Core Identity
* Entity Framework Core
* MySQL
* MySQL Workbench
* Pomelo


## Description

A website for Pierre to track his various treats. Only Users who make an account can create, change, and delete items from the website. All other users can view the list of items and their details.

## Setup/Installation Requirements

#### Install Tools
This project assumes you have MySQL Server and MySQL Workbench installed on your system. If necessary, follow along with the installation steps for the tools introduced in these series of lessons on [LearnHowToProgram](https://full-time.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-c-and-net).

#### Set Up the Database
To set up a new database to run with this application, follow the instructions in this [LearnHowToProgram Lesson](https://full-time.learnhowtoprogram.com/c-and-net/database-basics/creating-a-test-database-exporting-and-importing-databases-with-mysql-workbench).
#### Install and Run the Project

1. Copy the **[URL](https://github.com/Schmelzberry/PierreTreats.git)** provided for this repository.
2. Open Terminal.
3. Change your working directory to where you want the cloned directory.
4. In your terminal, type `git clone` and use the copied URL from Step 1. Or, copy the following git command:
```bash
$ git clone https://github.com/Schmelzberry/PierreTreats.git
```
5. Open your terminal and navigate to this project's production directory called `TreatTracker`.
6. Within the production directory of the project, create a file called `appsettings.json` and add the following code to it:
   ```json
    {
      "ConnectionStrings": {
          "DefaultConnection": "Server=localhost;Port=3306;database=[DATABASE];uid=[USERNAME];pwd=[PASSWORD];"
      }
    }
   ```
7. Next, make sure to update the connection string with your own system's values for `[USERNAME]` and `[PASSWORD]` and `[DATABASE]`! Don't forget to replace the brackets `[]` as well.
8. Now that your connection string is ready, from the `TreatTracker` directory, run the following command:

```bash
$ dotnet ef database update
```

9. Now that the database schema is in place, we're ready to run the program. 
10. In the command line, run the following command to compile and run web application in development mode with a watcher:
   
```bash
$ dotnet watch run
```
> Optionally, you can run `dotnet build` to compile this web app without running it.

11. Open the browser to https://localhost:5001 to use the web application. 
> If you cannot access localhost:5001 it is likely because you have not configured a .NET developer security certificate for HTTPS.


## Known Bugs or Potential Issues

* Models currently lack data annotations, but project functions well without them.

## License

MIT License

Copyright (c) Jake Elsberry

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.