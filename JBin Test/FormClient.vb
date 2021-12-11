Imports System.IO
Imports JBin

Public Class FormClient


    Dim myClients As New Clients
    Dim WithEvents myJBin As New AG

    Enum Status
        [New] = 0
        Edit = 2
        View = 3
    End Enum
    Dim StatusForm As Status
    Dim IndexCliente As Integer = -1
    Dim FileClients As String = Application.StartupPath & "\clients.bin"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Show()
        Me.Refresh()

        Dim f As New FileInfo(FileClients)
        If f.Exists Then
            myJBin.Load(FileClients)
            ReadClients()
        End If

        StatusForm = Status.View
        RefrehsStatus()

        lblIntro.Visible = False
        BtnExit.Visible = True
        GroupBoxAll.Visible = True

    End Sub

    Private Sub myJBin_OnError(Sender As Object, e As AGErrorEventArgs) Handles myJBin.OnError
        MsgBox(e.ToString())
        AbortWrite = True
    End Sub

    Private Sub RefrehsStatus()

        Select Case StatusForm
            Case Status.Edit
                GroupBoxClient.Enabled = True
                BtnNew.Enabled = False
                BtnDelete.Enabled = True
                BtnSave.Enabled = True
                BtnCancel.Enabled = True

            Case Status.New
                txtID.Text = CStr(myClients.CountClient + 1)
                txtName.Text = ""
                txtEmail.Text = ""
                txtMobile.Text = ""
                lblColor.BackColor = Color.Black
                DateTimePicker1.Value = Now
                txtAddress.Text = ""
                txtCountry.Text = ""
                txtDetails.Text = ""
                GroupBoxClient.Enabled = True
                BtnNew.Enabled = False
                BtnEdit.Enabled = False
                BtnDelete.Enabled = False
                BtnSave.Enabled = True
                BtnCancel.Enabled = True

            Case Status.View
                GroupBoxClient.Enabled = False
                BtnNew.Enabled = True
                BtnDelete.Enabled = False
                BtnSave.Enabled = False
                BtnCancel.Enabled = False

        End Select

    End Sub

    Private Sub ViewClient(Index As Integer)

        If Index = -1 Then

            txtID.Text = ""
            txtName.Text = ""
            txtEmail.Text = ""
            txtMobile.Text = ""
            lblColor.BackColor = Color.Black
            DateTimePicker1.Value = Now
            txtAddress.Text = ""
            txtCountry.Text = ""
            txtDetails.Text = ""

        Else

            txtID.Text = myClients.Item(Index).ID
            txtName.Text = myClients.Item(Index).Name
            txtEmail.Text = myClients.Item(Index).Email
            txtMobile.Text = myClients.Item(Index).Mobile
            lblColor.BackColor = myClients.Item(Index).HairColor
            DateTimePicker1.Value = myClients.Item(Index).Birthdate
            txtAddress.Text = myClients.Item(Index).Address
            txtCountry.Text = myClients.Item(Index).Country
            txtDetails.Text = myClients.Item(Index).Details

        End If

        lblView.Text = Index + 1 & " of " & myClients.CountClient

    End Sub

    Private Sub ReadClients()

        myJBin.pLFO = 0
        Dim NumCl As Integer = myJBin.GetInt

        For i As Integer = 0 To NumCl - 1
            Dim newCl As New Client
            With newCl
                .ID = myJBin.GetInt
                .Name = myJBin.GetString
                .Email = myJBin.GetString
                .Mobile = myJBin.GetString
                .HairColor = myJBin.GetColor
                .Birthdate = myJBin.GetDate
                .Address = myJBin.GetString
                .Country = myJBin.GetString
                .Details = myJBin.GetString
            End With
            myClients.AddClient(newCl)
        Next

        If myClients.CountClient > 0 Then

            scrollIndex.Maximum = myClients.CountClient
            NumericUpDown1.Maximum = myClients.CountClient
            scrollIndex.Value = 1
            scrollIndex.Minimum = 1

        Else

            scrollIndex.Value = 0
            scrollIndex.Minimum = 0
            scrollIndex.Maximum = 0
            NumericUpDown1.Maximum = 1

        End If

    End Sub

    Dim AbortWrite As Boolean = False
    Private Sub WriteClients()

        myJBin = New AG
        myJBin.TypeFile = TypeFileJBin.Custom

        myJBin.AddInt(myClients.CountClient)

        For i As Integer = 0 To myClients.CountClient - 1
            With myClients.Item(i)
                myJBin.AddInt(.ID)
                myJBin.AddString(.Name)
                myJBin.AddString(.Email)
                myJBin.AddString(.Mobile)
                myJBin.AddColor(.HairColor)
                myJBin.AddDate(.Birthdate)
                myJBin.AddString(.Address)
                myJBin.AddString(.Country)
                myJBin.AddString(.Details)
                ' EXAMPLE FOR DETECT ERROR
                If AbortWrite Then Exit Sub
            End With
        Next

        myJBin.Save(FileClients)

    End Sub

