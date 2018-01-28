Public Class Form2


    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub buttonBT_Click(sender As Object, e As EventArgs) Handles buttonBT.Click
        BT.Show()
        Me.Hide()

    End Sub

    Private Sub buttonIT_Click(sender As Object, e As EventArgs) Handles buttonIT.Click
        IT.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.Close()
        ElseIf result = DialogResult.No Then
            Me.Show()
        End If

    End Sub
End Class