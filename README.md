# _Eau Claire Salon_

#### _A Basic Online Management System for a Salon's Clients and Stylists_

#### _By **Jennifer Batara**_

## Description

This application is a ASP.Net MVC web application that gives a salon owner the ability to take a look at all the stylists, clients, services, and appointments on offer for their salon.

The user is able to add stylsits, add clients, add services, and add appointments. No clients can be added without any stylists available, and no appointments can be made without client.

## User Stories
- As the salon owner, I need to be able to see a list of all stylists.
- As the salon owner, I need to be able to select a stylist, see their details, and see a list of all clients that - belong to that stylist.
- As the salon owner, I need to add new stylists to our system when they are hired.
- As the salon owner, I need to be able to add new clients to a specific stylist. I should not be able to add a client if no stylists have been added.

## Setup/Installation 

### Requirements
-   Internet Connection
-   Internet browser
-   Bash Terminal
-   .NET Core 2.2
-   SQLite

### Cloning the Project Locally
If you do not have the .NET Core installed on your computer, please install it by following the directions for your operating system [here](https://dotnet.microsoft.com/download). The .NET Core version used for this project is 2.2.

To view locally please change directory to the directory in which you would like to clone the repository. Copy the link to [this repo](https://github.com/jbatara/EauClaireSalon.git) and type the following command into your Bash terminal:
```
$git clone repo_url
```

with repo_url being the url that was just copied. To open the console app, navigate to the local directory which the online repository was cloned to using the command

```
$cd EauClaireSalon/HairSalon
```

### Setting up a MySql 

Make sure you have MySql installed on your machine. If you do not, download the [MySql Community Server](https://dev.mysql.com/downloads/mysql/). Install MySql, and create a password for the default user. _Make sure to write down this password as all future MySql processes need this password!_

Once installed correctly, run a local instance of your MySql database using the command:
```
$mysql -u root -p
```
The terminal will prompt you to input your password that you have previously saved.

Once running successfully, you will see a welcome message and the prompt will turn into:
```
mysql> 
```
### MySql Database Schema
To reconstruct the database schema and data from the mysql command line interface type in the following commands:

1. Create a new database called salon
```
mysql> CREATE DATABASE salon;
```
Some errors you may encounter:
- ERROR 1007 (HY000): Can't create database 'salon'; database exists
  In this case, make sure that your previously created salon database is empty, so that you don't overwrite important data. If it is not empty, change the name of the database to something different. _Be sure to note the name of the database, as it will be important for future configuration._

2. Change the working database to the new 'salon' database you have created. (If your database name is different, replace 'salon' with your database name.)
```
mysql> USE salon;
```

3. Recreate the database schema by pointing to the Salon.sql file. Make sure to replace "[local path]" with the path from the root to the location of the EauClaireSalon project.
```
mysql> SOURCE [local path]/EauClaireSalon/HairSalon/Salon.sql;
```

Now your database has been recreated!

### Connecting the Application to Local MySql Instance
Open the _appsettings.json_ file in the Hair Salon folder.
```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=salon;uid=root;pwd=password;"
  }
}
```
Change "password" to your MySql password. Please make sure to correct the database name if it was changed.


### Running the Application

Change the terminal directory to be in the HairSalon project of the EauClaireSalon folder. Confirming that you have .NET core installed (version 2.2), run the app with the command
```
$dotnet run
```
and enjoy!

This project is currently not hosted online.

## Known Bugs

_None. All previously reported bugs have been resolved._

## Support and contact details

Please feel free to contact the developer by raising a new [issue](https://github.com/jbatara/EauClaireSalon/issues/new) on the github repo. You can browse the current issues [here](https://github.com/jbatara/EauClaireSalon/issues).

## Technologies Used

* C#
* .NET Core 2.2

### License

_MIT_

Copyright (c) 2019 **_Jennifer Batara_**
