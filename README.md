![Image of Yaktocat](https://i.pinimg.com/originals/c7/1c/b8/c71cb81fcd65b4f3b0bd824f26ef7e06.png)

# Hogwarts Institutional Api

Institutional api for new student applications of the Hogwarts School of Witchcraft and Wizardry.

This project was generated with dotnet version 5.0.205

## Set up development server

Run `dotnet restore` for install dependencies.

For the database set up, the [EF Core command-line tools](https://docs.microsoft.com/en-us/ef/core/cli/) must be installed.

Run `dotnet ef database update` to create the Database and apply the initial migrations.

Run `dotnet watch run` for a dev server. the main endpoint is `https://localhost:5001/api`. The app will automatically reload if you change any of the source files.

Visit `https://localhost:5001/swagger/` for test the api through Swagger or read the [Doc](https://docs.google.com/document/d/1Nj3IsAIWhRQiAsWvPrcvV1BPnBTt-F0fNIPSmgtLMq0/edit?usp=sharing).
