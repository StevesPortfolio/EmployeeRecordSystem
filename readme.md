# Employee Record System

__Case Study__
Your exercise is to write code to for one of the processes in a larger system (an employee management or ‘HR’ system). Your process is part of the sub-system called ‘Employee Record System’ (add, display, delete or update records).

You have been asked to work on part of this system, specifically to code one of the processes (Record Employee Data). The design for your process is given below.

## Process Descriptions

__Data Descriptions__

``` Visual Basic.net
Dim EmpID As Integer
Dim firstname As String
Dim lastname As String
Dim phone As String
Public Const EmpFile As String = "Employees.csv"
```

Note: The file name should be declared as a constant in the module. Do NOT ‘hard code’ the file name – use the constant name ‘EmpFile’.

__File Description__
Employees.csv is a text file of comma separated values.
Fields are: EmployeeID, FirstName, LastName, Phone
Employee ID is an integer, starting at 1

1. Get Employee Data (**interface only)
   1. Check that all fields are complete
   2. Collect all data from form fields
   3. Call AddRecordToFile with Employee information (optional - update list box)
   4. Call DisplayRecords
   5. Clear all fields

>Notes: this is a form, a button on the form will call the sub “AddRecordToFile”, and send the validated information from the form.

2. AddRecordToFile(FirstName, LastName, Phone)
   1. ID = GetNextEmployeeID
   2. Open employee file
   3. Append record to file (ID, FirstName, LastName, Phone)
   4. Close file

>Note: this is a sub, should be written in a code module. The sub must have the name and inputs shown above.

3. GetNextEmployeeID
   1. Open Employee File
   2. Set highest to zero
   3. While not end of file
      1. Read next recordGet ID from record
      2. If ID>highest then
         1. Highest = ID
      3. End if
      4. End while
   4. Close file
   5. Return Highest +1

>Note: this is a function, should be written in a code module. The function must have the name shown above, and must return an integer.

4. DisplayRecords(list box)
   1. Open Employee File
   2. Clear list box
   3. While not end of file
      1. Read record
      2. Add record to list box
   4. End while
   5. Close file
