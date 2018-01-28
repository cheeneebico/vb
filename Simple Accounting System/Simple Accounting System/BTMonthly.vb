Public Class BTMonthly

    Private Sub btmgs_KeyPress(sender As Object, e As KeyPressEventArgs) Handles btmgs.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
            AndAlso e.KeyChar <> ControlChars.Back AndAlso
            e.KeyChar <> "." Then
            e.Handled = True
        End If
    End Sub

    Private Sub btmgs_TextChanged(sender As Object, e As EventArgs) Handles btmgs.TextChanged
        If String.IsNullOrEmpty(btmgs.Text) OrElse String.IsNullOrEmpty(comboboxbtmv.SelectedText) Then Exit Sub
        If Not IsNumeric(btmgs.Text) OrElse Not IsNumeric(comboboxbtmv.SelectedText) Then Exit Sub

        btmtd.Text = CDbl(btmgs.Text) * CDbl(comboboxbtmv.SelectedText)
    End Sub

    Private Sub comboboxbtmv_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboboxbtmv.SelectedIndexChanged
        If String.IsNullOrEmpty(btmgs.Text) OrElse String.IsNullOrEmpty(comboboxbtmv.Text) Then Exit Sub
        btmtd.Text = CDbl(btmgs.Text) * CDbl(comboboxbtmv.Text)
    End Sub

    Private Sub btmtd_TextChanged(sender As Object, e As EventArgs) Handles btmtd.TextChanged
        If String.IsNullOrEmpty(btmgs.Text) OrElse String.IsNullOrEmpty(comboboxbtmv.Text) Then Exit Sub
        btmtd.Text = CDbl(btmgs.Text) * CDbl(comboboxbtmv.Text)
    End Sub

    Private Sub labelbtmgs_Click(sender As Object, e As EventArgs) Handles labelbtmgs.Click

    End Sub

    Private Sub buttonbtmPrint_Click(sender As Object, e As EventArgs) Handles buttonbtmPrint.Click
        PrintFormBTM.Print()

    End Sub

    Private Sub textboxbtyear_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textboxbtyear.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub buttonbtmClear_Click(sender As Object, e As EventArgs) Handles buttonbtmClear.Click
        boxbtmname.Clear()
        textboxbtyear.Clear()
        btmgs.Text = "0.0"
        btmtd.Text = "0.0"
        comboboxbtmmon.SelectedIndex = -1
        comboboxbtmv.SelectedIndex = -1


    End Sub

    Private Sub boxbtmname_TextChanged(sender As Object, e As EventArgs) Handles boxbtmname.TextChanged
        '
        'boxbtmname.SelectionStart = boxbtmname.TextLength
        'SendKeys.Send("+{HOME}")
    End Sub

    Private Sub BTMonthly_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        boxbtmname.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BT.Show()
        Me.Hide()

    End Sub
End Class