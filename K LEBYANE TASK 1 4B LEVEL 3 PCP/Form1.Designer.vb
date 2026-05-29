<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        btnCalculate = New Button()
        btnPromooffer = New Button()
        btnClear = New Button()
        btnExit = New Button()
        chkLaptop = New CheckBox()
        chkSmartphone = New CheckBox()
        chkGamingconsole = New CheckBox()
        chkTabletplus = New CheckBox()
        Label1 = New Label()
        lblCnames = New Label()
        lblCemail = New Label()
        lblCcontactdetails = New Label()
        lblSubtotal = New Label()
        lblDiscount = New Label()
        lblVat = New Label()
        lstDisplay = New ListBox()
        radWirelessmouse = New RadioButton()
        radHeadphones = New RadioButton()
        radFlashdrive = New RadioButton()
        radLaptopbag = New RadioButton()
        picTech = New PictureBox()
        grpBproduct = New GroupBox()
        grpAaccessories = New GroupBox()
        txtCustomername = New TextBox()
        txtCustomeremail = New TextBox()
        txtSubtotal = New TextBox()
        txtDiscount = New TextBox()
        txtVat = New TextBox()
        Label8 = New Label()
        lblFinaltotal = New Label()
        txtFinaltotal = New TextBox()
        Label10 = New Label()
        mskContactdetails = New MaskedTextBox()
        CType(picTech, ComponentModel.ISupportInitialize).BeginInit()
        grpBproduct.SuspendLayout()
        grpAaccessories.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Location = New Point(293, 480)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(80, 23)
        btnCalculate.TabIndex = 0
        btnCalculate.Text = "CALCULATE"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' btnPromooffer
        ' 
        btnPromooffer.Location = New Point(38, 480)
        btnPromooffer.Name = "btnPromooffer"
        btnPromooffer.Size = New Size(162, 23)
        btnPromooffer.TabIndex = 1
        btnPromooffer.Text = "PROMOTIONAL OFFER"
        btnPromooffer.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(454, 480)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(75, 23)
        btnClear.TabIndex = 2
        btnClear.Text = "CLEAR"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(631, 480)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(75, 23)
        btnExit.TabIndex = 3
        btnExit.Text = "EXIT"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' chkLaptop
        ' 
        chkLaptop.AutoSize = True
        chkLaptop.Location = New Point(6, 22)
        chkLaptop.Name = "chkLaptop"
        chkLaptop.Size = New Size(84, 19)
        chkLaptop.TabIndex = 4
        chkLaptop.Text = "Laptop Pro"
        chkLaptop.UseVisualStyleBackColor = True
        ' 
        ' chkSmartphone
        ' 
        chkSmartphone.AutoSize = True
        chkSmartphone.Location = New Point(6, 47)
        chkSmartphone.Name = "chkSmartphone"
        chkSmartphone.Size = New Size(91, 19)
        chkSmartphone.TabIndex = 5
        chkSmartphone.Text = "Smartphone"
        chkSmartphone.UseVisualStyleBackColor = True
        ' 
        ' chkGamingconsole
        ' 
        chkGamingconsole.AutoSize = True
        chkGamingconsole.Location = New Point(6, 72)
        chkGamingconsole.Name = "chkGamingconsole"
        chkGamingconsole.Size = New Size(117, 19)
        chkGamingconsole.TabIndex = 6
        chkGamingconsole.Text = "Gaming Console "
        chkGamingconsole.UseVisualStyleBackColor = True
        ' 
        ' chkTabletplus
        ' 
        chkTabletplus.AutoSize = True
        chkTabletplus.Location = New Point(6, 96)
        chkTabletplus.Name = "chkTabletplus"
        chkTabletplus.Size = New Size(83, 19)
        chkTabletplus.TabIndex = 7
        chkTabletplus.Text = "Tablet Plus"
        chkTabletplus.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(201, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(452, 37)
        Label1.TabIndex = 8
        Label1.Text = "MICROTECH  ELECTRONICS STORE"
        ' 
        ' lblCnames
        ' 
        lblCnames.AutoSize = True
        lblCnames.Location = New Point(28, 119)
        lblCnames.Name = "lblCnames"
        lblCnames.Size = New Size(113, 15)
        lblCnames.TabIndex = 9
        lblCnames.Text = "Customer's Names :"
        ' 
        ' lblCemail
        ' 
        lblCemail.AutoSize = True
        lblCemail.Location = New Point(28, 153)
        lblCemail.Name = "lblCemail"
        lblCemail.Size = New Size(105, 15)
        lblCemail.TabIndex = 10
        lblCemail.Text = "Customer's Email :"
        ' 
        ' lblCcontactdetails
        ' 
        lblCcontactdetails.AutoSize = True
        lblCcontactdetails.Location = New Point(23, 186)
        lblCcontactdetails.Name = "lblCcontactdetails"
        lblCcontactdetails.Size = New Size(156, 15)
        lblCcontactdetails.TabIndex = 11
        lblCcontactdetails.Text = "Customer's Contact Details :"
        ' 
        ' lblSubtotal
        ' 
        lblSubtotal.AutoSize = True
        lblSubtotal.Location = New Point(322, 298)
        lblSubtotal.Name = "lblSubtotal"
        lblSubtotal.Size = New Size(57, 15)
        lblSubtotal.TabIndex = 12
        lblSubtotal.Text = "Subtotal :"
        ' 
        ' lblDiscount
        ' 
        lblDiscount.AutoSize = True
        lblDiscount.Location = New Point(322, 327)
        lblDiscount.Name = "lblDiscount"
        lblDiscount.Size = New Size(60, 15)
        lblDiscount.TabIndex = 13
        lblDiscount.Text = "Discount :"
        ' 
        ' lblVat
        ' 
        lblVat.AutoSize = True
        lblVat.Location = New Point(322, 351)
        lblVat.Name = "lblVat"
        lblVat.Size = New Size(51, 15)
        lblVat.TabIndex = 14
        lblVat.Text = "VAT(%) :"
        ' 
        ' lstDisplay
        ' 
        lstDisplay.FormattingEnabled = True
        lstDisplay.ItemHeight = 15
        lstDisplay.Location = New Point(555, 114)
        lstDisplay.Name = "lstDisplay"
        lstDisplay.Size = New Size(216, 289)
        lstDisplay.TabIndex = 15
        ' 
        ' radWirelessmouse
        ' 
        radWirelessmouse.AutoSize = True
        radWirelessmouse.Location = New Point(6, 22)
        radWirelessmouse.Name = "radWirelessmouse"
        radWirelessmouse.Size = New Size(107, 19)
        radWirelessmouse.TabIndex = 16
        radWirelessmouse.TabStop = True
        radWirelessmouse.Text = "Wireless Mouse"
        radWirelessmouse.UseVisualStyleBackColor = True
        ' 
        ' radHeadphones
        ' 
        radHeadphones.AutoSize = True
        radHeadphones.Location = New Point(6, 47)
        radHeadphones.Name = "radHeadphones"
        radHeadphones.Size = New Size(92, 19)
        radHeadphones.TabIndex = 17
        radHeadphones.TabStop = True
        radHeadphones.Text = "Headphones"
        radHeadphones.UseVisualStyleBackColor = True
        ' 
        ' radFlashdrive
        ' 
        radFlashdrive.AutoSize = True
        radFlashdrive.Location = New Point(6, 72)
        radFlashdrive.Name = "radFlashdrive"
        radFlashdrive.Size = New Size(112, 19)
        radFlashdrive.TabIndex = 18
        radFlashdrive.TabStop = True
        radFlashdrive.Text = "32GB Flash Drive"
        radFlashdrive.UseVisualStyleBackColor = True
        ' 
        ' radLaptopbag
        ' 
        radLaptopbag.AutoSize = True
        radLaptopbag.Location = New Point(6, 97)
        radLaptopbag.Name = "radLaptopbag"
        radLaptopbag.Size = New Size(85, 19)
        radLaptopbag.TabIndex = 19
        radLaptopbag.TabStop = True
        radLaptopbag.Text = "Laptop Bag"
        radLaptopbag.UseVisualStyleBackColor = True
        ' 
        ' picTech
        ' 
        picTech.Image = My.Resources.Resources.pic1
        picTech.Location = New Point(38, 1)
        picTech.Name = "picTech"
        picTech.Size = New Size(147, 74)
        picTech.SizeMode = PictureBoxSizeMode.StretchImage
        picTech.TabIndex = 20
        picTech.TabStop = False
        ' 
        ' grpBproduct
        ' 
        grpBproduct.Controls.Add(chkLaptop)
        grpBproduct.Controls.Add(chkSmartphone)
        grpBproduct.Controls.Add(chkGamingconsole)
        grpBproduct.Controls.Add(chkTabletplus)
        grpBproduct.Location = New Point(28, 348)
        grpBproduct.Name = "grpBproduct"
        grpBproduct.Size = New Size(200, 118)
        grpBproduct.TabIndex = 21
        grpBproduct.TabStop = False
        grpBproduct.Text = "Group B-Products :"
        ' 
        ' grpAaccessories
        ' 
        grpAaccessories.Controls.Add(radWirelessmouse)
        grpAaccessories.Controls.Add(radHeadphones)
        grpAaccessories.Controls.Add(radFlashdrive)
        grpAaccessories.Controls.Add(radLaptopbag)
        grpAaccessories.Location = New Point(28, 212)
        grpAaccessories.Name = "grpAaccessories"
        grpAaccessories.Size = New Size(200, 124)
        grpAaccessories.TabIndex = 0
        grpAaccessories.TabStop = False
        grpAaccessories.Text = "Group-A Accessories :"
        ' 
        ' txtCustomername
        ' 
        txtCustomername.Location = New Point(185, 114)
        txtCustomername.Name = "txtCustomername"
        txtCustomername.Size = New Size(100, 23)
        txtCustomername.TabIndex = 22
        ' 
        ' txtCustomeremail
        ' 
        txtCustomeremail.Location = New Point(185, 150)
        txtCustomeremail.Name = "txtCustomeremail"
        txtCustomeremail.Size = New Size(100, 23)
        txtCustomeremail.TabIndex = 23
        ' 
        ' txtSubtotal
        ' 
        txtSubtotal.Location = New Point(400, 290)
        txtSubtotal.Name = "txtSubtotal"
        txtSubtotal.Size = New Size(100, 23)
        txtSubtotal.TabIndex = 25
        ' 
        ' txtDiscount
        ' 
        txtDiscount.Location = New Point(400, 319)
        txtDiscount.Name = "txtDiscount"
        txtDiscount.Size = New Size(100, 23)
        txtDiscount.TabIndex = 26
        ' 
        ' txtVat
        ' 
        txtVat.Location = New Point(400, 348)
        txtVat.Name = "txtVat"
        txtVat.Size = New Size(100, 23)
        txtVat.TabIndex = 27
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(259, 46)
        Label8.Name = "Label8"
        Label8.Size = New Size(241, 21)
        Label8.TabIndex = 28
        Label8.Text = "Smart Eletronic For Smart  Living."
        ' 
        ' lblFinaltotal
        ' 
        lblFinaltotal.AutoSize = True
        lblFinaltotal.Location = New Point(322, 383)
        lblFinaltotal.Name = "lblFinaltotal"
        lblFinaltotal.Size = New Size(67, 15)
        lblFinaltotal.TabIndex = 29
        lblFinaltotal.Text = "Final Total :"
        ' 
        ' txtFinaltotal
        ' 
        txtFinaltotal.Location = New Point(400, 383)
        txtFinaltotal.Name = "txtFinaltotal"
        txtFinaltotal.Size = New Size(100, 23)
        txtFinaltotal.TabIndex = 30
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(28, 90)
        Label10.Name = "Label10"
        Label10.Size = New Size(182, 21)
        Label10.TabIndex = 31
        Label10.Text = "Customer's Information"
        ' 
        ' mskContactdetails
        ' 
        mskContactdetails.Location = New Point(185, 183)
        mskContactdetails.Mask = "(999) 000-0000"
        mskContactdetails.Name = "mskContactdetails"
        mskContactdetails.Size = New Size(100, 23)
        mskContactdetails.TabIndex = 32
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 525)
        Controls.Add(mskContactdetails)
        Controls.Add(Label10)
        Controls.Add(txtFinaltotal)
        Controls.Add(lblFinaltotal)
        Controls.Add(Label8)
        Controls.Add(txtVat)
        Controls.Add(txtDiscount)
        Controls.Add(txtSubtotal)
        Controls.Add(txtCustomeremail)
        Controls.Add(txtCustomername)
        Controls.Add(grpAaccessories)
        Controls.Add(grpBproduct)
        Controls.Add(picTech)
        Controls.Add(lstDisplay)
        Controls.Add(lblVat)
        Controls.Add(lblDiscount)
        Controls.Add(lblSubtotal)
        Controls.Add(lblCcontactdetails)
        Controls.Add(lblCemail)
        Controls.Add(lblCnames)
        Controls.Add(Label1)
        Controls.Add(btnExit)
        Controls.Add(btnClear)
        Controls.Add(btnPromooffer)
        Controls.Add(btnCalculate)
        Name = "Form1"
        Text = "K LEBYANE "
        CType(picTech, ComponentModel.ISupportInitialize).EndInit()
        grpBproduct.ResumeLayout(False)
        grpBproduct.PerformLayout()
        grpAaccessories.ResumeLayout(False)
        grpAaccessories.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnPromooffer As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents chkLaptop As CheckBox
    Friend WithEvents chkSmartphone As CheckBox
    Friend WithEvents chkGamingconsole As CheckBox
    Friend WithEvents chkTabletplus As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblCnames As Label
    Friend WithEvents lblCemail As Label
    Friend WithEvents lblCcontactdetails As Label
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents lblDiscount As Label
    Friend WithEvents lblVat As Label
    Friend WithEvents lstDisplay As ListBox
    Friend WithEvents radWirelessmouse As RadioButton
    Friend WithEvents radHeadphones As RadioButton
    Friend WithEvents radFlashdrive As RadioButton
    Friend WithEvents radLaptopbag As RadioButton
    Friend WithEvents picTech As PictureBox
    Friend WithEvents grpBproduct As GroupBox
    Friend WithEvents grpAaccessories As GroupBox
    Friend WithEvents txtCustomername As TextBox
    Friend WithEvents txtCustomeremail As TextBox
    Friend WithEvents txtSubtotal As TextBox
    Friend WithEvents txtDiscount As TextBox
    Friend WithEvents txtVat As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents lblFinaltotal As Label
    Friend WithEvents txtFinaltotal As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents mskContactdetails As MaskedTextBox

End Class
