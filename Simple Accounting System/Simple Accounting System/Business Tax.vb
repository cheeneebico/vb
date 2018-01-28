Public Class BT

    Private Sub buttonBTM_Click(sender As Object, e As EventArgs) Handles buttonBTM.Click
        BTMonthly.Show()
        Me.Hide()
    End Sub

    Private Sub buttonBTQ_Click(sender As Object, e As EventArgs) Handles buttonBTQ.Click
        BTQuarterly.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
        Me.Hide()

    End Sub
End Class