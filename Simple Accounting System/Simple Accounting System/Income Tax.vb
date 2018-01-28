Public Class Income_Tax
    Dim rate As Decimal
    Dim difference As Decimal



    Private Sub textboxqitni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textboxqitni.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
AndAlso e.KeyChar <> ControlChars.Back AndAlso
e.KeyChar <> "." Then
            e.Handled = True
        End If



    End Sub

    Private Sub textboxqitni_TextChanged(sender As Object, e As EventArgs) Handles textboxqitni.TextChanged
        Dim tbval As Decimal

        If Not Decimal.TryParse(textboxqitni.Text, tbval) Then
            MessageBox.Show("Not a valid number.")
        End If

        If tbval >= 0 AndAlso tbval <= 10000 Then
            textboxittd.Text = tbval * 0.05
        ElseIf tbval >= 10000 AndAlso tbval <= 30000 Then
            difference = tbval - 10000
            rate = difference * 0.1
            tbval = rate + 500
        ElseIf tbval >= 30000 AndAlso tbval <= 70000 Then
            difference = tbval - 30000
            rate = difference * 0.15
            tbval = rate + 2500
        ElseIf tbval >= 70000 AndAlso tbval <= 140000 Then
            difference = tbval - 70000
            rate = difference * 0.2
            tbval = rate + 8500
        ElseIf tbval >= 140000 AndAlso tbval <= 250000 Then
            difference = tbval - 140000
            rate = difference * 0.25
            tbval = rate + 22500
        ElseIf tbval >= 250000 AndAlso tbval <= 500000 Then
            difference = tbval - 250000
            rate = difference * 0.3
            tbval = rate + 50000
        ElseIf tbval >= 500000 AndAlso tbval <= 999999999999999 Then
            difference = tbval - 500000
            rate = difference * 0.32
            tbval = rate + 125000
        End If

        textboxittd.Text = tbval.ToString()

    End Sub

    Private Sub textboxittd_TextChanged(sender As Object, e As EventArgs) Handles textboxittd.TextChanged

    End Sub

    Private Sub comboboxitq_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboboxitq.SelectedIndexChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub buttonbtmPrint_Click(sender As Object, e As EventArgs) Handles buttonbtmPrint.Click
        PrintForm1.Print()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles labelitquarter.Click

    End Sub

    Private Sub labelbtmname_Click(sender As Object, e As EventArgs) Handles labelbtmname.Click

    End Sub

    Private Sub textboxityear_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textboxityear.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub buttonbtmClear_Click(sender As Object, e As EventArgs) Handles buttonbtmClear.Click
        textboxitnoc.Clear()
        comboboxitq.SelectedIndex = -1
        textboxityear.Clear()
        textboxittd.Text = "0.0"
        textboxqitni.Text = "0.0"


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        IT.Show()
        Me.Hide()

    End Sub

    Private Sub textboxityear_TextChanged(sender As Object, e As EventArgs) Handles textboxityear.TextChanged

    End Sub

    Private Sub Income_Tax_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

