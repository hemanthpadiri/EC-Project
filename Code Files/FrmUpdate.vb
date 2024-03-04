
Imports System.Data.SQLite
Imports System.IO
Imports System.Data
Public Class FrmUpdate
    Public strUserPhn As String
    Public strUserAadhar As String
    Private Sub FrmUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MessageBox.Show(strUserAadhar)
        'MessageBox.Show(strUserPhn)
        Dim Qry1 As String
        Qry1 = ""

        Dim SQLitecnStr As String = "Data Source=" & Application.StartupPath & "\DB\EC_DB_Sample.db; Integrated Security=true"

        Qry1 = "SELECT * from Voter where PHONE = '" & strUserPhn & "' OR AADHAR = '" & strUserPhn & "'"


        Dim myAdapter As SQLiteDataAdapter = New SQLiteDataAdapter(Qry1, SQLitecnStr)
        myAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey
        Dim OrdDs As DataSet = New DataSet
        myAdapter.Fill(OrdDs)

        'DataGridView1.Rows.Add(i + 1, OrdDs.Tables(0).Rows(i).Item("Seq_no").ToString.Trim, OrdDs.Tables(0).Rows(i).Item("VoterId").ToString.Trim, OrdDs.Tables(0).Rows(i).Item("name").ToString.Trim, OrdDs.Tables(0).Rows(i).Item("Age").ToString.Trim, OrdDs.Tables(0).Rows(i).Item("Sex").ToString.Trim, OrdDs.Tables(0).Rows(i).Item("Const_Code").ToString.Trim, OrdDs.Tables(0).Rows(i).Item("State").ToString.Trim, "", OrdDs.Tables(0).Rows(i).Item("Approv_By").ToString.Trim, OrdDs.Tables(0).Rows(i).Item("Approve_Status").ToString.Trim, OrdDs.Tables(0).Rows(i).Item("Approve_dt").ToString.Trim, OrdDs.Tables(0).Rows(i).Item("phone").ToString.Trim, OrdDs.Tables(0).Rows(i).Item("Aadhar").ToString.Trim)

        txtname.Text = OrdDs.Tables(0).Rows(0).Item("name").ToString.Trim
        txtAge.Text = OrdDs.Tables(0).Rows(0).Item("Age").ToString.Trim
        txtSex.Text = OrdDs.Tables(0).Rows(0).Item("Sex").ToString.Trim
        txtConst.Text = OrdDs.Tables(0).Rows(0).Item("Const_Code").ToString.Trim
        txtAppBy.Text = OrdDs.Tables(0).Rows(0).Item("Approv_By").ToString.Trim
        txtstate.Text = OrdDs.Tables(0).Rows(0).Item("state").ToString.Trim
        txtphone.Text = OrdDs.Tables(0).Rows(0).Item("phone").ToString.Trim
        txtAadhar.Text = OrdDs.Tables(0).Rows(0).Item("aadhar").ToString.Trim

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub btnApprove_Click(sender As Object, e As EventArgs) Handles btnApprove.Click

        Dim SQLitecnStr As String = "Data Source=" & Application.StartupPath & "\DB\EC_DB_Sample.db; Integrated Security=true"
        Dim SQLiteConn As New SQLiteConnection
        Dim SQLitecmd As New SQLiteCommand
        Dim SQLiteReader As SQLiteDataReader
        SQLiteConn.ConnectionString = SQLitecnStr
        SQLiteConn.Open()

        SQLitecmd.Connection = SQLiteConn
        SQLitecmd.CommandText = "UPDATE VOTER  SET Approve_status=1 WHERE PHONE = '" & strUserPhn & "' OR AADHAR = '" & strUserPhn & "';"
        SQLitecmd.ExecuteNonQuery()

        SQLiteConn.Close()
    End Sub

    Private Sub btnRej_Click(sender As Object, e As EventArgs) Handles btnRej.Click
        Dim SQLitecnStr As String = "Data Source=" & Application.StartupPath & "\DB\EC_DB_Sample.db; Integrated Security=true"
        Dim SQLiteConn As New SQLiteConnection
        Dim SQLitecmd As New SQLiteCommand
        Dim SQLiteReader As SQLiteDataReader
        SQLiteConn.ConnectionString = SQLitecnStr
        SQLiteConn.Open()

        SQLitecmd.Connection = SQLiteConn
        SQLitecmd.CommandText = "UPDATE VOTER  SET Approve_status=2 WHERE PHONE = '" & strUserPhn & "' OR AADHAR = '" & strUserPhn & "';"
        SQLitecmd.ExecuteNonQuery()

        SQLiteConn.Close()
    End Sub
End Class