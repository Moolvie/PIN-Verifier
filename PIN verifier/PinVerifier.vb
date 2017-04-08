Public Class PinVerifier
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        pinInputBox_1.Text = String.Empty
        pinInputBox_2.Text = String.Empty
        pinInputBox_3.Text = String.Empty
        pinInputBox_4.Text = String.Empty
        pinInputBox_5.Text = String.Empty
        pinInputBox_6.Text = String.Empty
        pinInputBox_7.Text = String.Empty
        pinInputBox_1.Focus()
    End Sub

    Private Sub VerifyButton_Click(sender As Object, e As EventArgs) Handles VerifyButton.Click

        Dim pinMinMax As New Dictionary(Of Integer, Tuple(Of Integer, Integer))

        pinMinMax.Add(1, New Tuple(Of Integer, Integer)(7, 9))
        pinMinMax.Add(2, New Tuple(Of Integer, Integer)(5, 7))
        pinMinMax.Add(3, New Tuple(Of Integer, Integer)(0, 4))
        pinMinMax.Add(4, New Tuple(Of Integer, Integer)(0, 9))
        pinMinMax.Add(5, New Tuple(Of Integer, Integer)(6, 9))
        pinMinMax.Add(6, New Tuple(Of Integer, Integer)(3, 6))
        pinMinMax.Add(7, New Tuple(Of Integer, Integer)(4, 8))

        Dim inputValues(6) As Integer
        Dim inputError1 As Boolean = False
        Dim inputError2 As Boolean = False
        Dim inputError3 As Boolean = False
        Dim inputError4 As Boolean = False
        Dim inputError5 As Boolean = False
        Dim inputError6 As Boolean = False
        Dim inputError7 As Boolean = False

        inputError1 = validateIntegerInput(pinInputBox_1, inputValues, 0)
        inputError2 = validateIntegerInput(pinInputBox_2, inputValues, 1)
        inputError3 = validateIntegerInput(pinInputBox_3, inputValues, 2)
        inputError4 = validateIntegerInput(pinInputBox_4, inputValues, 3)
        inputError5 = validateIntegerInput(pinInputBox_5, inputValues, 4)
        inputError6 = validateIntegerInput(pinInputBox_6, inputValues, 5)
        inputError7 = validateIntegerInput(pinInputBox_6, inputValues, 6)

        For i As Integer = 0 To (inputValues.Count - 1)
            Dim limits = pinMinMax(i + 1)
            If (inputValues(i) < limits.Item1 Or inputValues(i) > limits.Item2) Then
                MessageBox.Show("Value for digit #" & (i + 1) & " is bad.", "Out of range error", MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation)
                Exit For
            End If
        Next
        MessageBox.Show("PIN Verified!")
    End Sub
    Function validateIntegerInput(ByVal inputText As TextBox, ByRef InputNumber() As Integer, ByVal index As Integer) As Boolean

        ' set return value to false
        Dim foundError As Boolean = False

        If Not (Integer.TryParse(inputText.Text, InputNumber(index))) Then
            MessageBox.Show("Input for digit #" & (index + 1) & " must be an integer.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            foundError = True
        End If

        Return foundError
    End Function
End Class
