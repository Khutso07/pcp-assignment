Public Class Form1
    ' LEBYANE KHUTSO 
    ' GROUP 4B  STUDENT N0 202387616


    ' CONSTANTS

    Const VAT_RATE As Double = 0.15

    ' GLOBAL VARIABLES
    Dim strCustomerName As String
    Dim strCustomerEmail As String
    Dim strContactdetails As String
    Dim subtotal As Double
    Dim discountRate As Double
    Dim discountAmount As Double
    Dim vatAmount As Double
    Dim finalTotal As Double

    ' PROMOTIONAL OFFER BUTTON
    Private Sub btnPromooffer_Click(sender As Object, e As EventArgs) Handles btnPromooffer.Click

        If Not ValidateCustomerInfo() Then Exit Sub
        If Not IsGroupASelected() Then
            MessageBox.Show("Please select ONE product from Group A.",
                            "Selection Required",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            Exit Sub
        End If

        DisplayPromotionMessage()

    End Sub


    ' CALCULATE BUTTON

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        If Not ValidateCustomerInfo() Then Exit Sub
        If Not IsGroupASelected() Then
            MessageBox.Show("Please select ONE product from Group A before calculating.",
                            "Selection Required",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim subtotal As Double = CalculateSubtotal()
        Dim groupBCount As Integer = CountGroupBItems()
        Dim discountRate As Double = DetermineDiscount(groupBCount)
        Dim discountAmount As Double = CalculateDiscount(subtotal, discountRate)
        Dim vatAmount As Double = CalculateVAT(subtotal - discountAmount)
        Dim finalTotal As Double = CalculateFinalTotal(subtotal, discountAmount, vatAmount)

        'Display in textboxes
        txtSubtotal.Text = subtotal.ToString("C2")
        txtDiscount.Text = discountAmount.ToString("C2")
        txtVat.Text = vatAmount.ToString("C2")
        txtFinaltotal.Text = finalTotal.ToString("C2")

        DisplayInvoice(subtotal, discountAmount, vatAmount, finalTotal)

    End Sub


    ' VALIDATE CUSTOMER INFO

    Private Function ValidateCustomerInfo() As Boolean

        'check empty fields

        If txtCustomername.Text = "" Or txtCustomeremail.Text = "" Or mskContactdetails.Text = "" Then
            MessageBox.Show("Please complete all customer information fields.",
                            "Missing Information",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)



            Return False
        End If
        'Email format validation
        If Not txtCustomeremail.Text.Contains("@") Or
           Not txtCustomeremail.Text.Contains(".") Then

            MessageBox.Show("Enter a valid email address.",
                            "Invalid Email",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            Return False
        End If


        Return True

    End Function


    ' CHECK IF GROUP B SELECTED

    Private Function IsGroupASelected() As Boolean
        Return chkLaptop.Checked Or chkSmartphone.Checked Or
               chkGamingconsole.Checked Or chkTabletplus.Checked
    End Function


    ' CALCULATE SUBTOTAL

    Private Function CalculateSubtotal() As Double

        Dim total As Double = 0

        'Group B
        If chkLaptop.Checked Then total = 13000
        If chkSmartphone.Checked Then total = 11000
        If chkGamingconsole.Checked Then total = 10000
        If chkTabletplus.Checked Then total = 6000

        'Group A
        If radWirelessmouse.Checked Then total = 450
        If radHeadphones.Checked Then total = 1100
        If radFlashdrive.Checked Then total = 180
        If radLaptopbag.Checked Then total = 800

        Return total

    End Function


    ' COUNT GROUP A ITEMS

    Private Function CountGroupBItems() As Integer

        Dim count As Integer = 0

        If radWirelessmouse.Checked Then count = 450
        If radHeadphones.Checked Then count = 1100
        If radFlashdrive.Checked Then count = 180
        If radLaptopbag.Checked Then count = 13000

        Return count

    End Function


    ' DETERMINE DISCOUNT

    Private Function DetermineDiscount(groupBCount As Integer) As Double

        If groupBCount >= 2 Then
            Return 0.15
        ElseIf groupBCount = 1 Then
            Return 0.1
        Else
            Return 0
        End If

    End Function


    ' CALCULATE DISCOUNT

    Private Function CalculateDiscount(subtotal As Double, rate As Double) As Double
        Return subtotal * rate
    End Function


    ' CALCULATE VAT

    Private Function CalculateVAT(amountAfterDiscount As Double) As Double
        Return amountAfterDiscount * VAT_RATE
    End Function


    ' FINAL TOTAL

    Private Function CalculateFinalTotal(subtotal As Double, discount As Double, vat As Double) As Double

        Return (subtotal - discount) + vat

    End Function


    ' DISPLAY PROMOTION MESSAGE

    Private Sub DisplayPromotionMessage()

        lstDisplay.Items.Clear()
        lstDisplay.Items.Add("***** MICROTECH ELECTRONICS STORE *****")
        lstDisplay.Items.Add("Special Promotion Available!")
        lstDisplay.Items.Add("Buy 1 Main Product + 2 Accessories")
        lstDisplay.Items.Add("Get up to 10% Discount")
        lstDisplay.Items.Add("---------------------------------------")

    End Sub


    ' DISPLAY INVOICE

    Private Sub DisplayInvoice(subtotal As Double, discount As Double, vat As Double,
                               finalTotal As Double)

        lstDisplay.Items.Clear()
        lstDisplay.Items.Add("========= INVOICE =========")
        lstDisplay.Items.Add("Customer: " & txtCustomername.Text)
        lstDisplay.Items.Add("Email: " & txtCustomeremail.Text)
        lstDisplay.Items.Add("Contact: " & mskContactdetails.Text)
        lstDisplay.Items.Add("----------------------------")


        ' GROUP A SELECTION

        If radLaptopbag.Checked Then
            subtotal = 800
            lstDisplay.Items.Add("Laptopbag - R800")
        ElseIf radHeadphones.Checked Then
            subtotal = 11000
            lstDisplay.Items.Add("Headphone - R11000")
        ElseIf radFlashdrive.Checked Then
            subtotal = 180
            lstDisplay.Items.Add("Flash drive - R180")
        ElseIf radWirelessmouse.Checked Then
            subtotal = 450
            lstDisplay.Items.Add("Wireless Mouse - R450")

        End If


        ' GROUP B SELECTION 

        Dim accessoryCount As Integer = 0

        If chkGamingconsole.Checked Then
            subtotal = 10000
            accessoryCount = 1
            lstDisplay.Items.Add("Gaming Console - R10000")
        End If

        If chkLaptop.Checked Then
            subtotal = 13000
            accessoryCount = 1
            lstDisplay.Items.Add("Laptop Pro - R13000")
        End If

        If chkSmartphone.Checked Then
            subtotal = 11000
            accessoryCount = 1
            lstDisplay.Items.Add("Smartphone - R11000")
        End If

        If chkTabletplus.Checked Then
            subtotal = 6000
            accessoryCount = 1
            lstDisplay.Items.Add("Tablet Plus - R6000")
        End If

        lstDisplay.Items.Add("--------------------------------")

        '----------------------------
        ' DETERMINE DISCOUNT
        '----------------------------
        If accessoryCount >= 2 Then
            discountRate = 0.15
        ElseIf accessoryCount = 1 Then
            discountRate = 0.1
        Else
            discountRate = 0
        End If

        discountAmount = subtotal * discountRate
        vatAmount = (subtotal - discountAmount) * 0.15
        finalTotal = (subtotal - discountAmount) + vatAmount
        lstDisplay.Items.Add("Subtotal: " & subtotal.ToString("C2"))
        lstDisplay.Items.Add("Discount: " & discount.ToString("C2"))
        lstDisplay.Items.Add("VAT (15%): " & vat.ToString("C2"))
        lstDisplay.Items.Add("----------------------------")
        lstDisplay.Items.Add("FINAL TOTAL: " & finalTotal.ToString("C2"))
        lstDisplay.Items.Add("============================")

    End Sub


    ' Clear button

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        If MessageBox.Show("Are you sure you want to clear?",
                           "Confirm clear",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.Close()
        End If

        txtCustomername.Clear()
        txtCustomeremail.Clear()
        mskContactdetails.Clear()

        chkLaptop.Checked = False
        chkSmartphone.Checked = False
        chkGamingconsole.Checked = False
        chkTabletplus.Checked = False

        radWirelessmouse.Checked = False
        radHeadphones.Checked = False
        radFlashdrive.Checked = False
        radLaptopbag.Checked = False

        txtSubtotal.Clear()
        txtDiscount.Clear()
        txtVat.Clear()
        txtFinaltotal.Clear()

        lstDisplay.Items.Clear()

        txtCustomername.Focus()

    End Sub

    ' Exit button
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        If MessageBox.Show("Are you sure you want to exit?",
                           "Confirm Exit",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.Close()
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
