# Pierre's Sweet and Savory Treats

#### _Track Treats and Flavors, 05/04/2021_

#### By _**Tristen Everett**_

## Description

This project was an attempt at showing the skills I learned to program in C# using Identity. In this project I built a ASP.NET MVC webapp that allows a logged in user to add Flavors and Treats to the database. A logged in user would then also be able to navigate to the edit view to modify the created Treat's or Flavor's Name and add a many to many relationship to objects of the other type. Users who are not logged in would then be able to navigate to the home route and detail views for Treats and Flavors to view what has been added. This project was built to meet the needs of the user stories listed below.

### User Stories

* The application should have user authentication. A user should be able to log in and log out. Only logged in users should have create, update and delete functionality. All users should be able to have read functionality.
* There should be a many-to-many relationship between Treats and Flavors. A treat can have many flavors (such as sweet, savory, spicy, or creamy) and a flavor can have many treats. For instance, the "sweet" flavor could include chocolate croissants, cheesecake, and so on.
* A user should be able to navigate to a splash page that lists all treats and flavors. Users should be able to click on an individual treat or flavor to see all the treats/flavors that belong to it.

## Setup/Installation Requirements

1. Clone this Repo
2. Run `dotnet ef database update` from within /SweetTreats to create the database
3. You may need to update the file /SweetTreats/appsettings.json to match the userID and password for the computer your using
4. Run `dotnet restore` from within /SweetTreats file location
5. Run `dotnet build` from within /SweetTreats file location
6. Run `dotnet run` from within /SweetTreats file location
7. Using your preferred web browser navigate to http://localhost:5000/

## Technologies Used

* C#
* ASP.NET Core
* Entity Framework Core
* Identity
* MYSQL
* Razor Pages

### License

This software is licensed under the MIT license

Copyright (c) 2021 **_Tristen Everett_**