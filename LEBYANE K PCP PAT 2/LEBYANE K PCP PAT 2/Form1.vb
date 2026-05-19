Imports System.IO

Public Class Form1


    'Structure stores one special offer record
    ' *****read names from a sequential access file
    ' **and displays them in the list box
    Dim inputfile As IO.StreamReader
    Dim strlineoftext As String
    Dim filepath As String = "specials.txt"


    Structure SpecialOffer
        Dim specialID As String
        Dim groupAAccessory As String
        Dim groupBProduct As String
        Dim productPrice As Decimal
        Dim discountRate As Decimal
        Dim finalPrice As Decimal
    End Structure

    'Array declaration
    Dim specials(15) As SpecialOffer
    Dim recordCount As Integer = 0
    Dim selectedIndex As Integer = -1

    'Text file name
    Dim FILE_NAME As String = "specials.txt"

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click

        If Not File.Exists("specials.txt") Then
            MessageBox.Show("specials.txt file not found. Please place it in bin\Debug folder.")
            Exit Sub
        End If

        lstspecial.Items.Clear()

        Dim reader As StreamReader = New StreamReader("specials.txt")

        Do While reader.Peek() <> -1

            Dim line As String = reader.ReadLine()
            Dim fields() As String = line.Split(","c)

            lstspecial.Items.Add(fields(0) & " | " &
                              fields(1) & "    | " &
                              fields(2) & " | R" &
                              fields(3) & " | " &
                              fields(4) & "% | R" &
                              fields(5))

        Loop

        reader.Close()

        MessageBox.Show("Data loaded successfully.")

    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        DisplayAllRecords()
    End Sub

    Private Sub DisplayAllRecords()

        lstspecial.Items.Clear()

        For i As Integer = 0 To recordCount - 1
            lstspecial.Items.Add(FormatRecord(i))
        Next

        lblRecordCount.Text = "Records loaded: " & recordCount.ToString()

    End Sub

    Private Function FormatRecord(index As Integer) As String

        Return index & " | " &
               specials(index).specialID & " | " &
               specials(index).groupAAccessory & " | " &
               specials(index).groupBProduct & " | R" &
               specials(index).productPrice.ToString("0.00") & " | " &
               specials(index).discountRate.ToString("0") & "% | Final: R" &
               specials(index).finalPrice.ToString("0.00")

    End Function


    Private Sub lstSpecials_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstspecial.SelectedIndexChanged

        If lstspecial.SelectedIndex = -1 Then Exit Sub

        Dim selectedText As String = lstspecial.SelectedItem.ToString()
        Dim parts() As String = selectedText.Split("|"c)

        If parts.Length < 6 Then Exit Sub

        If IsNumeric(parts(0).Trim()) Then
            selectedIndex = CInt(parts(0).Trim())
        Else
            selectedIndex = lstspecial.SelectedIndex
        End If

        If selectedIndex >= 0 And selectedIndex < recordCount Then
            DisplayRecord(selectedIndex)
        End If

    End Sub


    Private Sub DisplayRecord(index As Integer)

        txtSpecialID.Text = specials(index).specialID
        txtGroupA.Text = specials(index).groupAAccessory
        txtGroupB.Text = specials(index).groupBProduct
        txtPrice.Text = specials(index).productPrice.ToString("0.00")
        txtDiscount.Text = specials(index).discountRate.ToString("0")
        txtFinalprice.Text = specials(index).finalPrice.ToString("0.00")

    End Sub


    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click






        Dim FILE_NAME As String = "specials.txt"
        Dim searchValue As String = txtSearch.Text.Trim().ToLower()

        Dim found As Boolean = False

        ' Clear previous results
        lstspecial.Items.Clear()

        ' Check if file exists
        If File.Exists(filepath) Then
        End If
        ' Read all lines
        Dim lines() As String = File.ReadAllLines(filepath)

            ' Search through lines
            For Each line As String In lines

                If line.ToLower().Contains(txtSearch.Text) Then
                    lstspecial.Items.Add(line)
                End If

            Next


            If searchValue = "" Then
            MessageBox.Show("Please enter a Special ID or product name to search.",
                            "Search Required",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            Exit Sub
        End If

        For i As Integer = 0 To recordCount - 1

            If specials(i).specialID.ToLower() = searchValue Or
               specials(i).groupAAccessory.ToLower().Contains(searchValue) Or
               specials(i).groupBProduct.ToLower().Contains(searchValue) Then

                lstspecial.SelectedIndex = i
                DisplayRecord(i)
                found = True
                Exit For

            End If



        Next

        If found = False Then
            MessageBox.Show(" record found.",
                            "Search Result",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
        End If

    End Sub


    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Dim filePath As String = "specials.txt"

        ' Check if file exists
        If File.Exists(filePath) Then

            ' Read all lines
            Dim lines() As String = File.ReadAllLines(filePath)

            ' update  alphabetically
            Dim updatedLines = lines.OrderBy(Function(x) x).ToArray()

            ' update through lines
            For Each line As String In lines

                If line.ToLower().Contains(txtSpecialID.Text) Then
                    lstspecial.Items.Add(line)
                End If

            Next

            ' Write updated lines back to file
            File.WriteAllLines(filePath, updatedLines)

        End If

        If selectedIndex = -1 Then
            MessageBox.Show("Please select a record to update.",
                            "No Record Selected",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Not IsNumeric(txtPrice.Text) Or Not IsNumeric(txtDiscount.Text) Then
            MessageBox.Show("Price and discount must be numeric values.",
                            "Invalid Input",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
            Exit Sub
        End If



        DisplayAllRecords()

        MessageBox.Show("Record updated successfully.",
                        "Updated",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)

    End Sub

    Private Function CalculateFinalPrice(price As Integer, discount As Integer) As Integer

        Dim discountAmount As Integer
        Dim finalAmount As Integer

        discountAmount = price * (discount / 100)
        finalAmount = price - discountAmount

        Return finalAmount

    End Function


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Try
            Dim writer As StreamWriter = New StreamWriter(FILE_NAME, False)

            For i As Integer = 0 To recordCount - 1

                writer.WriteLine(specials(i).specialID & "," &
                                 specials(i).groupAAccessory & "," &
                                 specials(i).groupBProduct & "," &
                                 specials(i).productPrice.ToString("0.00") & "," &
                                 specials(i).discountRate.ToString() & "," &
                                 specials(i).finalPrice.ToString("0.00"))
            Next

            writer.Close()

            MessageBox.Show("Data saved successfully to specials.txt.",
                            "Saved",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error saving file: " & ex.Message)
        End Try

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        If MessageBox.Show("Are you sure you want to clear?",
                           "Confirm clear",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.Close()
        End If

        txtSearch.Clear()
        txtSpecialID.Clear()
        txtGroupA.Clear()
        txtGroupB.Clear()
        txtPrice.Clear()
        txtDiscount.Clear()
        txtFinalprice.Clear()

        lstspecial.ClearSelected()
        selectedIndex = -1

        lstspecial.Items.Clear()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        If MessageBox.Show("Are you sure you want to exit?",
                           "Confirm Exit",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.Close()
        End If

    End Sub
End Class
