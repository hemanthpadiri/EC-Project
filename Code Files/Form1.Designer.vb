<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmEMSystem
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEMSystem))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblheading = New System.Windows.Forms.Label()
        Me.btnRegVoter = New System.Windows.Forms.Button()
        Me.btnFindVoter = New System.Windows.Forms.Button()
        Me.btnNews = New System.Windows.Forms.Button()
        Me.btnResults = New System.Windows.Forms.Button()
        Me.btnVote = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.tabHome = New System.Windows.Forms.TabControl()
        Me.tbRegVoters = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.sno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Seq_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Voterid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Age = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sex = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Const_Code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.State = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Approv_By = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Approve_Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Approve_dt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.phone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Aadhar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rdRej = New System.Windows.Forms.RadioButton()
        Me.rdPend = New System.Windows.Forms.RadioButton()
        Me.rdAprv = New System.Windows.Forms.RadioButton()
        Me.tbFindVoters = New System.Windows.Forms.TabPage()
        Me.cmbType = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.cmbFilter = New System.Windows.Forms.ComboBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.S_No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Vphone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VAadhar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VConst = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbNews = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tabResults = New System.Windows.Forms.TabPage()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.cmbResults = New System.Windows.Forms.ComboBox()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.SNo1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Const_Code1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Const_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Winner = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Party = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoofVotes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Majority = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.tabHome.SuspendLayout()
        Me.tbRegVoters.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbFindVoters.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbNews.SuspendLayout()
        Me.tabResults.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(127, 100)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "EC"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblheading
        '
        Me.lblheading.AutoSize = True
        Me.lblheading.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblheading.ForeColor = System.Drawing.Color.Red
        Me.lblheading.Location = New System.Drawing.Point(158, 32)
        Me.lblheading.Name = "lblheading"
        Me.lblheading.Size = New System.Drawing.Size(65, 20)
        Me.lblheading.TabIndex = 2
        Me.lblheading.Text = "header"
        '
        'btnRegVoter
        '
        Me.btnRegVoter.Location = New System.Drawing.Point(12, 128)
        Me.btnRegVoter.Name = "btnRegVoter"
        Me.btnRegVoter.Size = New System.Drawing.Size(173, 49)
        Me.btnRegVoter.TabIndex = 3
        Me.btnRegVoter.Text = "Voter - Login"
        Me.btnRegVoter.UseVisualStyleBackColor = True
        '
        'btnFindVoter
        '
        Me.btnFindVoter.Location = New System.Drawing.Point(191, 128)
        Me.btnFindVoter.Name = "btnFindVoter"
        Me.btnFindVoter.Size = New System.Drawing.Size(173, 49)
        Me.btnFindVoter.TabIndex = 4
        Me.btnFindVoter.Text = "Find Voter/Etc"
        Me.btnFindVoter.UseVisualStyleBackColor = True
        '
        'btnNews
        '
        Me.btnNews.Location = New System.Drawing.Point(370, 128)
        Me.btnNews.Name = "btnNews"
        Me.btnNews.Size = New System.Drawing.Size(173, 49)
        Me.btnNews.TabIndex = 5
        Me.btnNews.Text = "Newsfeeds"
        Me.btnNews.UseVisualStyleBackColor = True
        '
        'btnResults
        '
        Me.btnResults.Location = New System.Drawing.Point(549, 128)
        Me.btnResults.Name = "btnResults"
        Me.btnResults.Size = New System.Drawing.Size(173, 49)
        Me.btnResults.TabIndex = 6
        Me.btnResults.Text = "Results"
        Me.btnResults.UseVisualStyleBackColor = True
        '
        'btnVote
        '
        Me.btnVote.Location = New System.Drawing.Point(728, 128)
        Me.btnVote.Name = "btnVote"
        Me.btnVote.Size = New System.Drawing.Size(173, 49)
        Me.btnVote.TabIndex = 7
        Me.btnVote.Text = "Cast Ur Vote"
        Me.btnVote.UseVisualStyleBackColor = True
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(805, 12)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(88, 88)
        Me.btnLogin.TabIndex = 8
        Me.btnLogin.Text = "Admin Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'tabHome
        '
        Me.tabHome.AllowDrop = True
        Me.tabHome.Controls.Add(Me.tbRegVoters)
        Me.tabHome.Controls.Add(Me.tbFindVoters)
        Me.tabHome.Controls.Add(Me.tbNews)
        Me.tabHome.Controls.Add(Me.tabResults)
        Me.tabHome.Location = New System.Drawing.Point(19, 183)
        Me.tabHome.Name = "tabHome"
        Me.tabHome.SelectedIndex = 0
        Me.tabHome.Size = New System.Drawing.Size(974, 262)
        Me.tabHome.TabIndex = 10
        '
        'tbRegVoters
        '
        Me.tbRegVoters.Controls.Add(Me.DataGridView1)
        Me.tbRegVoters.Controls.Add(Me.rdRej)
        Me.tbRegVoters.Controls.Add(Me.rdPend)
        Me.tbRegVoters.Controls.Add(Me.rdAprv)
        Me.tbRegVoters.Location = New System.Drawing.Point(4, 22)
        Me.tbRegVoters.Name = "tbRegVoters"
        Me.tbRegVoters.Padding = New System.Windows.Forms.Padding(3)
        Me.tbRegVoters.Size = New System.Drawing.Size(966, 236)
        Me.tbRegVoters.TabIndex = 0
        Me.tbRegVoters.Text = "Approvals"
        Me.tbRegVoters.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sno, Me.Seq_no, Me.Voterid, Me.name, Me.Age, Me.Sex, Me.Const_Code, Me.State, Me.Approv_By, Me.Approve_Status, Me.Approve_dt, Me.phone, Me.Aadhar})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(6, 38)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.Size = New System.Drawing.Size(954, 195)
        Me.DataGridView1.TabIndex = 13
        '
        'sno
        '
        Me.sno.HeaderText = "S.No"
        Me.sno.Name = "sno"
        '
        'Seq_no
        '
        Me.Seq_no.HeaderText = "SeqNo"
        Me.Seq_no.Name = "Seq_no"
        '
        'Voterid
        '
        Me.Voterid.HeaderText = "Voterid"
        Me.Voterid.Name = "Voterid"
        '
        'name
        '
        Me.name.HeaderText = "name"
        Me.name.Name = "name"
        '
        'Age
        '
        Me.Age.HeaderText = "Age"
        Me.Age.Name = "Age"
        '
        'Sex
        '
        Me.Sex.HeaderText = "Sex"
        Me.Sex.Name = "Sex"
        '
        'Const_Code
        '
        Me.Const_Code.HeaderText = "Const_Code"
        Me.Const_Code.Name = "Const_Code"
        '
        'State
        '
        Me.State.HeaderText = "State"
        Me.State.Name = "State"
        '
        'Approv_By
        '
        Me.Approv_By.HeaderText = "Approv_By"
        Me.Approv_By.Name = "Approv_By"
        '
        'Approve_Status
        '
        Me.Approve_Status.HeaderText = "Approve_Status"
        Me.Approve_Status.Name = "Approve_Status"
        '
        'Approve_dt
        '
        Me.Approve_dt.HeaderText = "Approve_dt"
        Me.Approve_dt.Name = "Approve_dt"
        '
        'phone
        '
        Me.phone.HeaderText = "phone"
        Me.phone.Name = "phone"
        '
        'Aadhar
        '
        Me.Aadhar.HeaderText = "Aadhar"
        Me.Aadhar.Name = "Aadhar"
        '
        'rdRej
        '
        Me.rdRej.AutoSize = True
        Me.rdRej.Location = New System.Drawing.Point(211, 15)
        Me.rdRej.Name = "rdRej"
        Me.rdRej.Size = New System.Drawing.Size(68, 17)
        Me.rdRej.TabIndex = 12
        Me.rdRej.TabStop = True
        Me.rdRej.Text = "Rejected"
        Me.rdRej.UseVisualStyleBackColor = True
        '
        'rdPend
        '
        Me.rdPend.AutoSize = True
        Me.rdPend.Location = New System.Drawing.Point(117, 15)
        Me.rdPend.Name = "rdPend"
        Me.rdPend.Size = New System.Drawing.Size(64, 17)
        Me.rdPend.TabIndex = 11
        Me.rdPend.TabStop = True
        Me.rdPend.Text = "Pending"
        Me.rdPend.UseVisualStyleBackColor = True
        '
        'rdAprv
        '
        Me.rdAprv.AutoSize = True
        Me.rdAprv.Location = New System.Drawing.Point(14, 15)
        Me.rdAprv.Name = "rdAprv"
        Me.rdAprv.Size = New System.Drawing.Size(71, 17)
        Me.rdAprv.TabIndex = 10
        Me.rdAprv.TabStop = True
        Me.rdAprv.Text = "Approved"
        Me.rdAprv.UseVisualStyleBackColor = True
        '
        'tbFindVoters
        '
        Me.tbFindVoters.Controls.Add(Me.cmbType)
        Me.tbFindVoters.Controls.Add(Me.TextBox1)
        Me.tbFindVoters.Controls.Add(Me.cmbFilter)
        Me.tbFindVoters.Controls.Add(Me.DataGridView2)
        Me.tbFindVoters.Location = New System.Drawing.Point(4, 22)
        Me.tbFindVoters.Name = "tbFindVoters"
        Me.tbFindVoters.Padding = New System.Windows.Forms.Padding(3)
        Me.tbFindVoters.Size = New System.Drawing.Size(966, 236)
        Me.tbFindVoters.TabIndex = 1
        Me.tbFindVoters.Text = "Find Voter & Etc.,"
        Me.tbFindVoters.UseVisualStyleBackColor = True
        '
        'cmbType
        '
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.Items.AddRange(New Object() {"Voters", "Political Party", "Party Symbols", "Constituency"})
        Me.cmbType.Location = New System.Drawing.Point(6, 7)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(105, 21)
        Me.cmbType.TabIndex = 8
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(242, 7)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(147, 20)
        Me.TextBox1.TabIndex = 7
        '
        'cmbFilter
        '
        Me.cmbFilter.FormattingEnabled = True
        Me.cmbFilter.Items.AddRange(New Object() {"VoterID", "Constituency", "Phone No", "Aadhar No"})
        Me.cmbFilter.Location = New System.Drawing.Point(114, 7)
        Me.cmbFilter.Name = "cmbFilter"
        Me.cmbFilter.Size = New System.Drawing.Size(121, 21)
        Me.cmbFilter.TabIndex = 6
        '
        'DataGridView2
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.S_No, Me.ID, Me.VName, Me.Vphone, Me.VAadhar, Me.VConst, Me.Column1, Me.Column2})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView2.Location = New System.Drawing.Point(6, 33)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(954, 197)
        Me.DataGridView2.TabIndex = 0
        '
        'S_No
        '
        Me.S_No.HeaderText = "S No"
        Me.S_No.Name = "S_No"
        '
        'ID
        '
        Me.ID.HeaderText = "Voter Id"
        Me.ID.Name = "ID"
        '
        'VName
        '
        Me.VName.HeaderText = "Name"
        Me.VName.Name = "VName"
        '
        'Vphone
        '
        Me.Vphone.HeaderText = "Phone"
        Me.Vphone.Name = "Vphone"
        '
        'VAadhar
        '
        Me.VAadhar.HeaderText = "Aadhar No"
        Me.VAadhar.Name = "VAadhar"
        '
        'VConst
        '
        Me.VConst.HeaderText = "Constituency"
        Me.VConst.Name = "VConst"
        '
        'Column1
        '
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = ""
        Me.Column2.Name = "Column2"
        '
        'tbNews
        '
        Me.tbNews.Controls.Add(Me.Label2)
        Me.tbNews.Controls.Add(Me.RichTextBox1)
        Me.tbNews.Controls.Add(Me.Panel1)
        Me.tbNews.Location = New System.Drawing.Point(4, 22)
        Me.tbNews.Name = "tbNews"
        Me.tbNews.Size = New System.Drawing.Size(966, 236)
        Me.tbNews.TabIndex = 2
        Me.tbNews.Text = "News"
        Me.tbNews.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MediumTurquoise
        Me.Label2.Location = New System.Drawing.Point(263, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(206, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Lok Sabha Elections 2024: "
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(266, 52)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(577, 146)
        Me.RichTextBox1.TabIndex = 1
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Location = New System.Drawing.Point(3, 9)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(232, 224)
        Me.Panel1.TabIndex = 0
        '
        'tabResults
        '
        Me.tabResults.Controls.Add(Me.TextBox2)
        Me.tabResults.Controls.Add(Me.cmbResults)
        Me.tabResults.Controls.Add(Me.DataGridView3)
        Me.tabResults.Location = New System.Drawing.Point(4, 22)
        Me.tabResults.Name = "tabResults"
        Me.tabResults.Padding = New System.Windows.Forms.Padding(3)
        Me.tabResults.Size = New System.Drawing.Size(966, 236)
        Me.tabResults.TabIndex = 3
        Me.tabResults.Text = "Results"
        Me.tabResults.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(133, 6)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(147, 20)
        Me.TextBox2.TabIndex = 9
        '
        'cmbResults
        '
        Me.cmbResults.FormattingEnabled = True
        Me.cmbResults.Items.AddRange(New Object() {"Const Code", "Const Name", "Winner", "Party"})
        Me.cmbResults.Location = New System.Drawing.Point(6, 5)
        Me.cmbResults.Name = "cmbResults"
        Me.cmbResults.Size = New System.Drawing.Size(121, 21)
        Me.cmbResults.TabIndex = 8
        '
        'DataGridView3
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView3.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SNo1, Me.Const_Code1, Me.Const_Name, Me.Winner, Me.Party, Me.NoofVotes, Me.Majority})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView3.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridView3.Location = New System.Drawing.Point(6, 32)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(954, 198)
        Me.DataGridView3.TabIndex = 0
        '
        'SNo1
        '
        Me.SNo1.HeaderText = "S No"
        Me.SNo1.Name = "SNo1"
        '
        'Const_Code1
        '
        Me.Const_Code1.HeaderText = "Const Code"
        Me.Const_Code1.Name = "Const_Code1"
        '
        'Const_Name
        '
        Me.Const_Name.HeaderText = "Name"
        Me.Const_Name.Name = "Const_Name"
        '
        'Winner
        '
        Me.Winner.HeaderText = "Winner"
        Me.Winner.Name = "Winner"
        '
        'Party
        '
        Me.Party.HeaderText = "Party"
        Me.Party.Name = "Party"
        '
        'NoofVotes
        '
        Me.NoofVotes.HeaderText = "No of Votes"
        Me.NoofVotes.Name = "NoofVotes"
        '
        'Majority
        '
        Me.Majority.HeaderText = "Majority"
        Me.Majority.Name = "Majority"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "EC.jpeg")
        '
        'FrmEMSystem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 450)
        Me.Controls.Add(Me.tabHome)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.btnVote)
        Me.Controls.Add(Me.btnResults)
        Me.Controls.Add(Me.btnNews)
        Me.Controls.Add(Me.btnFindVoter)
        Me.Controls.Add(Me.btnRegVoter)
        Me.Controls.Add(Me.lblheading)
        Me.Controls.Add(Me.Button1)
        'Me.name = "FrmEMSystem"
        Me.tabHome.ResumeLayout(False)
        Me.tbRegVoters.ResumeLayout(False)
        Me.tbRegVoters.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbFindVoters.ResumeLayout(False)
        Me.tbFindVoters.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbNews.ResumeLayout(False)
        Me.tbNews.PerformLayout()
        Me.tabResults.ResumeLayout(False)
        Me.tabResults.PerformLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents lblheading As Label
    Friend WithEvents btnRegVoter As Button
    Friend WithEvents btnFindVoter As Button
    Friend WithEvents btnNews As Button
    Friend WithEvents btnResults As Button
    Friend WithEvents btnVote As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents tabHome As TabControl
    Friend WithEvents tbRegVoters As TabPage
    Friend WithEvents tbFindVoters As TabPage
    Friend WithEvents tbNews As TabPage
    Friend WithEvents tabResults As TabPage
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents rdRej As RadioButton
    Friend WithEvents rdPend As RadioButton
    Friend WithEvents rdAprv As RadioButton
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents cmbFilter As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents cmbResults As ComboBox
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents SNo1 As DataGridViewTextBoxColumn
    Friend WithEvents Const_Code1 As DataGridViewTextBoxColumn
    Friend WithEvents Const_Name As DataGridViewTextBoxColumn
    Friend WithEvents Winner As DataGridViewTextBoxColumn
    Friend WithEvents Party As DataGridViewTextBoxColumn
    Friend WithEvents NoofVotes As DataGridViewTextBoxColumn
    Friend WithEvents Majority As DataGridViewTextBoxColumn
    Friend WithEvents sno As DataGridViewTextBoxColumn
    Friend WithEvents Seq_no As DataGridViewTextBoxColumn
    Friend WithEvents Voterid As DataGridViewTextBoxColumn
    Friend WithEvents name As DataGridViewTextBoxColumn
    Friend WithEvents Age As DataGridViewTextBoxColumn
    Friend WithEvents Sex As DataGridViewTextBoxColumn
    Friend WithEvents Const_Code As DataGridViewTextBoxColumn
    Friend WithEvents State As DataGridViewTextBoxColumn
    Friend WithEvents Approv_By As DataGridViewTextBoxColumn
    Friend WithEvents Approve_Status As DataGridViewTextBoxColumn
    Friend WithEvents Approve_dt As DataGridViewTextBoxColumn
    Friend WithEvents phone As DataGridViewTextBoxColumn
    Friend WithEvents Aadhar As DataGridViewTextBoxColumn
    Friend WithEvents cmbType As ComboBox
    Friend WithEvents S_No As DataGridViewTextBoxColumn
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents VName As DataGridViewTextBoxColumn
    Friend WithEvents Vphone As DataGridViewTextBoxColumn
    Friend WithEvents VAadhar As DataGridViewTextBoxColumn
    Friend WithEvents VConst As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
End Class
