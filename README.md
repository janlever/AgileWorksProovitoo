# DotNet customer complaint website
- This is a customer support environment app where users can add, view, and remove complaints/appeals. The program runs on the server side using .NET, utilizing the MVC pattern. The application is connected to a SQLite database. Table schema:

```SQL
CREATE TABLE "Applications" (
"ApplicationID" INTEGER NOT NULL CONSTRAINT "PK_Applications" PRIMARY KEY AUTOINCREMENT,
"Deadline" TEXT NOT NULL,
"Description" TEXT NOT NULL,
"EntryDate" TEXT NOT NULL,
"Solved" INTEGER NOT NULL
)
```

### Challenges Faced

- Since I had no prior experience with .NET, it was challenging to know where to even start. Additionally, adapting to the MVC pattern was difficult: shared folders, views folders, etc. Also work with controllers and models were new to me so that too was an obstacle. Connecting to the database also posed problems, but eventually, it started working.

### Functionality

- When opening the page, the user has the option, through hyperlinks, to submit a new appeal or view all appeal.
- The same options are available on the navigation bar.
- By clicking "Vajuta siia, et esitada pöördumine", the user can write a description of the appeal and select a deadline.
- After clicking "Saada pöördumine", a view is opened displaying the newly entered description of the appeal.
- Additionally in this view, there is an option to enter a new appeal or view all submitted appeals.
- On the view displaying all appeals, there is a table showing the appeal description, entry timestamp, deadline, and "marked as solved" status.
- All of this data is retrieved from the database once the user submits the request.
- Users have the option to mark appeals as solved, removing them from the table and the database.
- Starting from the moment when there is less than an hour until the deadline, all columns related to that appeal turn red.

### Running the app in Terminal

- cd TodoApi
- dotnet run --launch-profile https
- Open link: https://localhost:7028
