<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtSpecialID = New System.Windows.Forms.TextBox()
        Me.txtGroupA = New System.Windows.Forms.TextBox()
        Me.txtGroupB = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtDiscount = New System.Windows.Forms.TextBox()
        Me.txtFinalprice = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lstspecial = New System.Windows.Forms.ListBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.grpSpecials = New System.Windows.Forms.GroupBox()
        Me.lblRecordCount = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSpecials.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(12, 483)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(75, 23)
        Me.btnLoad.TabIndex = 0
        Me.btnLoad.Text = "LOAD"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(120, 483)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowse.TabIndex = 1
        Me.btnBrowse.Text = "BROWSE"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(115, 63)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(62, 23)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "SEARCH"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(356, 483)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(471, 483)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(594, 483)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(232, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(382, 25)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "MICROTECH ELCTRONICS STORE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(557, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Special ID :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(557, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Group A Accessories :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(557, 197)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Group B Products :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(557, 235)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Product Price :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(557, 270)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Discount Rate :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(557, 312)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Final Price :"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.LEBYANE_K_PCP_PAT_2.My.Resources.Resources.pic1
        Me.PictureBox1.Location = New System.Drawing.Point(57, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(151, 94)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'txtSpecialID
        '
        Me.txtSpecialID.Location = New System.Drawing.Point(670, 125)
        Me.txtSpecialID.Name = "txtSpecialID"
        Me.txtSpecialID.Size = New System.Drawing.Size(100, 20)
        Me.txtSpecialID.TabIndex = 19
        '
        'txtGroupA
        '
        Me.txtGroupA.Location = New System.Drawing.Point(670, 161)
        Me.txtGroupA.Name = "txtGroupA"
        Me.txtGroupA.Size = New System.Drawing.Size(100, 20)
        Me.txtGroupA.TabIndex = 20
        '
        'txtGroupB
        '
        Me.txtGroupB.Location = New System.Drawing.Point(670, 196)
        Me.txtGroupB.Name = "txtGroupB"
        Me.txtGroupB.Size = New System.Drawing.Size(100, 20)
        Me.txtGroupB.TabIndex = 21
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(670, 228)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtPrice.TabIndex = 22
        '
        'txtDiscount
        '
        Me.txtDiscount.Location = New System.Drawing.Point(670, 263)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(100, 20)
        Me.txtDiscount.TabIndex = 23
        '
        'txtFinalprice
        '
        Me.txtFinalprice.Location = New System.Drawing.Point(670, 305)
        Me.txtFinalprice.Name = "txtFinalprice"
        Me.txtFinalprice.Size = New System.Drawing.Size(100, 20)
        Me.txtFinalprice.TabIndex = 24
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(294, 51)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(242, 18)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Smart Electronics For Smart Living."
        '
        'lstspecial
        '
        Me.lstspecial.FormattingEnabled = True
        Me.lstspecial.Location = New System.Drawing.Point(31, 122)
        Me.lstspecial.Name = "lstspecial"
        Me.lstspecial.Size = New System.Drawing.Size(479, 342)
        Me.lstspecial.TabIndex = 28
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(610, 364)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 13)
        Me.Label8.TabIndex = 29
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(9, 61)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(100, 24)
        Me.txtSearch.TabIndex = 30
        '
        'grpSpecials
        '
        Me.grpSpecials.Controls.Add(Me.lblRecordCount)
        Me.grpSpecials.Controls.Add(Me.txtSearch)
        Me.grpSpecials.Controls.Add(Me.btnSearch)
        Me.grpSpecials.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSpecials.Location = New System.Drawing.Point(560, 354)
        Me.grpSpecials.Name = "grpSpecials"
        Me.grpSpecials.Size = New System.Drawing.Size(200, 100)
        Me.grpSpecials.TabIndex = 31
        Me.grpSpecials.TabStop = False
        Me.grpSpecials.Text = "Specials"
        '
        'lblRecordCount
        '
        Me.lblRecordCount.AutoSize = True
        Me.lblRecordCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecordCount.Location = New System.Drawing.Point(17, 34)
        Me.lblRecordCount.Name = "lblRecordCount"
        Me.lblRecordCount.Size = New System.Drawing.Size(173, 13)
        Me.lblRecordCount.TabIndex = 31
        Me.lblRecordCount.Text = "Enter Special ID or Product Name :"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(237, 483)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 32
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 518)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.grpSpecials)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lstspecial)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtFinalprice)
        Me.Controls.Add(Me.txtDiscount)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtGroupB)
        Me.Controls.Add(Me.txtGroupA)
        Me.Controls.Add(Me.txtSpecialID)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.btnLoad)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSpecials.ResumeLayout(False)
        Me.grpSpecials.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLoad As Button
    Friend WithEvents btnBrowse As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtSpecialID As TextBox
    Friend WithEvents txtGroupA As TextBox
    Friend WithEvents txtGroupB As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtDiscount As TextBox
    Friend WithEvents txtFinalprice As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents lstspecial As ListBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents grpSpecials As GroupBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents lblRecordCount As Label
End Class
