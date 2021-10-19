
'Module Name: modEmployeeData
'Author: Steve Teece
'Date Written: 30 March, 2019
'Task: Coding to a model exercise
'Version 1.0


'ModuleName: modEmployeeData
'Author: Steve Teece
'Version: 1.0
'Task: Week 10 exercise, coding to a model
'Date Written: 1 April, 2018

Imports System.IO

Module modEmployeeData
    'Declare module level variables
    Public Const EmpFile As String = "Employees.csv"

    Dim EmpID As Integer
    Dim firstname As String
    Dim lastname As String
    Dim phone As String

    ''' <summary>
    ''' Adds a new record to the Employee file in CSV format
    ''' </summary>
    ''' <param name="FirstName">First name of the new employee as a string</param>
    ''' <param name="LastName">Last name of the new employee as string</param>
    ''' <param name="Phone">P{hone number of the new employee as string</param>
    Public Sub AddRecordToFile(FirstName As String, LastName As String, Phone As String)
        'ID = GetNextEmployeeID
        'Open employee file  
        'Append record To file (ID, FirstName, LastName, Phone)
        'Close file
        Dim newEmployeeRecord As String = ""
        EmpID = GetNextEmployeeID()

        'Create new comma separated string for writing to text file
        newEmployeeRecord = vbCrLf + EmpID.ToString() + "," + FirstName + " " + LastName + "," + Phone

        'Create new Streamwriter to append to the text file
        Dim sw As StreamWriter = New StreamWriter(EmpFile, True)
        'Write the new record
        sw.WriteLine(newEmployeeRecord)

        'Close the file
        sw.Close()


    End Sub

    ''' <summary>
    ''' Loops through the CSV file until the last record
    ''' Finds the highest ID in the file and returns the ID for a new record
    ''' (highest existing ID + 1)
    ''' </summary>
    ''' <returns>Integer representing the ID of the next record to be added</returns>
    Private Function GetNextEmployeeID() As Integer
        'Open Employee File
        'Set highest to zero
        'While Not end of file
        '   Read next record
        '   Get ID from record
        '   If ID > highest Then
        '       Highest = ID
        '   End If
        'End While
        'Close file
        'Return Highest + 1

        'Define temporary variables
        Dim tempRecord As String
        Dim sr As StreamReader = New StreamReader(EmpFile)
        Dim tempID As Integer
        Dim newID As Integer = 0

        If File.Exists(EmpFile) Then
            'Loop through file to end
            Do While sr.Peek() >= 0
                tempRecord = sr.ReadLine()
                'Get ID of record just read
                tempID = GetRecordID(tempRecord)
                If tempID > newID Then
                    newID = tempID
                End If
            Loop
            newID += 1
        Else
            MessageBox.Show("The employee file was not found", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        sr.Close()
        Return newID
    End Function

    Public Sub DisplayRecords(lst As ListBox)
        'Open employee file
        'Clear list box
        'While not end of file
        '   Read record
        '   Add record to list box
        'End While
        'Close file

        lst.Items.Clear()

        Dim sr As New StreamReader(EmpFile)

        Do While sr.Peek() >= 0
            lst.Items.Add(sr.ReadLine)
        Loop
        sr.Close()

    End Sub

    ''' <summary>
    ''' Takes a single line of a CSV file,converts it to an array of the record, and figures out the ID of the record
    ''' which is the first element of the array
    ''' </summary>
    ''' <param name="record">Sing line of a record, with fields separated by the comma "," character</param>
    ''' <returns>Integer representing the ID of the current record</returns>
    Private Function GetRecordID(record As String) As Integer
        Dim output As Integer
        Dim tempRecord() As String
        tempRecord = Split(record, ","c)
        output = CType(tempRecord(0), Integer)
        Return output

    End Function


End Module