#Region "CONSTROLS"

    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click

        StatusForm = Status.New
        RefrehsStatus()

    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click

        StatusForm = Status.Edit
        RefrehsStatus()

    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If IndexCliente = -1 Then Exit Sub
        If myClients.CountClient = 0 Then Exit Sub

        Dim res = MsgBox("Delete client?", vbYesNo)
        If res = vbYes Then
            myClients.RemoveClient(IndexCliente)
            If myClients.CountClient = 0 Then
                IndexCliente = -1
                ViewClient(IndexCliente)
            Else
                If IndexCliente > myClients.CountClient - 1 Then
                    IndexCliente = myClients.CountClient - 1
                End If
            End If
            ViewClient(IndexCliente)
        End If

        StatusForm = Status.View
        RefrehsStatus()

    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

        Select Case StatusForm
            Case Status.Edit
                With myClients.Item(IndexCliente)
                    .ID = txtID.Text
                    .Name = txtName.Text
                    .Email = txtEmail.Text
                    .Mobile = txtMobile.Text
                    .HairColor = lblColor.BackColor
                    .Birthdate = DateTimePicker1.Value
                    .Address = txtAddress.Text
                    .Country = txtCountry.Text
                    .Details = txtDetails.Text
                End With

            Case Status.New
                Dim newCl As New Client
                With newCl
                    .ID = txtID.Text
                    .Name = txtName.Text
                    .Email = txtEmail.Text
                    .Mobile = txtMobile.Text
                    .HairColor = lblColor.BackColor
                    .Birthdate = DateTimePicker1.Value
                    .Address = txtAddress.Text
                    .Country = txtCountry.Text
                    .Details = txtDetails.Text
                End With
                myClients.AddClient(newCl)
                scrollIndex.Maximum = myClients.CountClient
                NumericUpDown1.Maximum = myClients.CountClient
                scrollIndex.Value = myClients.CountClient
                scrollIndex.Minimum = 1

        End Select
        StatusForm = Status.View
        RefrehsStatus()
        WriteClients()

    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click

        StatusForm = Status.View
        RefrehsStatus()

    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Dispose()
    End Sub

    Private Sub scrollIndex_ValueChanged(sender As Object, e As EventArgs) Handles scrollIndex.ValueChanged
        IndexCliente = scrollIndex.Value - 1
        ViewClient(IndexCliente)
    End Sub

    Private Sub BtnGo_Click(sender As Object, e As EventArgs) Handles BtnGo.Click
        If NumericUpDown1.Value > myClients.CountClient - 1 Then NumericUpDown1.Value = myClients.CountClient
        If NumericUpDown1.Value < 1 Then NumericUpDown1.Value = 1
        IndexCliente = NumericUpDown1.Value - 1
        ViewClient(IndexCliente)
    End Sub

    Private Sub lblColor_Click(sender As Object, e As EventArgs) Handles lblColor.Click
        Dim ColorDialog1 As New ColorDialog
        ColorDialog1.Color = lblColor.BackColor
        If ColorDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            lblColor.BackColor = ColorDialog1.Color
        End If
    End Sub

