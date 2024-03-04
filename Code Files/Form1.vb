Imports System.Data.SQLite
Imports System.IO
Imports System.Data

Public Class FrmEMSystem

    Public strPhone As String
    Public strAadhar As String
    Friend sharevalue As String = "Boo"
    Private Sub FrmEMSystem_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblheading.Text = "ELECTION COMMISSION OF INDIA - PARLIMENT ELECTIONS - 2024"
        tabHome.SelectedIndex = 2
        'tabHome.TabPages(0).Visible = False
        'tabHome.TabPages(2).Hide()
        'tabHome.TabPages(1).Hide()
        'tabHome.TabPages(3).Hide()
        'tabHome.TabPages(1).Enabled = False
        'tabHome.TabPages(2).Enabled = False
        'tabHome.TabPages(3).Enabled = False

        'Dim SQLitecnStr As String = "Data Source=" & Application.StartupPath & "\DB\EC_DB_Sample.db; Integrated Security=true"
        'Dim SQLiteConn As New SQLiteConnection
        'Dim SQLitecmd As New SQLiteCommand
        'Dim SQLiteReader As SQLiteDataReader

        'SQLiteConn.ConnectionString = SQLitecnStr
        'SQLiteConn.Open()

        'SQLitecmd.Connection = SQLiteConn
        'SQLitecmd.CommandText = "SELECT * from demo;"  'LIMIT 1
        'SQLiteReader = SQLitecmd.ExecuteReader()

        'While SQLiteReader.Read()
        '    'Dim Lstv As New ListViewItem
        '    'Lstv.Text = SQLiteReader("id").ToString
        '    'Lstv.Text = SQLiteReader("text").ToString
        '    'Lstv.SubItems.Add(SQLiteReader("text").ToString)
        '    ''Lstv.SubItems.Add(SQLiteReader("MyMono").ToString)
        '    'MyLstView.Items.Add(Lstv)
        'End While
        'SQLiteReader.Close()
        'SQLiteConn.Close()

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        '' ADMIN / EC COMMISIONERS
        Dim LF As New LoginForm1()
        LF.intType = 1
        LF.Show()
        Me.Hide()
        Call LoadApprovals(1)
        tabHome.SelectedIndex = 0
        'tabHome.SelectedTab = tbFindVoters
    End Sub
    Private Sub Showtab(i As Integer)

        'tabHome.TabPages(1).Hide()
        If i = 1 Then
            'tabHome.TabPages.Remove(tabResults)
            'tabHome.TabPages.Remove(tabResults)
            'tabHome.TabPages.Remove(tabResults)
        ElseIf i = 2 Then
            'tabHome.TabPages.Remove(tabResults)
            'tabHome.TabPages.Remove(tabResults)
            'tabHome.TabPages.Remove(tabResults)
        End If
    End Sub
    Private Sub btnRegVoter_Click(sender As Object, e As EventArgs) Handles btnRegVoter.Click
        Dim LF As New LoginForm1()
        LF.intType = 2
        LF.Show()
        Me.Hide()

        'strPhone = LF.strPhone
        'strAadhar = LF.strAadhar
        tabHome.SelectedIndex = 1
    End Sub
    Private Sub LoadApprovals(inttemp As Integer)
        'Dim SQLitecnStr As String = "Data Source=" & Application.StartupPath & "\DB\EC_DB_Sample.db; Integrated Security=true"
        ''Dim OrdDs As New DataSet, OrdDa As New SqlDataAdapter, OrdCon As New SqlConnection(ConnectionStringGlobal), OrdStr As String
        Dim Qry1 As String
        Qry1 = ""

        Dim SQLitecnStr As String = "Data Source=" & Application.StartupPath & "\DB\EC_DB_Sample.db; Integrated Security=true"
        'Dim SQLiteConn As New SQLiteConnection
        'Dim SQLitecmd As New SQLiteCommand
        'Dim SQLiteReader As SQLiteDataReader
        'Dim SQLiteAdapter As SQLiteDataAdapter
        'Dim ds As New DataSet

        'SQLiteConn.ConnectionString = SQLitecnStr
        'SQLiteConn.Open()

        'SQLitecmd.Connection = SQLiteConn
        If inttemp = 1 Then
            Qry1 = "SELECT * from Voter where Approve_status = 0"
        ElseIf inttemp = 2 Then
            Qry1 = "SELECT * from Voter where Approve_status = 1"
        Else
            Qry1 = "SELECT * from Voter where Approve_status >=2"
        End If

        Dim myAdapter As SQLiteDataAdapter = New SQLiteDataAdapter(Qry1, SQLitecnStr)
        myAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey
        Dim OrdDs As DataSet = New DataSet
        myAdapter.Fill(OrdDs)
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.Rows.Clear()

        DataGridView1.Columns(0).Width = 50
        DataGridView1.Columns(1).Width = 50
        DataGridView1.Columns(2).Width = 90
        DataGridView1.Columns(3).Width = 90
        DataGridView1.Columns(4).Width = 50
        DataGridView1.Columns(5).Width = 50
        DataGridView1.Columns(6).Width = 70
        DataGridView1.Columns(7).Width = 50
        DataGridView1.Columns(8).Width = 80
        DataGridView1.Columns(9).Width = 50
        For i As Integer = 0 To OrdDs.Tables(0).Rows.Count - 1
            DataGridView1.Rows.Add(i + 1, OrdDs.Tables(0).Rows(i).Item("Seq_no").ToString.Trim, OrdDs.Tables(0).Rows(i).Item("VoterId").ToString.Trim, OrdDs.Tables(0).Rows(i).Item("name").ToString.Trim, OrdDs.Tables(0).Rows(i).Item("Age").ToString.Trim, OrdDs.Tables(0).Rows(i).Item("Sex").ToString.Trim, OrdDs.Tables(0).Rows(i).Item("Const_Code").ToString.Trim, OrdDs.Tables(0).Rows(i).Item("State").ToString.Trim, "", OrdDs.Tables(0).Rows(i).Item("Approv_By").ToString.Trim, OrdDs.Tables(0).Rows(i).Item("Approve_Status").ToString.Trim, OrdDs.Tables(0).Rows(i).Item("Approve_dt").ToString.Trim, OrdDs.Tables(0).Rows(i).Item("phone").ToString.Trim, OrdDs.Tables(0).Rows(i).Item("Aadhar").ToString.Trim)
            'DataGridView1.Rows.Add(OrdDs.Tables(0).Rows(i).ItemArray())
        Next

        'DataGridView1.DataSource = OrdDs
    End Sub
    Private Sub LoadApprovals2()
        'Dim SQLitecnStr As String = "Data Source=" & Application.StartupPath & "\DB\EC_DB_Sample.db; Integrated Security=true"
        ''Dim OrdDs As New DataSet, OrdDa As New SqlDataAdapter, OrdCon As New SqlConnection(ConnectionStringGlobal), OrdStr As String
        Dim Qry1 As String
        Qry1 = ""

        Dim SQLitecnStr As String = "Data Source=" & Application.StartupPath & "\DB\EC_DB_Sample.db; Integrated Security=true"
        Dim SQLiteConn As New SQLiteConnection
        Dim SQLitecmd As New SQLiteCommand
        Dim SQLiteReader As SQLiteDataReader
        Dim SQLiteAdapter As SQLiteDataAdapter
        Dim ds As New DataSet

        SQLiteConn.ConnectionString = SQLitecnStr
        SQLiteConn.Open()

        SQLitecmd.Connection = SQLiteConn

        SQLitecmd.CommandText = "SELECT * from Voter where approve_status =0 ;"
        'OrdDa.SelectCommand.CommandTimeout = 100000
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.Rows.Clear()
        DataGridView1.AllowUserToAddRows = False
        SQLiteReader = SQLitecmd.ExecuteReader()
        DataGridView1.DataSource = SQLiteReader
        'DataGridView1.data()

        'If SQLiteAdapter.Fill(ds) > 0 Then
        '    For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
        '        DataGridView1.Rows.Add(i + 1, ds.Tables(0).Rows(i).Item("PO Number").ToString.Trim, ds.Tables(0).Rows(i).Item("PODate").ToString.Trim)
        '    Next

        'End If


    End Sub

    Private Sub LoadApprovals1()
        Dim SQLitecnStr As String = "Data Source=" & Application.StartupPath & "\DB\EC_DB_Sample.db; Integrated Security=true"
        Dim SQLiteConn As New SQLiteConnection
        Dim SQLitecmd As New SQLiteCommand
        Dim SQLiteReader As SQLiteDataReader
        Dim SQLiteAdapter As SQLiteDataAdapter
        Dim ds As New DataSet

        SQLiteConn.ConnectionString = SQLitecnStr
        SQLiteConn.Open()

        SQLitecmd.Connection = SQLiteConn
        SQLitecmd.CommandText = "SELECT * from Voter where approve_status =0 ;"  'LIMIT 1
        SQLiteReader = SQLitecmd.ExecuteReader()
        DataGridView1.DataSource = SQLiteReader
        'While SQLiteReader.Read()
        '    'Dim Lstv As New ListViewItem
        '    'Lstv.Text = SQLiteReader("id").ToString
        '    'Lstv.Text = SQLiteReader("text").ToString
        '    'Lstv.SubItems.Add(SQLiteReader("text").ToString)
        '    ''Lstv.SubItems.Add(SQLiteReader("MyMono").ToString)
        '    'MyLstView.Items.Add(Lstv)
        'End While

        'SQLitecmd.CommandText = "SELECT * FROM VW_DIFFERENCE_IN_LOCSTDCOST_ITEMSTD"
        'SQLiteAdapter.SelectCommand = SQLitecmd.CommandText
        'SQLiteAdapter.Fill(ds)
        'DataGridView1.DataSource = SQLiteReader


        'SQLiteDataAdapter(SQLitecmd.CommandText, SQLitecmd.Connection)
        'SQLiteAdapter.Fill(ds)
        'DataGridView1.DataSource = ds.Tables[0].DefaultView


        'Using SQLconnect As New SQLiteConnection("Data Source=" & Application.StartupPath & "\DB\EC_DB_Sample.db; Integrated Security=true"),
        '  SQLcommand As New SQLiteCommand("SELECT * from Voter where approve_status =0 ;", SQLconnect)

        '    SQLconnect.Open()
        '    Using SQLreader As SQLiteDataReader = SQLcommand.ExecuteReader()
        '        DataGridView1.DataSource = SQLreader.Read
        '    End Using
        'End Using

        SQLiteReader.Close()
        SQLiteConn.Close()
    End Sub

    'Private Sub rdAprv_CheckedChanged(sender As Object, e As EventArgs)
    '    LoadApprovals(2)
    'End Sub

    'Private Sub rdPend_CheckedChanged(sender As Object, e As EventArgs)
    '    LoadApprovals(1)
    'End Sub

    'Private Sub rdRej_CheckedChanged(sender As Object, e As EventArgs)
    '    LoadApprovals(3)
    'End Sub




    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs)
        'Dim Row = DataGridView1.CurrentRow
        'strPONumber = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells("PONUMBER").Value.ToString
        'If Row IsNot Nothing Then
        '    Dim Clmn1 = Row.Cells("PONUMBER").ColumnIndex
        '    If Clmn1 = DataGridView1.CurrentCell.ColumnIndex Then

        '        If strPONumber.TrimEnd <> "" Then

        '            'Call OpenPOCopy(strPONumber.Trim)

        '        End If
        '    End If
        'End If


        Dim UP As New FrmUpdate()
        UP.strUserPhn = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells("PHONE").Value.ToString
        UP.strUserAadhar = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells("AADHAR").Value.ToString
        UP.Show()
    End Sub

    Private Sub btnFindVoter_Click(sender As Object, e As EventArgs) Handles btnFindVoter.Click

        tabHome.SelectedIndex = 1
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub btnNews_Click(sender As Object, e As EventArgs) Handles btnNews.Click

        tabHome.SelectedIndex = 2
    End Sub

    Private Sub btnResults_Click(sender As Object, e As EventArgs) Handles btnResults.Click

        tabHome.SelectedIndex = 3
    End Sub



    Private Sub rdRej_CheckedChanged(sender As Object, e As EventArgs) Handles rdRej.CheckedChanged
        LoadApprovals(3)
    End Sub

    Private Sub rdPend_CheckedChanged(sender As Object, e As EventArgs) Handles rdPend.CheckedChanged
        LoadApprovals(1)
    End Sub

    Private Sub rdAprv_CheckedChanged(sender As Object, e As EventArgs) Handles rdAprv.CheckedChanged

        LoadApprovals(2)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        If cmbType.Text = "Voters" Then
            LoadVoters(1)
        ElseIf cmbType.Text = "Political Party" Then
            LoadVoters(2)
        ElseIf cmbType.Text = "Party Symbols" Then
            LoadVoters(3)
        ElseIf cmbType.Text = "Constituency" Then
            LoadVoters(4)
        End If
    End Sub



    Private Sub LoadVoters(intType As Integer)
        Dim Qry1 As String
        Qry1 = ""

        Dim SQLitecnStr As String = "Data Source=" & Application.StartupPath & "\DB\EC_DB_Sample.db; Integrated Security=true"
        If intType = 1 Then
            Qry1 = "SELECT * from Voter where "
            If cmbFilter.SelectedIndex = 0 Then
                Qry1 &= " VoterId like '%"
            ElseIf cmbFilter.SelectedIndex = 1 Then
                Qry1 &= " Const_Code like '%"
            ElseIf cmbFilter.SelectedIndex = 2 Then
                Qry1 &= " phone like '%"
            ElseIf cmbFilter.SelectedIndex = 3 Then
                Qry1 &= " aadhar like '%"
            ElseIf cmbFilter.SelectedIndex = 4 Then
                Qry1 &= " name like '%"
            Else
                Qry1 &= " name like '%"
            End If
            Qry1 &= TextBox1.Text.Trim & "%'"
        ElseIf intType = 2 Then
            Qry1 = "SELECT * from partyMaster where "
            Qry1 &= " name like '%"
            Qry1 &= TextBox1.Text.Trim & "%'"

        ElseIf intType = 3 Then
            Qry1 = "SELECT * from partySymbol where "
            Qry1 &= " name like '%"
            Qry1 &= TextBox1.Text.Trim & "%'"
        ElseIf intType = 4 Then
            Qry1 = "SELECT * from Const where "
            Qry1 &= " Constituency like '%"
            Qry1 &= TextBox1.Text.Trim & "%'"
        End If

        Dim myAdapter As SQLiteDataAdapter = New SQLiteDataAdapter(Qry1, SQLitecnStr)
        myAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey
        Dim OrdDs As DataSet = New DataSet
        myAdapter.Fill(OrdDs)
        DataGridView2.AllowUserToAddRows = False
        DataGridView2.Rows.Clear()
        'DataGridView2.Columns(0).Width = 50
        'DataGridView2.Columns(1).Width = 50
        'DataGridView2.Columns(2).Width = 90
        For i As Integer = 0 To OrdDs.Tables(0).Rows.Count - 1

            If intType = 1 Then
                DataGridView2.Rows.Add(i + 1, OrdDs.Tables(0).Rows(i).Item("VoterId").ToString.Trim, OrdDs.Tables(0).Rows(i).Item("name").ToString.Trim, OrdDs.Tables(0).Rows(i).Item("phone").ToString.Trim, OrdDs.Tables(0).Rows(i).Item("Aadhar").ToString.Trim, OrdDs.Tables(0).Rows(i).Item("Const_Code").ToString.Trim)
            ElseIf intType = 2 Then
                DataGridView2.Rows.Add(i + 1, OrdDs.Tables(0).Rows(i).Item("party_id").ToString.Trim, OrdDs.Tables(0).Rows(i).Item("name").ToString.Trim, OrdDs.Tables(0).Rows(i).Item("symbol").ToString.Trim, OrdDs.Tables(0).Rows(i).Item("active").ToString.Trim, OrdDs.Tables(0).Rows(i).Item("president_").ToString.Trim)
            ElseIf intType = 3 Then
                DataGridView2.Rows.Add(i + 1, OrdDs.Tables(0).Rows(i).Item("symbolid").ToString.Trim, OrdDs.Tables(0).Rows(i).Item("symbol").ToString.Trim, OrdDs.Tables(0).Rows(i).Item("Active").ToString.Trim, OrdDs.Tables(0).Rows(i).Item("alloted").ToString.Trim, OrdDs.Tables(0).Rows(i).Item("party_id").ToString.Trim, OrdDs.Tables(0).Rows(i).Item("name").ToString.Trim, OrdDs.Tables(0).Rows(i).Item("president_").ToString.Trim)
            ElseIf intType = 4 Then
                DataGridView2.Rows.Add(i + 1, OrdDs.Tables(0).Rows(i).Item("const_code").ToString.Trim, OrdDs.Tables(0).Rows(i).Item("constituency").ToString.Trim, OrdDs.Tables(0).Rows(i).Item("state").ToString.Trim)
            End If


        Next
    End Sub


    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        LoadResults()
    End Sub

    Private Sub LoadResults()
        Dim Qry1 As String
        Qry1 = ""

        Dim SQLitecnStr As String = "Data Source=" & Application.StartupPath & "\DB\EC_DB_Sample.db; Integrated Security=true"

        Qry1 = "SELECT * from results where "
        If cmbResults.SelectedIndex = 0 Then
            Qry1 &= " Const_Code like '%"
        ElseIf cmbResults.SelectedIndex = 1 Then
            Qry1 &= " name like '%"
        ElseIf cmbResults.SelectedIndex = 2 Then
            Qry1 &= " winner like '%"
        ElseIf cmbResults.SelectedIndex = 3 Then
            Qry1 &= " party like '%"
        Else
            Qry1 &= " name like '%"
        End If
        Qry1 &= TextBox2.Text.Trim & "%'"

        Dim myAdapter As SQLiteDataAdapter = New SQLiteDataAdapter(Qry1, SQLitecnStr)
        myAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey
        Dim OrdDs As DataSet = New DataSet
        myAdapter.Fill(OrdDs)
        DataGridView3.AllowUserToAddRows = False
        DataGridView3.Rows.Clear()
        'DataGridView2.Columns(0).Width = 50
        'DataGridView2.Columns(1).Width = 50
        'DataGridView2.Columns(2).Width = 90
        For i As Integer = 0 To OrdDs.Tables(0).Rows.Count - 1
            DataGridView3.Rows.Add(i + 1, OrdDs.Tables(0).Rows(i).Item("Const_Code").ToString.Trim, OrdDs.Tables(0).Rows(i).Item("name").ToString.Trim, OrdDs.Tables(0).Rows(i).Item("winner").ToString.Trim, OrdDs.Tables(0).Rows(i).Item("party").ToString.Trim, OrdDs.Tables(0).Rows(i).Item("noofvotes").ToString.Trim, OrdDs.Tables(0).Rows(i).Item("majority").ToString.Trim)

        Next
    End Sub

    Private Sub cmbType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbType.SelectedIndexChanged
        If cmbType.Text <> "Voters" Then
            cmbFilter.Enabled = False
        Else
            cmbFilter.Enabled = True
        End If

        If cmbType.Text = "Voters" Then
            DataGridView2.Columns(0).HeaderText = "S.No"
            DataGridView2.Columns(1).HeaderText = "Voter ID"
            DataGridView2.Columns(2).HeaderText = "Name"
            DataGridView2.Columns(3).HeaderText = "Phone"
            DataGridView2.Columns(4).HeaderText = "Aadhar No"
            DataGridView2.Columns(5).HeaderText = "Constituency"
            DataGridView2.Columns(6).HeaderText = ""
            DataGridView2.Columns(7).HeaderText = ""
            LoadVoters(1)

        ElseIf cmbType.Text = "Political Party" Then
            DataGridView2.Columns(0).HeaderText = "S.No"
            DataGridView2.Columns(1).HeaderText = "Party ID"
            DataGridView2.Columns(2).HeaderText = "Name"
            DataGridView2.Columns(3).HeaderText = "Symbol"
            DataGridView2.Columns(4).HeaderText = "Active"
            DataGridView2.Columns(5).HeaderText = "President"
            DataGridView2.Columns(6).HeaderText = ""
            DataGridView2.Columns(7).HeaderText = ""
            LoadVoters(2)
        ElseIf cmbType.Text = "Party Symbols" Then
            DataGridView2.Columns(0).HeaderText = "S.No"
            DataGridView2.Columns(1).HeaderText = "Symbol ID"
            DataGridView2.Columns(2).HeaderText = "Symbol"
            DataGridView2.Columns(3).HeaderText = "Active"
            DataGridView2.Columns(4).HeaderText = "Alloted"
            DataGridView2.Columns(5).HeaderText = "Party"
            DataGridView2.Columns(6).HeaderText = "Name"
            DataGridView2.Columns(7).HeaderText = "President"
            LoadVoters(3)
        ElseIf cmbType.Text = "Constituency" Then
            DataGridView2.Columns(0).HeaderText = "S.No"
            DataGridView2.Columns(1).HeaderText = "Const_code"
            DataGridView2.Columns(2).HeaderText = "constituency"
            DataGridView2.Columns(3).HeaderText = "state"
            DataGridView2.Columns(4).HeaderText = ""
            DataGridView2.Columns(5).HeaderText = ""
            DataGridView2.Columns(6).HeaderText = ""
            DataGridView2.Columns(7).HeaderText = ""
            LoadVoters(4)
        End If

    End Sub

    Private Sub cmbResults_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbResults.SelectedIndexChanged
        LoadResults()
    End Sub

    Private Sub btnVote_Click(sender As Object, e As EventArgs) Handles btnVote.Click
        Dim LF As New frmEVM()

        LF.strPhone = strPhone
        LF.strAadhar = strAadhar
        LF.Show()
        Me.Hide()
    End Sub
End Class
