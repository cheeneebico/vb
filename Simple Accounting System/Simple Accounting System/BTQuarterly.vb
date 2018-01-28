Public Class BTQuarterly
    Dim newcom As String
    Dim quar As String
    Dim grosssl As Double
    Dim qvat As Integer = 12
    Dim qnonvat As Integer = 3
    Dim qtotal As Double
    Dim qprev As Double
    Dim qtd As Double


    Private Sub boxbtqgs_KeyPress(sender As Object, e As KeyPressEventArgs) Handles boxbtqgs.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
    AndAlso e.KeyChar <> ControlChars.Back AndAlso
    e.KeyChar <> "." Then
            e.Handled = True
        End If
    End Sub

    Private Sub BTQuarterly_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub boxbtqname_TextChanged(sender As Object, e As EventArgs) Handles boxbtqname.TextChanged
        newcom = boxbtqname.Text

    End Sub

    Private Sub boxbtqgs_TextChanged(sender As Object, e As EventArgs) Handles boxbtqgs.TextChanged
        If String.IsNullOrEmpty(boxbtqgs.Text) OrElse String.IsNullOrEmpty(comboboxbtqv.Text) Then Exit Sub
        boxbtqtotal.Text = CDbl(boxbtqgs.Text) * CDbl(comboboxbtqv.Text)
    End Sub

    Private Sub comboboxbtqv_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboboxbtqv.SelectedIndexChanged
        If String.IsNullOrEmpty(boxbtqgs.Text) OrElse String.IsNullOrEmpty(comboboxbtqv.Text) Then Exit Sub
        boxbtqtotal.Text = CDbl(boxbtqgs.Text) * CDbl(comboboxbtqv.Text)
    End Sub

    Private Sub boxbtqtotal_TextChanged(sender As Object, e As EventArgs) Handles boxbtqtotal.TextChanged
        If String.IsNullOrEmpty(boxbtqtotal.Text) OrElse String.IsNullOrEmpty(boxbtqprev.Text) Then Exit Sub
        btqtd.Text = CDbl(boxbtqtotal.Text) - CDbl(boxbtqprev.Text)
    End Sub

    Private Sub boxbtqprev_TextChanged(sender As Object, e As EventArgs) Handles boxbtqprev.TextChanged
        If String.IsNullOrEmpty(boxbtqtotal.Text) OrElse String.IsNullOrEmpty(boxbtqprev.Text) Then Exit Sub
        btqtd.Text = CDbl(boxbtqtotal.Text) - CDbl(boxbtqprev.Text)
    End Sub

    Private Sub buttonbtqprint_Click(sender As Object, e As EventArgs) Handles buttonbtqprint.Click
        PrintFormBTQ.Print()

    End Sub

    Private Sub boxbtqprev_KeyPress(sender As Object, e As KeyPressEventArgs) Handles boxbtqprev.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
   AndAlso e.KeyChar <> ControlChars.Back AndAlso
   e.KeyChar <> "." Then
            e.Handled = True
        End If
    End Sub

    Private Sub textboxbtyear_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textboxbtyear.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
   AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub buttonbtqclear_Click(sender As Object, e As EventArgs) Handles buttonbtqclear.Click
        boxbtqname.Clear()
        textboxbtyear.Clear()
        comboboxbtq.SelectedIndex = -1
        boxbtqgs.Text = "0.0"
        comboboxbtqv.SelectedIndex = -1
        boxbtqtotal.Text = "0.0"
        boxbtqprev.Text = "0.0"
        btqtd.Text = "0.0"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BT.Show()
        Me.Hide()

    End Sub
End Class