#End Region

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If StatusForm = Status.View Then
            If IndexCliente < 0 Or IndexCliente > myClients.CountClient - 1 Then
                BtnEdit.Enabled = False
            Else
                BtnEdit.Enabled = True
            End If
        End If

        If myClients.CountClient = 0 Then
            NumericUpDown1.Enabled = False
            BtnGo.Enabled = False
        Else
            NumericUpDown1.Enabled = True
            BtnGo.Enabled = True
        End If



    End Sub




    'Private Sub Button1_Click(sender As Object, e As EventArgs)

    '    Dim D = 1, M = 1, A = 2019
    '    Dim R = 0, G = 128, B = 255
    '    Dim myDate As Date = Now

    '    For x = 0 To 25000
    '        Me.Text = x
    '        Dim newCl As New Client
    '        With newCl
    '            .ID = x + 1
    '            .Name = "Name " & x
    '            .Email = "Email " & x
    '            .Mobile = "Mobile " & x
    '            .Address = "Address " & x
    '            .Country = "Country " & x
    '            .Details = "My details " & x

    '            .HairColor = Color.FromArgb(R, G, B)
    '            R += 1 : If R > 255 Then R = 0
    '            G += 1 : If G > 255 Then G = 0
    '            B += 1 : If B > 255 Then B = 0

    '            myDate.AddDays(1)
    '            .Birthdate = myDate
    '            M += 1 : If M > 12 Then M = 1
    '            D += 1 : If D > 28 Then D = 1

    '        End With
    '        myClients.AddClient(newCl)

    '    Next
    '    WriteClients()
    '    IndexCliente = 1
    '    ViewClient(IndexCliente)
    '    MsgBox("Ya")
    'End Sub

End Class


Public Class Client
    Private _ID As Integer
    Public Property ID As Integer
        Get
            Return _ID
        End Get
        Set
            _ID = Value
        End Set
    End Property

    Private _Name As String
    Public Property Name As String
        Get
            Return _Name
        End Get
        Set
            _Name = Value
        End Set
    End Property

    Private _Email As String
    Public Property Email As String
        Get
            Return _Email
        End Get
        Set
            _Email = Value
        End Set
    End Property

    Private _Mobile As String
    Public Property Mobile As String
        Get
            Return _Mobile
        End Get
        Set
            _Mobile = Value
        End Set
    End Property

    Private _Birthdate As Date
    Public Property Birthdate As Date
        Get
            Return _Birthdate
        End Get
        Set
            _Birthdate = Value
        End Set
    End Property

    Private _HairColor As Color
    Public Property HairColor As Color
        Get
            Return _HairColor
        End Get
        Set
            _HairColor = Value
        End Set
    End Property

    Private _Country As String
    Public Property Country As String
        Get
            Return _Country
        End Get
        Set
            _Country = Value
        End Set
    End Property

    Private _Address As String
    Public Property Address As String
        Get
            Return _Address
        End Get
        Set
            _Address = Value
        End Set
    End Property

    Private _Details As String
    Public Property Details As String
        Get
            Return _Details
        End Get
        Set
            _Details = Value
        End Set
    End Property
End Class

Public Class Clients

    Public Sub New()

    End Sub

    Private _Item As Client()
    Public Property Item() As Client()
        Get
            Return _Item
        End Get
        Set
            _Item = Value
        End Set
    End Property

#Region "ADD REMOVE"

    Private newCount As Integer

    Public ReadOnly Property CountClient() As Integer
        Get
            If IsNothing(Item) Then
                newCount = 0
            Else
                newCount = Item.Length
            End If
            Return newCount
        End Get
    End Property

    Public Function AddClient(newDiagrama As Client) As Integer

        If IsNothing(newDiagrama) Then Return -1

        Dim MaxFiles As Integer
        If IsNothing(Item) Then
            MaxFiles = 0
        Else
            MaxFiles = Item.Length
        End If

        ReDim Preserve Item(MaxFiles)
        Item(MaxFiles) = New Client
        Item(MaxFiles) = newDiagrama

        Return 0

    End Function

    Public Sub RemoveClient(Index As Integer)

        If IsNothing(Item) Then Exit Sub
        If Index < 0 Then Exit Sub
        If Index > Item.Length - 1 Then Exit Sub

        For x As Integer = Index + 1 To Item.Length - 1
            Item(x - 1) = Item(x)
        Next
        ReDim Preserve Item(Item.Length - 2)

    End Sub

#End Region



End Class