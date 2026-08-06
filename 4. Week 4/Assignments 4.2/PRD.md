# Application Design
## Product Requirements Documents

**Purpose:** Design a mini learning management for Teacher Role. Allow the Teacher to login. If the User id is “Teacher” and password “Admin” allow the user to get into the system and open another form. Allow teacher to add student with following fields:

- Student Id
- Student name
- GPA
Use any suitable generic list to save students in it.

Save the details of the student with highest GPA in a text file.

Allow teacher to delete the student.

**Language:** C#, Windows Forms
**Design of custom data type:**
```b
User (abstract class) - no parent type 
- UserName: string
- _password: string

Teacher : User 
- UserName: string 
- Password: string 

Student : User 
- GPA: double 

SessionContext (static class) - no parent type
- CurrentTeacher: Teacher 
- IsLoggedIn: bool 

Form1 : Form
Preliminary solution structure:

- Dependencies
- Models
  -> User
  -> Teacher
  -> Student
- Components
  -> Months
  -> Address
  -> MockData
- Views
  -> MainView
  -> AddView
  -> EditDelView
  →> LogInView
- README.md
- Program. cs
```
**Work Flows:**
```
- User start at MainView with all buttons and data not visible
- Only option available is "Log In"
- Log In Pop up accepting username and pass will decide user role
- AuthenticateUser and initiate SessionContext methods
- From there, data and options become visible accordingly
- User choices:
  -> Add / Delete students to class
  -> Save Student with highest GPA to txt file
  -> Add / Edit Grades
```
**External resources required (e.g. database, Azure):** None <br>
**Planned development time in hours:** 4 hours