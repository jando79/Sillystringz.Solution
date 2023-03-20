# _Dr. Sillystringz's Factory_

#### By _David Jandron_

#### _A C# web application using MySQL that creates a website for Dr.Sillystringz's Factory to track and manage Engineers and Machines assigned to specific factory sites _

## Technologies Used

* _.Net 6_
* _ASP.NET Core MVC 6_
* _C#_
* _MYSQL_

## Description

_This is site built to allow users to add engineers, machines, and factory locations. Engineers can be added to the machines they are able to fix. Machines can be added to Factoryy Locations._

## Setup/Installation Requirements

* Clone this repo.
* Open the terminal and navigate to this project's production directory called "Sillystringz.Solution".
* Within the production directory "Factory", create a new file called `appsettings.json`.
* Within appsettings.json, put in the following code.
```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=factory;uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
  }
}
```
* Within the production directory "Factory", run `dotnet watch run` in the command line to start the project in development mode with a watcher.

* Open the browser to https://localhost:5001.


## Known Bugs

* _Deleting and engineer from machine details produces and error message_

## License

_MIT License_

Copyright (c) _2023_ _authored by: David Jandron_