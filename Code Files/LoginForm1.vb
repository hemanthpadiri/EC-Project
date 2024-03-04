
Imports System.Data.SQLite

Public Class LoginForm1
    'Dim int As New CommonClass
    ' validate()
    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    'Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
    '    Me.Close()
    'End Sub
    Public intType As Integer '' 1-Admin/EC Team 2- Voter
    'Public strPhone As String
    'Public strAadhar As String
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'Dim colorDesc As CommonClass
        'colorDesc = New CommonClass()
        'Dim itemCode As Integer = "" 'Integer.Parse(itemCodeTextBox.Text)
        'colorDesc.getValue(itemCode) 'this line triggers an error.
        'itemCode = colorDesc.Validate()

        Dim SQLitecnStr As String = "Data Source=" & Application.StartupPath & "\DB\EC_DB_Sample.db; Integrated Security=true"
        Dim SQLiteConn As New SQLiteConnection
        Dim SQLitecmd As New SQLiteCommand
        Dim SQLiteReader As SQLiteDataReader

        SQLiteConn.ConnectionString = SQLitecnStr
        SQLiteConn.Open()


        Dim VoterId As String
        VoterId = Randomm(2)

        ' create a New SQL command
        SQLitecmd = SQLiteConn.CreateCommand()
        If intType = 1 Then
            SQLitecmd.CommandText = "SELECT OTP,PASSWORD,PHONE,AADHAR from ECLogin where PHONE ='" & UsernameTextBox.Text.Trim & "' OR AADHAR ='" & UsernameTextBox.Text.Trim & "';"  'LIMIT 1
        Else
            SQLitecmd.CommandText = "SELECT OTP,PASSWORD,PHONE,AADHAR from VLogin where PHONE ='" & UsernameTextBox.Text.Trim & "' OR AADHAR ='" & UsernameTextBox.Text.Trim & "';"  'LIMIT 1
        End If
        SQLiteReader = SQLitecmd.ExecuteReader()


        While SQLiteReader.Read()
            If PasswordTextBox.Text.Trim <> SQLiteReader("password").ToString.Trim Then
                lblLogin.Text = "invalid. Please enter valid credentials"
                lblLogin.ForeColor = Color.Red
            Else
                lblLogin.Text = "Success"
                lblLogin.ForeColor = Color.Green
                FrmEMSystem.strPhone = SQLiteReader("phone").ToString.Trim
                FrmEMSystem.strAadhar = SQLiteReader("Aadhar").ToString.Trim

            End If
        End While

        SQLiteReader.Close()
        SQLiteConn.Close()

    End Sub

    Private Sub btnReg_Click(sender As Object, e As EventArgs) Handles btnReg.Click


        Dim SQLitecnStr As String = "Data Source=" & Application.StartupPath & "\DB\EC_DB_Sample.db; Integrated Security=true"
        Dim SQLiteConn As New SQLiteConnection
        Dim SQLitecmd As New SQLiteCommand
        Dim SQLiteReader As SQLiteDataReader

        SQLiteConn.ConnectionString = SQLitecnStr
        SQLiteConn.Open()


        Dim VoterId As String
        VoterId = Randomm(1)

        ' create a New SQL command
        SQLitecmd = SQLiteConn.CreateCommand()
        '// Let the SQLiteCommand object know our SQL-Query
        'SQLitecmd.CommandText = "CREATE TABLE tbl_regVoter (id integer primary key, text varchar(100));"
        'SQLitecmd.ExecuteNonQuery()
        '// Lets insert something into our New table
        If intType = 1 Then
            SQLitecmd.CommandText = "INSERT INTO ECCOMM (EC_ID,name,Age,ACTIVE,phone,Aadhar) VALUES ('" & VoterId & "','" & txtName.Text.Trim & "','" & txtAge.Text.Trim & "',1,'" & txtPhone.Text.Trim & "','" & txtAadhar.Text.Trim & "');"
        Else
            SQLitecmd.CommandText = "INSERT INTO Voter (VoterId,name,Age,Sex,Const_Code,State,Approv_By,Approve_Status,Approve_dt,phone,Aadhar) VALUES ('" & VoterId & "','" & txtName.Text.Trim & "','" & txtAge.Text.Trim & "','" & ComboBox1.Text & "','" & txtConst.Text.Trim & "','" & txtState.Text.Trim & "', 'ADMIN','0','20240221','" & txtPhone.Text.Trim & "','" & txtAadhar.Text.Trim & "');"
        End If
        SQLitecmd.ExecuteNonQuery()

        Panel2.Visible = True

    End Sub
    Public Function Randomm(I As Integer) As String
        Dim Generator As System.Random = New System.Random()
        If I = 1 Then
            Return Generator.Next(222222222, 999999999)
        Else
            Return Generator.Next(22222, 99999)
        End If
    End Function

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel2.Visible = False
        If intType = 1 Then
            txtheading.Text = "EC/ADMIN LOGIN"
        Else
            txtheading.Text = "VOTER LOGIN"
        End If

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click


        Dim SQLitecnStr As String = "Data Source=" & Application.StartupPath & "\DB\EC_DB_Sample.db; Integrated Security=true"
        Dim SQLiteConn As New SQLiteConnection
        Dim SQLitecmd As New SQLiteCommand
        Dim SQLiteReader As SQLiteDataReader

        SQLiteConn.ConnectionString = SQLitecnStr
        SQLiteConn.Open()

        SQLitecmd = SQLiteConn.CreateCommand()
        If intType = 1 Then
            SQLitecmd.CommandText = "INSERT INTO ECLogin (PHONE,AADHAR,PASSWORD) VALUES ('" & txtPhone.Text.Trim & "','" & txtAadhar.Text.Trim & "','" & txtPaswd2.Text.Trim & "');"
        Else
            SQLitecmd.CommandText = "INSERT INTO VLogin (PHONE,AADHAR,PASSWORD) VALUES ('" & txtPhone.Text.Trim & "','" & txtAadhar.Text.Trim & "','" & txtPaswd2.Text.Trim & "');"
        End If

        SQLitecmd.ExecuteNonQuery()

    End Sub

    Private Sub LoginForm1_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        'Dim frm1 As New FrmEMSystem()
        'frm1.Show()
        FrmEMSystem.Show()
    End Sub
End Class
