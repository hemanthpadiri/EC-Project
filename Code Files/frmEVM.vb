

Imports System.Data.SQLite
Public Class frmEVM

    Public strPhone As String
    Public strAadhar As String
    Public strVotedfor As String
    Dim votedforName As String = ""

    Private Sub frmEVM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        strPhone = FrmEMSystem.strPhone
        strAadhar = FrmEMSystem.strAadhar

        getDetails()
        LoadEVM()
    End Sub

    Public Sub LoadEVM()

        Dim SQLitecnStr As String = "Data Source=" & Application.StartupPath & "\DB\EC_DB_Sample.db; Integrated Security=true"
        Dim SQLiteConn As New SQLiteConnection
        Dim SQLitecmd As New SQLiteCommand
        Dim SQLiteReader As SQLiteDataReader
        Dim i As Integer

        SQLiteConn.ConnectionString = SQLitecnStr
        SQLiteConn.Open()
        ' create a New SQL command
        SQLitecmd = SQLiteConn.CreateCommand()
        For Each tb In TableLayoutPanel1.Controls.OfType(Of Button)
            tb.Visible = False
        Next
        'Select Case A.Name,A.Party,B.party_id,B.Name,B.Symbolid,B.Symbol FROM MPCand A  Left OUTER JOIN partySymbol B On A.Party=B.Name WHERE constid = 5 And B.party_id NOTNULL
        SQLitecmd.CommandText = "Select A.CandId,A.Name,A.Party,B.party_id,B.Name,B.Symbolid,B.Symbol FROM MPCand A  Left OUTER JOIN partySymbol B ON A.Party=B.Name WHERE constid = '" & lblConstituency.Text.Trim & "' And B.party_id NOTNULL  LIMIT 10"  'LIMIT 1
        SQLiteReader = SQLitecmd.ExecuteReader()
        i = 1
        While SQLiteReader.Read()

            For Each cntrl As Control In TableLayoutPanel1.Controls
                If cntrl.Name.EndsWith("btnCand" + i.ToString) Then
                    cntrl.Visible = True
                    cntrl.Text = SQLiteReader("name").ToString.Trim
                    cntrl.Tag = SQLiteReader("CandId").ToString.Trim
                End If

                If cntrl.Name.EndsWith("btnSym" + i.ToString) Then
                    cntrl.Visible = True
                    cntrl.Text = SQLiteReader("Symbol").ToString.Trim
                End If

                If cntrl.Name.EndsWith("btnAlt" + i.ToString) Then
                    cntrl.Visible = True
                    cntrl.BackColor = Color.Gray
                End If

                If cntrl.Name.EndsWith("btnV" + i.ToString) Then
                    cntrl.Visible = True
                End If

            Next
            i += 1
        End While

        SQLiteReader.Close()
        SQLiteConn.Close()


    End Sub

    Public Sub getDetails()


        Dim SQLitecnStr As String = "Data Source=" & Application.StartupPath & "\DB\EC_DB_Sample.db; Integrated Security=true"
        Dim SQLiteConn As New SQLiteConnection
        Dim SQLitecmd As New SQLiteCommand
        Dim SQLiteReader As SQLiteDataReader

        SQLiteConn.ConnectionString = SQLitecnStr
        SQLiteConn.Open()
        Dim VoterId As String

        ' create a New SQL command
        SQLitecmd = SQLiteConn.CreateCommand()

        SQLitecmd.CommandText = "SELECT Const_Code,voterid,name,age from voter where PHONE ='" & strPhone.Trim & "' OR AADHAR ='" & strAadhar.Trim & "';"  'LIMIT 1

        SQLiteReader = SQLitecmd.ExecuteReader()


        While SQLiteReader.Read()

            lblVoterName.Text = SQLiteReader("name").ToString.Trim
            lblAge.Text = SQLiteReader("Age").ToString.Trim
            lblConstituency.Text = SQLiteReader("COnst_code").ToString.Trim
            lblVoterID.Text = SQLiteReader("voterid").ToString.Trim

        End While

        SQLiteReader.Close()
        SQLiteConn.Close()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        Dim SQLitecnStr As String = "Data Source=" & Application.StartupPath & "\DB\EC_DB_Sample.db; Integrated Security=true"
        Dim SQLiteConn As New SQLiteConnection
        Dim SQLitecmd As New SQLiteCommand
        Dim SQLiteReader As SQLiteDataReader

        SQLiteConn.ConnectionString = SQLitecnStr
        SQLiteConn.Open()
        SQLitecmd = SQLiteConn.CreateCommand()

        SQLitecmd.CommandText = "SELECT candid,name from MPCand where candid ='" & strVotedfor.Trim & "';"  'LIMIT 1

        SQLiteReader = SQLitecmd.ExecuteReader()


        While SQLiteReader.Read()

            votedforName = SQLiteReader("name").ToString.Trim

        End While

        SQLiteReader.Close()
        SQLiteConn.Close()

        Dim result As DialogResult = MessageBox.Show("You voted for ID :" & strVotedfor.Trim & " Candidate : " & votedforName.Trim & " , You really want to proceed..?", "Vote Summary", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Cancel Then
            'MessageBox.Show("Cancel pressed")
        ElseIf result = DialogResult.No Then
            'MessageBox.Show("No pressed")
        ElseIf result = DialogResult.Yes Then
            'MessageBox.Show("Yes pressed")
            RecordVote()
        End If

    End Sub
    Public Sub RecordVote()
        Dim SQLitecnStr As String = "Data Source=" & Application.StartupPath & "\DB\EC_DB_Sample.db; Integrated Security=true"
        Dim SQLiteConn As New SQLiteConnection
        Dim SQLitecmd As New SQLiteCommand
        Dim SQLiteReader As SQLiteDataReader

        SQLiteConn.ConnectionString = SQLitecnStr
        SQLiteConn.Open()

        Dim seqNo, seqNoevm As String
        seqNo = Randomm(2)
        seqNoevm = Randomm(1)
        ' create a New SQL command
        SQLitecmd = SQLiteConn.CreateCommand()
        SQLitecmd.CommandText = "INSERT INTO VoteLog (voteseq,constcode,candid,candname,validvote,date,voterid,phone,evmid) VALUES ('" & seqNo & "','" & lblConstituency.Text.Trim & "','" & strVotedfor.Trim & "','" & votedforName.Trim & "','1','20240101','" & lblVoterID.Text.Trim & "','92374238723','" & seqNoevm & "');"

        SQLitecmd.ExecuteNonQuery()
    End Sub
    Public Function Randomm(I As Integer) As String
        Dim Generator As System.Random = New System.Random()
        If I = 1 Then
            Return Generator.Next(222222222, 999999999)
        Else
            Return Generator.Next(22222, 99999)
        End If
    End Function
    Public Sub ChangeClr(i As Integer)
        For Each cntrl As Control In TableLayoutPanel1.Controls
            If cntrl.Name.EndsWith("btnAlt" + i.ToString) Then
                cntrl.BackColor = Color.Red
            ElseIf cntrl.Name.StartsWith("btnAlt") Then
                cntrl.BackColor = Color.Gray
            End If
        Next
    End Sub
    Private Sub btnV1_Click(sender As Object, e As EventArgs) Handles btnV1.Click
        strVotedfor = btnCand1.Tag.ToString.Trim
        ChangeClr(1)
    End Sub

    Private Sub btnV2_Click(sender As Object, e As EventArgs) Handles btnV2.Click
        strVotedfor = btnCand2.Tag.ToString.Trim
        ChangeClr(2)
    End Sub

    Private Sub btnV3_Click(sender As Object, e As EventArgs) Handles btnV3.Click
        strVotedfor = btnCand3.Tag.ToString.Trim
        ChangeClr(3)
    End Sub

    Private Sub btnV4_Click(sender As Object, e As EventArgs) Handles btnV4.Click
        strVotedfor = btnCand4.Tag.ToString.Trim
        ChangeClr(4)
    End Sub

    Private Sub btnV5_Click(sender As Object, e As EventArgs) Handles btnV5.Click
        strVotedfor = btnCand5.Tag.ToString.Trim
        ChangeClr(5)
    End Sub

    Private Sub btnV6_Click(sender As Object, e As EventArgs) Handles btnV6.Click
        strVotedfor = btnCand6.Tag.ToString.Trim
        ChangeClr(6)
    End Sub

    Private Sub btnV7_Click(sender As Object, e As EventArgs) Handles btnV7.Click
        strVotedfor = btnCand7.Tag.ToString.Trim
        ChangeClr(7)
    End Sub

    Private Sub btnV8_Click(sender As Object, e As EventArgs) Handles btnV8.Click
        strVotedfor = btnCand8.Tag.ToString.Trim
        ChangeClr(8)
    End Sub

    Private Sub btnV9_Click(sender As Object, e As EventArgs) Handles btnV9.Click
        strVotedfor = btnCand9.Tag.ToString.Trim
        ChangeClr(9)
    End Sub

    Private Sub btnV10_Click(sender As Object, e As EventArgs) Handles btnV10.Click
        strVotedfor = btnCand10.Tag.ToString.Trim
        ChangeClr(10)
    End Sub

    Private Sub frmEVM_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FrmEMSystem.Show()
    End Sub
End Class