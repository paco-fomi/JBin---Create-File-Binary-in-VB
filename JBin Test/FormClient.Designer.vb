<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormClient
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.BtnNew = New System.Windows.Forms.Button()
        Me.txtDetails = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.GroupBoxClient = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCountry = New System.Windows.Forms.TextBox()
        Me.txtMobile = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblColor = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.BtnGo = New System.Windows.Forms.Button()
        Me.scrollIndex = New System.Windows.Forms.HScrollBar()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.lblView = New System.Windows.Forms.Label()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.GroupBoxAll = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblIntro = New System.Windows.Forms.Label()
        Me.GroupBoxClient.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxAll.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnNew
        '
        Me.BtnNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnNew.Location = New System.Drawing.Point(20, 466)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(79, 34)
        Me.BtnNew.TabIndex = 0
        Me.BtnNew.Text = "New"
        Me.BtnNew.UseVisualStyleBackColor = True
        '
        'txtDetails
        '
        Me.txtDetails.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDetails.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDetails.Location = New System.Drawing.Point(16, 330)
        Me.txtDetails.Multiline = True
        Me.txtDetails.Name = "txtDetails"
        Me.txtDetails.Size = New System.Drawing.Size(614, 64)
        Me.txtDetails.TabIndex = 1
        '
        'txtName
        '
        Me.txtName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtName.Location = New System.Drawing.Point(16, 91)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(614, 23)
        Me.txtName.TabIndex = 2
        '
        'GroupBoxClient
        '
        Me.GroupBoxClient.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxClient.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBoxClient.Controls.Add(Me.Label12)
        Me.GroupBoxClient.Controls.Add(Me.DateTimePicker1)
        Me.GroupBoxClient.Controls.Add(Me.Label9)
        Me.GroupBoxClient.Controls.Add(Me.Label3)
        Me.GroupBoxClient.Controls.Add(Me.txtCountry)
        Me.GroupBoxClient.Controls.Add(Me.txtMobile)
        Me.GroupBoxClient.Controls.Add(Me.Label4)
        Me.GroupBoxClient.Controls.Add(Me.txtID)
        Me.GroupBoxClient.Controls.Add(Me.Label7)
        Me.GroupBoxClient.Controls.Add(Me.Label11)
        Me.GroupBoxClient.Controls.Add(Me.lblColor)
        Me.GroupBoxClient.Controls.Add(Me.Label6)
        Me.GroupBoxClient.Controls.Add(Me.Label10)
        Me.GroupBoxClient.Controls.Add(Me.Label5)
        Me.GroupBoxClient.Controls.Add(Me.Label2)
        Me.GroupBoxClient.Controls.Add(Me.txtAddress)
        Me.GroupBoxClient.Controls.Add(Me.txtEmail)
        Me.GroupBoxClient.Controls.Add(Me.Label1)
        Me.GroupBoxClient.Controls.Add(Me.txtName)
        Me.GroupBoxClient.Controls.Add(Me.txtDetails)
        Me.GroupBoxClient.Location = New System.Drawing.Point(20, 42)
        Me.GroupBoxClient.Name = "GroupBoxClient"
        Me.GroupBoxClient.Size = New System.Drawing.Size(655, 408)
        Me.GroupBoxClient.TabIndex = 3
        Me.GroupBoxClient.TabStop = False
        '
        'Label12
        '
        Me.Label12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.BackColor = System.Drawing.Color.Silver
        Me.Label12.Location = New System.Drawing.Point(13, 183)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(617, 1)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "HairColor"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateTimePicker1.Location = New System.Drawing.Point(341, 215)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(289, 23)
        Me.DateTimePicker1.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(338, 259)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 15)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Country"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(338, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Mobile"
        '
        'txtCountry
        '
        Me.txtCountry.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCountry.Location = New System.Drawing.Point(341, 279)
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.Size = New System.Drawing.Size(289, 23)
        Me.txtCountry.TabIndex = 2
        '
        'txtMobile
        '
        Me.txtMobile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMobile.Location = New System.Drawing.Point(341, 143)
        Me.txtMobile.Name = "txtMobile"
        Me.txtMobile.Size = New System.Drawing.Size(289, 23)
        Me.txtMobile.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(18, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "ID"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(16, 39)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(82, 23)
        Me.txtID.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(338, 195)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 15)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Birthdate"
        '
        'Label11
        '
        Me.Label11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.BackColor = System.Drawing.Color.Silver
        Me.Label11.Location = New System.Drawing.Point(13, 251)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(617, 1)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "HairColor"
        '
        'lblColor
        '
        Me.lblColor.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblColor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblColor.Location = New System.Drawing.Point(13, 215)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(94, 24)
        Me.lblColor.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 195)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 15)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "HairColor"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 310)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 15)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Details"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 259)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 15)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Address"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Email"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(16, 279)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(280, 23)
        Me.txtAddress.TabIndex = 2
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(16, 143)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(280, 23)
        Me.txtEmail.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Name"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NumericUpDown1.Location = New System.Drawing.Point(534, 477)
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(92, 23)
        Me.NumericUpDown1.TabIndex = 9
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'BtnGo
        '
        Me.BtnGo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnGo.Location = New System.Drawing.Point(631, 476)
        Me.BtnGo.Name = "BtnGo"
        Me.BtnGo.Size = New System.Drawing.Size(41, 25)
        Me.BtnGo.TabIndex = 8
        Me.BtnGo.Text = "Go"
        Me.BtnGo.UseVisualStyleBackColor = True
        '
        'scrollIndex
        '
        Me.scrollIndex.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.scrollIndex.LargeChange = 1
        Me.scrollIndex.Location = New System.Drawing.Point(437, 23)
        Me.scrollIndex.Maximum = 0
        Me.scrollIndex.Name = "scrollIndex"
        Me.scrollIndex.Size = New System.Drawing.Size(275, 24)
        Me.scrollIndex.TabIndex = 6
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(16, 9)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(71, 25)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Clients"
        '
        'BtnEdit
        '
        Me.BtnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnEdit.Location = New System.Drawing.Point(105, 466)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(79, 34)
        Me.BtnEdit.TabIndex = 0
        Me.BtnEdit.Text = "Edit"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnSave.Location = New System.Drawing.Point(275, 466)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(79, 34)
        Me.BtnSave.TabIndex = 0
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnCancel.Location = New System.Drawing.Point(360, 466)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(79, 34)
        Me.BtnCancel.TabIndex = 0
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnExit.Location = New System.Drawing.Point(603, 572)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(109, 34)
        Me.BtnExit.TabIndex = 0
        Me.BtnExit.Text = "Close"
        Me.BtnExit.UseVisualStyleBackColor = True
        Me.BtnExit.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnDelete.Location = New System.Drawing.Point(190, 466)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(79, 34)
        Me.BtnDelete.TabIndex = 4
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'lblView
        '
        Me.lblView.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblView.Location = New System.Drawing.Point(93, 25)
        Me.lblView.Name = "lblView"
        Me.lblView.Size = New System.Drawing.Size(341, 18)
        Me.lblView.TabIndex = 3
        Me.lblView.Text = "0 of 0"
        Me.lblView.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBoxAll
        '
        Me.GroupBoxAll.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxAll.Controls.Add(Me.BtnGo)
        Me.GroupBoxAll.Controls.Add(Me.BtnNew)
        Me.GroupBoxAll.Controls.Add(Me.NumericUpDown1)
        Me.GroupBoxAll.Controls.Add(Me.BtnEdit)
        Me.GroupBoxAll.Controls.Add(Me.BtnSave)
        Me.GroupBoxAll.Controls.Add(Me.BtnCancel)
        Me.GroupBoxAll.Controls.Add(Me.GroupBoxClient)
        Me.GroupBoxAll.Controls.Add(Me.BtnDelete)
        Me.GroupBoxAll.Controls.Add(Me.Label8)
        Me.GroupBoxAll.Location = New System.Drawing.Point(21, 50)
        Me.GroupBoxAll.Name = "GroupBoxAll"
        Me.GroupBoxAll.Size = New System.Drawing.Size(691, 516)
        Me.GroupBoxAll.TabIndex = 11
        Me.GroupBoxAll.TabStop = False
        Me.GroupBoxAll.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(535, 458)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 15)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Jump"
        '
        'lblIntro
        '
        Me.lblIntro.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIntro.Location = New System.Drawing.Point(12, 188)
        Me.lblIntro.Name = "lblIntro"
        Me.lblIntro.Size = New System.Drawing.Size(711, 90)
        Me.lblIntro.TabIndex = 12
        Me.lblIntro.Text = "Loading records One moment, please"
        Me.lblIntro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(734, 615)
        Me.Controls.Add(Me.scrollIndex)
        Me.Controls.Add(Me.lblIntro)
        Me.Controls.Add(Me.GroupBoxAll)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.lblView)
        Me.Controls.Add(Me.Label13)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinimumSize = New System.Drawing.Size(750, 654)
        Me.Name = "FormClient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Example Client (VB.NET)"
        Me.GroupBoxClient.ResumeLayout(False)
        Me.GroupBoxClient.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxAll.ResumeLayout(False)
        Me.GroupBoxAll.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnNew As Button
    Friend WithEvents txtDetails As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents GroupBoxClient As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMobile As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents lblColor As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtCountry As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnExit As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BtnDelete As Button
    Friend WithEvents lblView As Label
    Friend WithEvents scrollIndex As HScrollBar
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents BtnGo As Button
    Friend WithEvents GroupBoxAll As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents lblIntro As Label
End Class
