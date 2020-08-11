[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![LinkedIn][linkedin-shield]][linkedin-url]

<!-- PROJECT LOGO -->
<br />
<p align="center">
  <h3 align="center">Oracle Data Fetch</h3>

  <p align="center">
    Oracle Data Fetch is a small web service for fetching data from old Oracle 10g database with use of ODP.NET.
    <br />
    <br />
    <a href="https://github.com/matdon90/OracleDataFetch/issues">Report Bug</a>
    ·
    <a href="https://github.com/matdon90/OracleDataFetch/issues">Request Feature</a>
  </p>
</p>

<!-- TABLE OF CONTENTS -->
## Table of Contents

* [About the Project](#about-the-project)
* [Used Technologies](#used-technologies)
* [Getting Started](#getting-started)
* [Contributing](#contributing)
* [Contact](#contact)


<!-- ABOUT THE PROJECT -->
## About The Project

Oracle Data Fetch is a small Web API 2 service for fetching data from old, obsolate Oracle 10g database where cannot be used EF.
In project there is implemented connection to database with use of ODP.NET. To encapsulate the logic required to access data source the Repository pattern is used.


<!-- USED TECHNOLOGIES -->
### Used Technologies

* [ASP.NET MVC v5.1.0.0](https://dotnet.microsoft.com/apps/aspnet)
* [ASP.NET Web API 2](https://docs.microsoft.com/en-US/aspnet/web-api/)
* [ODP.NET](https://www.oracle.com/database/technologies/appdev/dotnet/odp.html)
* [Autofac](https://autofac.org/)
* [AutoMapper](https://automapper.org/)
* [Swagger](https://swagger.io/)

<!-- GETTING STARTED -->
## Getting Started

To get a local copy up and running follow these simple steps:

* Download the latest stable version from the download tab and unzip it to your folder
* Open the solution in Visual Studio 2019. 
* Build the solution to install Nuget packages.
* Change in web project in `Web.config` the data needed for database connection:

```xml
  <connectionStrings>
    <add name="OracleDb" connectionString="yourConnectionString"/>
  </connectionStrings>
```

```xml
  <appSettings>
    <add key="yourTableNameId" value="yourTableName"/>
  </appSettings>
```
* To have it working with your model you need to create appropriate model, view model, controller, service and repository basing on my `BearingChokes` model.
* Run application
* To access SwaggerUI fire up your browser and open url `https://localhost:44351/swagger`
* To use other programs i.e. POSTMAN use url `https://localhost:44351/api/[PrefixOfYourController]`. In my case `https://localhost:44351/api/bearingchokes`
* Enjoy ;-)


<!-- CONTRIBUTING -->
## Contributing

Contributions are what make the open source community such an amazing place to be learn, inspire, and create. Any contributions you make are **greatly appreciated**.

1. 🍴 Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. 🔃 Open a Pull Request


<!-- CONTACT -->
## Contact

Mateusz Donhefner

Project Link: [https://github.com/matdon90/OracleDataFetch](https://github.com/matdon90/OracleDataFetch)

<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[contributors-shield]: https://img.shields.io/github/contributors/matdon90/OracleDataFetch.svg?style=flat-square
[contributors-url]: https://github.com/matdon90/OracleDataFetch/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/matdon90/OracleDataFetch.svg?style=flat-square
[forks-url]: https://github.com/matdon90/OracleDataFetch/network/members
[stars-shield]: https://img.shields.io/github/stars/matdon90/OracleDataFetch.svg?style=flat-square
[stars-url]: https://github.com/matdon90/OracleDataFetch/stargazers
[issues-shield]: https://img.shields.io/github/issues/matdon90/OracleDataFetch.svg?style=flat-square
[issues-url]: https://github.com/matdon90/OracleDataFetch/issues
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=flat-square&logo=linkedin&colorB=555
[linkedin-url]: https://www.linkedin.com/in/mateusz-donhefner/