![Image of Yaktocat](https://i.pinimg.com/originals/c7/1c/b8/c71cb81fcd65b4f3b0bd824f26ef7e06.png)

# Hogwarts Institutional Api

Institutional api for new student applications of the Hogwarts School of Witchcraft and Wizardry.

This project was generated with dotnet version 5.0.205

## Set up development server

Run `dotnet restore` for install dependencies.

For the database set up, the [EF Core command-line tools](https://docs.microsoft.com/en-us/ef/core/cli/) must be installed.

Run `dotnet ef database update` to create the Database and apply the initial migrations.

Run `dotnet watch run` for a dev server. the main endpoint is `https://localhost:5001/api`. The app will automatically reload if you change any of the source files.

Visit `https://localhost:5001/swagger/` for test the api thru Swagger interface

## Code scaffolding

Run `ng generate component component-name` to generate a new component. You can also use `ng generate directive|pipe|service|class|guard|interface|enum|module`.

## Project structure inside /src/app/ folder

```bash
├── components   # Contains all the reusable components of the app
│   ├── forms    # Module with the forms of the app
│   ├── tables   # Module with the tables of the system
│   └── ui       # Module with the common Ui components like a spinner
├── models       # Contains the main user interfaces and classes of the app
├── pages        # Contains all the interfaces of the app
├── pipes        # Contains all the pipes of the app
├── services     # All the services of the system
└── shared       # Contains the shared elements of the UI like the navbar or the footer
```
